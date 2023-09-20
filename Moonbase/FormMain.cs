using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moonbase
{
    public partial class FormMain : AdjustableForm
    {
        public FormMain()
        {
            InitializeComponent();
            AdjustWindowSize();
        }

        /// <summary>
        /// Adjusts all UI elements of this form
        /// </summary>
        protected override void OnResize()
        {
            base.OnResize();

            //Set the background image scale for this form
            this.MainBackground.Size = new Size(this.ContentPanel.Width, this.ContentPanel.Height);
        }

        #region AdjustableForm radio buttons
        private void Button_Windowed_CheckedChanged(object sender, EventArgs e)
        {
            //Make sure the button is not being unchecked
            if (Button_Windowed.Checked)
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
        #endregion AdjustableForm radio buttons
    }
}
