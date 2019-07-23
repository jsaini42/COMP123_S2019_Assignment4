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
            double weight, height, bmi;
            weight = double.Parse(WeightTextBox.Text);
            height = double.Parse(HeightTextBox.Text);
            if (ImperialRadioButton.Checked == true )
            {
                bmi = (weight * 703) / (height * height);
                if (bmi < 18.5)
                {
                    ResultLabel.Text = String.Format("{0:f}",bmi + "\n Underweight");
                }
                else if (bmi > 18.5 && bmi < 24.9)
                {
                    ResultLabel.Text = String.Format("{0:f}",bmi + "\n Normal");
                }
                else if (bmi > 25 && bmi < 29.9)
                {
                    ResultLabel.Text = String.Format("{0:f}",bmi + "\n Overweight");
                }
                else if (bmi > 30)
                {
                    ResultLabel.Text = String.Format("{0:f}",bmi + "\n Obese");
                }
            }
           
            
            
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

        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {
            this.Size = new Size(320, 480);
        }
    }
}
