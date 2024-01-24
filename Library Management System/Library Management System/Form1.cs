using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnbooks_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            this.Hide();
        }

        private void btnlending_Click(object sender, EventArgs e)
        {
            lendings lends = new lendings();
            lends.Show();
            this.Hide();
        }

        private void btnmembers_Click(object sender, EventArgs e)
        {
            members mem = new members();
            mem.Show();
            this.Hide();
        }
    }
}
