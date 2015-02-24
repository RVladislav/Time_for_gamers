﻿namespace Time
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmC1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmC2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmC3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmC4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmC5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmC6 = new System.Windows.Forms.ToolStripMenuItem();
            this.bColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCB1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCB2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.ContextMenuStrip = this.contextMenuStrip;
            this.lblTime.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTime.Name = "lblTime";
            this.lblTime.DoubleClick += new System.EventHandler(this.lblTime_DoubleClick);
            this.lblTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTime_MouseDown);
            this.lblTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblTime_MouseUp);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmColor,
            this.bColorToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            resources.ApplyResources(this.contextMenuStrip, "contextMenuStrip");
            // 
            // tsmColor
            // 
            this.tsmColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmC1,
            this.tsmC2,
            this.tsmC3,
            this.tsmC4,
            this.tsmC5,
            this.tsmC6});
            this.tsmColor.Name = "tsmColor";
            resources.ApplyResources(this.tsmColor, "tsmColor");
            // 
            // tsmC1
            // 
            this.tsmC1.BackColor = System.Drawing.Color.DarkRed;
            this.tsmC1.Name = "tsmC1";
            resources.ApplyResources(this.tsmC1, "tsmC1");
            this.tsmC1.Click += new System.EventHandler(this.tsmC1_Click);
            // 
            // tsmC2
            // 
            this.tsmC2.BackColor = System.Drawing.Color.Orange;
            this.tsmC2.Name = "tsmC2";
            resources.ApplyResources(this.tsmC2, "tsmC2");
            this.tsmC2.Click += new System.EventHandler(this.tsmC2_Click);
            // 
            // tsmC3
            // 
            this.tsmC3.BackColor = System.Drawing.Color.LimeGreen;
            this.tsmC3.Name = "tsmC3";
            resources.ApplyResources(this.tsmC3, "tsmC3");
            this.tsmC3.Click += new System.EventHandler(this.tsmC3_Click);
            // 
            // tsmC4
            // 
            this.tsmC4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tsmC4.Name = "tsmC4";
            resources.ApplyResources(this.tsmC4, "tsmC4");
            this.tsmC4.Click += new System.EventHandler(this.tsmC4_Click);
            // 
            // tsmC5
            // 
            this.tsmC5.BackColor = System.Drawing.Color.MediumOrchid;
            this.tsmC5.Name = "tsmC5";
            resources.ApplyResources(this.tsmC5, "tsmC5");
            this.tsmC5.Click += new System.EventHandler(this.tsmC5_Click);
            // 
            // tsmC6
            // 
            this.tsmC6.BackColor = System.Drawing.Color.DeepPink;
            this.tsmC6.Name = "tsmC6";
            resources.ApplyResources(this.tsmC6, "tsmC6");
            this.tsmC6.Click += new System.EventHandler(this.tsmC6_Click);
            // 
            // bColorToolStripMenuItem
            // 
            this.bColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCB1,
            this.tsmCB2});
            this.bColorToolStripMenuItem.Name = "bColorToolStripMenuItem";
            resources.ApplyResources(this.bColorToolStripMenuItem, "bColorToolStripMenuItem");
            // 
            // tsmCB1
            // 
            this.tsmCB1.BackColor = System.Drawing.Color.White;
            this.tsmCB1.Name = "tsmCB1";
            resources.ApplyResources(this.tsmCB1, "tsmCB1");
            this.tsmCB1.Click += new System.EventHandler(this.tsmCB1_Click);
            // 
            // tsmCB2
            // 
            this.tsmCB2.BackColor = System.Drawing.Color.Black;
            this.tsmCB2.Name = "tsmCB2";
            resources.ApplyResources(this.tsmCB2, "tsmCB2");
            this.tsmCB2.Click += new System.EventHandler(this.tsmCB2_Click);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            this.DoubleClick += new System.EventHandler(this.Main_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmColor;
        private System.Windows.Forms.ToolStripMenuItem tsmC1;
        private System.Windows.Forms.ToolStripMenuItem tsmC2;
        private System.Windows.Forms.ToolStripMenuItem tsmC3;
        private System.Windows.Forms.ToolStripMenuItem tsmC4;
        private System.Windows.Forms.ToolStripMenuItem tsmC5;
        private System.Windows.Forms.ToolStripMenuItem tsmC6;
        private System.Windows.Forms.ToolStripMenuItem bColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCB1;
        private System.Windows.Forms.ToolStripMenuItem tsmCB2;
    }
}

