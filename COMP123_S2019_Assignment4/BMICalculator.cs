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
 * Program description: BMI Calculator which allow the user to enter weight and height and thus calculate bmi and result.
 * Revision History: added click events . added class properties 
 *                  
 */

namespace COMP123_S2019_Assignment4
{    
    public partial class BMICalculator : Form
    {
        // Class Properties
        public string outputString { get; set; }       
        public float outputValue { get; set; }
        public bool decimalExists { get; set; }
        public TextBox ActiveLabel { get; set; }

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
                BMIResultTextBox.Text = "You are Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                BMIResultTextBox.Text = "You are Normal";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {               
                BMIResultTextBox.Text = "You are Overweight";
            }
            else 
            {                
                BMIResultTextBox.Text = "You Are Obese";
            }
            BMITextBox.Text = String.Format("{0:f}", bmi);
        }
        private void FormLabel_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This event handler for reset click button will clear the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            this.HeightTextBox.Text = "";
            this.WeightTextBox.Text = "";
            this.BMITextBox.Text = "";
            this.BMIResultTextBox.Text = "";          
        }

        /// <summary>
        /// The event handler for bmi calculator Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_Load(object sender, EventArgs e)
        {
            this.Size = new Size(320, 480);
            outputString = "0";
        }

        /// <summary>
        /// The event handler for HeightTextBox click event will locate the keyboard .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTextBox_Click(object sender, EventArgs e)
        {
            DigitKeyboardPanel.BringToFront();
            DigitKeyboardPanel.Location = new Point(37, HeightTextBox.Location.Y + 105);
        }

        /// <summary>
        /// The event handler for WeightTextBox click event will locate the keyboard .
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WeightTextBox_Click(object sender, EventArgs e)
        {
            DigitKeyboardPanel.BringToFront();
            DigitKeyboardPanel.Location = new Point(37, HeightTextBox.Location.Y + 150);
        }

        /// <summary>
        /// This shared event handler for NumericButton Click will be used to put inputs in the required fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericButton_Click(object sender, EventArgs e)
        {
            Button TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            int Buttonvalue = 0;           
            bool ButtonResult = int.TryParse(tag, out Buttonvalue);
            if (ButtonResult)
            {
                int maxSize = (decimalExists) ? 5 : 3;
                if (outputString == "0")
                {
                    outputString = tag;
                }
                else
                {
                    if (outputString.Length < 5)
                    {
                        outputString += tag;
                        DisplayLabel.Text = outputString;
                    }
                        
                }
            }
            else
            {
                switch (tag)
                {
                    case "back":
                        removeLastCharacterFromDisplayLabel();
                        break;
                    case "done":
                        finalizeOutput();
                        break;
                    case "clear":
                        clearDigitKeyboard();
                        break;
                    case "decimal":
                        addDecimalToDisplayLabel();
                        break;
                }
            }
        }

        /// <summary>
        /// This is the method to remove digit from DisplayLabel in DigitKeyboard
        /// </summary>
        private void removeLastCharacterFromDisplayLabel()
        {
            var LastChar = outputString.Substring(outputString.Length - 1);
            if (LastChar == ".")
            {
                decimalExists = false;
            }
            outputString = outputString.Remove(outputString.Length - 1);

            if (outputString.Length == 0)
            {
                outputString = "0";
            }
            DisplayLabel.Text = outputString;
        }

        /// <summary>
        /// This is  event handler for ActiveLabel Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActiveLabel_Click(object sender, EventArgs e)
        {
            DigitKeyboardPanel.BringToFront();
            DigitKeyboardPanel.Visible = true;
            DigitKeyboardPanel.Location = new Point(37, WeightLabel.Location.Y + 105);

            if (ActiveLabel != null)
            {
                ActiveLabel.BackColor = Color.White;
                ActiveLabel = null;
            }
            ActiveLabel = sender as TextBox;
            ActiveLabel.BackColor = Color.LightBlue;
            if (ActiveLabel.Text != "0")
            {
                DisplayLabel.Text = ActiveLabel.Text;
                outputString = ActiveLabel.Text;

            }           
        }

        /// <summary>
        /// This private method will clear digits in DigitKeyboard
        /// </summary>
        private void clearDigitKeyboard()
        {
            DisplayLabel.Text = "0";
            outputString = "0";
            outputValue = 0.0f;
            decimalExists = false;
        }

        /// <summary>
        /// This method will add Decimal to  DisplayLabel.
        /// </summary>
        private void addDecimalToDisplayLabel()
        {           
                if (!decimalExists)
                {
                    outputString += ".";
                    decimalExists = true;
                }           
        }

        /// <summary>
        /// This method will display the final digits of DisplayLabel in TextBox.
        /// </summary>
        private void finalizeOutput()
        {
            outputValue = float.Parse(outputString);

            outputValue = (float)Math.Round(outputValue, 1);
            if (outputValue < 0.1f)
            {
                outputValue = 0.1f;
            }
            ActiveLabel.Text = outputValue.ToString();
            clearDigitKeyboard();
            DigitKeyboardPanel.Visible = false;
        } 
        
        /// <summary>
        /// This is event handler for BMICalculator_FormClosing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is CheckChanged event handler for MatricRadioButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>       
        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MetricRadioButton.Checked == true)
            {
                HeightUnitLabel.Text = "m";
                WeightUnitLabel.Text = "kg";

            }
            else
            {
                HeightUnitLabel.Text = "inc";               
                WeightUnitLabel.Text = "po";
            }
        }

    }
}
