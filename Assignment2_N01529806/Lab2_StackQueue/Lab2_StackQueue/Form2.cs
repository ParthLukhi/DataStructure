using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_StackQueue
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        private LinkedList<course> linkedlist;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            linkedlist = new LinkedList<course>();
        }

        private void btn_sq_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txtCourseName.Text != "" || txtScore.Text != "")
            {
                linkedlist.AddLast(new course(txtCourseName.Text, txtScore.Text));
            }
            else
            {
                MessageBox.Show("Please enter valid input",
                         "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btn_Disp_Click(object sender, EventArgs e)
        {
            lblLinkedList.Items.Clear();
            if (linkedlist.Count != 0)
            {
                foreach (course c in linkedlist)
                {
                    lblLinkedList.Items.Add(c);
                }
            }
            else
            {
                MessageBox.Show("There is nothing to Display",
                         "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            lblLinkedList.Items.Clear();
            if(txtCourseName.Text != "" || txtScore.Text !="")
            {
                linkedlist.Find(new course(txtCourseName.Text, txtScore.Text));
                lblLinkedList.Items.Add(txtCourseName.Text + ' ' + txtScore.Text);
            }
            else if(linkedlist.Count == 0)
            {
                MessageBox.Show("List is empty",
                         "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please enter valid input",
                         "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            
        }

        private void btnAddfirst_Click(object sender, EventArgs e)
        {
            if(txtCourseName.Text != "" || txtScore.Text != "")
            {
                linkedlist.AddFirst(new course(txtCourseName.Text, txtScore.Text));
            }
            else
            {
                MessageBox.Show("Please enter valid input",
                         "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnremovefirst_Click(object sender, EventArgs e)
        {
            if (linkedlist.Count != 0)
            {
                linkedlist.RemoveFirst();
            }
            else
            {
                MessageBox.Show("There is no data.",
                         "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            //lblLinkedList.Items.Clear();
            if(txtCourseName.Text != "")
            {
              //  LinkedListNode<course> result = linkedlist.Find(new course(txtCourseName.Text, txtScore.Text));
            }
            else
            {
                MessageBox.Show("There is no data.",
                         "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            //lblLinkedList.Items.Remove(result);
        }

        private void btnremovelast_Click(object sender, EventArgs e)
        {

            if (linkedlist.Count == 0)
            {
                MessageBox.Show("There is no data.",
                         "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                linkedlist.RemoveLast();
            }
        }
    }
}
