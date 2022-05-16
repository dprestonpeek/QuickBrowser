using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace QuickBrowser
{
    public partial class BrowserController : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        const uint SWP_NOSIZE = 0x0001;
        const uint SWP_NOZORDER = 0x0004;

        ChromiumWebBrowser chrome;
        BrowserWindow browser;
        
        Point moveOffset;
        bool typedUrl = true;

        public BrowserController()
        {
            InitializeComponent();
            InitializeCefsharp();
            InitializeBrowser();
            InitializePreferences();
            InitializeAutocomplete();
        }

        private void InitializeCefsharp()
        {
            CefSettings settings = new CefSettings
            {
                CachePath = "cache",
                UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/77.0.3865.120 Safari/537.36",
            };
            Cef.Initialize(settings);
            Cef.EnableHighDPISupport();
            chrome = new ChromiumWebBrowser("www.google.com");
            chrome.AddressChanged += Chrome_AddressChanged;
        }

        private void InitializeBrowser()
        {
            browser = new BrowserWindow(chrome);
            browser.Resize += browser_Resize;
            browser.ResizeEnd += Resize_Click;
        }

        private void InitializePreferences()
        {
            string[] prefs = File.ReadAllLines("../../../Resources/pref.txt");
            this.Opacity = double.Parse(prefs[0].Split('=')[1]);
            this.TopMost = bool.Parse(prefs[1].Split('=')[1]);
            if (bool.Parse(prefs[2].Split('=')[1]))
            {
                this.TransparencyKey = Color.Empty;
            }
            else
            {
                this.TransparencyKey = Handlebar.BackColor;
            }

            browser.Opacity = double.Parse(prefs[3].Split('=')[1]);
            OpacityBar.Value = (int)(browser.Opacity * 10);
            browser.TopMost = bool.Parse(prefs[4].Split('=')[1]);
            StayOnTop.Checked = browser.TopMost;
            if (bool.Parse(prefs[5].Split('=')[1]))
            {
                browser.TransparencyKey = Color.Empty;
                DisplayHandlebar.Checked = true;
            }
            else
            {
                browser.TransparencyKey = Handlebar.BackColor;
                DisplayHandlebar.Checked = false;
            }
        }

        private void InitializeAutocomplete()
        {
            string[] words = File.ReadAllLines("../../../Resources/autocomplete.txt");
            foreach (string word in words)
            {
                Url.AutoCompleteCustomSource.Add(word);
            }
        }

        private void SavePreferences()
        {
            string[] prefs = new string[6];
            This.Checked = true;
            prefs[0] = "this.opacity=" + this.Opacity;
            prefs[1] = "this.top=" + this.TopMost;
            prefs[2] = "this.handlebar=" + DisplayHandlebar.Checked;
            That.Checked = true;
            prefs[3] = "that.opacity=" + browser.Opacity;
            prefs[4] = "that.top=" + browser.TopMost;
            prefs[5] = "that.handlebar=" + DisplayHandlebar.Checked;
            File.WriteAllLines("../../../Resources/pref.txt", prefs);
        }

        private void SaveAutocomplete()
        {
            string[] words = new string[Url.AutoCompleteCustomSource.Count];
            Url.AutoCompleteCustomSource.CopyTo(words, 0);
            File.WriteAllLines("../../../Resources/autocomplete.txt", words);
        }

        private void Chrome_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            try
            {
                Url.Text = chrome.Address;
                if (!Url.AutoCompleteCustomSource.Contains(chrome.Address) && typedUrl)
                {
                    Url.AutoCompleteCustomSource.Add(chrome.Address);
                    SaveAutocomplete();
                    typedUrl = false;
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            SavePreferences();
            Application.Exit();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            browser.Close();
            chrome = new ChromiumWebBrowser("www.google.com");
            browser = new BrowserWindow(chrome);
        }

        private void Go_Click(object sender, EventArgs e)
        {
            string address = Url.Text;
            if (address.Contains(" "))
            {
                address.Replace(" ", "%20");
                address = "https://www.google.com/search?q=" + address;
            }
            OpenBrowser(address);
            typedUrl = true;
        }

        private void OpenBrowser(string address)
        {
            chrome.Load(address);
            browser.Show();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            chrome.Refresh();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            chrome.Back();
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            chrome.Forward();
        }

        private void StayOnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (This.Checked)
            {
                TopMost = StayOnTop.Checked;
            }
            else
            {
                browser.TopMost = StayOnTop.Checked;
            }
        }

        private void DisplayHandlebar_CheckedChanged(object sender, EventArgs e)
        {
            if (This.Checked)
            {
                if (DisplayHandlebar.Checked)
                {
                    TransparencyKey = Color.Empty;
                }
                else
                {
                    TransparencyKey = Handlebar.BackColor;
                }
            }
            else
            {
                if (DisplayHandlebar.Checked)
                {
                    browser.TransparencyKey = Color.Empty;
                }
                else
                {
                    browser.TransparencyKey = Handlebar.BackColor;
                }
            }
        }

        private void Handlebar_MouseDown(object sender, MouseEventArgs e)
        {
            moveOffset = e.Location;
            Timer.Enabled = true;
        }

        private void Handlebar_MouseUp(object sender, MouseEventArgs e)
        {
            Timer.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Location = new Point(MousePosition.X - moveOffset.X, MousePosition.Y - moveOffset.Y);
        }

        private void Opacity_Scroll(object sender, EventArgs e)
        {
            if (This.Checked)
            {
                Opacity = OpacityBar.Value * 0.1;
            }
            else
            {
                browser.Opacity = OpacityBar.Value * 0.1;
            }
        }

        private void browser_Resize(object sender, EventArgs e)
        {
            if (browser.WindowState == FormWindowState.Normal)
            {
                Hide.Text = "Hide";
            }
            else
            {
                Hide.Text = "Show";
            }
        }

        private void Resize_Click(object sender, EventArgs e)
        {
            if (This.Checked)
            {
                if (this.FormBorderStyle == FormBorderStyle.None)
                {
                    this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                    ResizeButton.Text = "Lock";
                }
                else if (this.FormBorderStyle == FormBorderStyle.SizableToolWindow)
                {
                    this.FormBorderStyle = FormBorderStyle.None;
                    ResizeButton.Text = "Resize";
                }
            }
            else
            {
                if (browser.FormBorderStyle == FormBorderStyle.None)
                {
                    browser.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                    ResizeButton.Text = "Lock";
                }
                else if (browser.FormBorderStyle == FormBorderStyle.SizableToolWindow)
                {
                    browser.FormBorderStyle = FormBorderStyle.None;
                    ResizeButton.Text = "Resize";
                }
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            OpenBrowser("www.google.com");
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            if (Hide.Text == "Hide")
            {
                browser.WindowState = FormWindowState.Minimized;
                Hide.Text = "Show";
            }
            else
            {
                browser.WindowState = FormWindowState.Normal;
                Hide.Text = "Hide";
            }
        }

        private void This_CheckedChanged(object sender, EventArgs e)
        {
            if (This.Checked)
            {
                OpacityBar.Value = (int)(this.Opacity * 10);
                StayOnTop.Checked = this.TopMost;
                if (this.TransparencyKey == Color.Empty)
                {
                    DisplayHandlebar.Checked = true;
                }
                else
                {
                    DisplayHandlebar.Checked = false;
                }
                if (this.FormBorderStyle == FormBorderStyle.None)
                {
                    ResizeButton.Text = "Resize";
                }
                else
                {
                    ResizeButton.Text = "Lock";
                }
            }
            else
            {
                OpacityBar.Value = (int)(browser.Opacity * 10);
                StayOnTop.Checked = browser.TopMost;
                if (browser.TransparencyKey == Color.Empty)
                {
                    DisplayHandlebar.Checked = true;
                }
                else
                {
                    DisplayHandlebar.Checked = false;
                }
            }
        }

        private void BrowserController_Resize(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            ResizeButton.Text = "Resize";
        }
    }
}
