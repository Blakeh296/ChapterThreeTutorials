namespace PaintJobEstimator
{
    partial class F1PaintJobEstimator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.outPutGallons = new System.Windows.Forms.Label();
            this.outPutTotal = new System.Windows.Forms.Label();
            this.outPutLaborCharges = new System.Windows.Forms.Label();
            this.outPutCostofPaint = new System.Windows.Forms.Label();
            this.outPutLaborhours = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(278, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(69, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Sq feet of space to be painted And Price of paint per gallon";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 79);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(278, 46);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(69, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price per Gallon :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sq feet :";
            // 
            // outPutGallons
            // 
            this.outPutGallons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outPutGallons.Location = new System.Drawing.Point(278, 15);
            this.outPutGallons.Name = "outPutGallons";
            this.outPutGallons.Size = new System.Drawing.Size(69, 23);
            this.outPutGallons.TabIndex = 4;
            this.outPutGallons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outPutTotal
            // 
            this.outPutTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outPutTotal.Location = new System.Drawing.Point(278, 148);
            this.outPutTotal.Name = "outPutTotal";
            this.outPutTotal.Size = new System.Drawing.Size(69, 23);
            this.outPutTotal.TabIndex = 5;
            this.outPutTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outPutLaborCharges
            // 
            this.outPutLaborCharges.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outPutLaborCharges.Location = new System.Drawing.Point(278, 116);
            this.outPutLaborCharges.Name = "outPutLaborCharges";
            this.outPutLaborCharges.Size = new System.Drawing.Size(69, 23);
            this.outPutLaborCharges.TabIndex = 6;
            this.outPutLaborCharges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outPutCostofPaint
            // 
            this.outPutCostofPaint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outPutCostofPaint.Location = new System.Drawing.Point(278, 84);
            this.outPutCostofPaint.Name = "outPutCostofPaint";
            this.outPutCostofPaint.Size = new System.Drawing.Size(69, 23);
            this.outPutCostofPaint.TabIndex = 7;
            this.outPutCostofPaint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outPutLaborhours
            // 
            this.outPutLaborhours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outPutLaborhours.Location = new System.Drawing.Point(278, 52);
            this.outPutLaborhours.Name = "outPutLaborhours";
            this.outPutLaborhours.Size = new System.Drawing.Size(69, 23);
            this.outPutLaborhours.TabIndex = 8;
            this.outPutLaborhours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(290, 351);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(69, 23);
            this.btnMainMenu.TabIndex = 9;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 351);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.outPutGallons);
            this.groupBox2.Controls.Add(this.outPutTotal);
            this.groupBox2.Controls.Add(this.outPutLaborCharges);
            this.groupBox2.Controls.Add(this.outPutLaborhours);
            this.groupBox2.Controls.Add(this.outPutCostofPaint);
            this.groupBox2.Location = new System.Drawing.Point(12, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 184);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(66, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Total cost of the Job :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(67, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Labor Charges :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(67, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Cost of the Paint :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(67, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Labor hours Required :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Gallons of paint Required :";
            // 
            // F1PaintJobEstimator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 384);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "F1PaintJobEstimator";
            this.Text = "Paint Job Estimator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label outPutGallons;
        private System.Windows.Forms.Label outPutTotal;
        private System.Windows.Forms.Label outPutLaborCharges;
        private System.Windows.Forms.Label outPutCostofPaint;
        private System.Windows.Forms.Label outPutLaborhours;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

