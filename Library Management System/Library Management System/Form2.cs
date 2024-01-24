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
   
    public partial class Books : Form
    {
        //variables
        string author, title, date;
        int bookid, price;
     
        //db connection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Databases\lmsdb.mdf;Integrated Security=True;Connect Timeout=30");
        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {

        }
    }
}
