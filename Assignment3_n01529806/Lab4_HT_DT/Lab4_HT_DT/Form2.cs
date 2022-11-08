using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_HT_DT
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        private Form3 form3;
        private HashSet<string> hs1;
        private HashSet<string> hs2;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            hs1 = new HashSet<string>();
            hs2 = new HashSet<string>();
            this.form3 = new Form3(this);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnform1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void btndisp_Click(object sender, EventArgs e)
        {
            HSet1.Items.Clear();
            HSet2.Items.Clear();

            if (hs1.Count != 0)
            {
                foreach (string s in hs1)
                {
                    HSet1.Items.Add(s);
                }
            }
            else
            {
                MessageBox.Show("Nothing to display on HSet1", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            
            if (hs2.Count != 0)
            {
                foreach (string s in hs2)
                {
                    HSet2.Items.Add(s);
                }
            }
            else
            {
                MessageBox.Show("Nothing to display on HSet2", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }

        }

        private void btnadd_hs1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter values", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            else
            {
                hs1.Add(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void btnremove_hs1_Click(object sender, EventArgs e)
        {
            if (hs1.Contains(textBox1.Text))
            {
                hs1.Remove(textBox1.Text);
                textBox1.Clear();
            }
            else if(textBox1.Text == "")
            {
                MessageBox.Show("Please enter values", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Value not found or HSet1 is Empty", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }

        }

        private void btnadd_hs2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter values", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            else
            {
                hs2.Add(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void btnremove_hs2_Click(object sender, EventArgs e)
        {
            if (hs2.Contains(textBox1.Text))
            {
                hs2.Remove(textBox1.Text);
                textBox1.Clear();
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter values", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Value not found or HSet2 is Empty", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            if(HSet1 != null)
            {
                hs1.Clear();
            }
            else
            {
                MessageBox.Show("Empty List", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }

            if(HSet2 != null)
            {
                hs2.Clear();
            }
            else
            {
                MessageBox.Show("Empty List", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            
        }

        private void btnintersect_Click(object sender, EventArgs e)
        {
            if (HSet1 == null && HSet1 == null)
            {
                MessageBox.Show("Unable to Intersect", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
                
            }
            hs1.IntersectWith(hs2);
        }

        private void btnunion_Click(object sender, EventArgs e)
        {
            if(HSet1 == null && HSet2 == null)
            {
                MessageBox.Show("Unable to Union", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            } 
            hs2.UnionWith(hs1);
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            label1.Text = hs1.IsSubsetOf(hs2).ToString();
        }

        private void btnsuper_Click(object sender, EventArgs e)
        {
            label1.Text = hs1.IsSupersetOf(hs2).ToString();
        }

        private void btn_form3_Click(object sender, EventArgs e)
        {
            this.Hide();
            form3.Show();
        }
    }
}
