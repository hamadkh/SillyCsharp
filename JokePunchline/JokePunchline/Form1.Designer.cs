namespace JokePunchline
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
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnPunchline = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(95, 110);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(75, 23);
            this.btnSetup.TabIndex = 0;
            this.btnSetup.Text = "button1";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnPunchline
            // 
            this.btnPunchline.Location = new System.Drawing.Point(344, 110);
            this.btnPunchline.Name = "btnPunchline";
            this.btnPunchline.Size = new System.Drawing.Size(75, 23);
            this.btnPunchline.TabIndex = 1;
            this.btnPunchline.Text = "button2";
            this.btnPunchline.UseVisualStyleBackColor = true;
            this.btnPunchline.Click += new System.EventHandler(this.btnPunchline_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(92, 42);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(35, 13);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 182);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnPunchline);
            this.Controls.Add(this.btnSetup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Joke & Punchline ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Button btnPunchline;
        private System.Windows.Forms.Label lblText;
    }
}

