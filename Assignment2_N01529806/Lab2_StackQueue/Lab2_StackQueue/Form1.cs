using System.Drawing.Imaging;

namespace Lab2_StackQueue
{
    public partial class Form1 : Form
    {
        private Stack<course> courses;
        private Queue<course> courseQ;
        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
            courses = new Stack<course>();
            courseQ = new Queue<course>();
            this.form2 = new Form2(this);
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtscore.Text == "")
            {
                MessageBox.Show("Please enter valid both the fields",
                       "ERROR!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else 
            {
                //course abc = new course(txtname.Text, txtscore.Text);
                courses.Push(new course(txtname.Text, txtscore.Text));
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if(courses.Count != 0)
            {
                courses.Pop();  
            }
            else
            {
                MessageBox.Show("Nothing to Pop Out",
                         "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btndisp_Click(object sender, EventArgs e)
        {
            lbxStack.Items.Clear();
            if (courses.Count != 0)
            {
                foreach (var course in courses)
                {
                    lbxStack.Items.Add(course);
                }
            }
            else
            {
                MessageBox.Show("There is no value to Display",
                         "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnenqueue_Click(object sender, EventArgs e)
        {
            if(txtnamequeue.Text != "" || txtscorequeue.Text !="")
            {
                courseQ.Enqueue(new course(txtnamequeue.Text, txtscorequeue.Text));
            }
            else
            {
                MessageBox.Show("Please enter valid both the fields",
                       "ERROR!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btndequeue_Click(object sender, EventArgs e)
        {
            if(courseQ.Count != 0)
            {
                courseQ.Dequeue();
            }
            else
            {
                MessageBox.Show("Nothing to Dequeue.",
                       "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btndispq_Click(object sender, EventArgs e)
        {
            lbxQueue.Items.Clear();
            if (courseQ.Count != 0)
            {
                course[] courseArray = courseQ.ToArray();
                for (int i = 0; i < courseArray.Length; i++)
                {
                    lbxQueue.Items.Add(courseArray[i]);
                }
            }
            else
            {
                MessageBox.Show("There is nothing to display in Queue",
                    "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btn_ll_Click(object sender, EventArgs e)
        {
            //this.Hide();
            form2.Show();
        }

        private void btnpeek_Click(object sender, EventArgs e)
        {
            lbxQueue.Items.Clear();
            if (courseQ.Count != 0)
            {
                lbxQueue.Items.Add(courseQ.Peek());
                //courseQ.Peek();
            }
            else
            {
                MessageBox.Show("There is nothing to peek in Queue",
                    "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnpeekstack_Click(object sender, EventArgs e)
        {
            lbxStack.Items.Clear();
            if(courses.Count != 0)
            {
                lbxStack.Items.Add(courses.Peek());
            }
            else
            {
                MessageBox.Show("There is nothing to peek in Stack.",
                    "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }
    }
}