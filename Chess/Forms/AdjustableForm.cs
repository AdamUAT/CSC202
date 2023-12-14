using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class AdjustableForm : Form
    {
        public AdjustableForm()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(OnFormSizeChange);
        }

        
        /// <summary>
        /// Sets this form to the Program's prefered window state.
        /// </summary>
        protected void AdjustWindowSize()
        {
            if (Program._windowMode != Program.WindowMode.Windowed)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }

            //Resizes all the UI elements
            OnResize();
        }

        /// <summary>
        /// Detects when the physical size of the form changes
        /// </summary>
        private void OnFormSizeChange(object sender, EventArgs e)
        {
            OnResize();
        }

        /// <summary>
        /// Resizes the black background and adjusts the ContentPanel to the correct aspect ratio.
        /// </summary>
        protected virtual void OnResize()
        {
            //Set the background color
            //Streching images leads to gradients.
            Background.Size = ClientSize;
            Bitmap flag = new Bitmap(ClientSize.Width, ClientSize.Height);
            Graphics flagGraphics = Graphics.FromImage(flag);
            flagGraphics.FillRectangle(Brushes.Black, 0, 0, ClientSize.Width, ClientSize.Height);
            this.Background.Image = flag;

            //Adjust ContentPanel
            if (Program._windowMode == Program.WindowMode.Widescreen)
            {
                this.ContentPanel.Location = new Point(0, 0);
                this.ContentPanel.Size = this.ClientSize;
            }
            else
            {
                //Too wide
                if ((float)ClientSize.Width / (float)ClientSize.Height > Program.ASPECT_RATIO)
                {
                    int desiredWidth = (int)(this.ClientSize.Height * Program.ASPECT_RATIO);
                    //Get the left offset
                    int leftOffset = (this.ClientSize.Width - desiredWidth) / 2;
                    this.ContentPanel.Location = new Point(leftOffset, 0);
                    this.ContentPanel.Size = new Size(desiredWidth, ClientSize.Height);
                }
                else //Too narrow
                {
                    int desiredHeight = (int)(this.ClientSize.Width / Program.ASPECT_RATIO);
                    //Get the top offset
                    int topOffset = (this.ClientSize.Height - desiredHeight) / 2;
                    this.ContentPanel.Location = new Point(0, topOffset);
                    this.ContentPanel.Size = new Size(ClientSize.Width, desiredHeight);
                }
            }
        }
    }
}
