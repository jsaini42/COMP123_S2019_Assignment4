namespace COMP123_S2019_Assignment4
{
    partial class BMICalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BMITableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BMIResultTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.FormLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ResultLabel = new System.Windows.Forms.Label();
            this.DigitsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.BMITableLayoutPanel.SuspendLayout();
            this.DigitsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMITableLayoutPanel
            // 
            this.BMITableLayoutPanel.ColumnCount = 2;
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.87097F));
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.12903F));
            this.BMITableLayoutPanel.Controls.Add(this.BMIResultTextBox, 0, 4);
            this.BMITableLayoutPanel.Controls.Add(this.WeightTextBox, 1, 2);
            this.BMITableLayoutPanel.Controls.Add(this.ImperialRadioButton, 0, 0);
            this.BMITableLayoutPanel.Controls.Add(this.BMITextBox, 1, 4);
            this.BMITableLayoutPanel.Controls.Add(this.MetricRadioButton, 1, 0);
            this.BMITableLayoutPanel.Controls.Add(this.WeightLabel, 0, 2);
            this.BMITableLayoutPanel.Controls.Add(this.CalculateBMIButton, 0, 3);
            this.BMITableLayoutPanel.Controls.Add(this.HeightTextBox, 1, 1);
            this.BMITableLayoutPanel.Controls.Add(this.ResetButton, 1, 3);
            this.BMITableLayoutPanel.Controls.Add(this.HeightLabel, 0, 1);
            this.BMITableLayoutPanel.Location = new System.Drawing.Point(1, 43);
            this.BMITableLayoutPanel.Name = "BMITableLayoutPanel";
            this.BMITableLayoutPanel.RowCount = 5;
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BMITableLayoutPanel.Size = new System.Drawing.Size(310, 221);
            this.BMITableLayoutPanel.TabIndex = 0;
            // 
            // BMIResultTextBox
            // 
            this.BMIResultTextBox.BackColor = System.Drawing.Color.LightGray;
            this.BMIResultTextBox.Enabled = false;
            this.BMIResultTextBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BMIResultTextBox.Location = new System.Drawing.Point(3, 179);
            this.BMIResultTextBox.Multiline = true;
            this.BMIResultTextBox.Name = "BMIResultTextBox";
            this.BMIResultTextBox.Size = new System.Drawing.Size(192, 38);
            this.BMIResultTextBox.TabIndex = 10;
            this.BMIResultTextBox.TextChanged += new System.EventHandler(this.BMIResultTextBox_TextChanged);
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(201, 91);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(57, 38);
            this.WeightTextBox.TabIndex = 5;
            this.WeightTextBox.TextChanged += new System.EventHandler(this.WeightTextBox_TextChanged);
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(3, 3);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(128, 35);
            this.ImperialRadioButton.TabIndex = 0;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChanged);
            // 
            // BMITextBox
            // 
            this.BMITextBox.BackColor = System.Drawing.Color.LightGray;
            this.BMITextBox.Enabled = false;
            this.BMITextBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BMITextBox.Location = new System.Drawing.Point(201, 179);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(100, 38);
            this.BMITextBox.TabIndex = 8;
            this.BMITextBox.TextChanged += new System.EventHandler(this.BMITextBox_TextChanged);
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(201, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(106, 35);
            this.MetricRadioButton.TabIndex = 1;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // WeightLabel
            // 
            this.WeightLabel.Location = new System.Drawing.Point(3, 91);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(192, 38);
            this.WeightLabel.TabIndex = 3;
            this.WeightLabel.Text = "My Weight:";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.WeightLabel.Click += new System.EventHandler(this.WeightLabel_Click);
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 135);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(192, 38);
            this.CalculateBMIButton.TabIndex = 7;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(201, 47);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(57, 38);
            this.HeightTextBox.TabIndex = 4;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(201, 135);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(100, 38);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // HeightLabel
            // 
            this.HeightLabel.Location = new System.Drawing.Point(3, 47);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(192, 38);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "My Height:";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.HeightLabel.Click += new System.EventHandler(this.HeightLabel_Click);
            // 
            // FormLabel
            // 
            this.FormLabel.Location = new System.Drawing.Point(38, 9);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(221, 31);
            this.FormLabel.TabIndex = 0;
            this.FormLabel.Text = "Body Mass Index";
            this.FormLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FormLabel.Click += new System.EventHandler(this.FormLabel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(202, 287);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 31);
            this.ResultLabel.TabIndex = 1;
            // 
            // DigitsTableLayoutPanel
            // 
            this.DigitsTableLayoutPanel.ColumnCount = 4;
            this.DigitsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.DigitsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.DigitsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.DigitsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.DigitsTableLayoutPanel.Controls.Add(this.DecimalButton, 2, 3);
            this.DigitsTableLayoutPanel.Controls.Add(this.ZeroButton, 0, 3);
            this.DigitsTableLayoutPanel.Controls.Add(this.OneButton, 2, 2);
            this.DigitsTableLayoutPanel.Controls.Add(this.TwoButton, 1, 2);
            this.DigitsTableLayoutPanel.Controls.Add(this.ThreeButton, 0, 2);
            this.DigitsTableLayoutPanel.Controls.Add(this.SixButton, 2, 1);
            this.DigitsTableLayoutPanel.Controls.Add(this.FiveButton, 1, 1);
            this.DigitsTableLayoutPanel.Controls.Add(this.FourButton, 0, 1);
            this.DigitsTableLayoutPanel.Controls.Add(this.NineButton, 2, 0);
            this.DigitsTableLayoutPanel.Controls.Add(this.EightButton, 1, 0);
            this.DigitsTableLayoutPanel.Controls.Add(this.SevenButton, 0, 0);
            this.DigitsTableLayoutPanel.Controls.Add(this.BackButton, 3, 0);
            this.DigitsTableLayoutPanel.Controls.Add(this.DoneButton, 3, 2);
            this.DigitsTableLayoutPanel.Location = new System.Drawing.Point(44, 270);
            this.DigitsTableLayoutPanel.Name = "DigitsTableLayoutPanel";
            this.DigitsTableLayoutPanel.RowCount = 4;
            this.DigitsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.DigitsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.DigitsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.DigitsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.DigitsTableLayoutPanel.Size = new System.Drawing.Size(239, 175);
            this.DigitsTableLayoutPanel.TabIndex = 2;
            // 
            // SevenButton
            // 
            this.SevenButton.Location = new System.Drawing.Point(3, 3);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(53, 37);
            this.SevenButton.TabIndex = 0;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            // 
            // EightButton
            // 
            this.EightButton.Location = new System.Drawing.Point(62, 3);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(53, 37);
            this.EightButton.TabIndex = 1;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            // 
            // NineButton
            // 
            this.NineButton.Location = new System.Drawing.Point(121, 3);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(53, 37);
            this.NineButton.TabIndex = 2;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            // 
            // FourButton
            // 
            this.FourButton.Location = new System.Drawing.Point(3, 46);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(53, 37);
            this.FourButton.TabIndex = 3;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            // 
            // FiveButton
            // 
            this.FiveButton.Location = new System.Drawing.Point(62, 46);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(53, 37);
            this.FiveButton.TabIndex = 4;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            // 
            // SixButton
            // 
            this.SixButton.Location = new System.Drawing.Point(121, 46);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(53, 37);
            this.SixButton.TabIndex = 5;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            // 
            // ThreeButton
            // 
            this.ThreeButton.Location = new System.Drawing.Point(3, 89);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(53, 37);
            this.ThreeButton.TabIndex = 6;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            // 
            // TwoButton
            // 
            this.TwoButton.Location = new System.Drawing.Point(62, 89);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(53, 37);
            this.TwoButton.TabIndex = 7;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            // 
            // OneButton
            // 
            this.OneButton.Location = new System.Drawing.Point(121, 89);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(53, 37);
            this.OneButton.TabIndex = 8;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            // 
            // ZeroButton
            // 
            this.DigitsTableLayoutPanel.SetColumnSpan(this.ZeroButton, 2);
            this.ZeroButton.Location = new System.Drawing.Point(3, 132);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(112, 40);
            this.ZeroButton.TabIndex = 9;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackButton.Location = new System.Drawing.Point(180, 3);
            this.BackButton.Name = "BackButton";
            this.DigitsTableLayoutPanel.SetRowSpan(this.BackButton, 2);
            this.BackButton.Size = new System.Drawing.Size(56, 80);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "bksp";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // DecimalButton
            // 
            this.DecimalButton.Location = new System.Drawing.Point(121, 132);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(53, 40);
            this.DecimalButton.TabIndex = 11;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            // 
            // DoneButton
            // 
            this.DoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.Location = new System.Drawing.Point(180, 89);
            this.DoneButton.Name = "DoneButton";
            this.DigitsTableLayoutPanel.SetRowSpan(this.DoneButton, 2);
            this.DoneButton.Size = new System.Drawing.Size(56, 83);
            this.DoneButton.TabIndex = 12;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 701);
            this.Controls.Add(this.DigitsTableLayoutPanel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.FormLabel);
            this.Controls.Add(this.BMITableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.BMITableLayoutPanel.ResumeLayout(false);
            this.BMITableLayoutPanel.PerformLayout();
            this.DigitsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMITableLayoutPanel;
        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox BMIResultTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TableLayoutPanel DigitsTableLayoutPanel;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button DoneButton;
    }
}

