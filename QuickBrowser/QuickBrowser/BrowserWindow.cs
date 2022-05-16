using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace QuickBrowser
{
    public partial class BrowserWindow : Form
    {
        Point moveOffset;
        ChromiumWebBrowser chrome;
        public BrowserWindow(ChromiumWebBrowser chrome)
        {
            InitializeComponent();
            this.chrome = chrome;
            BrowserPanel.Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
