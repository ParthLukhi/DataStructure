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
    public partial class Form2 : Form
    {
        private Form1 form1;
        private Form3 form3;
        public Form2(Form1 form1)
        {
            this.form1 = form1;
            this.form3 = new Form3(this);
            InitializeComponent();
        }

        private void btnform1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void btnform3_Click(object sender, EventArgs e)
        {
            this.Hide();
            form3.Show();
        }
    }
}
