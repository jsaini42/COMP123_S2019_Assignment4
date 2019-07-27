using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Author's name: Jaspinder Singh Saini
 * Author’s student number:301044893 
 * Date last Modified: July26,2019
 * Program description: This program will Load SplasForm and after 3 second will open BMICalculator Form.
 * Revision History: added tick event handler.
 */

namespace COMP123_S2019_Assignment4
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for splashForm Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
        /// <summary>
        /// This is  tick event handler for SplashTimer tick event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            this.Hide();
            Program.bmiform.Show();
        }

        
    }
}
