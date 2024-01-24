
namespace Library_Management_System
{
    partial class Books
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtbookid = new System.Windows.Forms.TextBox();
            this.txtauthor = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.btnviewbooks = new System.Windows.Forms.Button();
            this.btndeletebooks = new System.Windows.Forms.Button();
            this.btnbookadd = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date";
            // 
            // txtbookid
            // 
            this.txtbookid.Location = new System.Drawing.Point(319, 94);
            this.txtbookid.Name = "txtbookid";
            this.txtbookid.Size = new System.Drawing.Size(100, 20);
            this.txtbookid.TabIndex = 6;
            // 
            // txtauthor
            // 
            this.txtauthor.Location = new System.Drawing.Point(319, 134);
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(100, 20);
            this.txtauthor.TabIndex = 7;
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(319, 174);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(100, 20);
            this.txttitle.TabIndex = 8;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(319, 215);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 20);
            this.txtprice.TabIndex = 9;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(319, 255);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(100, 20);
            this.txtdate.TabIndex = 10;
            // 
            // btnviewbooks
            // 
            this.btnviewbooks.Location = new System.Drawing.Point(592, 120);
            this.btnviewbooks.Name = "btnviewbooks";
            this.btnviewbooks.Size = new System.Drawing.Size(75, 23);
            this.btnviewbooks.TabIndex = 11;
            this.btnviewbooks.Text = "View";
            this.btnviewbooks.UseVisualStyleBackColor = true;
            // 
            // btndeletebooks
            // 
            this.btndeletebooks.Location = new System.Drawing.Point(592, 205);
            this.btndeletebooks.Name = "btndeletebooks";
            this.btndeletebooks.Size = new System.Drawing.Size(75, 23);
            this.btndeletebooks.TabIndex = 12;
            this.btndeletebooks.Text = "Delete";
            this.btndeletebooks.UseVisualStyleBackColor = true;
            this.btndeletebooks.Click += new System.EventHandler(this.btndeletebooks_Click);
            // 
            // btnbookadd
            // 
            this.btnbookadd.Location = new System.Drawing.Point(592, 255);
            this.btnbookadd.Name = "btnbookadd";
            this.btnbookadd.Size = new System.Drawing.Size(75, 23);
            this.btnbookadd.TabIndex = 13;
            this.btnbookadd.Text = "Add";
            this.btnbookadd.UseVisualStyleBackColor = true;
            this.btnbookadd.Click += new System.EventHandler(this.btnbookadd_Click);
            // 
            // btnhome
            // 
            this.btnhome.Location = new System.Drawing.Point(12, 334);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(75, 23);
            this.btnhome.TabIndex = 14;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = true;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnbookadd);
            this.Controls.Add(this.btndeletebooks);
            this.Controls.Add(this.btnviewbooks);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.txtauthor);
            this.Controls.Add(this.txtbookid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Books";
            this.Text = "ManageBooks";
            this.Load += new System.EventHandler(this.Books_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbookid;
        private System.Windows.Forms.TextBox txtauthor;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Button btnviewbooks;
        private System.Windows.Forms.Button btndeletebooks;
        private System.Windows.Forms.Button btnbookadd;
        private System.Windows.Forms.Button btnhome;
    }
}