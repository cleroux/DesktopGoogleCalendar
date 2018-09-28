using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// TODO: Remove secrets file picker, and/or add choice between secrets file and default (my) API credentials.
// TODO: Improve Options button show/hide.  (mainly hide, sometimes it doesn't go away)
// MAYBE: Option choice to use Google's event forecolor, backcolor, or custom color from color picker.

namespace DesktopGoogleCalendar
{
    public partial class MainFrm : Form
    {
        private DesktopInfo desktop;
        private Graphics graphics;
        private GoogleCalendar cal;
        private int dateLblMarginTop = 4;
        private int eventLblMarginTop = 0;
        private int eventLblIndentation = 10;
        private int timeLblWidth = 48;
        private int lblCurPos = 0;

        [DllImport("user32.dll")]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
        const UInt32 SWP_NOSIZE = 0x01;
        const UInt32 SWP_NOMOVE = 0x02;
        const UInt32 SWP_NOACTIVATE = 0x0010;

        public MainFrm()
        {
            InitializeComponent();
        }

        private void showOptions()
        {
            OptionsFrm opts = new OptionsFrm();
            DialogResult res = opts.ShowDialog();
            if (res == DialogResult.OK)
            {
                setWindowPosition();
                cal.LoadEvents();
            }
            else if (res == DialogResult.Abort)
            {
                this.Close();
            }
            else
            {
                setWindowPosition();
            }
        }

        private void OptionsBtn_Click(object sender, EventArgs e)
        {
            showOptions();
        }

        private void MainFrm_MouseMove(object sender, MouseEventArgs e)
        {
            OptionsBtn.Visible = true;
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            desktop = new DesktopInfo();
            graphics = CreateGraphics();
            setWindowPosition();
            updateDateTimeLabels();

            // Set up the Google Calendar class and callbacks
            cal = new GoogleCalendar(Properties.Settings.Default.ApiClientSecretsFile);
            cal.InitFail = showOptions;
            cal.LoadSuccess = removeEventLabels;
            cal.EachDate = newDateHandler;
            cal.EachEvent = newEventHandler;

            updateDateTimeLabels();
            cal.LoadEvents();
            UpdateTimer.Enabled = true;
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            // Update the date/time labels every tick
            updateDateTimeLabels();

            // Update the calendar every hour
            if (DateTime.Now.Minute == 0 && DateTime.Now.Second == 0)
            {
                cal.LoadEvents();
            }

        }

        private void updateDateTimeLabels()
        {
            DateTime now = DateTime.Now;
            ClockLbl.Text = now.ToString("h:mm tt");
            TodayLbl.Text = now.ToLongDateString();
        }

        private void MainFrm_MouseLeave(object sender, EventArgs e)
        {
            if (this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
            {
                return;
            }
            OptionsBtn.Visible = false;
        }

        private void setWindowPosition()
        {
            SetWindowPos(Handle, HWND_BOTTOM, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE);

            this.Top = 40;
            this.Height = desktop.Height - 80;
            if (Properties.Settings.Default.WindowPosition == "Right")
            {
                this.Left = desktop.XMax - this.Width; // Right-most alignment on desktop
            }
            else
            {
                this.Left = desktop.XMin;
            }

            TodayLbl.Top = ClockLbl.Top + ClockLbl.Height;

            lblCurPos = TodayLbl.Top + TodayLbl.Height;
        }

        private void newEventHandler(CalendarEvent ev) {

            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Text = ev.Summary;

            SizeF s = graphics.MeasureString(lbl.Text, Properties.Settings.Default.EventFont);
            int height = Convert.ToInt32(Math.Ceiling(s.Height));

            if (lblCurPos + eventLblMarginTop + height > desktop.Height - 80)
            {
                lblCurPos = desktop.Height;
                return;
            }
            
            lbl.UseMnemonic = false;
            lbl.ForeColor = ev.Color;
            lbl.DataBindings.Add("Font", Properties.Settings.Default, "EventFont");
            lbl.Left = eventLblIndentation + timeLblWidth;
            lbl.Top = lblCurPos + eventLblMarginTop;
            lbl.Tag = "CalEvtLbl";
            //lbl.BorderStyle = BorderStyle.FixedSingle; // Debug
            this.Controls.Add(lbl);

            if (ev.DateTime.TimeOfDay != TimeSpan.Zero)
            {
                Label timeLbl = new Label();
                timeLbl.Width = timeLblWidth;
                //timeLbl.AutoSize = true;
                timeLbl.Text = ev.DateTime.ToShortTimeString();
                timeLbl.TextAlign = ContentAlignment.TopRight;
                timeLbl.UseMnemonic = false;
                timeLbl.ForeColor = ev.Color;
                timeLbl.DataBindings.Add("Font", Properties.Settings.Default, "EventFont");
                timeLbl.Left = eventLblIndentation;
                timeLbl.Top = lblCurPos + eventLblMarginTop;
                timeLbl.Tag = "CalEvtLbl";
                //timeLbl.BorderStyle = BorderStyle.FixedSingle; // Debug
                this.Controls.Add(timeLbl);
            }

            lblCurPos = lbl.Top + height;
        }

        private void newDateHandler(DateTime date)
        {
            if (DateTime.Today.Date == date)
            {
                return;
            }

            Label lbl = new Label();
            lbl.AutoSize = true;
            lbl.Text = date.ToLongDateString();

            // Find the size of the label
            SizeF s = graphics.MeasureString(lbl.Text, Properties.Settings.Default.DateFont);
            int height = Convert.ToInt32(Math.Ceiling(s.Height));
            s = graphics.MeasureString("X", Properties.Settings.Default.EventFont);
            int eventHeight = Convert.ToInt32(Math.Ceiling(s.Height));

            if ((lblCurPos + dateLblMarginTop + height) + (eventLblMarginTop + eventHeight) > desktop.Height - 80)
            {
                lblCurPos = desktop.Height;
                return;
            }

            lbl.UseMnemonic = false;
            lbl.DataBindings.Add("ForeColor", Properties.Settings.Default, "DateFontColor");
            lbl.DataBindings.Add("Font", Properties.Settings.Default, "DateFont");
            lbl.Left = 5;
            lbl.Top = lblCurPos + dateLblMarginTop;
            lblCurPos = lbl.Top + height;
            lbl.Tag = "CalEvtLbl";

            // Debug
            //lbl.BorderStyle = BorderStyle.FixedSingle;
            
            this.Controls.Add(lbl);
        }

        private void removeEventLabels()
        {
            for(int i=0; i < Controls.Count; i++)
            {
                if ((string)Controls[i].Tag == "CalEvtLbl")
                {
                    Controls[i--].Dispose();
                }
            }
            lblCurPos = TodayLbl.Top + TodayLbl.Height;
        }

        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams baseParams = base.CreateParams;
                baseParams.ExStyle |= 0x08000000 | 0x00000080; // WS_EX_NOACTIVATE, WS_EX_TOOLWINDOW
                return baseParams;
            }
        }
    }
}
