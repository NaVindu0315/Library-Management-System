
namespace Library_Management_System
{
    partial class lendings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.txtmemid = new System.Windows.Forms.TextBox();
            this.txtbrwdate = new System.Windows.Forms.TextBox();
            this.txtrtndate = new System.Windows.Forms.TextBox();
            this.btnviewlendings = new System.Windows.Forms.Button();
            this.btnbookdetails = new System.Windows.Forms.Button();
            this.btnlend = new System.Windows.Forms.Button();
            this.btnrecieve = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnhistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Lendings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Member ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Borrowd Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Return Date";
            // 
            // txtbookid
            // 
            this.txtbookid.Location = new System.Drawing.Point(309, 101);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.Size = new System.Drawing.Size(100, 20);
            this.txtbookid.TabIndex = 5;
            // 
            // txtmemid
            // 
            this.txtmemid.Location = new System.Drawing.Point(309, 142);
            this.txtmemid.Name = "txtmemid";
            this.txtmemid.Size = new System.Drawing.Size(100, 20);
            this.txtmemid.TabIndex = 6;
            // 
            // txtbrwdate
            // 
            this.txtbrwdate.Location = new System.Drawing.Point(309, 185);
            this.txtbrwdate.Name = "txtbrwdate";
            this.txtbrwdate.Size = new System.Drawing.Size(100, 20);
            this.txtbrwdate.TabIndex = 7;
            // 
            // txtrtndate
            // 
            this.txtrtndate.Location = new System.Drawing.Point(309, 227);
            this.txtrtndate.Name = "txtrtndate";
            this.txtrtndate.Size = new System.Drawing.Size(100, 20);
            this.txtrtndate.TabIndex = 8;
            // 
            // btnviewlendings
            // 
            this.btnviewlendings.Location = new System.Drawing.Point(601, 145);
            this.btnviewlendings.Name = "btnviewlendings";
            this.btnviewlendings.Size = new System.Drawing.Size(102, 23);
            this.btnviewlendings.TabIndex = 9;
            this.btnviewlendings.Text = "View Lendings";
            this.btnviewlendings.UseVisualStyleBackColor = true;
            this.btnviewlendings.Click += new System.EventHandler(this.btnviewlendings_Click);
            // 
            // btnbookdetails
            // 
            this.btnbookdetails.Location = new System.Drawing.Point(601, 188);
            this.btnbookdetails.Name = "btnbookdetails";
            this.btnbookdetails.Size = new System.Drawing.Size(102, 23);
            this.btnbookdetails.TabIndex = 10;
            this.btnbookdetails.Text = "Get Book Details";
            this.btnbookdetails.UseVisualStyleBackColor = true;
            // 
            // btnlend
            // 
            this.btnlend.Location = new System.Drawing.Point(426, 301);
            this.btnlend.Name = "btnlend";
            this.btnlend.Size = new System.Drawing.Size(126, 23);
            this.btnlend.TabIndex = 11;
            this.btnlend.Text = "Lend the Book";
            this.btnlend.UseVisualStyleBackColor = true;
            this.btnlend.Click += new System.EventHandler(this.btnlend_Click);
            // 
            // btnrecieve
            // 
            this.btnrecieve.Location = new System.Drawing.Point(257, 301);
            this.btnrecieve.Name = "btnrecieve";
            this.btnrecieve.Size = new System.Drawing.Size(101, 23);
            this.btnrecieve.TabIndex = 12;
            this.btnrecieve.Text = "Recieve the Book";
            this.btnrecieve.UseVisualStyleBackColor = true;
            // 
            // btnhome
            // 
            this.btnhome.Location = new System.Drawing.Point(12, 23);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(75, 23);
            this.btnhome.TabIndex = 13;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnhistory
            // 
            this.btnhistory.Location = new System.Drawing.Point(601, 94);
            this.btnhistory.Name = "btnhistory";
            this.btnhistory.Size = new System.Drawing.Size(102, 23);
            this.btnhistory.TabIndex = 14;
            this.btnhistory.Text = "Previous Details";
            this.btnhistory.UseVisualStyleBackColor = true;
            // 
            // lendings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnhistory);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnrecieve);
            this.Controls.Add(this.btnlend);
            this.Controls.Add(this.btnbookdetails);
            this.Controls.Add(this.btnviewlendings);
            this.Controls.Add(this.txtrtndate);
            this.Controls.Add(this.txtbrwdate);
            this.Controls.Add(this.txtmemid);
            this.Controls.Add(this.txtbookid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "lendings";
            this.Text = "lendings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbookid;
        private System.Windows.Forms.TextBox txtmemid;
        private System.Windows.Forms.TextBox txtbrwdate;
        private System.Windows.Forms.TextBox txtrtndate;
        private System.Windows.Forms.Button btnviewlendings;
        private System.Windows.Forms.Button btnbookdetails;
        private System.Windows.Forms.Button btnlend;
        private System.Windows.Forms.Button btnrecieve;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnhistory;
    }
}