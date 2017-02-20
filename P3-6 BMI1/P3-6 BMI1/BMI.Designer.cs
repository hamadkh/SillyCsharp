namespace P3_6_BMI
{
    partial class BMI
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblBMI = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtBMI = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(330, 179);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 34);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(196, 179);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(117, 34);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.txtReset_Click);
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(45, 131);
            this.lblBMI.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(75, 16);
            this.lblBMI.TabIndex = 15;
            this.lblBMI.Text = "Your BMI is";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(37, 179);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(5);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(141, 34);
            this.btnCalc.TabIndex = 14;
            this.btnCalc.Text = "Calculate BMI";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtBMI
            // 
            this.txtBMI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBMI.Location = new System.Drawing.Point(196, 127);
            this.txtBMI.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.Size = new System.Drawing.Size(243, 34);
            this.txtBMI.TabIndex = 13;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(196, 80);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(5);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(241, 22);
            this.txtHeight.TabIndex = 12;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(196, 27);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(5);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(241, 22);
            this.txtWeight.TabIndex = 11;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(45, 87);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(100, 16);
            this.lblHeight.TabIndex = 10;
            this.lblHeight.Text = "Height (inches):";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(45, 34);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(109, 16);
            this.lblWeight.TabIndex = 9;
            this.lblWeight.Text = "Weight (pounds):";
            // 
            // BMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 245);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtBMI);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWeight);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BMI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label txtBMI;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
    }
}

