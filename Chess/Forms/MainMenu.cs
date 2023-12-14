using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Net.Mime.MediaTypeNames;

namespace Chess
{
    public partial class MainMenu : AdjustableForm
    {
        Bitmap buttonImage;

        //Controls the sliding of the button's text when hovered over
        //Designer variables
        int PlayTextOffset = 140;
        int SettingsTextOffset = 100;
        int QuitTextOffset = 140;
        int PlayTextStart = 21;
        int SettingsTextStart = 21;
        int QuitTextStart = 21;
        float TextOffsetTime = 0.1f;
        //Temp variables
        int PlayTextOffsetGoal = 0;
        int SettingsTextOffsetGoal = 0;
        int QuitTextOffsetGoal = 0;

        //The size/location of the resizing buttons/text
        System.Numerics.Vector2 PlayButtonPositionPercent;
        System.Numerics.Vector2 PlayButtonScalePercent;
        System.Numerics.Vector2 SettingsButtonPositionPercent;
        System.Numerics.Vector2 SettingsButtonScalePercent;
        System.Numerics.Vector2 QuitButtonPositionPercent;
        System.Numerics.Vector2 QuitButtonScalePercent;

        System.Numerics.Vector2 PlayButtonTextScalePercent;
        float PlayButtonPositionHeightPercent;
        float PlayButtonPositionPercentStartX;
        float PlayButtonPositionPercentEndX;
        System.Numerics.Vector2 SettingsButtonTextScalePercent;
        float SettingsButtonPositionHeightPercent;
        float SettingsButtonPositionPercentStartX;
        float SettingsButtonPositionPercentEndX;
        System.Numerics.Vector2 QuitButtonTextScalePercent;
        float QuitButtonPositionHeightPercent;
        float QuitButtonPositionPercentStartX;
        float QuitButtonPositionPercentEndX;



        public MainMenu()
        {
            InitializeComponent();

            //Calculate the image of the buttons as a bitmap.
            buttonImage = (Bitmap)PlayButton.Image;

            Program.updateTimer.Tick += new EventHandler(OnUpdate);

            PlayTextOffsetGoal = PlayTextStart;
            SettingsTextOffsetGoal = SettingsTextStart;
            QuitTextOffsetGoal = QuitTextStart;

            SettingsBox.Hide();

            AdjustWindowSize();
        }

