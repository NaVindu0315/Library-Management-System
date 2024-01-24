using System;
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
    public partial class lendings : Form
    {
        //db connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\lmsdb.mdf;Integrated Security=True;Connect Timeout=30");
        //variables
        int bookid;
        string memberid, brwdate, rtrndate;
        public lendings()
        {
            InitializeComponent();
        }

        private void btnviewlendings_Click(object sender, EventArgs e)
        {
            viewlendings views = new viewlendings();
            views.Show();
            this.Hide();
        }

        private void btnbookdetails_Click(object sender, EventArgs e)
        {
            bookid = int.Parse(txtbookid.Text);
            string SelectSql = "SELECT memberid,brwdate FROM lendings WHERE bookid = '" + bookid + "'";
            SqlCommand comsel = new SqlCommand(SelectSql, con);
            ///try catch block
            try
            {
                con.Open();
                using (SqlDataReader read = comsel.ExecuteReader())
                {
                    while (read.Read())
                    {
                        txtmemid.Text = (read["memberid"].ToString());
                        txtbrwdate.Text = (read["brwdate"].ToString());

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            ///end
        }

        private void btnrecieve_Click(object sender, EventArgs e)
        {
            memberid = txtmemid.Text;
            bookid = int.Parse(txtbookid.Text);
            brwdate = txtbrwdate.Text;
            rtrndate = txtrtndate.Text;
            string adprvs = "INSERT INTO previous VALUES ('" + bookid + "','" + memberid + "','" + brwdate + "','" + rtrndate + "')";
            string del = "DELETE FROM lendings WHERE bookid ='" + bookid + "'";
            SqlCommand adnw = new SqlCommand(adprvs, con);
            SqlCommand delete = new SqlCommand(del, con);
            ///try catch block
            try
            {
                con.Open();
                adnw.ExecuteNonQuery();
                delete.ExecuteNonQuery();
                MessageBox.Show("Book " + bookid + " recieved");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }
            ///end
            ///
            txtbookid.Text = "";
            txtmemid.Text = "";
            txtbrwdate.Text = "";
            txtrtndate.Text = "";



        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            hstry hs = new hstry();
            hs.Show();
            this.Hide();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnlend_Click(object sender, EventArgs e)
        {
            bookid = int.Parse(txtbookid.Text);
            memberid = txtmemid.Text;
            brwdate = txtbrwdate.Text;
            rtrndate = "TBD";
            //query
            string lendnow = "INSERT INTO lendings VALUES ('" + bookid + "','" + memberid + "','" + brwdate + "','" + rtrndate + "')";
            SqlCommand adnw = new SqlCommand(lendnow, con);
            ///try catch block
            try
            {
                con.Open();
                adnw.ExecuteNonQuery();
                MessageBox.Show("Book " + bookid + " lended to member "+memberid);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                con.Close();
            }
            ///try catch block end
            txtbookid.Text = "";
            txtmemid.Text = "";
            txtbrwdate.Text = "";

        }
    }
}
