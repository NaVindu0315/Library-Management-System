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
    public partial class viewlendings : Form
    {
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
    }
}
