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
    public partial class viewlendings : Form
    {
        //db connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\lmsdb.mdf;Integrated Security=True;Connect Timeout=30");

        public viewlendings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lendings lends = new lendings();
            lends.Show();
            this.Hide();
        }

        private void viewlendings_Load(object sender, EventArgs e)
        {
            string qryy = "SELECT * FROM lendings ";
            SqlDataAdapter adapter = new SqlDataAdapter(qryy, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "lendings");
            dataGridView1.DataSource = set.Tables["lendings"];

        }
    }
}
