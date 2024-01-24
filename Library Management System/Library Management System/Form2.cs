﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Library_Management_System
{
   
    public partial class Books : Form
    {
        //db connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\lmsdb.mdf;Integrated Security=True;Connect Timeout=30");
        //variables
        string author, title, date;
        int bookid, price;

        private void btndeletebooks_Click(object sender, EventArgs e)
        {
            bookid = int.Parse(txtbookid.Text);
            string del = "DELETE FROM books WHERE bookid ='" + bookid + "'";
            SqlCommand cmddel = new SqlCommand(del, con);
            ///try catch block
            try
            {
                con.Open();
                cmddel.ExecuteNonQuery();
                MessageBox.Show("Book " + bookid + " removed from the Database successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            ///block end]
            txtbookid.Text = "";

        }

        private void btnviewbooks_Click(object sender, EventArgs e)
        {
            bookview bkview = new bookview();
            bkview.Show();
            this.Hide();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnbookadd_Click(object sender, EventArgs e)
        {
            bookid = int.Parse(txtbookid.Text);
            author = txtauthor.Text;
            title = txttitle.Text;
            price = int.Parse(txtprice.Text);
            date = txtdate.Text;

            string addbook = "INSERT INTO books VALUES ('" + bookid + "','" + author + "','" + title + "','" + price + "','" + date + "')";
            SqlCommand adbk = new SqlCommand(addbook, con);

            //try catch block 
            try
            {
                con.Open();
                adbk.ExecuteNonQuery();
                MessageBox.Show("New Book " + title + " is succesfully added under "+bookid+" code");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }
            ///block end
            ///txtbox clearing
            txtbookid.Text = "";
            txtauthor.Text = "";
            txttitle.Text = "";
            txtprice.Text = "";
            txtdate.Text = "";

        }

      
        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {

        }
    }
}
