namespace Chess
{
    internal static class Program
    {
        public static AudioManager audioManager;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            audioManager = new AudioManager();

            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenu());
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        public static void Quit()
        {
            Application.Exit();
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