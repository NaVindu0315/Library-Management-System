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
    public partial class hstry : Form
    {
        //db connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\lmsdb.mdf;Integrated Security=True;Connect Timeout=30");

        public hstry()
        {
            InitializeComponent();
        }

        private void btnlending_Click(object sender, EventArgs e)
        {
            lendings lends = new lendings();
            lends.Show();
            this.Hide();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void hstry_Load(object sender, EventArgs e)
        {
            string qryy = "SELECT * FROM previous";
            SqlDataAdapter adapter = new SqlDataAdapter(qryy, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "previous");
            dataGridView1.DataSource = set.Tables["previous"];
        }
    }
}
