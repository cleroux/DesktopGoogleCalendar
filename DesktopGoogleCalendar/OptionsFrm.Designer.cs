namespace DesktopGoogleCalendar
{
    partial class OptionsFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OptionsTabs = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.AccountGroup = new System.Windows.Forms.GroupBox();
            this.ClientSecretsFileTxt = new System.Windows.Forms.Label();
            this.ClientSecretsLink = new System.Windows.Forms.LinkLabel();
            this.SecretsFileBrowseBtn = new System.Windows.Forms.Button();
            this.ClientSecretsFileLbl = new System.Windows.Forms.Label();
            this.StartupGroup = new System.Windows.Forms.GroupBox();
            this.OptionsStartupChk = new System.Windows.Forms.CheckBox();
            this.tabAppearance = new System.Windows.Forms.TabPage();
            this.FontGroup = new System.Windows.Forms.GroupBox();
            this.EventDateFontColor = new System.Windows.Forms.Label();
            this.DateFontColor = new System.Windows.Forms.Label();
            this.EventDateFontBtn = new System.Windows.Forms.Button();
            this.EventDateFontTxt = new System.Windows.Forms.Label();
            this.EventDateFontLbl = new System.Windows.Forms.Label();
            this.DateFontBtn = new System.Windows.Forms.Button();
            this.DateFontTxt = new System.Windows.Forms.Label();
            this.DateFontLbl = new System.Windows.Forms.Label();
            this.EventFontTxt = new System.Windows.Forms.Label();
            this.ClockFontColor = new System.Windows.Forms.Label();
            this.ClockFontBtn = new System.Windows.Forms.Button();
            this.ClockFontTxt = new System.Windows.Forms.Label();
            this.ClockFontLbl = new System.Windows.Forms.Label();
            this.EventFontBtn = new System.Windows.Forms.Button();
            this.EventFontLbl = new System.Windows.Forms.Label();
            this.PositionLbl = new System.Windows.Forms.Label();
            this.PositionSelect = new System.Windows.Forms.ComboBox();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.VerLbl = new System.Windows.Forms.Label();
            this.ProgramTitleLbl = new System.Windows.Forms.Label();
            this.GithubLink = new System.Windows.Forms.LinkLabel();
            this.AboutAuthorLbl = new System.Windows.Forms.Label();
            this.OptionsCancelBtn = new System.Windows.Forms.Button();
            this.OptionsOkBtn = new System.Windows.Forms.Button();
            this.OptionsExitBtn = new System.Windows.Forms.Button();
            this.OptionsTabs.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.AccountGroup.SuspendLayout();
            this.StartupGroup.SuspendLayout();
            this.tabAppearance.SuspendLayout();
            this.FontGroup.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionsTabs
            // 
            this.OptionsTabs.Controls.Add(this.tabGeneral);
            this.OptionsTabs.Controls.Add(this.tabAppearance);
            this.OptionsTabs.Controls.Add(this.tabAbout);
            this.OptionsTabs.Location = new System.Drawing.Point(6, 6);
            this.OptionsTabs.Name = "OptionsTabs";
            this.OptionsTabs.SelectedIndex = 0;
            this.OptionsTabs.Size = new System.Drawing.Size(423, 218);
            this.OptionsTabs.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.AccountGroup);
            this.tabGeneral.Controls.Add(this.StartupGroup);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Size = new System.Drawing.Size(415, 192);
            this.tabGeneral.TabIndex = 3;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // AccountGroup
            // 
            this.AccountGroup.Controls.Add(this.ClientSecretsFileTxt);
            this.AccountGroup.Controls.Add(this.ClientSecretsLink);
            this.AccountGroup.Controls.Add(this.SecretsFileBrowseBtn);
            this.AccountGroup.Controls.Add(this.ClientSecretsFileLbl);
            this.AccountGroup.Location = new System.Drawing.Point(16, 72);
            this.AccountGroup.Name = "AccountGroup";
            this.AccountGroup.Size = new System.Drawing.Size(384, 86);
            this.AccountGroup.TabIndex = 2;
            this.AccountGroup.TabStop = false;
            this.AccountGroup.Text = "Google Account";
            // 
            // ClientSecretsFileTxt
            // 
            this.ClientSecretsFileTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClientSecretsFileTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DesktopGoogleCalendar.Properties.Settings.Default, "ApiClientSecretsFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ClientSecretsFileTxt.Location = new System.Drawing.Point(50, 36);
            this.ClientSecretsFileTxt.Name = "ClientSecretsFileTxt";
            this.ClientSecretsFileTxt.Size = new System.Drawing.Size(292, 20);
            this.ClientSecretsFileTxt.TabIndex = 7;
            this.ClientSecretsFileTxt.Text = global::DesktopGoogleCalendar.Properties.Settings.Default.ApiClientSecretsFile;
            // 
            // ClientSecretsLink
            // 
            this.ClientSecretsLink.AutoSize = true;
            this.ClientSecretsLink.Location = new System.Drawing.Point(47, 57);
            this.ClientSecretsLink.Name = "ClientSecretsLink";
            this.ClientSecretsLink.Size = new System.Drawing.Size(245, 13);
            this.ClientSecretsLink.TabIndex = 6;
            this.ClientSecretsLink.TabStop = true;
            this.ClientSecretsLink.Tag = "https://console.developers.google.com/start/api?id=calendar";
            this.ClientSecretsLink.Text = "Click here to create or download your Client ID File";
            this.ClientSecretsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClientSecretsLink_LinkClicked);
            // 
            // SecretsFileBrowseBtn
            // 
            this.SecretsFileBrowseBtn.Location = new System.Drawing.Point(348, 31);
            this.SecretsFileBrowseBtn.Name = "SecretsFileBrowseBtn";
            this.SecretsFileBrowseBtn.Size = new System.Drawing.Size(30, 25);
            this.SecretsFileBrowseBtn.TabIndex = 5;
            this.SecretsFileBrowseBtn.Text = "...";
            this.SecretsFileBrowseBtn.UseVisualStyleBackColor = true;
            this.SecretsFileBrowseBtn.Click += new System.EventHandler(this.SecretsFileBrowseBtn_Click);
            // 
            // ClientSecretsFileLbl
            // 
            this.ClientSecretsFileLbl.AutoSize = true;
            this.ClientSecretsFileLbl.Location = new System.Drawing.Point(47, 18);
            this.ClientSecretsFileLbl.Name = "ClientSecretsFileLbl";
            this.ClientSecretsFileLbl.Size = new System.Drawing.Size(151, 13);
            this.ClientSecretsFileLbl.TabIndex = 3;
            this.ClientSecretsFileLbl.Text = "Google Calendar Client ID File:";
            // 
            // StartupGroup
            // 
            this.StartupGroup.Controls.Add(this.OptionsStartupChk);
            this.StartupGroup.Location = new System.Drawing.Point(16, 12);
            this.StartupGroup.Name = "StartupGroup";
            this.StartupGroup.Size = new System.Drawing.Size(384, 47);
            this.StartupGroup.TabIndex = 1;
            this.StartupGroup.TabStop = false;
            this.StartupGroup.Text = "Startup";
            // 
            // OptionsStartupChk
            // 
            this.OptionsStartupChk.AutoSize = true;
            this.OptionsStartupChk.Checked = global::DesktopGoogleCalendar.Properties.Settings.Default.RunAtStartup;
            this.OptionsStartupChk.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::DesktopGoogleCalendar.Properties.Settings.Default, "RunAtStartup", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.OptionsStartupChk.Location = new System.Drawing.Point(50, 18);
            this.OptionsStartupChk.Name = "OptionsStartupChk";
            this.OptionsStartupChk.Size = new System.Drawing.Size(275, 17);
            this.OptionsStartupChk.TabIndex = 1;
            this.OptionsStartupChk.Text = "Run Desktop Google Calendar when Windows starts";
            this.OptionsStartupChk.UseVisualStyleBackColor = true;
            // 
            // tabAppearance
            // 
            this.tabAppearance.Controls.Add(this.FontGroup);
            this.tabAppearance.Controls.Add(this.PositionLbl);
            this.tabAppearance.Controls.Add(this.PositionSelect);
            this.tabAppearance.Location = new System.Drawing.Point(4, 22);
            this.tabAppearance.Name = "tabAppearance";
            this.tabAppearance.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppearance.Size = new System.Drawing.Size(415, 192);
            this.tabAppearance.TabIndex = 1;
            this.tabAppearance.Text = "Appearance";
            this.tabAppearance.UseVisualStyleBackColor = true;
            // 
            // FontGroup
            // 
            this.FontGroup.Controls.Add(this.EventDateFontColor);
            this.FontGroup.Controls.Add(this.DateFontColor);
            this.FontGroup.Controls.Add(this.EventDateFontBtn);
            this.FontGroup.Controls.Add(this.EventDateFontTxt);
            this.FontGroup.Controls.Add(this.EventDateFontLbl);
            this.FontGroup.Controls.Add(this.DateFontBtn);
            this.FontGroup.Controls.Add(this.DateFontTxt);
            this.FontGroup.Controls.Add(this.DateFontLbl);
            this.FontGroup.Controls.Add(this.EventFontTxt);
            this.FontGroup.Controls.Add(this.ClockFontColor);
            this.FontGroup.Controls.Add(this.ClockFontBtn);
            this.FontGroup.Controls.Add(this.ClockFontTxt);
            this.FontGroup.Controls.Add(this.ClockFontLbl);
            this.FontGroup.Controls.Add(this.EventFontBtn);
            this.FontGroup.Controls.Add(this.EventFontLbl);
            this.FontGroup.Location = new System.Drawing.Point(17, 38);
            this.FontGroup.Name = "FontGroup";
            this.FontGroup.Size = new System.Drawing.Size(384, 142);
            this.FontGroup.TabIndex = 10;
            this.FontGroup.TabStop = false;
            this.FontGroup.Text = "Fonts";
            // 
            // EventDateFontColor
            // 
            this.EventDateFontColor.BackColor = global::DesktopGoogleCalendar.Properties.Settings.Default.DateFontColor;
            this.EventDateFontColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EventDateFontColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DesktopGoogleCalendar.Properties.Settings.Default, "DateFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EventDateFontColor.Location = new System.Drawing.Point(353, 79);
            this.EventDateFontColor.Name = "EventDateFontColor";
            this.EventDateFontColor.Size = new System.Drawing.Size(25, 20);
            this.EventDateFontColor.TabIndex = 24;
            this.EventDateFontColor.Click += new System.EventHandler(this.EventDateFontColor_Click);
            // 
            // DateFontColor
            // 
            this.DateFontColor.BackColor = global::DesktopGoogleCalendar.Properties.Settings.Default.TodayFontColor;
            this.DateFontColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DateFontColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DesktopGoogleCalendar.Properties.Settings.Default, "TodayFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DateFontColor.Location = new System.Drawing.Point(353, 49);
            this.DateFontColor.Name = "DateFontColor";
            this.DateFontColor.Size = new System.Drawing.Size(25, 20);
            this.DateFontColor.TabIndex = 23;
            this.DateFontColor.Click += new System.EventHandler(this.DateFontColor_Click);
            // 
            // EventDateFontBtn
            // 
            this.EventDateFontBtn.Location = new System.Drawing.Point(317, 77);
            this.EventDateFontBtn.Name = "EventDateFontBtn";
            this.EventDateFontBtn.Size = new System.Drawing.Size(30, 23);
            this.EventDateFontBtn.TabIndex = 22;
            this.EventDateFontBtn.Text = "...";
            this.EventDateFontBtn.UseVisualStyleBackColor = true;
            this.EventDateFontBtn.Click += new System.EventHandler(this.EventDateFontBtn_Click);
            // 
            // EventDateFontTxt
            // 
            this.EventDateFontTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EventDateFontTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DesktopGoogleCalendar.Properties.Settings.Default, "dateFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EventDateFontTxt.Location = new System.Drawing.Point(81, 77);
            this.EventDateFontTxt.Name = "EventDateFontTxt";
            this.EventDateFontTxt.Size = new System.Drawing.Size(230, 20);
            this.EventDateFontTxt.TabIndex = 21;
            this.EventDateFontTxt.Text = "[Font: Name=Tahoma, Size=12, Units=3, GdiCharSet=1, GdiVerticalFont=False]";
            // 
            // EventDateFontLbl
            // 
            this.EventDateFontLbl.AutoSize = true;
            this.EventDateFontLbl.Location = new System.Drawing.Point(11, 78);
            this.EventDateFontLbl.Name = "EventDateFontLbl";
            this.EventDateFontLbl.Size = new System.Drawing.Size(64, 13);
            this.EventDateFontLbl.TabIndex = 20;
            this.EventDateFontLbl.Text = "Event Date:";
            this.EventDateFontLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DateFontBtn
            // 
            this.DateFontBtn.Location = new System.Drawing.Point(317, 48);
            this.DateFontBtn.Name = "DateFontBtn";
            this.DateFontBtn.Size = new System.Drawing.Size(30, 23);
            this.DateFontBtn.TabIndex = 19;
            this.DateFontBtn.Text = "...";
            this.DateFontBtn.UseVisualStyleBackColor = true;
            this.DateFontBtn.Click += new System.EventHandler(this.DateFontBtn_Click);
            // 
            // DateFontTxt
            // 
            this.DateFontTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DateFontTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DesktopGoogleCalendar.Properties.Settings.Default, "todayFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DateFontTxt.Location = new System.Drawing.Point(81, 48);
            this.DateFontTxt.Name = "DateFontTxt";
            this.DateFontTxt.Size = new System.Drawing.Size(230, 20);
            this.DateFontTxt.TabIndex = 18;
            this.DateFontTxt.Text = "[Font: Name=Tahoma, Size=16, Units=3, GdiCharSet=1, GdiVerticalFont=False]";
            // 
            // DateFontLbl
            // 
            this.DateFontLbl.AutoSize = true;
            this.DateFontLbl.Location = new System.Drawing.Point(42, 49);
            this.DateFontLbl.Name = "DateFontLbl";
            this.DateFontLbl.Size = new System.Drawing.Size(33, 13);
            this.DateFontLbl.TabIndex = 17;
            this.DateFontLbl.Text = "Date:";
            // 
            // EventFontTxt
            // 
            this.EventFontTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EventFontTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DesktopGoogleCalendar.Properties.Settings.Default, "eventFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EventFontTxt.Location = new System.Drawing.Point(81, 109);
            this.EventFontTxt.Name = "EventFontTxt";
            this.EventFontTxt.Size = new System.Drawing.Size(230, 20);
            this.EventFontTxt.TabIndex = 16;
            this.EventFontTxt.Text = "[Font: Name=Tahoma, Size=11, Units=3, GdiCharSet=1, GdiVerticalFont=False]";
            // 
            // ClockFontColor
            // 
            this.ClockFontColor.BackColor = global::DesktopGoogleCalendar.Properties.Settings.Default.ClockFontColor;
            this.ClockFontColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClockFontColor.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DesktopGoogleCalendar.Properties.Settings.Default, "ClockFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ClockFontColor.Location = new System.Drawing.Point(353, 20);
            this.ClockFontColor.Name = "ClockFontColor";
            this.ClockFontColor.Size = new System.Drawing.Size(25, 20);
            this.ClockFontColor.TabIndex = 15;
            this.ClockFontColor.Click += new System.EventHandler(this.ClockFontColor_Click);
            // 
            // ClockFontBtn
            // 
            this.ClockFontBtn.Location = new System.Drawing.Point(317, 19);
            this.ClockFontBtn.Name = "ClockFontBtn";
            this.ClockFontBtn.Size = new System.Drawing.Size(30, 23);
            this.ClockFontBtn.TabIndex = 14;
            this.ClockFontBtn.Text = "...";
            this.ClockFontBtn.UseVisualStyleBackColor = true;
            this.ClockFontBtn.Click += new System.EventHandler(this.ClockFontBtn_Click);
            // 
            // ClockFontTxt
            // 
            this.ClockFontTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClockFontTxt.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DesktopGoogleCalendar.Properties.Settings.Default, "clockFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ClockFontTxt.Location = new System.Drawing.Point(81, 19);
            this.ClockFontTxt.Name = "ClockFontTxt";
            this.ClockFontTxt.Size = new System.Drawing.Size(230, 20);
            this.ClockFontTxt.TabIndex = 13;
            this.ClockFontTxt.Text = "[Font: Name=Tahoma, Size=26, Units=3, GdiCharSet=1, GdiVerticalFont=False]";
            // 
            // ClockFontLbl
            // 
            this.ClockFontLbl.AutoSize = true;
            this.ClockFontLbl.Location = new System.Drawing.Point(38, 22);
            this.ClockFontLbl.Name = "ClockFontLbl";
            this.ClockFontLbl.Size = new System.Drawing.Size(37, 13);
            this.ClockFontLbl.TabIndex = 12;
            this.ClockFontLbl.Text = "Clock:";
            this.ClockFontLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // EventFontBtn
            // 
            this.EventFontBtn.Location = new System.Drawing.Point(317, 109);
            this.EventFontBtn.Name = "EventFontBtn";
            this.EventFontBtn.Size = new System.Drawing.Size(30, 23);
            this.EventFontBtn.TabIndex = 11;
            this.EventFontBtn.Text = "...";
            this.EventFontBtn.UseVisualStyleBackColor = true;
            this.EventFontBtn.Click += new System.EventHandler(this.EventFontBtn_Click);
            // 
            // EventFontLbl
            // 
            this.EventFontLbl.AutoSize = true;
            this.EventFontLbl.Location = new System.Drawing.Point(14, 110);
            this.EventFontLbl.Name = "EventFontLbl";
            this.EventFontLbl.Size = new System.Drawing.Size(61, 13);
            this.EventFontLbl.TabIndex = 10;
            this.EventFontLbl.Text = "Event Title:";
            this.EventFontLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PositionLbl
            // 
            this.PositionLbl.AutoSize = true;
            this.PositionLbl.Location = new System.Drawing.Point(14, 14);
            this.PositionLbl.Name = "PositionLbl";
            this.PositionLbl.Size = new System.Drawing.Size(92, 13);
            this.PositionLbl.TabIndex = 1;
            this.PositionLbl.Text = "Calendar Position:";
            // 
            // PositionSelect
            // 
            this.PositionSelect.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DesktopGoogleCalendar.Properties.Settings.Default, "WindowPosition", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PositionSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionSelect.FormattingEnabled = true;
            this.PositionSelect.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.PositionSelect.Location = new System.Drawing.Point(112, 11);
            this.PositionSelect.Name = "PositionSelect";
            this.PositionSelect.Size = new System.Drawing.Size(106, 21);
            this.PositionSelect.TabIndex = 0;
            this.PositionSelect.Text = global::DesktopGoogleCalendar.Properties.Settings.Default.WindowPosition;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.pictureBox1);
            this.tabAbout.Controls.Add(this.groupBox1);
            this.tabAbout.Controls.Add(this.VerLbl);
            this.tabAbout.Controls.Add(this.ProgramTitleLbl);
            this.tabAbout.Controls.Add(this.GithubLink);
            this.tabAbout.Controls.Add(this.AboutAuthorLbl);
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(415, 192);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::DesktopGoogleCalendar.Properties.Resources.GoogleCalendarIcon;
            this.pictureBox1.Location = new System.Drawing.Point(5, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 66);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DescriptionLbl);
            this.groupBox1.Location = new System.Drawing.Point(16, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 78);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLbl.Location = new System.Drawing.Point(10, 16);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(368, 43);
            this.DescriptionLbl.TabIndex = 6;
            this.DescriptionLbl.Text = "Desktop Google Calendar brings your Google calendars directly to your desktop so " +
    "you always know what\'s coming up!";
            this.DescriptionLbl.UseMnemonic = false;
            // 
            // VerLbl
            // 
            this.VerLbl.AutoSize = true;
            this.VerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerLbl.Location = new System.Drawing.Point(69, 40);
            this.VerLbl.Name = "VerLbl";
            this.VerLbl.Size = new System.Drawing.Size(57, 16);
            this.VerLbl.TabIndex = 4;
            this.VerLbl.Text = "Version:";
            // 
            // ProgramTitleLbl
            // 
            this.ProgramTitleLbl.AutoSize = true;
            this.ProgramTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramTitleLbl.Location = new System.Drawing.Point(67, 13);
            this.ProgramTitleLbl.Name = "ProgramTitleLbl";
            this.ProgramTitleLbl.Size = new System.Drawing.Size(259, 25);
            this.ProgramTitleLbl.TabIndex = 3;
            this.ProgramTitleLbl.Text = "Desktop Google Calendar";
            // 
            // GithubLink
            // 
            this.GithubLink.AutoSize = true;
            this.GithubLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GithubLink.Location = new System.Drawing.Point(69, 58);
            this.GithubLink.Name = "GithubLink";
            this.GithubLink.Size = new System.Drawing.Size(215, 16);
            this.GithubLink.TabIndex = 2;
            this.GithubLink.TabStop = true;
            this.GithubLink.Tag = "https://github.com/cleroux";
            this.GithubLink.Text = "Website: https://github.com/cleroux";
            this.GithubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLink_LinkClicked);
            // 
            // AboutAuthorLbl
            // 
            this.AboutAuthorLbl.AutoSize = true;
            this.AboutAuthorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutAuthorLbl.Location = new System.Drawing.Point(69, 78);
            this.AboutAuthorLbl.Name = "AboutAuthorLbl";
            this.AboutAuthorLbl.Size = new System.Drawing.Size(171, 16);
            this.AboutAuthorLbl.TabIndex = 0;
            this.AboutAuthorLbl.Text = "Created by: Cedric Le Roux";
            // 
            // OptionsCancelBtn
            // 
            this.OptionsCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OptionsCancelBtn.Location = new System.Drawing.Point(349, 230);
            this.OptionsCancelBtn.Name = "OptionsCancelBtn";
            this.OptionsCancelBtn.Size = new System.Drawing.Size(80, 23);
            this.OptionsCancelBtn.TabIndex = 1;
            this.OptionsCancelBtn.Text = "Cancel";
            this.OptionsCancelBtn.UseVisualStyleBackColor = true;
            this.OptionsCancelBtn.Click += new System.EventHandler(this.OptionsCancelBtn_Click);
            // 
            // OptionsOkBtn
            // 
            this.OptionsOkBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OptionsOkBtn.Location = new System.Drawing.Point(263, 230);
            this.OptionsOkBtn.Name = "OptionsOkBtn";
            this.OptionsOkBtn.Size = new System.Drawing.Size(80, 23);
            this.OptionsOkBtn.TabIndex = 2;
            this.OptionsOkBtn.Text = "OK";
            this.OptionsOkBtn.UseVisualStyleBackColor = true;
            this.OptionsOkBtn.Click += new System.EventHandler(this.OptionsOkBtn_Click);
            // 
            // OptionsExitBtn
            // 
            this.OptionsExitBtn.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.OptionsExitBtn.Location = new System.Drawing.Point(6, 230);
            this.OptionsExitBtn.Name = "OptionsExitBtn";
            this.OptionsExitBtn.Size = new System.Drawing.Size(110, 23);
            this.OptionsExitBtn.TabIndex = 3;
            this.OptionsExitBtn.Text = "Close Application";
            this.OptionsExitBtn.UseVisualStyleBackColor = true;
            // 
            // OptionsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 260);
            this.Controls.Add(this.OptionsExitBtn);
            this.Controls.Add(this.OptionsOkBtn);
            this.Controls.Add(this.OptionsCancelBtn);
            this.Controls.Add(this.OptionsTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OptionsFrm_Load);
            this.OptionsTabs.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.AccountGroup.ResumeLayout(false);
            this.AccountGroup.PerformLayout();
            this.StartupGroup.ResumeLayout(false);
            this.StartupGroup.PerformLayout();
            this.tabAppearance.ResumeLayout(false);
            this.tabAppearance.PerformLayout();
            this.FontGroup.ResumeLayout(false);
            this.FontGroup.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl OptionsTabs;
        private System.Windows.Forms.TabPage tabAppearance;
        private System.Windows.Forms.TabPage tabAbout;
        private System.Windows.Forms.LinkLabel GithubLink;
        private System.Windows.Forms.Label AboutAuthorLbl;
        private System.Windows.Forms.Button OptionsCancelBtn;
        private System.Windows.Forms.Button OptionsOkBtn;
        private System.Windows.Forms.ComboBox PositionSelect;
        private System.Windows.Forms.Label PositionLbl;
        private System.Windows.Forms.Button OptionsExitBtn;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.GroupBox StartupGroup;
        private System.Windows.Forms.CheckBox OptionsStartupChk;
        private System.Windows.Forms.GroupBox AccountGroup;
        private System.Windows.Forms.Button SecretsFileBrowseBtn;
        private System.Windows.Forms.Label ClientSecretsFileLbl;
        private System.Windows.Forms.LinkLabel ClientSecretsLink;
        private System.Windows.Forms.GroupBox FontGroup;
        private System.Windows.Forms.Label DateFontTxt;
        private System.Windows.Forms.Label DateFontLbl;
        private System.Windows.Forms.Label EventFontTxt;
        private System.Windows.Forms.Label ClockFontColor;
        private System.Windows.Forms.Button ClockFontBtn;
        private System.Windows.Forms.Label ClockFontTxt;
        private System.Windows.Forms.Label ClockFontLbl;
        private System.Windows.Forms.Button EventFontBtn;
        private System.Windows.Forms.Label EventFontLbl;
        private System.Windows.Forms.Button DateFontBtn;
        private System.Windows.Forms.Button EventDateFontBtn;
        private System.Windows.Forms.Label EventDateFontTxt;
        private System.Windows.Forms.Label EventDateFontLbl;
        private System.Windows.Forms.Label ClientSecretsFileTxt;
        private System.Windows.Forms.Label DateFontColor;
        private System.Windows.Forms.Label EventDateFontColor;
        private System.Windows.Forms.Label VerLbl;
        private System.Windows.Forms.Label ProgramTitleLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}