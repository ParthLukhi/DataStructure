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
    public partial class Form3 : Form
    {
        private Form2 form2;
        private Form4 form4;
        public Form3(Form2 form2)
        {
            InitializeComponent();
            this.form2 = form2;
            this.form4 = new Form4(this);
        }

        private void btnform2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void btnform4_Click(object sender, EventArgs e)
        {
            this.Hide();
            form4.Show();
        }
    }
}
