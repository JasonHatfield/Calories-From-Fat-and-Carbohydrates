namespace Calories
{
    partial class Form1
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dailyFatTextBox = new System.Windows.Forms.TextBox();
            this.dailyCarbsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outputFatCaloriesLabel = new System.Windows.Forms.Label();
            this.outputCarbCaloriesTextBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.calculateButton.Location = new System.Drawing.Point(72, 123);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exitButton.Location = new System.Drawing.Point(153, 123);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Daily Fat (grams):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Daily Carbohydrates (grams):";
            // 
            // dailyFatTextBox
            // 
            this.dailyFatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailyFatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyFatTextBox.Location = new System.Drawing.Point(163, 11);
            this.dailyFatTextBox.Name = "dailyFatTextBox";
            this.dailyFatTextBox.Size = new System.Drawing.Size(100, 22);
            this.dailyFatTextBox.TabIndex = 4;
            this.dailyFatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dailyCarbsTextBox
            // 
            this.dailyCarbsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dailyCarbsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyCarbsTextBox.Location = new System.Drawing.Point(163, 38);
            this.dailyCarbsTextBox.Name = "dailyCarbsTextBox";
            this.dailyCarbsTextBox.Size = new System.Drawing.Size(100, 22);
            this.dailyCarbsTextBox.TabIndex = 5;
            this.dailyCarbsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Calories from Fat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Calories from Carbs:";
            // 
            // outputFatCaloriesLabel
            // 
            this.outputFatCaloriesLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.outputFatCaloriesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputFatCaloriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputFatCaloriesLabel.Location = new System.Drawing.Point(163, 65);
            this.outputFatCaloriesLabel.Name = "outputFatCaloriesLabel";
            this.outputFatCaloriesLabel.Size = new System.Drawing.Size(100, 20);
            this.outputFatCaloriesLabel.TabIndex = 8;
            this.outputFatCaloriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputCarbCaloriesTextBox
            // 
            this.outputCarbCaloriesTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.outputCarbCaloriesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputCarbCaloriesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputCarbCaloriesTextBox.Location = new System.Drawing.Point(163, 92);
            this.outputCarbCaloriesTextBox.Name = "outputCarbCaloriesTextBox";
            this.outputCarbCaloriesTextBox.Size = new System.Drawing.Size(100, 20);
            this.outputCarbCaloriesTextBox.TabIndex = 9;
            this.outputCarbCaloriesTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(283, 160);
            this.Controls.Add(this.outputCarbCaloriesTextBox);
            this.Controls.Add(this.outputFatCaloriesLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dailyCarbsTextBox);
            this.Controls.Add(this.dailyFatTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Calorie Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dailyFatTextBox;
        private System.Windows.Forms.TextBox dailyCarbsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outputFatCaloriesLabel;
        private System.Windows.Forms.Label outputCarbCaloriesTextBox;
    }
}

