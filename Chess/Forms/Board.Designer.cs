namespace Chess
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
            Return = new PictureBox();
            BoardImage = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BoardBackground).BeginInit();
            BoardBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Return).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BoardImage).BeginInit();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(BoardImage);
            ContentPanel.Controls.Add(BoardBackground);
            ContentPanel.Location = new Point(0, 0);
            ContentPanel.Margin = new Padding(2, 3, 2, 3);
            ContentPanel.Size = new Size(800, 450);
            // 
            // BoardBackground
            // 
            BoardBackground.Controls.Add(Return);
            BoardBackground.Image = Properties.Resources.Wood1;
            BoardBackground.Location = new Point(0, 0);
            BoardBackground.Name = "BoardBackground";
            BoardBackground.Size = new Size(800, 451);
            BoardBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            BoardBackground.TabIndex = 0;
            BoardBackground.TabStop = false;
            // 
            // Return
            // 
            Return.BackColor = Color.Transparent;
            Return.Image = Properties.Resources.Return;
            Return.Location = new Point(690, 11);
            Return.Name = "Return";
            Return.Size = new Size(98, 41);
            Return.SizeMode = PictureBoxSizeMode.Zoom;
            Return.TabIndex = 2;
            Return.TabStop = false;
            Return.Click += Return_Click;
            // 
            // BoardImage
            // 
            BoardImage.Image = Properties.Resources.Board;
            BoardImage.Location = new Point(185, 11);
            BoardImage.Name = "BoardImage";
            BoardImage.Size = new Size(430, 429);
            BoardImage.SizeMode = PictureBoxSizeMode.Zoom;
            BoardImage.TabIndex = 1;
            BoardImage.TabStop = false;
            // 
            // Board
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Board";
            Text = "Board";
            ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BoardBackground).EndInit();
            BoardBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Return).EndInit();
            ((System.ComponentModel.ISupportInitialize)BoardImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox BoardBackground;
        private PictureBox BoardImage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox Return;
    }
}