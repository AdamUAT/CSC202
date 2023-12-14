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
        int PlayTextOffset = 60;
        int SettingsTextOffset = 60;
        int QuitTextOffset = 60;
        int PlayTextStart = 21;
        int SettingsTextStart = 21;
        int QuitTextStart = 21;
        float TextOffsetTime = 0.1f;
        //Temp variables
        int PlayTextOffsetGoal = 0;
        int SettingsTextOffsetGoal = 0;
        int QuitTextOffsetGoal = 0;



        public MainMenu()
        {
            InitializeComponent();

            //Calculate the image of the buttons as a bitmap.
            buttonImage = (Bitmap)PlayButton.Image;

            Program.updateTimer.Tick += new EventHandler(OnUpdate);

            PlayTextOffsetGoal = PlayTextStart;
            SettingsTextOffsetGoal = SettingsTextStart;
            QuitTextOffsetGoal = QuitTextStart;
        }

        protected override void OnResize()
        {
            base.OnResize();

            MainMenuBackground.Size = new Size(this.ContentPanel.Width, this.ContentPanel.Height);
        }

        private void OnUpdate(Object sender, EventArgs e)
        {
            MoveButtonText(PlayButtonText, PlayTextOffset, PlayTextStart, PlayTextOffsetGoal);
            MoveButtonText(SettingsButtonText, SettingsTextOffset, SettingsTextStart, SettingsTextOffsetGoal);
            MoveButtonText(QuitButtonText, QuitTextOffset, QuitTextStart, QuitTextOffsetGoal);
        }

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

            if (scaledClickPoint.X < 0 || scaledClickPoint.X > image.Width || scaledClickPoint.Y < 0 || scaledClickPoint.Y > image.Height)
            {
                return false;
            }

            return (image.GetPixel(scaledClickPoint.X, scaledClickPoint.Y).A > 0);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (IsMouseOnButton(PlayButton, buttonImage))
            {
                
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (IsMouseOnButton(SettingsButton, buttonImage))
            {

            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            if (IsMouseOnButton(QuitButton, buttonImage))
            {

            }
        }

        #region Button Animations
        #region Play Button
        private void PlayButton_MouseEnter(object sender, EventArgs e)
        {
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

    }
}
