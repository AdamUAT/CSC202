using System.Windows.Forms;

namespace Chess
{
    partial class MainMenu
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
            MainMenuBackground = new PictureBox();
            QuitButton = new PictureBox();
            QuitButtonText = new PictureBox();
            SettingsButton = new PictureBox();
            SettingsButtonText = new PictureBox();
            PlayButton = new PictureBox();
            PlayButtonText = new PictureBox();
            ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainMenuBackground).BeginInit();
            MainMenuBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuitButton).BeginInit();
            QuitButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuitButtonText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SettingsButton).BeginInit();
            SettingsButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SettingsButtonText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayButton).BeginInit();
            PlayButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PlayButtonText).BeginInit();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(MainMenuBackground);
            ContentPanel.Location = new Point(0, 0);
            ContentPanel.Size = new Size(800, 450);
            // 
            // MainMenuBackground
            // 
            MainMenuBackground.Controls.Add(QuitButton);
            MainMenuBackground.Controls.Add(SettingsButton);
            MainMenuBackground.Controls.Add(PlayButton);
            MainMenuBackground.Dock = DockStyle.Fill;
            MainMenuBackground.Image = Properties.Resources.MainMenuScreen;
            MainMenuBackground.Location = new Point(0, 0);
            MainMenuBackground.Name = "MainMenuBackground";
            MainMenuBackground.Size = new Size(800, 450);
            MainMenuBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            MainMenuBackground.TabIndex = 0;
            MainMenuBackground.TabStop = false;
            // 
            // QuitButton
            // 
            QuitButton.BackColor = Color.Transparent;
            QuitButton.Controls.Add(QuitButtonText);
            QuitButton.Image = Properties.Resources.MainMenuButton;
            QuitButton.Location = new Point(62, 322);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(315, 81);
            QuitButton.SizeMode = PictureBoxSizeMode.Zoom;
            QuitButton.TabIndex = 3;
            QuitButton.TabStop = false;
            QuitButton.Click += QuitButton_Click;
            QuitButton.MouseEnter += QuitButton_MouseEnter;
            QuitButton.MouseLeave += QuitButton_MouseLeave;
            // 
            // QuitButtonText
            // 
            QuitButtonText.BackColor = Color.Transparent;
            QuitButtonText.Image = Properties.Resources.QuitText;
            QuitButtonText.Location = new Point(21, 21);
            QuitButtonText.Name = "QuitButtonText";
            QuitButtonText.Size = new Size(125, 40);
            QuitButtonText.SizeMode = PictureBoxSizeMode.Zoom;
            QuitButtonText.TabIndex = 6;
            QuitButtonText.TabStop = false;
            QuitButtonText.Click += QuitButtonText_Click;
            QuitButtonText.MouseEnter += QuitButtonText_MouseEnter;
            // 
            // SettingsButton
            // 
            SettingsButton.BackColor = Color.Transparent;
            SettingsButton.Controls.Add(SettingsButtonText);
            SettingsButton.Image = Properties.Resources.MainMenuButton;
            SettingsButton.Location = new Point(96, 248);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(315, 81);
            SettingsButton.SizeMode = PictureBoxSizeMode.Zoom;
            SettingsButton.TabIndex = 2;
            SettingsButton.TabStop = false;
            SettingsButton.Click += SettingsButton_Click;
            SettingsButton.MouseEnter += SettingsButton_MouseEnter;
            SettingsButton.MouseLeave += SettingsButton_MouseLeave;
            // 
            // SettingsButtonText
            // 
            SettingsButtonText.BackColor = Color.Transparent;
            SettingsButtonText.Image = Properties.Resources.SettingsText;
            SettingsButtonText.Location = new Point(21, 21);
            SettingsButtonText.Name = "SettingsButtonText";
            SettingsButtonText.Size = new Size(164, 40);
            SettingsButtonText.SizeMode = PictureBoxSizeMode.Zoom;
            SettingsButtonText.TabIndex = 5;
            SettingsButtonText.TabStop = false;
            SettingsButtonText.Click += SettingsButtonText_Click;
            SettingsButtonText.MouseEnter += SettingsButtonText_MouseEnter;
            // 
            // PlayButton
            // 
            PlayButton.BackColor = Color.Transparent;
            PlayButton.Controls.Add(PlayButtonText);
            PlayButton.Image = Properties.Resources.MainMenuButton;
            PlayButton.Location = new Point(132, 170);
            PlayButton.Name = "PlayButton";
            PlayButton.Size = new Size(315, 81);
            PlayButton.SizeMode = PictureBoxSizeMode.Zoom;
            PlayButton.TabIndex = 1;
            PlayButton.TabStop = false;
            PlayButton.Click += PlayButton_Click;
            PlayButton.MouseEnter += PlayButton_MouseEnter;
            PlayButton.MouseLeave += PlayButton_MouseLeave;
            // 
            // PlayButtonText
            // 
            PlayButtonText.BackColor = Color.Transparent;
            PlayButtonText.Image = Properties.Resources.PlayText;
            PlayButtonText.Location = new Point(21, 21);
            PlayButtonText.Name = "PlayButtonText";
            PlayButtonText.Size = new Size(103, 40);
            PlayButtonText.SizeMode = PictureBoxSizeMode.Zoom;
            PlayButtonText.TabIndex = 4;
            PlayButtonText.TabStop = false;
            PlayButtonText.Click += PlayButtonText_Click;
            PlayButtonText.MouseEnter += PlayButtonText_MouseEnter;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "MainMenu";
            Text = "MainMenu";
            ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainMenuBackground).EndInit();
            MainMenuBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)QuitButton).EndInit();
            QuitButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)QuitButtonText).EndInit();
            ((System.ComponentModel.ISupportInitialize)SettingsButton).EndInit();
            SettingsButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SettingsButtonText).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayButton).EndInit();
            PlayButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PlayButtonText).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox MainMenuBackground;
        private PictureBox PlayButton;
        private PictureBox QuitButton;
        private PictureBox SettingsButton;
        private PictureBox PlayButtonText;
        private PictureBox QuitButtonText;
        private PictureBox SettingsButtonText;
    }
}