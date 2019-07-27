using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Author's name: Jaspinder Singh Saini
 * Author’s student number:301044893 
 * Date last Modified: July26,2019
 * Program description: this program will generate SplashForm as the first from when program will run .
 * Revision History: added form properties and  initialising it. 
 */
namespace COMP123_S2019_Assignment4
{
    static class Program
    {
        // Initiating properties of form
        public static SplashForm splashform { get; set; }
        public static BMICalculator bmiform { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            splashform = new SplashForm();
            bmiform = new BMICalculator();
            Application.Run(new SplashForm());
        }
    }
}
