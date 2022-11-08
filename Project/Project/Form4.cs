using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form4 : Form
    {
        private Form3 form3;
        private Form1 form1;
        public Form4(Form3 form3)
        {
            InitializeComponent();
            this.form3 = form3;
            //this.form1 = form1;
        }

        private void btnform3_Click(object sender, EventArgs e)
        {
            this.Hide();
            form3.Show();
        }

        private void btnform1_Click(object sender, EventArgs e)
        {
           // this.Hide();
            //form1.Show();
        }
    }
}
