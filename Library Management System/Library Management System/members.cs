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
    public partial class members : Form
    {
        //db connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\lmsdb.mdf;Integrated Security=True;Connect Timeout=30");
        //variables
        int memberid;
        string name, adrs, dob;
        public members()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            memberid = int.Parse(txtmemid.Text);
            name = txtname.Text;
            adrs = txtadrs.Text;
            dob = txtdob.Text;
            string addnew = "INSERT INTO members VALUES ('" + memberid + "','" + name + "','" + adrs + "','" + dob + "')";
            SqlCommand adnw = new SqlCommand(addnew, con);
            ///try catch block
            try
            {
                con.Open();
                adnw.ExecuteNonQuery();
                MessageBox.Show("New Member " + name + " is succesfully enrolled");
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
            txtmemid.Text = "";
            txtdob.Text = "";
            txtadrs.Text = ""; 
            txtname.Text = ""; 

        }
    }
}
