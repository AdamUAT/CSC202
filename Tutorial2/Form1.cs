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
    public partial class Form1 : AdjustableForm
    {
        public Form1()
        {
            InitializeComponent();
            AdjustWindowSize();
        }

        protected override void OnResize(object sender, EventArgs e)
        {
            base.OnResize(sender, e);

            this.MainBackground.Size = new Size(this.ContentPanel.Width, this.ContentPanel.Height);
        }

        private void Button_Windowed_CheckedChanged(object sender, EventArgs e)
        {
            //Make sure the button is not being unchecked
            if(Button_Windowed.Checked)
            {
                //Tell the program all future forms should be windowed
                Program._windowMode = Program.WindowMode.Windowed;

                //Update the window
                AdjustWindowSize();
            }
        }

        private void Button_Fullscreen_CheckedChanged(object sender, EventArgs e)
        {
            //Make sure the button is not being unchecked
            if (Button_Fullscreen.Checked)
            {
                //Tell the program all future forms should be fullscreen
                Program._windowMode = Program.WindowMode.Fullscreen;

                //Update the window
                AdjustWindowSize();
            }
        }

        private void Button_Widescreen_CheckedChanged(object sender, EventArgs e)
        {
            //Make sure the button is not being unchecked
            if (Button_Widescreen.Checked)
            {
                //Tell the program all future forms should be widescreen
                Program._windowMode = Program.WindowMode.Widescreen;

                //Update the window
                AdjustWindowSize();
            }
        }
    }
}
