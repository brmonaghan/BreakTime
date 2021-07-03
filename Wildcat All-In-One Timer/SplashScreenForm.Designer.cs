﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace UTimer
{
    [DesignerGenerated()]
    public partial class SplashScreenForm : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        private Label ApplicationTitle;
        private Label Version;
        private Label Copyright;
        private TableLayoutPanel MainLayoutPanel;
        private TableLayoutPanel DetailsLayoutPanel;

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenForm));
            MainLayoutPanel = new TableLayoutPanel();
            DetailsLayoutPanel = new TableLayoutPanel();
            Version = new Label();
            Copyright = new Label();
            ApplicationTitle = new Label();
            MainLayoutPanel.SuspendLayout();
            DetailsLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            MainLayoutPanel.BackgroundImage = (Image)resources.GetObject("MainLayoutPanel.BackgroundImage");
            MainLayoutPanel.BackgroundImageLayout = ImageLayout.Stretch;
            MainLayoutPanel.ColumnCount = 2;
            MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 243.0F));
            MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100.0F));
            MainLayoutPanel.Controls.Add(DetailsLayoutPanel, 1, 1);
            MainLayoutPanel.Controls.Add(ApplicationTitle, 1, 0);
            MainLayoutPanel.Dock = DockStyle.Fill;
            MainLayoutPanel.Location = new Point(0, 0);
            MainLayoutPanel.Name = "MainLayoutPanel";
            MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 218.0F));
            MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 38.0F));
            MainLayoutPanel.Size = new Size(496, 303);
            MainLayoutPanel.TabIndex = 0;
            // 
            // DetailsLayoutPanel
            // 
            DetailsLayoutPanel.Anchor = AnchorStyles.None;
            DetailsLayoutPanel.BackColor = Color.Transparent;
            DetailsLayoutPanel.ColumnCount = 1;
            DetailsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 247.0F));
            DetailsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 142.0F));
            DetailsLayoutPanel.Controls.Add(Version, 0, 0);
            DetailsLayoutPanel.Controls.Add(Copyright, 0, 1);
            DetailsLayoutPanel.Location = new Point(246, 221);
            DetailsLayoutPanel.Name = "DetailsLayoutPanel";
            DetailsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.0F));
            DetailsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.0F));
            DetailsLayoutPanel.Size = new Size(247, 79);
            DetailsLayoutPanel.TabIndex = 1;
            // 
            // Version
            // 
            Version.Anchor = AnchorStyles.None;
            Version.BackColor = Color.Transparent;
            Version.Font = new Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Version.Location = new Point(3, 9);
            Version.Name = "Version";
            Version.Size = new Size(241, 20);
            Version.TabIndex = 1;
            Version.Text = "Version {0}.{1:00}";
            // 
            // Copyright
            // 
            Copyright.Anchor = AnchorStyles.None;
            Copyright.BackColor = Color.Transparent;
            Copyright.Font = new Font("Microsoft Sans Serif", 9.0F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Copyright.Location = new Point(3, 39);
            Copyright.Name = "Copyright";
            Copyright.Size = new Size(241, 40);
            Copyright.TabIndex = 2;
            Copyright.Text = "Copyright";
            // 
            // ApplicationTitle
            // 
            ApplicationTitle.Anchor = AnchorStyles.None;
            ApplicationTitle.BackColor = Color.Transparent;
            ApplicationTitle.Font = new Font("Microsoft Sans Serif", 18.0F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            ApplicationTitle.Location = new Point(246, 3);
            ApplicationTitle.Name = "ApplicationTitle";
            ApplicationTitle.Size = new Size(247, 212);
            ApplicationTitle.TabIndex = 0;
            ApplicationTitle.Text = "Application Title";
            ApplicationTitle.TextAlign = ContentAlignment.BottomLeft;
            // 
            // FormSplash
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 303);
            ControlBox = false;
            Controls.Add(MainLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSplash";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            MainLayoutPanel.ResumeLayout(false);
            DetailsLayoutPanel.ResumeLayout(false);
            Load += new EventHandler(FormSplash_Load);
            ResumeLayout(false);
        }
    }
}