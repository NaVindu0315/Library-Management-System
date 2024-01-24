
namespace Library_Management_System
{
    partial class Home
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
            this.btnbooks = new System.Windows.Forms.Button();
            this.btnlending = new System.Windows.Forms.Button();
            this.btnmembers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnbooks
            // 
            this.btnbooks.Location = new System.Drawing.Point(211, 171);
            this.btnbooks.Name = "btnbooks";
            this.btnbooks.Size = new System.Drawing.Size(75, 23);
            this.btnbooks.TabIndex = 1;
            this.btnbooks.Text = "Books";
            this.btnbooks.UseVisualStyleBackColor = true;
            this.btnbooks.Click += new System.EventHandler(this.btnbooks_Click);
            // 
            // btnlending
            // 
            this.btnlending.Location = new System.Drawing.Point(372, 171);
            this.btnlending.Name = "btnlending";
            this.btnlending.Size = new System.Drawing.Size(75, 23);
            this.btnlending.TabIndex = 2;
            this.btnlending.Text = "Lending";
            this.btnlending.UseVisualStyleBackColor = true;
            // 
            // btnmembers
            // 
            this.btnmembers.Location = new System.Drawing.Point(519, 171);
            this.btnmembers.Name = "btnmembers";
            this.btnmembers.Size = new System.Drawing.Size(75, 23);
            this.btnmembers.TabIndex = 3;
            this.btnmembers.Text = "Members";
            this.btnmembers.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmembers);
            this.Controls.Add(this.btnlending);
            this.Controls.Add(this.btnbooks);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Library Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbooks;
        private System.Windows.Forms.Button btnlending;
        private System.Windows.Forms.Button btnmembers;
    }
}

