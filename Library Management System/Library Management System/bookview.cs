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
    public partial class bookview : Form
    {
        //db connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\lmsdb.mdf;Integrated Security=True;Connect Timeout=30");

        public bookview()
        {
            InitializeComponent();
        }

        private void btnbooks_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            this.Hide();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void bookview_Load(object sender, EventArgs e)
        {
            string qryy = "SELECT * FROM books ";
            SqlDataAdapter adapter = new SqlDataAdapter(qryy, con);
            DataSet set = new DataSet();
            adapter.Fill(set, "books");
            dataGridView1.DataSource = set.Tables["books"];
        }
    }
}
