﻿namespace COMP123_S2019_Assignment4
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
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.FormLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ResultLabel = new System.Windows.Forms.Label();
            this.DigitKeyboardPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.BMIResultTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.BMITableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WeightUnitLabel = new System.Windows.Forms.Label();
            this.HeightUnitLabel = new System.Windows.Forms.Label();
            this.DigitKeyboardPanel.SuspendLayout();
            this.BMITableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.BMITableLayoutPanel.SetColumnSpan(this.MetricRadioButton, 2);
            this.MetricRadioButton.Location = new System.Drawing.Point(200, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(106, 35);
            this.MetricRadioButton.TabIndex = 1;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.BackColor = System.Drawing.Color.Transparent;
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 153);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(191, 38);
            this.CalculateBMIButton.TabIndex = 7;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(200, 53);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(64, 38);
            this.HeightTextBox.TabIndex = 4;
            this.HeightTextBox.Click += new System.EventHandler(this.ActiveLabel_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Transparent;
            this.BMITableLayoutPanel.SetColumnSpan(this.ResetButton, 2);
            this.ResetButton.Location = new System.Drawing.Point(200, 153);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(100, 38);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // HeightLabel
            // 
            this.HeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeightLabel.Location = new System.Drawing.Point(3, 50);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(191, 38);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "My Height:";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormLabel
            // 
            this.FormLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.FormLabel.Location = new System.Drawing.Point(31, 22);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(221, 39);
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
            // DigitKeyboardPanel
            // 
            this.DigitKeyboardPanel.ColumnCount = 4;
            this.DigitKeyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.DigitKeyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.DigitKeyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.DigitKeyboardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.DigitKeyboardPanel.Controls.Add(this.DecimalButton, 2, 4);
            this.DigitKeyboardPanel.Controls.Add(this.ZeroButton, 0, 4);
            this.DigitKeyboardPanel.Controls.Add(this.OneButton, 2, 3);
            this.DigitKeyboardPanel.Controls.Add(this.TwoButton, 1, 3);
            this.DigitKeyboardPanel.Controls.Add(this.ThreeButton, 0, 3);
            this.DigitKeyboardPanel.Controls.Add(this.SixButton, 2, 2);
            this.DigitKeyboardPanel.Controls.Add(this.FiveButton, 1, 2);
            this.DigitKeyboardPanel.Controls.Add(this.FourButton, 0, 2);
            this.DigitKeyboardPanel.Controls.Add(this.NineButton, 2, 1);
            this.DigitKeyboardPanel.Controls.Add(this.EightButton, 1, 1);
            this.DigitKeyboardPanel.Controls.Add(this.SevenButton, 0, 1);
            this.DigitKeyboardPanel.Controls.Add(this.BackButton, 3, 1);
            this.DigitKeyboardPanel.Controls.Add(this.DoneButton, 3, 3);
            this.DigitKeyboardPanel.Controls.Add(this.DisplayLabel, 0, 0);
            this.DigitKeyboardPanel.Location = new System.Drawing.Point(37, 476);
            this.DigitKeyboardPanel.Name = "DigitKeyboardPanel";
            this.DigitKeyboardPanel.RowCount = 5;
            this.DigitKeyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DigitKeyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DigitKeyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DigitKeyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DigitKeyboardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DigitKeyboardPanel.Size = new System.Drawing.Size(235, 213);
            this.DigitKeyboardPanel.TabIndex = 2;
            // 
            // DecimalButton
            // 
            this.DecimalButton.BackColor = System.Drawing.Color.SteelBlue;
            this.DecimalButton.ForeColor = System.Drawing.Color.White;
            this.DecimalButton.Location = new System.Drawing.Point(119, 171);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(52, 39);
            this.DecimalButton.TabIndex = 11;
            this.DecimalButton.Tag = "decimal";
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = false;
            this.DecimalButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.SteelBlue;
            this.DigitKeyboardPanel.SetColumnSpan(this.ZeroButton, 2);
            this.ZeroButton.ForeColor = System.Drawing.Color.White;
            this.ZeroButton.Location = new System.Drawing.Point(3, 171);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(110, 39);
            this.ZeroButton.TabIndex = 9;
            this.ZeroButton.Tag = "0";
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.SteelBlue;
            this.OneButton.ForeColor = System.Drawing.Color.White;
            this.OneButton.Location = new System.Drawing.Point(119, 129);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(52, 36);
            this.OneButton.TabIndex = 8;
            this.OneButton.Tag = "1";
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.SteelBlue;
            this.TwoButton.ForeColor = System.Drawing.Color.White;
            this.TwoButton.Location = new System.Drawing.Point(61, 129);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(52, 36);
            this.TwoButton.TabIndex = 7;
            this.TwoButton.Tag = "2";
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ThreeButton.ForeColor = System.Drawing.Color.White;
            this.ThreeButton.Location = new System.Drawing.Point(3, 129);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(52, 36);
            this.ThreeButton.TabIndex = 6;
            this.ThreeButton.Tag = "3";
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SixButton.ForeColor = System.Drawing.Color.White;
            this.SixButton.Location = new System.Drawing.Point(119, 87);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(52, 36);
            this.SixButton.TabIndex = 5;
            this.SixButton.Tag = "6";
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.SteelBlue;
            this.FiveButton.ForeColor = System.Drawing.Color.White;
            this.FiveButton.Location = new System.Drawing.Point(61, 87);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(52, 36);
            this.FiveButton.TabIndex = 4;
            this.FiveButton.Tag = "5";
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.SteelBlue;
            this.FourButton.ForeColor = System.Drawing.Color.White;
            this.FourButton.Location = new System.Drawing.Point(3, 87);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(52, 36);
            this.FourButton.TabIndex = 3;
            this.FourButton.Tag = "4";
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.Color.SteelBlue;
            this.NineButton.ForeColor = System.Drawing.Color.White;
            this.NineButton.Location = new System.Drawing.Point(119, 45);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(52, 36);
            this.NineButton.TabIndex = 2;
            this.NineButton.Tag = "9";
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EightButton.ForeColor = System.Drawing.Color.White;
            this.EightButton.Location = new System.Drawing.Point(61, 45);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(52, 36);
            this.EightButton.TabIndex = 1;
            this.EightButton.Tag = "8";
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SevenButton.ForeColor = System.Drawing.Color.White;
            this.SevenButton.Location = new System.Drawing.Point(3, 45);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(52, 36);
            this.SevenButton.TabIndex = 0;
            this.SevenButton.Tag = "7";
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.DarkOrange;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackButton.Location = new System.Drawing.Point(177, 45);
            this.BackButton.Name = "BackButton";
            this.DigitKeyboardPanel.SetRowSpan(this.BackButton, 2);
            this.BackButton.Size = new System.Drawing.Size(55, 78);
            this.BackButton.TabIndex = 10;
            this.BackButton.Tag = "back";
            this.BackButton.Text = "bksp";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.ForestGreen;
            this.DoneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.ForeColor = System.Drawing.Color.White;
            this.DoneButton.Location = new System.Drawing.Point(177, 129);
            this.DoneButton.Name = "DoneButton";
            this.DigitKeyboardPanel.SetRowSpan(this.DoneButton, 2);
            this.DoneButton.Size = new System.Drawing.Size(55, 81);
            this.DoneButton.TabIndex = 12;
            this.DoneButton.Tag = "done";
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.NumericButton_Click);
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.BackColor = System.Drawing.Color.White;
            this.DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DigitKeyboardPanel.SetColumnSpan(this.DisplayLabel, 4);
            this.DisplayLabel.Location = new System.Drawing.Point(3, 0);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(229, 42);
            this.DisplayLabel.TabIndex = 13;
            this.DisplayLabel.Tag = "display";
            this.DisplayLabel.Text = "0";
            this.DisplayLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // BMITextBox
            // 
            this.BMITextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BMITextBox.Enabled = false;
            this.BMITextBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BMITextBox.Location = new System.Drawing.Point(7, 287);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(293, 38);
            this.BMITextBox.TabIndex = 8;
            // 
            // BMIResultTextBox
            // 
            this.BMIResultTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BMIResultTextBox.Enabled = false;
            this.BMIResultTextBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BMIResultTextBox.Location = new System.Drawing.Point(8, 344);
            this.BMIResultTextBox.Multiline = true;
            this.BMIResultTextBox.Name = "BMIResultTextBox";
            this.BMIResultTextBox.Size = new System.Drawing.Size(292, 40);
            this.BMIResultTextBox.TabIndex = 10;
            // 
            // WeightLabel
            // 
            this.WeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.WeightLabel.Location = new System.Drawing.Point(3, 100);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(191, 38);
            this.WeightLabel.TabIndex = 3;
            this.WeightLabel.Text = "My Weight:";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(200, 103);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(64, 38);
            this.WeightTextBox.TabIndex = 5;
            this.WeightTextBox.Click += new System.EventHandler(this.ActiveLabel_Click);
            // 
            // BMITableLayoutPanel
            // 
            this.BMITableLayoutPanel.ColumnCount = 3;
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.7037F));
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.2963F));
            this.BMITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.BMITableLayoutPanel.Controls.Add(this.WeightTextBox, 1, 2);
            this.BMITableLayoutPanel.Controls.Add(this.ImperialRadioButton, 0, 0);
            this.BMITableLayoutPanel.Controls.Add(this.MetricRadioButton, 1, 0);
            this.BMITableLayoutPanel.Controls.Add(this.WeightLabel, 0, 2);
            this.BMITableLayoutPanel.Controls.Add(this.HeightTextBox, 1, 1);
            this.BMITableLayoutPanel.Controls.Add(this.ResetButton, 1, 3);
            this.BMITableLayoutPanel.Controls.Add(this.HeightLabel, 0, 1);
            this.BMITableLayoutPanel.Controls.Add(this.CalculateBMIButton, 0, 3);
            this.BMITableLayoutPanel.Controls.Add(this.WeightUnitLabel, 2, 2);
            this.BMITableLayoutPanel.Controls.Add(this.HeightUnitLabel, 2, 1);
            this.BMITableLayoutPanel.Location = new System.Drawing.Point(-1, 64);
            this.BMITableLayoutPanel.Name = "BMITableLayoutPanel";
            this.BMITableLayoutPanel.RowCount = 4;
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMITableLayoutPanel.Size = new System.Drawing.Size(313, 200);
            this.BMITableLayoutPanel.TabIndex = 0;
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.AutoEllipsis = true;
            this.WeightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightUnitLabel.Location = new System.Drawing.Point(270, 100);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(36, 38);
            this.WeightUnitLabel.TabIndex = 12;
            this.WeightUnitLabel.Text = "po";
            this.WeightUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.AutoEllipsis = true;
            this.HeightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightUnitLabel.Location = new System.Drawing.Point(270, 50);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(36, 41);
            this.HeightUnitLabel.TabIndex = 11;
            this.HeightUnitLabel.Text = "inc";
            this.HeightUnitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 701);
            this.Controls.Add(this.DigitKeyboardPanel);
            this.Controls.Add(this.BMITextBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.FormLabel);
            this.Controls.Add(this.BMITableLayoutPanel);
            this.Controls.Add(this.BMIResultTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculator_FormClosing);
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.DigitKeyboardPanel.ResumeLayout(false);
            this.BMITableLayoutPanel.ResumeLayout(false);
            this.BMITableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TableLayoutPanel DigitKeyboardPanel;
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
        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.TextBox BMIResultTextBox;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TableLayoutPanel BMITableLayoutPanel;
        private System.Windows.Forms.Label HeightUnitLabel;
        private System.Windows.Forms.Label WeightUnitLabel;
    }
}

