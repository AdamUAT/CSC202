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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            MainMenuBackground = new PictureBox();
            QuitButton = new PictureBox();
            QuitButtonText = new PictureBox();
            SettingsButton = new PictureBox();
            SettingsButtonText = new PictureBox();
            PlayButton = new PictureBox();
            PlayButtonText = new PictureBox();
            SettingsBox = new GroupBox();
            Back = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            WindowModeButton_Widescreen = new RadioButton();
            WindowModeButton_Fullscreen = new RadioButton();
            WindowModeLabel = new Label();
            WindowModeButton_Windowed = new RadioButton();
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
            SettingsBox.SuspendLayout();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.Controls.Add(SettingsBox);
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
            // SettingsBox
            // 
            SettingsBox.Controls.Add(Back);
            SettingsBox.Controls.Add(label1);
            SettingsBox.Controls.Add(textBox1);
            SettingsBox.Controls.Add(WindowModeButton_Widescreen);
            SettingsBox.Controls.Add(WindowModeButton_Fullscreen);
            SettingsBox.Controls.Add(WindowModeLabel);
            SettingsBox.Controls.Add(WindowModeButton_Windowed);
            SettingsBox.Dock = DockStyle.Fill;
            SettingsBox.Location = new Point(0, 0);
            SettingsBox.Name = "SettingsBox";
            SettingsBox.Size = new Size(800, 450);
            SettingsBox.TabIndex = 1;
            SettingsBox.TabStop = false;
            SettingsBox.Text = "Settings";
            // 
            // Back
            // 
            Back.Location = new Point(28, 409);
            Back.Name = "Back";
            Back.Size = new Size(94, 29);
            Back.TabIndex = 6;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(429, 71);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 5;
            label1.Text = "How To Play:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(429, 91);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(266, 173);
            textBox1.TabIndex = 4;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // WindowModeButton_Widescreen
            // 
            WindowModeButton_Widescreen.AutoSize = true;
            WindowModeButton_Widescreen.Location = new Point(28, 151);
            WindowModeButton_Widescreen.Name = "WindowModeButton_Widescreen";
            WindowModeButton_Widescreen.Size = new Size(107, 24);
            WindowModeButton_Widescreen.TabIndex = 3;
            WindowModeButton_Widescreen.TabStop = true;
            WindowModeButton_Widescreen.Text = "Widescreen";
            WindowModeButton_Widescreen.UseVisualStyleBackColor = true;
            WindowModeButton_Widescreen.CheckedChanged += WindowModeButton_Widescreen_CheckedChanged;
            // 
            // WindowModeButton_Fullscreen
            // 
            WindowModeButton_Fullscreen.AutoSize = true;
            WindowModeButton_Fullscreen.Location = new Point(28, 121);
            WindowModeButton_Fullscreen.Name = "WindowModeButton_Fullscreen";
            WindowModeButton_Fullscreen.Size = new Size(95, 24);
            WindowModeButton_Fullscreen.TabIndex = 2;
            WindowModeButton_Fullscreen.TabStop = true;
            WindowModeButton_Fullscreen.Text = "Fullscreen";
            WindowModeButton_Fullscreen.UseVisualStyleBackColor = true;
            WindowModeButton_Fullscreen.CheckedChanged += WindowModeButton_Fullscreen_CheckedChanged;
            // 
            // WindowModeLabel
            // 
            WindowModeLabel.AutoSize = true;
            WindowModeLabel.Location = new Point(20, 58);
            WindowModeLabel.Name = "WindowModeLabel";
            WindowModeLabel.Size = new Size(107, 20);
            WindowModeLabel.TabIndex = 1;
            WindowModeLabel.Text = "Window Mode";
            // 
            // WindowModeButton_Windowed
            // 
            WindowModeButton_Windowed.AutoSize = true;
            WindowModeButton_Windowed.Location = new Point(28, 91);
            WindowModeButton_Windowed.Name = "WindowModeButton_Windowed";
            WindowModeButton_Windowed.Size = new Size(102, 24);
            WindowModeButton_Windowed.TabIndex = 0;
            WindowModeButton_Windowed.TabStop = true;
            WindowModeButton_Windowed.Text = "Windowed";
            WindowModeButton_Windowed.UseVisualStyleBackColor = true;
            WindowModeButton_Windowed.CheckedChanged += WindowModeButton_Windowed_CheckedChanged;
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
            SettingsBox.ResumeLayout(false);
            SettingsBox.PerformLayout();
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
        private GroupBox SettingsBox;
        private RadioButton WindowModeButton_Windowed;
        private RadioButton WindowModeButton_Widescreen;
        private RadioButton WindowModeButton_Fullscreen;
        private Label WindowModeLabel;
        private TextBox textBox1;
        private Label label1;
        private Button Back;
    }
}