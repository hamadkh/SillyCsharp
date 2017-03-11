namespace P4_4_Color_Mixer
{
    partial class ColorMixer
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
            this.gbLeft = new System.Windows.Forms.GroupBox();
            this.radioYellowLeft = new System.Windows.Forms.RadioButton();
            this.radioBlueLeft = new System.Windows.Forms.RadioButton();
            this.radioRedLeft = new System.Windows.Forms.RadioButton();
            this.gpRight = new System.Windows.Forms.GroupBox();
            this.radioYellowRight = new System.Windows.Forms.RadioButton();
            this.radioBlueRight = new System.Windows.Forms.RadioButton();
            this.radioRedRight = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMix = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbLeft.SuspendLayout();
            this.gpRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLeft
            // 
            this.gbLeft.Controls.Add(this.radioYellowLeft);
            this.gbLeft.Controls.Add(this.radioBlueLeft);
            this.gbLeft.Controls.Add(this.radioRedLeft);
            this.gbLeft.Location = new System.Drawing.Point(42, 38);
            this.gbLeft.Margin = new System.Windows.Forms.Padding(4);
            this.gbLeft.Name = "gbLeft";
            this.gbLeft.Padding = new System.Windows.Forms.Padding(4);
            this.gbLeft.Size = new System.Drawing.Size(191, 126);
            this.gbLeft.TabIndex = 0;
            this.gbLeft.TabStop = false;
            this.gbLeft.Text = "Select the First Color";
            // 
            // radioYellowLeft
            // 
            this.radioYellowLeft.AutoSize = true;
            this.radioYellowLeft.Location = new System.Drawing.Point(35, 84);
            this.radioYellowLeft.Margin = new System.Windows.Forms.Padding(4);
            this.radioYellowLeft.Name = "radioYellowLeft";
            this.radioYellowLeft.Size = new System.Drawing.Size(66, 20);
            this.radioYellowLeft.TabIndex = 2;
            this.radioYellowLeft.TabStop = true;
            this.radioYellowLeft.Text = "Yellow";
            this.radioYellowLeft.UseVisualStyleBackColor = true;
            // 
            // radioBlueLeft
            // 
            this.radioBlueLeft.AutoSize = true;
            this.radioBlueLeft.Location = new System.Drawing.Point(35, 54);
            this.radioBlueLeft.Margin = new System.Windows.Forms.Padding(4);
            this.radioBlueLeft.Name = "radioBlueLeft";
            this.radioBlueLeft.Size = new System.Drawing.Size(53, 20);
            this.radioBlueLeft.TabIndex = 1;
            this.radioBlueLeft.TabStop = true;
            this.radioBlueLeft.Text = "Blue";
            this.radioBlueLeft.UseVisualStyleBackColor = true;
            // 
            // radioRedLeft
            // 
            this.radioRedLeft.AutoSize = true;
            this.radioRedLeft.Location = new System.Drawing.Point(35, 25);
            this.radioRedLeft.Margin = new System.Windows.Forms.Padding(4);
            this.radioRedLeft.Name = "radioRedLeft";
            this.radioRedLeft.Size = new System.Drawing.Size(52, 20);
            this.radioRedLeft.TabIndex = 0;
            this.radioRedLeft.TabStop = true;
            this.radioRedLeft.Text = "Red";
            this.radioRedLeft.UseVisualStyleBackColor = true;
            // 
            // gpRight
            // 
            this.gpRight.Controls.Add(this.radioYellowRight);
            this.gpRight.Controls.Add(this.radioBlueRight);
            this.gpRight.Controls.Add(this.radioRedRight);
            this.gpRight.Location = new System.Drawing.Point(260, 38);
            this.gpRight.Margin = new System.Windows.Forms.Padding(4);
            this.gpRight.Name = "gpRight";
            this.gpRight.Padding = new System.Windows.Forms.Padding(4);
            this.gpRight.Size = new System.Drawing.Size(191, 126);
            this.gpRight.TabIndex = 1;
            this.gpRight.TabStop = false;
            this.gpRight.Text = "Select the Second Color";
            // 
            // radioYellowRight
            // 
            this.radioYellowRight.AutoSize = true;
            this.radioYellowRight.Location = new System.Drawing.Point(35, 84);
            this.radioYellowRight.Margin = new System.Windows.Forms.Padding(4);
            this.radioYellowRight.Name = "radioYellowRight";
            this.radioYellowRight.Size = new System.Drawing.Size(66, 20);
            this.radioYellowRight.TabIndex = 2;
            this.radioYellowRight.TabStop = true;
            this.radioYellowRight.Text = "Yellow";
            this.radioYellowRight.UseVisualStyleBackColor = true;
            // 
            // radioBlueRight
            // 
            this.radioBlueRight.AutoSize = true;
            this.radioBlueRight.Location = new System.Drawing.Point(35, 54);
            this.radioBlueRight.Margin = new System.Windows.Forms.Padding(4);
            this.radioBlueRight.Name = "radioBlueRight";
            this.radioBlueRight.Size = new System.Drawing.Size(53, 20);
            this.radioBlueRight.TabIndex = 1;
            this.radioBlueRight.TabStop = true;
            this.radioBlueRight.Text = "Blue";
            this.radioBlueRight.UseVisualStyleBackColor = true;
            // 
            // radioRedRight
            // 
            this.radioRedRight.AutoSize = true;
            this.radioRedRight.Location = new System.Drawing.Point(35, 25);
            this.radioRedRight.Margin = new System.Windows.Forms.Padding(4);
            this.radioRedRight.Name = "radioRedRight";
            this.radioRedRight.Size = new System.Drawing.Size(52, 20);
            this.radioRedRight.TabIndex = 0;
            this.radioRedRight.TabStop = true;
            this.radioRedRight.Text = "Red";
            this.radioRedRight.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(479, 84);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnMix
            // 
            this.btnMix.Location = new System.Drawing.Point(479, 38);
            this.btnMix.Margin = new System.Windows.Forms.Padding(4);
            this.btnMix.Name = "btnMix";
            this.btnMix.Size = new System.Drawing.Size(100, 28);
            this.btnMix.TabIndex = 2;
            this.btnMix.Text = "&Mix";
            this.btnMix.UseVisualStyleBackColor = true;
            this.btnMix.Click += new System.EventHandler(this.btnMix_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(479, 136);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ColorMixer
            // 
            this.AcceptButton = this.btnMix;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(623, 207);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbLeft);
            this.Controls.Add(this.gpRight);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMix);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ColorMixer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Mixer";
            this.Load += new System.EventHandler(this.ColorMixer_Load);
            this.gbLeft.ResumeLayout(false);
            this.gbLeft.PerformLayout();
            this.gpRight.ResumeLayout(false);
            this.gpRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLeft;
        private System.Windows.Forms.RadioButton radioYellowLeft;
        private System.Windows.Forms.RadioButton radioBlueLeft;
        private System.Windows.Forms.RadioButton radioRedLeft;
        private System.Windows.Forms.GroupBox gpRight;
        private System.Windows.Forms.RadioButton radioYellowRight;
        private System.Windows.Forms.RadioButton radioBlueRight;
        private System.Windows.Forms.RadioButton radioRedRight;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMix;
        private System.Windows.Forms.Button btnExit;
    }
}

