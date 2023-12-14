﻿namespace Chess
{
    partial class Board
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
            BoardBackground = new PictureBox();
            BoardImage = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BoardBackground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BoardImage).BeginInit();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(BoardImage);
            ContentPanel.Controls.Add(BoardBackground);
            ContentPanel.Location = new Point(0, 0);
            ContentPanel.Size = new Size(800, 450);
            // 
            // BoardBackground
            // 
            BoardBackground.Image = Properties.Resources.Wood1;
            BoardBackground.Location = new Point(0, 0);
            BoardBackground.Name = "BoardBackground";
            BoardBackground.Size = new Size(800, 450);
            BoardBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            BoardBackground.TabIndex = 0;
            BoardBackground.TabStop = false;
            // 
            // BoardImage
            // 
            BoardImage.Image = Properties.Resources.Board;
            BoardImage.Location = new Point(185, 10);
            BoardImage.Name = "BoardImage";
            BoardImage.Size = new Size(430, 430);
            BoardImage.SizeMode = PictureBoxSizeMode.Zoom;
            BoardImage.TabIndex = 1;
            BoardImage.TabStop = false;
            // 
            // Board
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Board";
            Text = "Board";
            ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BoardBackground).EndInit();
            ((System.ComponentModel.ISupportInitialize)BoardImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox BoardBackground;
        private PictureBox BoardImage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}