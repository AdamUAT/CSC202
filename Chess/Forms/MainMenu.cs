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

        public MainMenu()
        {
            InitializeComponent();

            //Calculate the image of the buttons as a bitmap.
            buttonImage = (Bitmap)PlayButton.Image;

        }

        protected override void OnResize()
        {
            base.OnResize();

            MainMenuBackground.Size = new Size(this.ContentPanel.Width, this.ContentPanel.Height);
        }

        /// <summary>
        /// Sees if the mouse is on the actual representation of a button and not just it's rect
        /// </summary>
        private bool IsMouseOnButton(int buttonWidth, int buttonHeight, Point mousePosition, Bitmap image)
        {
            Point scaledClickPoint;

            if (buttonWidth / buttonHeight > image.Width / image.Height)
            {
                //The PictureBox is stretched widthwise

                //Find the vertical scale amount
                float scalePercent = (float)buttonHeight / image.Height;

                //Find the horizontal space that should be ignored.
                int scaledImageWidth = (int)(image.Width * scalePercent);
                int pixelsToIgnore = buttonWidth - scaledImageWidth;

                //Check that the cursor is in the bounds of the image
                if (mousePosition.X < pixelsToIgnore / 2 || mousePosition.X > buttonWidth - pixelsToIgnore / 2)
                {
                    return false;
                }

                //Unscale the click point
                scaledClickPoint = new Point((int)((mousePosition.X - (pixelsToIgnore / 2)) / scalePercent), (int)(mousePosition.Y / scalePercent));
            }
            else
            {
                //The PictureBox is stretched heightwise

                //Find the horizontal scale amount
                float scalePercent = (float)buttonWidth / image.Width;

                //Find the vertical space that should be ignored.
                int scaledImageHeight = (int)(image.Height * scalePercent);
                int pixelsToIgnore = buttonHeight - scaledImageHeight;

                //Check that the cursor is in the bounds of the image
                if (mousePosition.Y < pixelsToIgnore / 2 || mousePosition.Y > buttonHeight - pixelsToIgnore / 2)
                {
                    return false;
                }

                //Unscale the click point
                scaledClickPoint = new Point((int)(mousePosition.X / scalePercent), (int)((mousePosition.Y - (pixelsToIgnore / 2)) / scalePercent));
            }

            return (image.GetPixel(scaledClickPoint.X, scaledClickPoint.Y).A > 0);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            MouseEventArgs args = e as MouseEventArgs;
            Point clickPoint = new Point(args.X, args.Y);

            if (IsMouseOnButton(PlayButton.Width, PlayButton.Height, clickPoint, buttonImage))
            {
                MessageBox.Show("Success!");
            }
        }
    }
}
