﻿namespace HopeCity.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picRestore = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picMaximize = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuTileButton5 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.headerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Location = new System.Drawing.Point(120, 65);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(680, 441);
            this.mainPanel.TabIndex = 1;
            // 
            // headerPanel
            // 
            this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.headerPanel.Controls.Add(this.panel1);
            this.headerPanel.Controls.Add(this.bunifuThinButton21);
            this.headerPanel.Controls.Add(this.bunifuImageButton1);
            this.headerPanel.Location = new System.Drawing.Point(120, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(680, 65);
            this.headerPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.picRestore);
            this.panel1.Controls.Add(this.picMinimize);
            this.panel1.Controls.Add(this.picMaximize);
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Location = new System.Drawing.Point(598, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(70, 24);
            this.panel1.TabIndex = 0;
            // 
            // picRestore
            // 
            this.picRestore.Image = ((System.Drawing.Image)(resources.GetObject("picRestore.Image")));
            this.picRestore.Location = new System.Drawing.Point(23, 0);
            this.picRestore.Name = "picRestore";
            this.picRestore.Size = new System.Drawing.Size(24, 24);
            this.picRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRestore.TabIndex = 2;
            this.picRestore.TabStop = false;
            this.picRestore.Click += new System.EventHandler(this.picRestore_Click);
            // 
            // picMinimize
            // 
            this.picMinimize.Image = ((System.Drawing.Image)(resources.GetObject("picMinimize.Image")));
            this.picMinimize.Location = new System.Drawing.Point(0, 0);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(24, 24);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMinimize.TabIndex = 1;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // picMaximize
            // 
            this.picMaximize.Image = ((System.Drawing.Image)(resources.GetObject("picMaximize.Image")));
            this.picMaximize.Location = new System.Drawing.Point(23, 0);
            this.picMaximize.Name = "picMaximize";
            this.picMaximize.Size = new System.Drawing.Size(24, 24);
            this.picMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMaximize.TabIndex = 1;
            this.picMaximize.TabStop = false;
            this.picMaximize.Click += new System.EventHandler(this.picMaximize_Click);
            // 
            // picClose
            // 
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(46, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(24, 24);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClose.TabIndex = 1;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.RoyalBlue;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Help";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(397, 14);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(80, 37);
            this.bunifuThinButton21.TabIndex = 1;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = true;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 0;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(514, 7);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(50, 50);
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 0;
            this.bunifuImageButton1.ZoomSpeed = 10;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.leftPanel.Controls.Add(this.bunifuPictureBox1);
            this.leftPanel.Controls.Add(this.bunifuTileButton5);
            this.leftPanel.Controls.Add(this.bunifuTileButton4);
            this.leftPanel.Controls.Add(this.bunifuTileButton3);
            this.leftPanel.Controls.Add(this.bunifuTileButton2);
            this.leftPanel.Controls.Add(this.bunifuTileButton1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(120, 506);
            this.leftPanel.TabIndex = 3;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.BackColor = System.Drawing.Color.White;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = false;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(120, 120);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // bunifuTileButton5
            // 
            this.bunifuTileButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuTileButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton5.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton5.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bunifuTileButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuTileButton5.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton5.Image")));
            this.bunifuTileButton5.ImagePosition = 7;
            this.bunifuTileButton5.ImageZoom = 20;
            this.bunifuTileButton5.LabelPosition = 21;
            this.bunifuTileButton5.LabelText = "Exit";
            this.bunifuTileButton5.Location = new System.Drawing.Point(0, 438);
            this.bunifuTileButton5.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.bunifuTileButton5.Name = "bunifuTileButton5";
            this.bunifuTileButton5.Size = new System.Drawing.Size(120, 55);
            this.bunifuTileButton5.TabIndex = 0;
            this.bunifuTileButton5.Click += new System.EventHandler(this.bunifuTileButton5_Click);
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton4.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton4.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton4.Image")));
            this.bunifuTileButton4.ImagePosition = 7;
            this.bunifuTileButton4.ImageZoom = 20;
            this.bunifuTileButton4.LabelPosition = 21;
            this.bunifuTileButton4.LabelText = "Setting";
            this.bunifuTileButton4.Location = new System.Drawing.Point(0, 307);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(120, 55);
            this.bunifuTileButton4.TabIndex = 0;
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton3.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton3.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton3.Image")));
            this.bunifuTileButton3.ImagePosition = 7;
            this.bunifuTileButton3.ImageZoom = 20;
            this.bunifuTileButton3.LabelPosition = 21;
            this.bunifuTileButton3.LabelText = "Profile";
            this.bunifuTileButton3.Location = new System.Drawing.Point(0, 247);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(120, 55);
            this.bunifuTileButton3.TabIndex = 0;
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton2.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton2.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 7;
            this.bunifuTileButton2.ImageZoom = 20;
            this.bunifuTileButton2.LabelPosition = 21;
            this.bunifuTileButton2.LabelText = "Students";
            this.bunifuTileButton2.Location = new System.Drawing.Point(0, 187);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(4, 1, 4, 4);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(120, 55);
            this.bunifuTileButton2.TabIndex = 0;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.color = System.Drawing.Color.Transparent;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 7;
            this.bunifuTileButton1.ImageZoom = 20;
            this.bunifuTileButton1.LabelPosition = 21;
            this.bunifuTileButton1.LabelText = "Dashboard";
            this.bunifuTileButton1.Location = new System.Drawing.Point(0, 127);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(120, 55);
            this.bunifuTileButton1.TabIndex = 0;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this.bunifuImageButton1;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.headerPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this.panel1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel leftPanel;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picMaximize;
        private System.Windows.Forms.PictureBox picClose;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.PictureBox picRestore;
    }
}