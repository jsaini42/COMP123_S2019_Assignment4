using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Created by : Jaspinder Singh Saini
 * s_Id: 301044893
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
