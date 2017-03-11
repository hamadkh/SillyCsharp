namespace P4_8_BMI_Enhancement
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(509, 159);
            this.button3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 42);
            this.button3.TabIndex = 4;
            this.button3.Text = "E&xit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 159);
            this.button2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "&Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 159);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Calculate BMI";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(334, 85);
            this.label3.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(179, 101);
            this.textBox2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Height (inches):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Weight (pounds):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 240);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