        protected override void OnResize()
        {
            base.OnResize();

            MainMenuBackground.Size = new Size(this.ContentPanel.Width, this.ContentPanel.Height);

            //Remember what the starting position the designers set for the default resolution for rescaling purposes.
            if (PlayButtonPositionPercent == System.Numerics.Vector2.Zero)
            {
                PlayButtonPositionPercent = new System.Numerics.Vector2((float)PlayButton.Location.X / MainMenuBackground.Width, (float)PlayButton.Location.Y / MainMenuBackground.Height);
                PlayButtonScalePercent = new System.Numerics.Vector2((float)PlayButton.Width / MainMenuBackground.Width, (float)PlayButton.Height / MainMenuBackground.Height);
                SettingsButtonPositionPercent = new System.Numerics.Vector2((float)SettingsButton.Location.X / MainMenuBackground.Width, (float)SettingsButton.Location.Y / MainMenuBackground.Height);
                SettingsButtonScalePercent = new System.Numerics.Vector2((float)SettingsButton.Width / MainMenuBackground.Width, (float)SettingsButton.Height / MainMenuBackground.Height);
                QuitButtonPositionPercent = new System.Numerics.Vector2((float)QuitButton.Location.X / MainMenuBackground.Width, (float)QuitButton.Location.Y / MainMenuBackground.Height);
                QuitButtonScalePercent = new System.Numerics.Vector2((float)QuitButton.Width / MainMenuBackground.Width, (float)QuitButton.Height / MainMenuBackground.Height);

                PlayButtonTextScalePercent = new System.Numerics.Vector2((float)PlayButtonText.Width / PlayButton.Width, (float)PlayButtonText.Height / PlayButton.Height);
                SettingsButtonTextScalePercent = new System.Numerics.Vector2((float)SettingsButtonText.Width / SettingsButton.Width, (float)SettingsButtonText.Height / SettingsButton.Height);
                QuitButtonTextScalePercent = new System.Numerics.Vector2((float)QuitButtonText.Width / QuitButton.Width, (float)QuitButtonText.Height / QuitButton.Height);

                PlayButtonPositionHeightPercent = (float)PlayButtonText.Location.Y / PlayButton.Height;
                SettingsButtonPositionHeightPercent = (float)SettingsButtonText.Location.Y / SettingsButton.Height;
                QuitButtonPositionHeightPercent = (float)QuitButtonText.Location.Y / QuitButton.Height;

                PlayButtonPositionPercentStartX = (float)PlayTextStart / PlayButton.Width;
                PlayButtonPositionPercentEndX = (float)PlayTextOffset / PlayButton.Width;
                SettingsButtonPositionPercentStartX = (float)SettingsTextStart / SettingsButton.Width;
                SettingsButtonPositionPercentEndX = (float)SettingsTextOffset / SettingsButton.Width;
                QuitButtonPositionPercentStartX = (float)QuitTextStart / QuitButton.Width;
                QuitButtonPositionPercentEndX = (float)QuitTextOffset / QuitButton.Width;
            }

            PlayButton.Location = new Point((int)(PlayButtonPositionPercent.X * MainMenuBackground.Width), (int)(PlayButtonPositionPercent.Y * MainMenuBackground.Height));
            PlayButton.Width = (int)(PlayButtonScalePercent.X * MainMenuBackground.Width);
            PlayButton.Height = (int)(PlayButtonScalePercent.Y * MainMenuBackground.Height);
            SettingsButton.Location = new Point((int)(SettingsButtonPositionPercent.X * MainMenuBackground.Width), (int)(SettingsButtonPositionPercent.Y * MainMenuBackground.Height));
            SettingsButton.Width = (int)(SettingsButtonScalePercent.X * MainMenuBackground.Width);
            SettingsButton.Height = (int)(SettingsButtonScalePercent.Y * MainMenuBackground.Height);
            QuitButton.Location = new Point((int)(QuitButtonPositionPercent.X * MainMenuBackground.Width), (int)(QuitButtonPositionPercent.Y * MainMenuBackground.Height));
            QuitButton.Width = (int)(QuitButtonScalePercent.X * MainMenuBackground.Width);
            QuitButton.Height = (int)(QuitButtonScalePercent.Y * MainMenuBackground.Height);

            float playButtonTextLocationPercentX = (float)(PlayButtonText.Location.X - PlayTextStart) / (PlayTextOffset - PlayTextStart);
            float settingsButtonTextLocationPercentX = (float)(SettingsButtonText.Location.X - SettingsTextStart) / (SettingsTextOffset - SettingsTextStart);
            float quitButtonTextLocationPercentX = (float)(QuitButtonText.Location.X - QuitTextStart) / (QuitTextOffset - QuitTextStart);

            PlayTextStart = (int)(PlayButtonPositionPercentStartX * PlayButton.Width);
            PlayTextOffset = (int)(PlayButtonPositionPercentEndX * PlayButton.Width);
            SettingsTextStart = (int)(SettingsButtonPositionPercentStartX * SettingsButton.Width);
            SettingsTextOffset = (int)(SettingsButtonPositionPercentEndX * SettingsButton.Width);
            QuitTextStart = (int)(QuitButtonPositionPercentStartX * QuitButton.Width);
            QuitTextOffset = (int)(QuitButtonPositionPercentEndX * QuitButton.Width);

            PlayButtonText.Location = new Point((int)((PlayTextOffset - PlayTextStart) * playButtonTextLocationPercentX + PlayTextStart), (int)(PlayButtonPositionHeightPercent * PlayButton.Height));
            SettingsButtonText.Location = new Point((int)((SettingsTextOffset - SettingsTextStart) * settingsButtonTextLocationPercentX + SettingsTextStart), (int)(PlayButtonPositionHeightPercent * PlayButton.Height));
            QuitButtonText.Location = new Point((int)((QuitTextOffset - QuitTextStart) * quitButtonTextLocationPercentX + QuitTextStart), (int)(PlayButtonPositionHeightPercent * PlayButton.Height));

            PlayTextOffsetGoal = PlayTextStart;
            SettingsTextOffsetGoal = SettingsTextStart;
            QuitTextOffsetGoal = QuitTextStart;

            PlayButtonText.Width = (int)(PlayButtonTextScalePercent.X * PlayButton.Width);
            PlayButtonText.Height = (int)(PlayButtonTextScalePercent.Y * PlayButton.Height);
            SettingsButtonText.Width = (int)(SettingsButtonTextScalePercent.X * SettingsButton.Width);
            SettingsButtonText.Height = (int)(SettingsButtonTextScalePercent.Y * SettingsButton.Height);
            QuitButtonText.Width = (int)(QuitButtonTextScalePercent.X * QuitButton.Width);
            QuitButtonText.Height = (int)(QuitButtonTextScalePercent.Y * QuitButton.Height);
        }

