using System;
using System.Drawing;

namespace DesktopGoogleCalendar
{
    class CalendarEvent
    {
        private string calendarId;
        private string summary;
        private DateTime datetime;
        private Color color;

        public CalendarEvent(string calendarId, string summary, DateTime datetime, Color color)
        {
            this.calendarId = calendarId;
            this.summary = summary;
            this.datetime = datetime;
            this.color = color;
        }

        public DateTime DateTime
        {
            get
            {
                return datetime;
            }
        }

        public string CalendarId
        {
            get
            {
                return calendarId;
            }
        }

        public string Summary
        {
            get
            {
                return summary;
            }
        }

        public Color Color
        {
            get
            {
                return color;
            }
        }
    }
}
