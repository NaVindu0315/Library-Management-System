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
