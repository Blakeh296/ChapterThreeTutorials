namespace CalculateFuelEconomy
{
    partial class calculateFuelEconomy
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
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.gallonsTextBox = new System.Windows.Forms.TextBox();
            this.milesPromptLabel = new System.Windows.Forms.Label();
            this.gallonsPromptLabel = new System.Windows.Forms.Label();
            this.mpgLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // milesTextBox
            // 
            this.milesTextBox.Location = new System.Drawing.Point(180, 12);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(100, 20);
            this.milesTextBox.TabIndex = 0;
            // 
            // gallonsTextBox
            // 
            this.gallonsTextBox.Location = new System.Drawing.Point(180, 38);
            this.gallonsTextBox.Name = "gallonsTextBox";
            this.gallonsTextBox.Size = new System.Drawing.Size(100, 20);
            this.gallonsTextBox.TabIndex = 1;
            // 
            // milesPromptLabel
            // 
            this.milesPromptLabel.AutoSize = true;
            this.milesPromptLabel.Location = new System.Drawing.Point(13, 15);
            this.milesPromptLabel.Name = "milesPromptLabel";
            this.milesPromptLabel.Size = new System.Drawing.Size(161, 13);
            this.milesPromptLabel.TabIndex = 2;
            this.milesPromptLabel.Text = "Enter the number of miles driven:";
            // 
            // gallonsPromptLabel
            // 
            this.gallonsPromptLabel.AutoSize = true;
            this.gallonsPromptLabel.Location = new System.Drawing.Point(27, 41);
            this.gallonsPromptLabel.Name = "gallonsPromptLabel";
            this.gallonsPromptLabel.Size = new System.Drawing.Size(147, 13);
            this.gallonsPromptLabel.TabIndex = 3;
            this.gallonsPromptLabel.Text = "Enter the gallons of gas used:";
            // 
            // mpgLabel
            // 
            this.mpgLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mpgLabel.Location = new System.Drawing.Point(93, 136);
            this.mpgLabel.Name = "mpgLabel";
            this.mpgLabel.Size = new System.Drawing.Size(100, 21);
            this.mpgLabel.TabIndex = 4;
            this.mpgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(100, 110);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(84, 13);
            this.outputDescriptionLabel.TabIndex = 5;
            this.outputDescriptionLabel.Text = "Your car\'s MPG:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(30, 195);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(180, 195);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // calculateFuelEconomy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 230);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.gallonsPromptLabel);
            this.Controls.Add(this.milesPromptLabel);
            this.Controls.Add(this.gallonsTextBox);
            this.Controls.Add(this.milesTextBox);
            this.Name = "calculateFuelEconomy";
            this.Text = "Fuel Economy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.TextBox gallonsTextBox;
        private System.Windows.Forms.Label milesPromptLabel;
        private System.Windows.Forms.Label gallonsPromptLabel;
        private System.Windows.Forms.Label mpgLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button1;
    }
}

