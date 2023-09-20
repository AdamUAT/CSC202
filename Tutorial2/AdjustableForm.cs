using System;
using System.Collections.Generic;
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
            AdjustWindowSize();
        }

        protected void AdjustWindowSize()
        {
            if(Program._windowMode != Program.WindowMode.Windowed)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }
    }
}