        private void OnUpdate(Object sender, EventArgs e)
        {
            MoveButtonText(PlayButtonText, PlayTextOffset, PlayTextStart, PlayTextOffsetGoal);
            MoveButtonText(SettingsButtonText, SettingsTextOffset, SettingsTextStart, SettingsTextOffsetGoal);
            MoveButtonText(QuitButtonText, QuitTextOffset, QuitTextStart, QuitTextOffsetGoal);
        }

        #region Buttons

        private void MoveButtonText(PictureBox text, int offset, int start, int goal)
        {
            if (text.Location.X != goal)
            {
                int newLocation = text.Location.X;

                if (text.Location.X > goal)
                {
                    //The button should be going to the start location
                    newLocation -= (int)((offset - start) * (float)Program.updateTimer.Interval / 1000.0f / TextOffsetTime);
                }
                else
                {
                    //The button should be going to the offset location
                    newLocation += (int)((offset - start) * (float)Program.updateTimer.Interval / 1000.0f / TextOffsetTime);
                }

                text.Location = new Point(newLocation, text.Location.Y);

                //Make sure it didn't overshoot
                if (text.Location.X > offset)
                {
                    text.Location = new Point(offset, text.Location.Y);
                }
                else if (text.Location.X < start)
                {
                    text.Location = new Point(start, text.Location.Y);
                }
            }
        }

