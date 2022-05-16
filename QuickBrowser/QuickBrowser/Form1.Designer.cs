namespace QuickBrowser
{
    partial class BrowserController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserController));
            this.Handlebar = new System.Windows.Forms.MenuStrip();
            this.Close = new System.Windows.Forms.ToolStripMenuItem();
            this.Minimize = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Abort = new System.Windows.Forms.Button();
            this.Go = new System.Windows.Forms.Button();
            this.Url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.That = new System.Windows.Forms.RadioButton();
            this.This = new System.Windows.Forms.RadioButton();
            this.Start = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Hide = new System.Windows.Forms.Button();
            this.ResizeButton = new System.Windows.Forms.Button();
            this.StayOnTop = new System.Windows.Forms.CheckBox();
            this.DisplayHandlebar = new System.Windows.Forms.CheckBox();
            this.OpacityBar = new System.Windows.Forms.TrackBar();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Handlebar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBar)).BeginInit();
            this.SuspendLayout();
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
            this.Handlebar.Size = new System.Drawing.Size(398, 28);
            this.Handlebar.TabIndex = 5;
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
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.Refresh);
            this.groupBox1.Controls.Add(this.Forward);
            this.groupBox1.Controls.Add(this.Back);
            this.groupBox1.Controls.Add(this.Abort);
            this.groupBox1.Controls.Add(this.Go);
            this.groupBox1.Controls.Add(this.Url);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 133);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation";
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.Black;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Refresh.ForeColor = System.Drawing.Color.White;
            this.Refresh.Location = new System.Drawing.Point(183, 76);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(31, 31);
            this.Refresh.TabIndex = 15;
            this.Refresh.Text = "⟳";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Forward
            // 
            this.Forward.BackColor = System.Drawing.Color.Black;
            this.Forward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Forward.ForeColor = System.Drawing.Color.White;
            this.Forward.Location = new System.Drawing.Point(220, 76);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(31, 31);
            this.Forward.TabIndex = 14;
            this.Forward.Text = ">";
            this.Forward.UseVisualStyleBackColor = false;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Black;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(146, 76);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(31, 31);
            this.Back.TabIndex = 13;
            this.Back.Text = "<";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Abort
            // 
            this.Abort.BackColor = System.Drawing.Color.Black;
            this.Abort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Abort.ForeColor = System.Drawing.Color.White;
            this.Abort.Location = new System.Drawing.Point(7, 76);
            this.Abort.Name = "Abort";
            this.Abort.Size = new System.Drawing.Size(58, 31);
            this.Abort.TabIndex = 11;
            this.Abort.Text = "Abort";
            this.Abort.UseVisualStyleBackColor = false;
            this.Abort.Click += new System.EventHandler(this.Close_Click);
            // 
            // Go
            // 
            this.Go.BackColor = System.Drawing.Color.Black;
            this.Go.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Go.ForeColor = System.Drawing.Color.White;
            this.Go.Location = new System.Drawing.Point(320, 76);
            this.Go.Name = "Go";
            this.Go.Size = new System.Drawing.Size(75, 31);
            this.Go.TabIndex = 12;
            this.Go.Text = "Go";
            this.Go.UseVisualStyleBackColor = false;
            this.Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // Url
            // 
            this.Url.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Url.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Url.BackColor = System.Drawing.Color.Black;
            this.Url.Dock = System.Windows.Forms.DockStyle.Top;
            this.Url.ForeColor = System.Drawing.Color.White;
            this.Url.Location = new System.Drawing.Point(3, 43);
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(392, 27);
            this.Url.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.That);
            this.groupBox2.Controls.Add(this.This);
            this.groupBox2.Controls.Add(this.Start);
            this.groupBox2.Controls.Add(this.CloseButton);
            this.groupBox2.Controls.Add(this.Hide);
            this.groupBox2.Controls.Add(this.ResizeButton);
            this.groupBox2.Controls.Add(this.StayOnTop);
            this.groupBox2.Controls.Add(this.DisplayHandlebar);
            this.groupBox2.Controls.Add(this.OpacityBar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 151);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Opacity:";
            // 
            // That
            // 
            this.That.AutoSize = true;
            this.That.Checked = true;
            this.That.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.That.Location = new System.Drawing.Point(80, 24);
            this.That.Name = "That";
            this.That.Size = new System.Drawing.Size(63, 24);
            this.That.TabIndex = 15;
            this.That.TabStop = true;
            this.That.Text = "That";
            this.That.UseVisualStyleBackColor = true;
            // 
            // This
            // 
            this.This.AutoSize = true;
            this.This.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.This.Location = new System.Drawing.Point(12, 24);
            this.This.Name = "This";
            this.This.Size = new System.Drawing.Size(62, 24);
            this.This.TabIndex = 14;
            this.This.Text = "This";
            this.This.UseVisualStyleBackColor = true;
            this.This.CheckedChanged += new System.EventHandler(this.This_CheckedChanged);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Black;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start.ForeColor = System.Drawing.Color.White;
            this.Start.Location = new System.Drawing.Point(6, 93);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(82, 31);
            this.Start.TabIndex = 12;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Black;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(182, 93);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(82, 31);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Hide
            // 
            this.Hide.BackColor = System.Drawing.Color.Black;
            this.Hide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Hide.ForeColor = System.Drawing.Color.White;
            this.Hide.Location = new System.Drawing.Point(302, 94);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(90, 31);
            this.Hide.TabIndex = 9;
            this.Hide.Text = "Hide";
            this.Hide.UseVisualStyleBackColor = false;
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // ResizeButton
            // 
            this.ResizeButton.BackColor = System.Drawing.Color.Black;
            this.ResizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResizeButton.ForeColor = System.Drawing.Color.White;
            this.ResizeButton.Location = new System.Drawing.Point(94, 93);
            this.ResizeButton.Name = "ResizeButton";
            this.ResizeButton.Size = new System.Drawing.Size(82, 31);
            this.ResizeButton.TabIndex = 7;
            this.ResizeButton.Text = "Resize";
            this.ResizeButton.UseVisualStyleBackColor = false;
            this.ResizeButton.Click += new System.EventHandler(this.Resize_Click);
            // 
            // StayOnTop
            // 
            this.StayOnTop.AutoSize = true;
            this.StayOnTop.Location = new System.Drawing.Point(220, 22);
            this.StayOnTop.Margin = new System.Windows.Forms.Padding(4);
            this.StayOnTop.Name = "StayOnTop";
            this.StayOnTop.Size = new System.Drawing.Size(115, 24);
            this.StayOnTop.TabIndex = 2;
            this.StayOnTop.Text = "Stay on top";
            this.StayOnTop.UseVisualStyleBackColor = true;
            this.StayOnTop.CheckedChanged += new System.EventHandler(this.StayOnTop_CheckedChanged);
            // 
            // DisplayHandlebar
            // 
            this.DisplayHandlebar.AutoSize = true;
            this.DisplayHandlebar.Checked = true;
            this.DisplayHandlebar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisplayHandlebar.Location = new System.Drawing.Point(220, 54);
            this.DisplayHandlebar.Margin = new System.Windows.Forms.Padding(4);
            this.DisplayHandlebar.Name = "DisplayHandlebar";
            this.DisplayHandlebar.Size = new System.Drawing.Size(165, 24);
            this.DisplayHandlebar.TabIndex = 3;
            this.DisplayHandlebar.Text = "Display handlebar";
            this.DisplayHandlebar.UseVisualStyleBackColor = true;
            this.DisplayHandlebar.CheckedChanged += new System.EventHandler(this.DisplayHandlebar_CheckedChanged);
            // 
            // OpacityBar
            // 
            this.OpacityBar.LargeChange = 10;
            this.OpacityBar.Location = new System.Drawing.Point(80, 54);
            this.OpacityBar.Minimum = 1;
            this.OpacityBar.Name = "OpacityBar";
            this.OpacityBar.Size = new System.Drawing.Size(104, 56);
            this.OpacityBar.SmallChange = 10;
            this.OpacityBar.TabIndex = 4;
            this.OpacityBar.Value = 10;
            this.OpacityBar.Scroll += new System.EventHandler(this.Opacity_Scroll);
            // 
            // Timer
            // 
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // BrowserController
            // 
            this.AcceptButton = this.Go;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(398, 298);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Handlebar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BrowserController";
            this.Text = "BrowserController";
            this.ResizeEnd += new System.EventHandler(this.BrowserController_Resize);
            this.Handlebar.ResumeLayout(false);
            this.Handlebar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpacityBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Handlebar;
        private System.Windows.Forms.ToolStripMenuItem Close;
        private System.Windows.Forms.ToolStripMenuItem Minimize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Abort;
        private System.Windows.Forms.Button Go;
        private System.Windows.Forms.TextBox Url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button Hide;
        private System.Windows.Forms.CheckBox StayOnTop;
        private System.Windows.Forms.CheckBox DisplayHandlebar;
        private System.Windows.Forms.TrackBar OpacityBar;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button Start;
        public System.Windows.Forms.Button ResizeButton;
        private System.Windows.Forms.RadioButton That;
        private System.Windows.Forms.RadioButton This;
        private System.Windows.Forms.Label label2;
    }
}

