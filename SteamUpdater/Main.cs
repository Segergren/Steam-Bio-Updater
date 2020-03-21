using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SteamCoronaUpdater
{
    public partial class Updater : Form
    {
        public Updater()
        {
            InitializeComponent();
        }
        private void Updater_Load(object sender, EventArgs e)
        {

        }
        /* Move window */
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        /* END move window */

        private void Togglebtn_Click(object sender, EventArgs e)
        {
            SteamUpdater.Properties.Settings.Default.bioCache = biotbx.Text;
            SteamUpdater.Properties.Settings.Default.Save();

            if (BioUpdater.Enabled == false)
            {
                BioUpdater.Start();
                Togglebtn.Text = "Stop";
            }
            else
            {
                BioUpdater.Stop();
                Togglebtn.Text = "Start";
            }

        }

        int minute = 0;

        List<CountryInfo> countryInfos = new List<CountryInfo>();
        Total total;
        private void UpdateSteam()
        {

            try
            {
                //Gets the Corona info.
                using (var webClient = new System.Net.WebClient())
                {
                    var json = webClient.DownloadString("https://coronavirus-19-api.herokuapp.com/countries");
                    countryInfos.Clear();
                    countryInfos = JsonConvert.DeserializeObject<List<CountryInfo>>(json);
                }

                using (var webClient = new System.Net.WebClient())
                {
                    var json2 = webClient.DownloadString("https://coronavirus-19-api.herokuapp.com/all");
                    total = JsonConvert.DeserializeObject<Total>(json2);
                }

                //Inserts the bio
                Browser.Document.GetElementById("summary").InnerText = FormatText(biotbx.Text);
                WaitNSeconds(1);
                //Clicks the save button
                HtmlElementCollection elc = this.Browser.Document.GetElementsByTagName("button");
                foreach (HtmlElement el in elc)
                {
                    if (el.GetAttribute("type").Equals("submit"))
                    {
                        el.InvokeMember("Click");
                    }
                }
            }
            catch (Exception)
            {
                Browser.Refresh();
            }

        }

        private string FormatText(string Text)
        {
            string textToFormat = Text;
            int CheckCounter = 0;
            while (true)
            {
                //If the bio includes a parentheses but could not be formatted.
                if (CheckCounter >= 4000)
                {
                    break;
                }
                CheckCounter++;

                //Gets the index of the beginning and end.
                int foundReplaceBeginning = textToFormat.IndexOf('(');
                int foundReplaceEnd = textToFormat.IndexOf(')');

                //If there is a parentheses left.
                if (foundReplaceBeginning != -1)
                {
                    //Get the country name and try to get the stats.
                    string countryName = textToFormat.Substring(foundReplaceBeginning + 1, (textToFormat.IndexOf('|') - foundReplaceBeginning) - 1);
                    CountryInfo country = null;
                    foreach (var item in countryInfos)
                    {
                        if (Convert.ToString(item.country).ToLower() == Convert.ToString(countryName.ToLower()))
                        {
                            country = item;
                        }
                    }
                    if (country != null)
                    {
                        //Formats the parentheses for corona.
                        switch (textToFormat.Split('|')[1].Substring(0, textToFormat.IndexOf(')') - textToFormat.IndexOf('|') - 1).ToLower())
                        {
                            case ("cases"):
                                textToFormat = textToFormat.Remove(foundReplaceBeginning, (foundReplaceEnd - foundReplaceBeginning) + 1);
                                textToFormat = textToFormat.Insert(foundReplaceBeginning, Convert.ToString(country.cases));
                                break;
                            case ("critical"):
                                textToFormat = textToFormat.Remove(foundReplaceBeginning, (foundReplaceEnd - foundReplaceBeginning) + 1);
                                textToFormat = textToFormat.Insert(foundReplaceBeginning, Convert.ToString(country.critical));
                                break;
                            case ("name"):
                                textToFormat = textToFormat.Remove(foundReplaceBeginning, (foundReplaceEnd - foundReplaceBeginning) + 1);
                                textToFormat = textToFormat.Insert(foundReplaceBeginning, Convert.ToString(country.country));
                                break;
                            case ("casesperonemillion"):
                                textToFormat = textToFormat.Remove(foundReplaceBeginning, (foundReplaceEnd - foundReplaceBeginning) + 1);
                                textToFormat = textToFormat.Insert(foundReplaceBeginning, Convert.ToString(country.casesPerOneMillion));
                                break;
                            case ("active"):
                                textToFormat = textToFormat.Remove(foundReplaceBeginning, (foundReplaceEnd - foundReplaceBeginning) + 1);
                                textToFormat = textToFormat.Insert(foundReplaceBeginning, Convert.ToString(country.active));
                                break;
                            case ("recovered"):
                                textToFormat = textToFormat.Remove(foundReplaceBeginning, (foundReplaceEnd - foundReplaceBeginning) + 1);
                                textToFormat = textToFormat.Insert(foundReplaceBeginning, Convert.ToString(country.recovered));
                                break;
                            case ("todaycases"):
                                textToFormat = textToFormat.Remove(foundReplaceBeginning, (foundReplaceEnd - foundReplaceBeginning) + 1);
                                textToFormat = textToFormat.Insert(foundReplaceBeginning, Convert.ToString(country.todayCases));
                                break;
                            case ("todaydeaths"):
                                textToFormat = textToFormat.Remove(foundReplaceBeginning, (foundReplaceEnd - foundReplaceBeginning) + 1);
                                textToFormat = textToFormat.Insert(foundReplaceBeginning, Convert.ToString(country.todayDeaths));
                                break;
                        }
                    }
                    else
                    {
                        //Formats the parentheses for total cases (Corona).
                        string command = textToFormat.Substring(foundReplaceBeginning + 1, (foundReplaceEnd - foundReplaceBeginning) - 1);
                        switch (command.ToLower())
                        {
                            case ("total|cases"):
                                textToFormat = textToFormat.Remove(foundReplaceBeginning, (foundReplaceEnd - foundReplaceBeginning) + 1);
                                textToFormat = textToFormat.Insert(foundReplaceBeginning, Convert.ToString(total.cases));
                                break;
                            case ("total|deaths"):
                                textToFormat = textToFormat.Remove(foundReplaceBeginning, (foundReplaceEnd - foundReplaceBeginning) + 1);
                                textToFormat = textToFormat.Insert(foundReplaceBeginning, Convert.ToString(total.deaths));
                                break;
                            case ("total|recovered"):
                                textToFormat = textToFormat.Remove(foundReplaceBeginning, (foundReplaceEnd - foundReplaceBeginning) + 1);
                                textToFormat = textToFormat.Insert(foundReplaceBeginning, Convert.ToString(total.recovered));
                                break;
                            //Formats the parentheses for time.
                            case ("time|hour"):
                                textToFormat = textToFormat.Remove(foundReplaceBeginning, (foundReplaceEnd - foundReplaceBeginning) + 1);
                                textToFormat = textToFormat.Insert(foundReplaceBeginning, DateTime.Now.ToString("HH"));
                                break;
                            case ("time|minute"):
                                textToFormat = textToFormat.Remove(foundReplaceBeginning, (foundReplaceEnd - foundReplaceBeginning) + 1);
                                textToFormat = textToFormat.Insert(foundReplaceBeginning, DateTime.Now.ToString("mm"));
                                break;
                            case ("time|second"):
                                textToFormat = textToFormat.Remove(foundReplaceBeginning, (foundReplaceEnd - foundReplaceBeginning) + 1);
                                textToFormat = textToFormat.Insert(foundReplaceBeginning, DateTime.Now.ToString("ss"));
                                break;
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            return textToFormat;
        }

        private void Updater_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(185, 59, 212), 1), new Rectangle(new Point(0, 0), new Size(this.Width - 1, this.Height - 1)));
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            if (BioUpdater.Enabled)
            {
                var doClose = MessageBox.Show("The updater is still running.\nAre you sure you want to close?", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (doClose == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void Hidebtn_Click(object sender, EventArgs e)
        {
            Hide();
            this.ShowInTaskbar = false;
            notifyIcon.Visible = true;
            notifyIcon.Text = "Steam Bio Updater";
        }
        bool secondStep = false;
        private void Loginbtn_Click(object sender, EventArgs e)
        {

            if (secondStep == false)
            {
                //Inputs username and password, then clicks login.
                Browser.Document.GetElementById("steamAccountName").InnerText = usernametbx.Text;
                Browser.Document.GetElementById("steamPassword").InnerText = passwordtbx.Text;
                Browser.Document.GetElementById("remember_login").InvokeMember("CLICK");
                WaitNSeconds(1);
                Browser.Document.GetElementById("SteamLogin").InvokeMember("CLICK");
                WaitNSeconds(5);

                //Gets the error if it occurs.
                string errorText = Browser.Document.GetElementById("error_display").InnerText;
                if (errorText != null)
                {
                    //Shows the error and refreshes the login page.
                    Browser.Refresh();
                    MessageBox.Show(errorText, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    bool steamguard = false;
                    try
                    {
                        //If the steamguard textfield appears.
                        string steamGuardFound = Browser.Document.GetElementById("twofactorcode_entry").InnerText;
                        steamguard = true;
                    }
                    catch
                    {
                        //No steamguard.
                    }

                    if (steamguard)
                    {
                        usernamelbl.Hide();
                        usernametbx.Hide();
                        passwordlbl.Text = "Steam Guard";
                        passwordtbx.Text = "";
                        passwordlbl.ForeColor = Color.Red;
                        secondStep = true;
                    }
                }
            }
            else
            {
                Browser.Document.GetElementById("twofactorcode_entry").InnerText = passwordtbx.Text;
                var links = Browser.Document.GetElementsByTagName("div");
                int count = 0;
                foreach (HtmlElement link in links)
                {
                    if (link.GetAttribute("className") == "auth_button_h3")
                    {
                        if (count == 9)
                        {
                            link.InvokeMember("CLICK");
                            break;
                        }
                        count++;
                    }
                }

            }
        }

        private void WaitNSeconds(int segundos)
        {
            if (segundos < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(segundos);
            while (DateTime.Now < _desired)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }

        bool GoneToEdit = false;
        private void LoggedInTimer_Tick(object sender, EventArgs e)
        {
            //Checks if the user is loggedin.
            if (Convert.ToString(Browser.Url).Contains("https://steamcommunity.com/id/"))
            {
                if (!GoneToEdit)
                {
                    Browser.Navigate(Browser.Url + "edit");
                    GoneToEdit = true;
                }
                else
                {
                    if (Convert.ToString(Browser.Url).Contains("/edit"))
                    {
                        //If the user is on the edit site, show the Bio panel.
                        loggedInTimer.Stop();
                        usernamelbl.Hide();
                        usernametbx.Hide();
                        passwordlbl.Hide();
                        passwordtbx.Hide();
                        loginbtn.Hide();
                        loggedInPanel.Show();
                        biotbx.Text = SteamUpdater.Properties.Settings.Default.bioCache;
                        Togglebtn.Enabled = false;
                        Togglebtn.Text = "localizing.";
                        WaitNSeconds(1);
                        Togglebtn.Text = "localizing..";
                        WaitNSeconds(1);
                        Togglebtn.Text = "localizing...";
                        WaitNSeconds(1);
                        Togglebtn.Text = "Start";
                        Togglebtn.Enabled = true;
                    }
                }
            }
        }

        private void Biotbx_TextChanged(object sender, EventArgs e)
        {
            //Steam bio character length.
            characterCounter.Text = biotbx.Text.Length + "/4000";
        }

        private void ShowFormat_Click(object sender, EventArgs e)
        {
            Format format = new Format();
            format.Show();
        }

        private void Updater_MouseDown(object sender, MouseEventArgs e)
        {
            //Makes it possible for the user to move the window
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Logo_MouseDown(object sender, MouseEventArgs e)
        {
            //Makes it possible for the user to move the window
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //Check if the login page is fully loaded.
            if (this.Browser.ReadyState != WebBrowserReadyState.Complete)
            {
                return;
            }
            else
            {
                loginbtn.Enabled = true;
            }
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            notifyIcon.Visible = false;
        }

        private void NotifyIcon_Click(object sender, EventArgs e)
        {
            Show();
            notifyIcon.Visible = false;
        }

        private void BioUpdater_Tick(object sender, EventArgs e)
        {
            if (minute != Convert.ToInt32(DateTime.Now.ToString("mm")))
            {
                minute = Convert.ToInt32(DateTime.Now.ToString("mm"));
                UpdateSteam();
            }
        }
    }
}
