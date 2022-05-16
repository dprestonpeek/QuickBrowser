namespace QuickBrowser
{
    partial class BrowserWindow
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
            this.BrowserPanel = new System.Windows.Forms.Panel();
            this.Handlebar = new System.Windows.Forms.MenuStrip();
            this.Close = new System.Windows.Forms.ToolStripMenuItem();
            this.Minimize = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Handlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrowserPanel
            // 
            this.BrowserPanel.AutoSize = true;
            this.BrowserPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BrowserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserPanel.Location = new System.Drawing.Point(0, 28);
            this.BrowserPanel.Name = "BrowserPanel";
            this.BrowserPanel.Size = new System.Drawing.Size(1000, 534);
            this.BrowserPanel.TabIndex = 3;
            // 
            // Handlebar
            // 
            this.Handlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Handlebar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Handlebar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Handlebar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Close,
            this.Minimize});
            this.Handlebar.Location = new System.Drawing.Point(0, 0);
            this.Handlebar.Name = "Handlebar";
            this.Handlebar.Size = new System.Drawing.Size(1000, 28);
            this.Handlebar.TabIndex = 4;
            this.Handlebar.Text = "menuStrip1";
            this.Handlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Handlebar_MouseDown);
            this.Handlebar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Handlebar_MouseUp);
            // 
            // Close
            // 
            this.Close.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(31, 24);
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Minimize
            // 
            this.Minimize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(27, 24);
            this.Minimize.Text = "_";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // BrowserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.BrowserPanel);
            this.Controls.Add(this.Handlebar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.Handlebar;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BrowserWindow";
            this.Text = "BrowserWindow";
            this.Handlebar.ResumeLayout(false);
            this.Handlebar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel BrowserPanel;
        private System.Windows.Forms.ToolStripMenuItem Close;
        private System.Windows.Forms.ToolStripMenuItem Minimize;
        public System.Windows.Forms.MenuStrip Handlebar;
        private System.Windows.Forms.Timer Timer;
    }
}