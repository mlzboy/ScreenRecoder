﻿namespace ScreenRecoder.App
{
    partial class FormScreenShutcut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScreenShutcut));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormScreenShutcut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormScreenShutcut";
            this.ShowInTaskbar = false;
            this.Text = "截图窗口";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChooseWindow_FormClosing);
            this.Load += new System.EventHandler(this.FormChooseWindow_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormChooseWindow_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormScreenShutcut_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormChooseWindow_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormScreenShutcut_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormChooseWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormScreenShutcut_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
    }
}