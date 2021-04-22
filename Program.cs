using Password_Manager_Program.Backend.Data_Classes;
using System;
using System.Windows.Forms;

namespace Password_Manager_Program
{
    static class Program
    {
        // Globally accessible storage object
        public static Storage storage;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // Enable visual styles and run the main form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
