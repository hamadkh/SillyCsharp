namespace P4_6_Book_Club_Points
{
    partial class BookClub
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
            this.txtPoints = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBooks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPoints
            // 
            this.txtPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPoints.Location = new System.Drawing.Point(321, 91);
            this.txtPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(105, 25);
            this.txtPoints.TabIndex = 9;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(60, 145);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(100, 28);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "&Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Points earned:";
            // 
            // txtBooks
            // 
            this.txtBooks.Location = new System.Drawing.Point(321, 50);
            this.txtBooks.Margin = new System.Windows.Forms.Padding(4);
            this.txtBooks.Name = "txtBooks";
            this.txtBooks.Size = new System.Drawing.Size(105, 22);
            this.txtBooks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of book(s) purchased this month:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(190, 145);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(320, 145);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BookClub
            // 
            this.AcceptButton = this.btnCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(489, 215);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBooks);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookClub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Club Points";
            this.Load += new System.EventHandler(this.BookClub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPoints;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

