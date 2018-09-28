using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;

namespace DesktopGoogleCalendar
{
    public partial class OptionsFrm : Form
    {
        public OptionsFrm()
        {
            InitializeComponent();
        }

        private void OptionsOkBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Properties.Settings.Default.ApiClientSecretsFile))
            {
                MessageBox.Show("You must specify a valid Client ID File.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
                return;
            }

            Properties.Settings.Default.Save();

            RegistryKey key = Registry.CurrentUser.OpenSubKey(global::DesktopGoogleCalendar.Properties.Resources.startupKeyPath, true);
            if (Properties.Settings.Default.RunAtStartup)
            {
                // Create registry key if it doesn't exist. (although, this key should always exist)
                if (key == null)
                {
                    key = Registry.CurrentUser.CreateSubKey(global::DesktopGoogleCalendar.Properties.Resources.startupKeyPath);
                }
                key.SetValue(global::DesktopGoogleCalendar.Properties.Resources.startupKeyName, Application.ExecutablePath.ToString());
            } else
            {
                // Delete registry key
                key.DeleteValue(global::DesktopGoogleCalendar.Properties.Resources.startupKeyName, false);
            }
        }

        private void OptionsFrm_Load(object sender, EventArgs e)
        {
            VerLbl.Text = String.Format("Version: {0}", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);
            ClientSecretsLink.Links.Add(0, 10, ClientSecretsLink.Tag);
            GithubLink.Links.Add(9, GithubLink.Tag.ToString().Length, GithubLink.Tag);

            Properties.Settings.Default.Reload();

            // Check if registry key was modified outside of this application and update settings accordingly
            RegistryKey key = Registry.CurrentUser.OpenSubKey(global::DesktopGoogleCalendar.Properties.Resources.startupKeyPath, true);
            if (key.GetValue(global::DesktopGoogleCalendar.Properties.Resources.startupKeyName) == null)
            {
                Properties.Settings.Default.RunAtStartup = false;
            } else
            {
                Properties.Settings.Default.RunAtStartup = true;
            }
        }

        private void SecretsFileBrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ClientSecretsFileTxt.Text = dlg.FileName;
            }
        }

        private void EventFontBtn_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.Font = global::DesktopGoogleCalendar.Properties.Settings.Default.EventFont;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                global::DesktopGoogleCalendar.Properties.Settings.Default.EventFont = dlg.Font;
                EventFontTxt.Text = global::DesktopGoogleCalendar.Properties.Settings.Default.EventFont.ToString();
            }
        }

        private void ClockFontBtn_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.Font = global::DesktopGoogleCalendar.Properties.Settings.Default.ClockFont;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                global::DesktopGoogleCalendar.Properties.Settings.Default.ClockFont = dlg.Font;
                ClockFontTxt.Text = global::DesktopGoogleCalendar.Properties.Settings.Default.ClockFont.ToString();
            }
        }

        private void DateFontBtn_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.Font = global::DesktopGoogleCalendar.Properties.Settings.Default.TodayFont;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                global::DesktopGoogleCalendar.Properties.Settings.Default.TodayFont = dlg.Font;
                DateFontTxt.Text = global::DesktopGoogleCalendar.Properties.Settings.Default.TodayFont.ToString();
            }
        }

        private void EventDateFontBtn_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.Font = global::DesktopGoogleCalendar.Properties.Settings.Default.DateFont;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                global::DesktopGoogleCalendar.Properties.Settings.Default.DateFont = dlg.Font;
                EventDateFontTxt.Text = global::DesktopGoogleCalendar.Properties.Settings.Default.DateFont.ToString();
            }
        }

        private void ClientSecretsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void ClockFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = ClockFontColor.BackColor;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ClockFontColor.BackColor = dlg.Color;
            }
        }

        private void DateFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = DateFontColor.BackColor;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                DateFontColor.BackColor = dlg.Color;
            }
        }

        private void EventDateFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = EventDateFontColor.BackColor;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                EventDateFontColor.BackColor = dlg.Color;
            }
        }

        private void OptionsCancelBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
        }
    }
}
