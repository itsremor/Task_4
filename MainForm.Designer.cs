namespace Task_4
{
    partial class MainForm
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
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.NumberStationsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AverageDistanceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SpeedTextBox = new System.Windows.Forms.TextBox();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.QLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // TypeComboBox
            //
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(276, 29);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(190, 24);
            this.TypeComboBox.TabIndex = 1;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titlle:";
            //
            // TitleTextBox
            //
            this.TitleTextBox.Location = new System.Drawing.Point(276, 99);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(190, 22);
            this.TitleTextBox.TabIndex = 5;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            //
            // NumberStationsTextBox
            //
            this.NumberStationsTextBox.Location = new System.Drawing.Point(276, 152);
            this.NumberStationsTextBox.Name = "NumberStationsTextBox";
            this.NumberStationsTextBox.Size = new System.Drawing.Size(190, 22);
            this.NumberStationsTextBox.TabIndex = 7;
            this.NumberStationsTextBox.TextChanged += new System.EventHandler(this.NumberStationsTextBox_TextChanged);
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "NumberStations:";
            //
            // AverageDistanceTextBox
            //
            this.AverageDistanceTextBox.Location = new System.Drawing.Point(276, 207);
            this.AverageDistanceTextBox.Name = "AverageDistanceTextBox";
            this.AverageDistanceTextBox.Size = new System.Drawing.Size(190, 22);
            this.AverageDistanceTextBox.TabIndex = 9;
            this.AverageDistanceTextBox.TextChanged += new System.EventHandler(this.AverageDistanceTextBox_TextChanged);
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "AverageDistance:";
            //
            // SpeedTextBox
            //
            this.SpeedTextBox.Location = new System.Drawing.Point(276, 266);
            this.SpeedTextBox.Name = "SpeedTextBox";
            this.SpeedTextBox.Size = new System.Drawing.Size(190, 22);
            this.SpeedTextBox.TabIndex = 11;
            this.SpeedTextBox.TextChanged += new System.EventHandler(this.SpeedTextBox_TextChanged);
            //
            // SpeedLabel
            //
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(217, 269);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(53, 17);
            this.SpeedLabel.TabIndex = 10;
            this.SpeedLabel.Text = "Speed:";
            //
            // CalculateButton
            //
            this.CalculateButton.Location = new System.Drawing.Point(170, 350);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(100, 29);
            this.CalculateButton.TabIndex = 12;
            this.CalculateButton.Text = "Calculate Q";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            //
            // QLabel
            //
            this.QLabel.AutoSize = true;
            this.QLabel.Location = new System.Drawing.Point(346, 356);
            this.QLabel.Name = "QLabel";
            this.QLabel.Size = new System.Drawing.Size(42, 17);
            this.QLabel.TabIndex = 13;
            this.QLabel.Text = "None";
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SpeedTextBox);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.AverageDistanceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumberStationsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeComboBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label QLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox NumberStationsTextBox;
        private System.Windows.Forms.TextBox AverageDistanceTextBox;
        private System.Windows.Forms.TextBox SpeedTextBox;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TypeComboBox;

        #endregion
    }
}
