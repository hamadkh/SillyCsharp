namespace CardIdentifier
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
            this.picDimond8 = new System.Windows.Forms.PictureBox();
            this.picClub2 = new System.Windows.Forms.PictureBox();
            this.picSpadesKing = new System.Windows.Forms.PictureBox();
            this.picSpadesAce = new System.Windows.Forms.PictureBox();
            this.picJoker = new System.Windows.Forms.PictureBox();
            this.lblText = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDimond8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClub2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpadesKing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpadesAce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJoker)).BeginInit();
            this.SuspendLayout();
            // 
            // picDimond8
            // 
            this.picDimond8.Image = global::CardIdentifier.Properties.Resources.diamond_8;
            this.picDimond8.Location = new System.Drawing.Point(12, 61);
            this.picDimond8.Name = "picDimond8";
            this.picDimond8.Size = new System.Drawing.Size(127, 164);
            this.picDimond8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDimond8.TabIndex = 0;
            this.picDimond8.TabStop = false;
            this.picDimond8.Click += new System.EventHandler(this.picDimond8_Click);
            // 
            // picClub2
            // 
            this.picClub2.Image = global::CardIdentifier.Properties.Resources.club_2;
            this.picClub2.Location = new System.Drawing.Point(155, 61);
            this.picClub2.Name = "picClub2";
            this.picClub2.Size = new System.Drawing.Size(120, 164);
            this.picClub2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClub2.TabIndex = 1;
            this.picClub2.TabStop = false;
            this.picClub2.Click += new System.EventHandler(this.picClub2_Click);
            // 
            // picSpadesKing
            // 
            this.picSpadesKing.Image = global::CardIdentifier.Properties.Resources.King_Spade;
            this.picSpadesKing.Location = new System.Drawing.Point(295, 61);
            this.picSpadesKing.Name = "picSpadesKing";
            this.picSpadesKing.Size = new System.Drawing.Size(123, 164);
            this.picSpadesKing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpadesKing.TabIndex = 2;
            this.picSpadesKing.TabStop = false;
            this.picSpadesKing.Click += new System.EventHandler(this.picSpadesKing_Click);
            // 
            // picSpadesAce
            // 
            this.picSpadesAce.Image = global::CardIdentifier.Properties.Resources.Ace_of_spades;
            this.picSpadesAce.Location = new System.Drawing.Point(435, 61);
            this.picSpadesAce.Name = "picSpadesAce";
            this.picSpadesAce.Size = new System.Drawing.Size(136, 164);
            this.picSpadesAce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpadesAce.TabIndex = 3;
            this.picSpadesAce.TabStop = false;
            this.picSpadesAce.Click += new System.EventHandler(this.picSpadesAce_Click);
            // 
            // picJoker
            // 
            this.picJoker.Image = global::CardIdentifier.Properties.Resources.joker_card;
            this.picJoker.Location = new System.Drawing.Point(586, 61);
            this.picJoker.Name = "picJoker";
            this.picJoker.Size = new System.Drawing.Size(136, 164);
            this.picJoker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJoker.TabIndex = 4;
            this.picJoker.TabStop = false;
            this.picJoker.Click += new System.EventHandler(this.picJoker_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(245, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(60, 24);
            this.lblText.TabIndex = 5;
            this.lblText.Text = "label1";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(295, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 37);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "button1";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(332, 268);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 395);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.picJoker);
            this.Controls.Add(this.picSpadesAce);
            this.Controls.Add(this.picSpadesKing);
            this.Controls.Add(this.picClub2);
            this.Controls.Add(this.picDimond8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Card Identifier";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDimond8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClub2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpadesKing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpadesAce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJoker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDimond8;
        private System.Windows.Forms.PictureBox picClub2;
        private System.Windows.Forms.PictureBox picSpadesKing;
        private System.Windows.Forms.PictureBox picSpadesAce;
        private System.Windows.Forms.PictureBox picJoker;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblName;
    }
}

