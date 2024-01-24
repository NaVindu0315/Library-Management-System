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
    public partial class hstry : Form
    {
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

        }
    }
}
