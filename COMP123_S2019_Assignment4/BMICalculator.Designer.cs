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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BMIResultTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.FormLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.87097F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.12903F));
            this.tableLayoutPanel1.Controls.Add(this.BMIResultTextBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.WeightTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ImperialRadioButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BMITextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.MetricRadioButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.WeightLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.HeightLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CalculateBMIButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.HeightTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ResetButton, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(310, 221);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BMIResultTextBox
            // 
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
            this.WeightTextBox.Size = new System.Drawing.Size(100, 38);
            this.WeightTextBox.TabIndex = 5;
            this.WeightTextBox.Text = "p/kg";
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
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(3, 88);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(141, 31);
            this.WeightLabel.TabIndex = 3;
            this.WeightLabel.Text = "My Weight";
            this.WeightLabel.Click += new System.EventHandler(this.WeightLabel_Click);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(3, 44);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(136, 31);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "My Height";
            this.HeightLabel.Click += new System.EventHandler(this.HeightLabel_Click);
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
            this.HeightTextBox.Size = new System.Drawing.Size(100, 38);
            this.HeightTextBox.TabIndex = 4;
            this.HeightTextBox.Text = "inc/m";
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // BMITextBox
            // 
            this.BMITextBox.Location = new System.Drawing.Point(201, 179);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(100, 38);
            this.BMITextBox.TabIndex = 8;
            this.BMITextBox.TextChanged += new System.EventHandler(this.BMITextBox_TextChanged);
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
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.Location = new System.Drawing.Point(6, 9);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(221, 31);
            this.FormLabel.TabIndex = 0;
            this.FormLabel.Text = "Body Mass Index";
            this.FormLabel.Click += new System.EventHandler(this.FormLabel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result";
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FormLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.Label label1;
    }
}

