using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace DesktopGoogleCalendar
{
    class GoogleCalendar
    {
        // Event callbacks
        private Action initFail = null;
        /// <summary>
        /// Called if the Calendar service initialization fails.
        /// </summary>
        public Action InitFail
        {
            set
            {
                this.initFail = value;
            }
        }
        
        private Action initSuccess = null;
        /// <summary>
        /// Called after successfully initializing the Calendar service.
        /// </summary>
        public Action InitSuccess
        {
            set
            {
                this.initSuccess = value;
            }
        }

        private Action loadFail = null;
        /// <summary>
        /// Called if reading Calendar data fails.
        /// </summary>
        public Action LoadFail
        {
            set
            {
                this.loadFail = value;
            }
        }

        private Action loadSuccess = null;
        /// <summary>
        /// Called after successfully loading data from the Calendar service.
        /// </summary>
        public Action LoadSuccess
        {
            set
            {
                this.loadSuccess = value;
            }
        }

        private Action<DateTime> eachDate = null;
        /// <summary>
        /// Called for each unique date in the list of events.
        /// </summary>
        public Action<DateTime> EachDate
        {
            set
            {
                this.eachDate = value;
            }
        }

        private Action<CalendarEvent> eachEvent = null;
        /// <summary>
        /// Called for each calendar event.
        /// </summary>
        public Action<CalendarEvent> EachEvent
        {
            set
            {
                this.eachEvent = value;
            }
        }

        // States
        private bool initialized = false;
        private bool loaded = false;

        // Calendar data
        string apiClientSecretsFilePath = null;
        static String[] scopes = { CalendarService.Scope.CalendarReadonly };
        private CalendarService service = null;
        Colors colors;
        IList<CalendarListEntry> calendars;
        private IList<CalendarEvent> events;

        /// <param name="apiClientSecretsFilePath">Path to a Google Oath2 client secrets file.</param>
        public GoogleCalendar(string apiClientSecretsFilePath) {
            this.apiClientSecretsFilePath = apiClientSecretsFilePath;
        }

        private bool Init()
        {
            try
            {
                UserCredential credential = null;
                using (FileStream stream = new FileStream(apiClientSecretsFilePath, FileMode.Open, FileAccess.Read))
                {
                    string credPath = Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, scopes, "user", CancellationToken.None, new FileDataStore(credPath, true)).Result;
                }
           
                service = new CalendarService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "Desktop Google Calendar"
                });

                colors = service.Colors.Get().Execute();

                initialized = true;
                if (initSuccess != null) { initSuccess(); }
            }
            catch (Exception e)
            {
                initialized = false;
                if (initFail != null) { initFail(); }
                MessageBox.Show("Error:" + e.GetBaseException().Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Load events from the Google Calendar service.  
        /// </summary>
        /// <remarks>
        /// Initializes the service if necessary and executes callbacks for each date and event found in the calendars.
        /// </remarks>
        /// <returns>true if events were loaded and processed successfully, false if any error occurred</returns>
        public bool LoadEvents()
        {
            bool result = false;

            if (!initialized && !Init())
            {
                return false;
            }
            try
            {
                events = new List<CalendarEvent>();
                calendars = service.CalendarList.List().Execute().Items;
                foreach (CalendarListEntry cal in calendars)
                {
                    EventsResource.ListRequest request = service.Events.List(cal.Id);
                    request.TimeMin = DateTime.Today;
                    request.TimeMax = DateTime.Today.AddYears(1);
                    request.ShowDeleted = false;
                    request.SingleEvents = true;
                    request.MaxResults = 50;
                    request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

                    Events evnts = request.Execute();
                    if (evnts.Items == null)
                    {
                        continue;
                    }

                    foreach (Event e in evnts.Items)
                    {
                        DateTime d = DateTime.MinValue;
                        if (e.Start.DateTime != null)
                        {
                            d = (DateTime)e.Start.DateTime;
                        }
                        else
                        {
                            d = DateTime.Parse(e.Start.Date);
                        }
                        //events.Add(new CalendarEvent(cal.Id, e.Summary, d.Date, getCalendarColor(cal.Id)));
                        events.Add(new CalendarEvent(cal.Id, e.Summary, d, getCalendarColor(cal.Id)));
                    }
                }
                loaded = true;
                events = events.OrderBy(o => o.DateTime).ToList();

                if (loadSuccess != null) { loadSuccess(); }

                result = GetEvents();
            }
            catch (Exception)
            {
                if (loadFail != null)
                {
                    loadFail();
                }
                return false;
            }

            return result;
        }

        /// <summary>
        /// Trigger callbacks for each date and event in calendars without re-loading from service.
        /// </summary>
        /// <remarks>
        /// Initializes the service and loads events only if necessary.
        /// </remarks>
        /// <returns>true if all events were processed successfully, false if any error occurred</returns>
        public bool GetEvents()
        {
            if (!initialized && !Init())
            {
                return false;
            }
            if (!loaded && !LoadEvents())
            {
                return false;
            }

            try {

                DateTime curEventDate = DateTime.MinValue;
                foreach (CalendarEvent e in events)
                {
                    if (e.DateTime.Date > curEventDate.Date)
                    {
                        curEventDate = e.DateTime;
                        if (curEventDate < DateTime.Today)
                        {
                            curEventDate = DateTime.Today;

                            // The following two lines should work if time of day is ever added to events
                            //TimeSpan d = DateTime.Today - curEventDate.Date;
                            //curEventDate = curEventDate.AddDays(d.Days);
                        }
                        if (eachDate != null) { eachDate(curEventDate); }
                    }
                    if (eachEvent != null) { eachEvent(e); }
                }
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        private Color getCalendarColor(string calendarId)
        {
            foreach(CalendarListEntry cal in calendars)
            {
                if (cal.Id == calendarId)
                {
                    return (Color)new ColorConverter().ConvertFromString(colors.Calendar[cal.ColorId].Background);
                }
            }
            return Color.White;
        }
    }
}
