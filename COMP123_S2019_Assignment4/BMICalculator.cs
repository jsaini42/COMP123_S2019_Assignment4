using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment4
{
    
    public partial class BMICalculator : Form
    {
        // CLASS PROPERTIES
        public string outputString { get; set; }       
        public float outputValue { get; set; }
        public bool decimalExists { get; set; }



        /// <summary>
        /// This is the constructor for BMICalculator Form
        /// </summary>
        public BMICalculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for CalculateBMIButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            double bmi;
            double weight = Convert.ToDouble(WeightTextBox.Text);
            double height = Convert.ToDouble(HeightTextBox.Text);
            if (ImperialRadioButton.Checked == true)
            {
                bmi = (weight * 703) / (height * height);
            }
            else
            {
                bmi = (weight) / (height * height);
            }
            if (bmi < 18.5)
            {                
                BMIResultTextBox.Text = "Underweight";
            }
            else if (bmi > 18.5 && bmi < 24.9)
            {
                BMIResultTextBox.Text = "Normal";
            }
            else if (bmi > 25 && bmi < 29.9)
            {               
                BMIResultTextBox.Text = "Overweight";
            }
            else 
            {                
                BMIResultTextBox.Text = "Obese";
            }
            BMITextBox.Text = String.Format("{0:f}", bmi);
        }

        private void FormLabel_Click(object sender, EventArgs e)
        {

        }

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
 
        private void HeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BMIResultTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BMITextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.HeightTextBox.Text = "";
            this.WeightTextBox.Text = "";
            this.BMITextBox.Text = "";
            this.BMIResultTextBox.Text = "";          
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {
            this.Size = new Size(320, 480);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BMITableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FourButton_Click(object sender, EventArgs e)
        {

        }
    }
}
