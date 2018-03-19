namespace ThreeFiveChangeCounterApplication
{
    partial class ChangeCounterApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeCounterApplication));
            this.tenCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.fiveCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.fiftyCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.twentyFiveCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tenCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiveCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiftyCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyFiveCentsPictureBox)).BeginInit();
            // 
            // tenCentsPictureBox
            // 
            this.tenCentsPictureBox.ErrorImage = global::_3._5ChangeCounterApplication.Properties.Resources._10_cents;
            this.tenCentsPictureBox.Image = global::_3._5ChangeCounterApplication.Properties.Resources._10_cents;
            this.tenCentsPictureBox.InitialImage = global::_3._5ChangeCounterApplication.Properties.Resources._10_cents;
            this.tenCentsPictureBox.Location = new System.Drawing.Point(165, 39);
            this.tenCentsPictureBox.Name = "tenCentsPictureBox";
            this.tenCentsPictureBox.Size = new System.Drawing.Size(84, 79);
            this.tenCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tenCentsPictureBox.TabIndex = 0;
            this.tenCentsPictureBox.TabStop = false;
            this.tenCentsPictureBox.Click += new System.EventHandler(this.tenCentsPictureBox_Click);
            // 
            // fiveCentsPictureBox
            // 
            this.fiveCentsPictureBox.Image = global::_3._5ChangeCounterApplication.Properties.Resources._5_cents;
            this.fiveCentsPictureBox.Location = new System.Drawing.Point(58, 38);
            this.fiveCentsPictureBox.Name = "fiveCentsPictureBox";
            this.fiveCentsPictureBox.Size = new System.Drawing.Size(84, 80);
            this.fiveCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fiveCentsPictureBox.TabIndex = 1;
            this.fiveCentsPictureBox.TabStop = false;
            this.fiveCentsPictureBox.Click += new System.EventHandler(this.fiveCentsPictureBox_Click);
            // 
            // fiftyCentsPictureBox
            // 
            this.fiftyCentsPictureBox.Image = global::_3._5ChangeCounterApplication.Properties.Resources._50_cents;
            this.fiftyCentsPictureBox.Location = new System.Drawing.Point(165, 124);
            this.fiftyCentsPictureBox.Name = "fiftyCentsPictureBox";
            this.fiftyCentsPictureBox.Size = new System.Drawing.Size(84, 80);
            this.fiftyCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fiftyCentsPictureBox.TabIndex = 2;
            this.fiftyCentsPictureBox.TabStop = false;
            this.fiftyCentsPictureBox.Click += new System.EventHandler(this.fiftyCentsPictureBox_Click);
            // 
            // twentyFiveCentsPictureBox
            // 
            this.twentyFiveCentsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("twentyFiveCentsPictureBox.Image")));
            this.twentyFiveCentsPictureBox.Location = new System.Drawing.Point(58, 124);
            this.twentyFiveCentsPictureBox.Name = "twentyFiveCentsPictureBox";
            this.twentyFiveCentsPictureBox.Size = new System.Drawing.Size(84, 80);
            this.twentyFiveCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.twentyFiveCentsPictureBox.TabIndex = 3;
            this.twentyFiveCentsPictureBox.TabStop = false;
            this.twentyFiveCentsPictureBox.Click += new System.EventHandler(this.twentyFiveCentsPictureBox_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(101, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(92, 13);
            this.instructionLabel.TabIndex = 4;
            this.instructionLabel.Text = "Click the Coins";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(135, 218);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(36, 13);
            this.outputDescriptionLabel.TabIndex = 5;
            this.outputDescriptionLabel.Text = "Total";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLabel.Location = new System.Drawing.Point(104, 241);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(89, 23);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(199, 241);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(23, 241);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear Total";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // ChangeCounterApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.twentyFiveCentsPictureBox);
            this.Controls.Add(this.fiftyCentsPictureBox);
            this.Controls.Add(this.fiveCentsPictureBox);
            this.Controls.Add(this.tenCentsPictureBox);
            this.Name = "ChangeCounterApplication";
            this.Text = "Change Counter";
            this.Load += new System.EventHandler(this.ChangeCounterApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tenCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiveCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiftyCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyFiveCentsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tenCentsPictureBox;
        private System.Windows.Forms.PictureBox fiveCentsPictureBox;
        private System.Windows.Forms.PictureBox fiftyCentsPictureBox;
        private System.Windows.Forms.PictureBox twentyFiveCentsPictureBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
    }
}

