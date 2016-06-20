namespace ConwaysGameOfLife
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb = new System.Windows.Forms.PictureBox();
            this.generationTimer = new System.Windows.Forms.Timer(this.components);
            this.btnRestart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblGen = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.speedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verySlow2xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slow4xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normal8xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fast12xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veryFast32xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.superSpeed64xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.colorThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pb.Location = new System.Drawing.Point(12, 29);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(600, 600);
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            this.pb.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // generationTimer
            // 
            this.generationTimer.Interval = 125;
            this.generationTimer.Tick += new System.EventHandler(this.generationTimer_Tick);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(12, 645);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(536, 645);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(93, 645);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 0;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // lblGen
            // 
            this.lblGen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGen.Location = new System.Drawing.Point(272, 645);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(100, 23);
            this.lblGen.TabIndex = 4;
            this.lblGen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speedToolStripMenuItem,
            this.colorThemeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // speedToolStripMenuItem
            // 
            this.speedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verySlow2xToolStripMenuItem,
            this.slow4xToolStripMenuItem,
            this.normal8xToolStripMenuItem,
            this.fast12xToolStripMenuItem,
            this.veryFast32xToolStripMenuItem,
            this.superSpeed64xToolStripMenuItem});
            this.speedToolStripMenuItem.Name = "speedToolStripMenuItem";
            this.speedToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.speedToolStripMenuItem.Text = "Speed";
            // 
            // verySlow2xToolStripMenuItem
            // 
            this.verySlow2xToolStripMenuItem.Name = "verySlow2xToolStripMenuItem";
            this.verySlow2xToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.verySlow2xToolStripMenuItem.Text = "Very Slow (2x)";
            this.verySlow2xToolStripMenuItem.Click += new System.EventHandler(this.verySlow2xToolStripMenuItem_Click);
            // 
            // slow4xToolStripMenuItem
            // 
            this.slow4xToolStripMenuItem.Name = "slow4xToolStripMenuItem";
            this.slow4xToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.slow4xToolStripMenuItem.Text = "Slow (4x)";
            this.slow4xToolStripMenuItem.Click += new System.EventHandler(this.slow4xToolStripMenuItem_Click);
            // 
            // normal8xToolStripMenuItem
            // 
            this.normal8xToolStripMenuItem.Name = "normal8xToolStripMenuItem";
            this.normal8xToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.normal8xToolStripMenuItem.Text = "Normal (8x)";
            this.normal8xToolStripMenuItem.Click += new System.EventHandler(this.normal8xToolStripMenuItem_Click);
            // 
            // fast12xToolStripMenuItem
            // 
            this.fast12xToolStripMenuItem.Name = "fast12xToolStripMenuItem";
            this.fast12xToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.fast12xToolStripMenuItem.Text = "Fast (16x)";
            this.fast12xToolStripMenuItem.Click += new System.EventHandler(this.fast12xToolStripMenuItem_Click);
            // 
            // veryFast32xToolStripMenuItem
            // 
            this.veryFast32xToolStripMenuItem.Name = "veryFast32xToolStripMenuItem";
            this.veryFast32xToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.veryFast32xToolStripMenuItem.Text = "Very Fast (32x)";
            this.veryFast32xToolStripMenuItem.Click += new System.EventHandler(this.veryFast32xToolStripMenuItem_Click);
            // 
            // superSpeed64xToolStripMenuItem
            // 
            this.superSpeed64xToolStripMenuItem.Name = "superSpeed64xToolStripMenuItem";
            this.superSpeed64xToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.superSpeed64xToolStripMenuItem.Text = "Super Speed (64x)";
            this.superSpeed64xToolStripMenuItem.Click += new System.EventHandler(this.superSpeed64xToolStripMenuItem_Click);
            // 
            // cbAuto
            // 
            this.cbAuto.AutoSize = true;
            this.cbAuto.Location = new System.Drawing.Point(403, 649);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(67, 17);
            this.cbAuto.TabIndex = 6;
            this.cbAuto.Text = "Autoplay";
            this.cbAuto.UseVisualStyleBackColor = true;
            this.cbAuto.CheckedChanged += new System.EventHandler(this.cbAuto_CheckedChanged);
            // 
            // colorThemeToolStripMenuItem
            // 
            this.colorThemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem,
            this.terminalToolStripMenuItem});
            this.colorThemeToolStripMenuItem.Name = "colorThemeToolStripMenuItem";
            this.colorThemeToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.colorThemeToolStripMenuItem.Text = "Color Theme";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // terminalToolStripMenuItem
            // 
            this.terminalToolStripMenuItem.Name = "terminalToolStripMenuItem";
            this.terminalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.terminalToolStripMenuItem.Text = "Terminal";
            this.terminalToolStripMenuItem.Click += new System.EventHandler(this.terminalToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPause;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 674);
            this.Controls.Add(this.cbAuto);
            this.Controls.Add(this.lblGen);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Conway\'s Game of Life";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Timer generationTimer;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem speedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verySlow2xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slow4xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normal8xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fast12xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veryFast32xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem superSpeed64xToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbAuto;
        private System.Windows.Forms.ToolStripMenuItem colorThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminalToolStripMenuItem;
    }
}

