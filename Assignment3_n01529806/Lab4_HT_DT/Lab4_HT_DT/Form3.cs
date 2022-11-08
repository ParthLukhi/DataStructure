using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4_HT_DT
{
    public partial class Form3 : Form
    {
        private Form2 form2;
        private SortedSet<string> Ss1;
        private SortedSet<string> Ss2;
        public Form3(Form2 form2)
        {
            InitializeComponent();
            this.form2=form2;
            Ss1 = new SortedSet<string>();
            Ss2 = new SortedSet<string>();
        }

        private void btn_form2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_disp_Click(object sender, EventArgs e)
        {
            SortedSet1.Items.Clear();
            SortedSet2.Items.Clear();

            if(Ss1.Count != 0)
            {
                foreach (string s in Ss1)
                {
                    SortedSet1.Items.Add(s);
                }
            }
            else
            {
                MessageBox.Show("Nothing to display on SortedSet1", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }

            if(Ss2.Count != 0)
            {
                foreach (string s in Ss2)
                {
                    SortedSet2.Items.Add(s);
                }
            }
            else
            {
                MessageBox.Show("Nothing to display on SortedSet2", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (SortedSet1 != null)
            {
                MessageBox.Show("Empty List", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            else
            {
                Ss1.Clear();
            }

            if (SortedSet2 == null)
            {
                MessageBox.Show("Nothing to clear on SortedSet2", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);

            }
            else
            {
                Ss2.Clear();
            }
        }

        private void btn_addss_Click(object sender, EventArgs e)
        {
            if(text_ss.Text == "")
            {
                MessageBox.Show("Please enter values", "Error", MessageBoxButtons.OKCancel,
                  MessageBoxIcon.Error);
            }
            else
            {
                Ss1.Add(text_ss.Text);
                text_ss.Clear();
            }
            
        }

        private void btnremove_ss1_Click(object sender, EventArgs e)
        {
            if (Ss1.Contains(text_ss.Text))
            {
                Ss1.Remove(text_ss.Text);
                text_ss.Clear();
            }
            else if (text_ss.Text == "")
            {
                MessageBox.Show("Please enter values", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Value not found or SortedSet1 is Empty", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
        }

        private void btn_addss2_Click(object sender, EventArgs e)
        {
            if (text_ss.Text == "")
            {
                MessageBox.Show("Please enter values", "Error", MessageBoxButtons.OKCancel,
                  MessageBoxIcon.Error);
            }
            else
            {
                Ss2.Add(text_ss.Text);
                text_ss.Clear();
            }
        }

        private void btn_removess2_Click(object sender, EventArgs e)
        {
            if (Ss2.Contains(text_ss.Text))
            {
                Ss2.Remove(text_ss.Text);
                text_ss.Clear();
            }
            else if (text_ss.Text == "")
            {
                MessageBox.Show("Please enter values", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Value not found or SortedSet1 is Empty", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
        }

        private void btn_intersect_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_union_Click(object sender, EventArgs e)
        {
            if (SortedSet1 == null && SortedSet2 == null)
            {
                MessageBox.Show("Unable to Union", "Error", MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Error);
            }
            Ss2.UnionWith(Ss1);
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            lbl.Text = Ss1.IsSubsetOf(Ss2).ToString();
        }

        private void btn_super_Click(object sender, EventArgs e)
        {
            lbl.Text = Ss1.IsSupersetOf(Ss2).ToString();
        }

        private void btn_inter_Click(object sender, EventArgs e)
        {
            if (SortedSet1 == null && SortedSet2 == null)
            {
                MessageBox.Show("Unable to Intersect", "Error", MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Error);
            }
            else
            {
                Ss1.IntersectWith(Ss2);
            }
        }
    }
}
