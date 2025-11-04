using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weakest_Z_Cheats___LoginForm__
{
    internal static class Program
    {
        // Add a reference to KeyAuthApp here.
        // Example placeholder. Replace with your actual KeyAuthApp class or instance.
        public static dynamic KeyAuthApp { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize KeyAuthApp before using it
            // Replace this with your actual initialization logic
            KeyAuthApp = null; // TODO: Assign your actual KeyAuthApp instance here

            string status = null;
            try
            {
                status = KeyAuthApp?.response?.message;
            }
            catch
            {
                status = null;
            }

            if (!string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Status: " + status);
            }
            else
            {
                MessageBox.Sho