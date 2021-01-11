using System.Threading;
namespace MatrixGrid
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tHREADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWToolStripMenuItem100 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_50 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_100 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_200 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.P = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tHREADToolStripMenuItem,
            this.vIEWToolStripMenuItem100});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tHREADToolStripMenuItem
            // 
            this.tHREADToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.resumeToolStripMenuItem});
            this.tHREADToolStripMenuItem.Name = "tHREADToolStripMenuItem";
            this.tHREADToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.tHREADToolStripMenuItem.Text = "THREAD";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // resumeToolStripMenuItem
            // 
            this.resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            this.resumeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resumeToolStripMenuItem.Text = "Resume";
            this.resumeToolStripMenuItem.Click += new System.EventHandler(this.resumeToolStripMenuItem_Click);
            // 
            // vIEWToolStripMenuItem100
            // 
            this.vIEWToolStripMenuItem100.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_50,
            this.toolStripMenuItem_100,
            this.toolStripMenuItem_200});
            this.vIEWToolStripMenuItem100.Name = "vIEWToolStripMenuItem100";
            this.vIEWToolStripMenuItem100.Size = new System.Drawing.Size(46, 20);
            this.vIEWToolStripMenuItem100.Text = "VIEW";
            // 
            // toolStripMenuItem_50
            // 
            this.toolStripMenuItem_50.Name = "toolStripMenuItem_50";
            this.toolStripMenuItem_50.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_50.Text = "50%";
            this.toolStripMenuItem_50.Click += new System.EventHandler(this.toolStripMenuItem_50_Click);
            // 
            // toolStripMenuItem_100
            // 
            this.toolStripMenuItem_100.Name = "toolStripMenuItem_100";
            this.toolStripMenuItem_100.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_100.Text = "100%";
            this.toolStripMenuItem_100.Click += new System.EventHandler(this.toolStripMenuItem_100_Click);
            // 
            // toolStripMenuItem_200
            // 
            this.toolStripMenuItem_200.Name = "toolStripMenuItem_200";
            this.toolStripMenuItem_200.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_200.Text = "200%";
            this.toolStripMenuItem_200.Click += new System.EventHandler(this.toolStripMenuItem_200_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(47, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "R";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.resumeToolStripMenuItem_Click);
            // 
            // P
            // 
            this.P.BackColor = System.Drawing.Color.Red;
            this.P.ForeColor = System.Drawing.SystemColors.Desktop;
            this.P.Location = new System.Drawing.Point(12, 27);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(29, 23);
            this.P.TabIndex = 4;
            this.P.Text = "P";
            this.P.UseVisualStyleBackColor = false;
            this.P.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.P);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tHREADToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
        public Thread GridMatrix;
        public bool bThreadStatus;
        private System.Windows.Forms.ToolStripMenuItem vIEWToolStripMenuItem100;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_50;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_100;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_200;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button P;
    }
}