        /// <summary>
        /// Sees if the mouse is on the actual representation of a button and not just it's rect
        /// </summary>
        private bool IsMouseOnButton(Control button, Bitmap image)
        {
            Point clickPoint = button.PointToClient(MousePosition);

            Point scaledClickPoint;

            if (button.Width / button.Height > image.Width / image.Height)
            {
                //The PictureBox is stretched widthwise

                //Find the vertical scale amount
                float scalePercent = (float)button.Height / image.Height;

                //Find the horizontal space that should be ignored.
                int scaledImageWidth = (int)(image.Width * scalePercent);
                int pixelsToIgnore = button.Width - scaledImageWidth;

                //Check that the cursor is in the bounds of the image
                if (clickPoint.X < pixelsToIgnore / 2 || clickPoint.X > button.Width - pixelsToIgnore / 2)
                {
                    return false;
                }

                //Unscale the click point
                scaledClickPoint = new Point((int)((clickPoint.X - (pixelsToIgnore / 2)) / scalePercent), (int)(clickPoint.Y / scalePercent));
            }
            else
            {
                //The PictureBox is stretched heightwise

                //Find the horizontal scale amount
                float scalePercent = (float)button.Width / image.Width;

                //Find the vertical space that should be ignored.
                int scaledImageHeight = (int)(image.Height * scalePercent);
                int pixelsToIgnore = button.Height - scaledImageHeight;

                //Check that the cursor is in the bounds of the image
                if (clickPoint.Y < pixelsToIgnore / 2 || clickPoint.Y > button.Height - pixelsToIgnore / 2)
                {
                    return false;
                }

                //Unscale the click point
                scaledClickPoint = new Point((int)(clickPoint.X / scalePercent), (int)((clickPoint.Y - (pixelsToIgnore / 2)) / scalePercent));
            }

            if (scaledClickPoint.X < 0 || scaledClickPoint.X >= image.Width || scaledClickPoint.Y < 0 || scaledClickPoint.Y >= image.Height)
            {
                return false;
            }

            return (image.GetPixel(scaledClickPoint.X, scaledClickPoint.Y).A > 0);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (IsMouseOnButton(PlayButton, buttonImage))
            {
                Play();
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (IsMouseOnButton(SettingsButton, buttonImage))
            {
                Settings();
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            if (IsMouseOnButton(QuitButton, buttonImage))
            {
                Quit();
            }
        }
        private void PlayButtonText_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void SettingsButtonText_Click(object sender, EventArgs e)
        {
            Settings();
        }

        private void QuitButtonText_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Play()
        {
            Board board = new Board();
            this.Hide();
            board.Show();
        }

        private void Settings()
        {
            SettingsBox.Show();
        }

        private void Quit()
        {
            Program.Quit();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            SettingsBox.Hide();
        }

        #region Button Animations
        #region Play Button
        private void PlayButton_MouseEnter(object sender, EventArgs e)
        {
            //Play audio
            Program.audioManager.PlayTextSlide();

            Program.updateTimer.Tick += UpdatePlayButton;
        }

        private void PlayButton_MouseLeave(object sender, EventArgs e)
        {
            Program.updateTimer.Tick -= UpdatePlayButton;

            PlayTextOffsetGoal = PlayTextStart;
        }

        private void PlayButtonText_MouseEnter(object sender, EventArgs e)
        {
            PlayTextOffsetGoal = PlayTextOffset;
        }

        private void UpdatePlayButton(object sender, EventArgs e)
        {
            if (IsMouseOnButton(PlayButton, buttonImage))
            {
                PlayTextOffsetGoal = PlayTextOffset;
            }
            else
            {
                PlayTextOffsetGoal = PlayTextStart;
            }
        }
        #endregion Play Button
        #region Settings Button
        private void SettingsButton_MouseEnter(object sender, EventArgs e)
        {
            //Play audio
            Program.audioManager.PlayTextSlide();

            Program.updateTimer.Tick += UpdateSettingsButton;
        }

        private void SettingsButton_MouseLeave(object sender, EventArgs e)
        {
            Program.updateTimer.Tick -= UpdateSettingsButton;

            SettingsTextOffsetGoal = SettingsTextStart;
        }

        private void SettingsButtonText_MouseEnter(object sender, EventArgs e)
        {
            SettingsTextOffsetGoal = SettingsTextOffset;
        }

        private void UpdateSettingsButton(object sender, EventArgs e)
        {
            if (IsMouseOnButton(SettingsButton, buttonImage))
            {
                SettingsTextOffsetGoal = SettingsTextOffset;
            }
            else
            {
                SettingsTextOffsetGoal = SettingsTextStart;
            }
        }
        #endregion Settings Button
        #region Quit Button

        private void QuitButton_MouseEnter(object sender, EventArgs e)
        {
            //Play audio
            Program.audioManager.PlayTextSlide();

            Program.updateTimer.Tick += UpdateQuitButton;
        }

        private void QuitButton_MouseLeave(object sender, EventArgs e)
        {
            Program.updateTimer.Tick -= UpdateQuitButton;

            QuitTextOffsetGoal = QuitTextStart;
        }

        private void QuitButtonText_MouseEnter(object sender, EventArgs e)
        {
            QuitTextOffsetGoal = QuitTextOffset;
        }

        private void UpdateQuitButton(object sender, EventArgs e)
        {
            if (IsMouseOnButton(QuitButton, buttonImage))
            {
                QuitTextOffsetGoal = QuitTextOffset;
            }
            else
            {
                QuitTextOffsetGoal = QuitTextStart;
            }
        }
        #endregion Quit Button
        #endregion Button Animations

        #endregion Buttons

        private void WindowModeButton_Windowed_CheckedChanged(object sender, EventArgs e)
        {
            if(WindowModeButton_Windowed.Checked)
            {
                Program._windowMode = Program.WindowMode.Windowed;

                WindowState = FormWindowState.Normal;

                AdjustWindowSize();
            }
        }

        private void WindowModeButton_Fullscreen_CheckedChanged(object sender, EventArgs e)
        {
            if (WindowModeButton_Fullscreen.Checked)
            {
                Program._windowMode = Program.WindowMode.Fullscreen;

                AdjustWindowSize();
            }
        }

        private void WindowModeButton_Widescreen_CheckedChanged(object sender, EventArgs e)
        {
            if (WindowModeButton_Widescreen.Checked)
            {
                Program._windowMode = Program.WindowMode.Widescreen;

                AdjustWindowSize();
            }
        }
    }
}
