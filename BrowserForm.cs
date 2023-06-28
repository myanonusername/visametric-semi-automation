using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisaMetric
{
    public partial class BrowserForm : Form
    {
        public string currentAddress = "";
        public string ApplicationDirectory = "";
        public BrowserForm()
        {
            CefSettings settings = new CefSettings();
            settings.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CEF";
            CefSharp.Cef.Initialize(settings);
            ApplicationDirectory = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\"));
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            browser.AddressChanged += Browser_AddressChanged;
            browser.LoadUrl("https://ir-appointment.visametric.com/ir");
        }

        private void Browser_AddressChanged(object sender, CefSharp.AddressChangedEventArgs e)
        {
            currentAddress = e.Address;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            textBoxUrl.Text = currentAddress;
        }

        private void btnNationality_Click(object sender, EventArgs e)
        {
            var sr = new StreamReader(ApplicationDirectory + @"\nationality.txt");
            string script = sr.ReadToEnd();
            browser.EvaluateScriptAsync(script);
        }

        private void btnMeetingDetails_Click(object sender, EventArgs e)
        {
            var sr = new StreamReader(ApplicationDirectory + @"\meeting-details.txt");
            string script = sr.ReadToEnd();
            browser.EvaluateScriptAsync(script);
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            var sr = new StreamReader(ApplicationDirectory + @"\personal-info.txt");
            string script = sr.ReadToEnd();
            browser.EvaluateScriptAsync(script);
        }

        private void btnEditNationality_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(ApplicationDirectory + @"\nationality.txt", "");
        }

        private void btnEditMeeting_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(ApplicationDirectory + @"\meeting-details.txt", "");

        }

        private void btnEditPersonalInfo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(ApplicationDirectory + @"\personal-info.txt", "");

        }
    }
}
