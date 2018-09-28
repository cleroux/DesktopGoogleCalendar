using System.Drawing;

namespace DesktopGoogleCalendar
{
    partial class MainFrm
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
            this.components = new System.ComponentModel.Container();
            this.OptionsBtn = new System.Windows.Forms.Button();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.ClockLbl = new System.Windows.Forms.Label();
            this.TodayLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OptionsBtn
            // 
            this.OptionsBtn.BackColor = System.Drawing.Color.Transparent;
            this.OptionsBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Desktop;
            this.OptionsBtn.FlatAppearance.BorderSize = 0;
            this.OptionsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.OptionsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.OptionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionsBtn.Image = global::DesktopGoogleCalendar.Properties.Resources.SettingsIconTransparent;
            this.OptionsBtn.Location = new System.Drawing.Point(302, 0);
            this.OptionsBtn.Name = "OptionsBtn";
            this.OptionsBtn.Size = new System.Drawing.Size(32, 32);
            this.OptionsBtn.TabIndex = 0;
            this.OptionsBtn.UseVisualStyleBackColor = false;
            this.OptionsBtn.Visible = false;
            this.OptionsBtn.Click += new System.EventHandler(this.OptionsBtn_Click);
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 1000;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // ClockLbl
            // 
            this.ClockLbl.AutoSize = true;
            this.ClockLbl.BackColor = System.Drawing.Color.Transparent;
            this.ClockLbl.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::DesktopGoogleCalendar.Properties.Settings.Default, "ClockFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ClockLbl.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DesktopGoogleCalendar.Properties.Settings.Default, "ClockFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ClockLbl.Font = global::DesktopGoogleCalendar.Properties.Settings.Default.ClockFont;
            this.ClockLbl.ForeColor = global::DesktopGoogleCalendar.Properties.Settings.Default.ClockFontColor;
            this.ClockLbl.Location = new System.Drawing.Point(1, 0);
            this.ClockLbl.Name = "ClockLbl";
            this.ClockLbl.Size = new System.Drawing.Size(165, 42);
            this.ClockLbl.TabIndex = 1;
            this.ClockLbl.Text = "12:00 AM";
            // 
            // TodayLbl
            // 
            this.TodayLbl.AutoSize = true;
            this.TodayLbl.BackColor = System.Drawing.Color.Transparent;
            this.TodayLbl.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::DesktopGoogleCalendar.Properties.Settings.Default, "TodayFont", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TodayLbl.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DesktopGoogleCalendar.Properties.Settings.Default, "TodayFontColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TodayLbl.Font = global::DesktopGoogleCalendar.Properties.Settings.Default.TodayFont;
            this.TodayLbl.ForeColor = global::DesktopGoogleCalendar.Properties.Settings.Default.TodayFontColor;
            this.TodayLbl.Location = new System.Drawing.Point(5, 42);
            this.TodayLbl.Name = "TodayLbl";
            this.TodayLbl.Size = new System.Drawing.Size(169, 27);
            this.TodayLbl.TabIndex = 2;
            this.TodayLbl.Text = "January 1, 1970";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(334, 162);
            this.ControlBox = false;
            this.Controls.Add(this.OptionsBtn);
            this.Controls.Add(this.TodayLbl);
            this.Controls.Add(this.ClockLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TransparencyKey = System.Drawing.SystemColors.Desktop;
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.MouseLeave += new System.EventHandler(this.MainFrm_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainFrm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OptionsBtn;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Label ClockLbl;
        private System.Windows.Forms.Label TodayLbl;
    }
}

