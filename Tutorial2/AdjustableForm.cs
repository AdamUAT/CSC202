using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial2
{
    /// <summary>
    /// A derived class of form that allows all derived classes to adjust aspect ratio automatically.
    /// </summary>
    public partial class AdjustableForm : Form
    {
        public AdjustableForm()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(OnResize);
        }

        protected void AdjustWindowSize()
        {
            if (Program._windowMode != Program.WindowMode.Windowed)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                if(Program._windowMode == Program.WindowMode.Widescreen)
                {
                    this.ContentPanel.Location = new Point(0, 0);
                    this.ContentPanel.Size = this.Size;
                }
                else
                {
                    //Too wide
                    if ((float)Size.Width / (float)Size.Height > Program.ASPECT_RATIO)
                    {
                        int desiredWidth = (int)(this.Size.Height * Program.ASPECT_RATIO);
                        //Get the left offset
                        int leftOffset = (this.Size.Width - desiredWidth) / 2;
                        this.ContentPanel.Location = new Point(leftOffset, 0);
                        this.ContentPanel.Size = new Size(desiredWidth, Size.Height);
                    }
                    else //Too narrow
                    {
                        int desiredHeight = (int)(this.Size.Width / Program.ASPECT_RATIO);
                        //Get the top offset
                        int topOffset = (this.Size.Height - desiredHeight) / 2;
                        this.ContentPanel.Location = new Point(0, topOffset);
                        this.ContentPanel.Size = new Size(Size.Width, desiredHeight);
                    }
                }
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        protected virtual void OnResize(object sender, EventArgs e)
        {
            //Set the background correctly.
            this.Background.SendToBack();
            Background.Size = Size;
            Bitmap flag = new Bitmap(Size.Width, Size.Height);
            Graphics flagGraphics = Graphics.FromImage(flag);
            flagGraphics.FillRectangle(Brushes.Black, 0, 0, Size.Width, Size.Height);
            this.Background.Image = flag;

            if(Program._windowMode == Program.WindowMode.Widescreen) 
            {
                this.ContentPanel.Location = new Point(0, 0);
                this.ContentPanel.Size = this.Size;
            }
            else
            {
                //Too wide
                if((float)Size.Width / (float)Size.Height > Program.ASPECT_RATIO) 
                {
                    int desiredWidth = (int)(this.Size.Height * Program.ASPECT_RATIO);
                    //Get the left offset
                    int leftOffset = (this.Size.Width - desiredWidth) / 2;
                    this.ContentPanel.Location = new Point(leftOffset, 0);
                    this.ContentPanel.Size = new Size(desiredWidth, Size.Height);
                }
                else //Too narrow
                {
                    int desiredHeight = (int)(this.Size.Width / Program.ASPECT_RATIO);
                    //Get the top offset
                    int topOffset = (this.Size.Height - desiredHeight) / 2;
                    this.ContentPanel.Location = new Point(0, topOffset);
                    this.ContentPanel.Size = new Size(Size.Width, desiredHeight);
                }
            }
        }
    }
}
