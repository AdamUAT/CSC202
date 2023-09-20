using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moonbase
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

        //Windowed: Adjustable window size, will not deform.
        //Fullscreen: Makes the form take up the whole screen, will not deform.
        //Widescreen: Makes the form take up the whole screen, will deform.
        public enum WindowMode { Windowed, Fullscreen, Widescreen };
        /// <summary>
        /// The current Window mode of the application.
        /// </summary>
        public static WindowMode _windowMode { get; set; } = WindowMode.Fullscreen; //Set default windowMode to Fullscreen
        /// <summary>
        /// The ideal aspect ratio of the program. Width:Height
        /// </summary>
        public const float ASPECT_RATIO = 16.0f / 9.0f;
    }
}
