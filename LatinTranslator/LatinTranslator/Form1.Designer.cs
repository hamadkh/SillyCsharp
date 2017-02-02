namespace LatinTranslator
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
            this.lblText = new System.Windows.Forms.Label();
            this.lblTranslation = new System.Windows.Forms.Label();
            this.btnSinister = new System.Windows.Forms.Button();
            this.btnDexter = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(29, 51);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(35, 13);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "label1";
            // 
            // lblTranslation
            // 
            this.lblTranslation.AutoSize = true;
            this.lblTranslation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranslation.Location = new System.Drawing.Point(147, 51);
            this.lblTranslation.Name = "lblTranslation";
            this.lblTranslation.Size = new System.Drawing.Size(41, 13);
            this.lblTranslation.TabIndex = 1;
            this.lblTranslation.Text = "label1";
            // 
            // btnSinister
            // 
            this.btnSinister.Location = new System.Drawing.Point(32, 104);
            this.btnSinister.Name = "btnSinister";
            this.btnSinister.Size = new System.Drawing.Size(75, 30);
            this.btnSinister.TabIndex = 2;
            this.btnSinister.Text = "button1";
            this.btnSinister.UseVisualStyleBackColor = true;
            this.btnSinister.Click += new System.EventHandler(this.btnSinister_Click);
            // 
            // btnDexter
            // 
            this.btnDexter.Location = new System.Drawing.Point(150, 104);
            this.btnDexter.Name = "btnDexter";
            this.btnDexter.Size = new System.Drawing.Size(75, 30);
            this.btnDexter.TabIndex = 3;
            this.btnDexter.Text = "button2";
            this.btnDexter.UseVisualStyleBackColor = true;
            this.btnDexter.Click += new System.EventHandler(this.btnDexter_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(279, 104);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(75, 30);
            this.btnMedium.TabIndex = 4;
            this.btnMedium.Text = "button3";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 172);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnDexter);
            this.Controls.Add(this.btnSinister);
            this.Controls.Add(this.lblTranslation);
            this.Controls.Add(this.lblText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Latin Translator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblTranslation;
        private System.Windows.Forms.Button btnSinister;
        private System.Windows.Forms.Button btnDexter;
        private System.Windows.Forms.Button btnMedium;
    }
}

