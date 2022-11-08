    using System.Collections;
using System.Linq;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        private ArrayList arrayList = new ArrayList();
        private List<course> list = new List<course>();
        public Form1()
        {
            InitializeComponent();
        }

        //Array-List
        private void btnAddAL_Click(object sender, EventArgs e)
        {

            if (txtArray.Text == "")
            {
                MessageBox.Show("Please enter valid course name",
                       "ERROR!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if(!arrayList.Contains(txtArray.Text))
            {
                arrayList.Add(txtArray.Text);
                txtArray.Clear();
                MessageBox.Show("Course added successfully.",
                    "Messaage", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("The course is already added, please select valid input!",
                    "Error Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveAL_Click(object sender, EventArgs e)
        {
            if (txtArray.Text == "")
            {
                MessageBox.Show("Please enter valid course name",
                       "ERROR!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (arrayList.Contains(txtArray.Text))
            {
                arrayList.Remove(txtArray.Text);
                txtArray.Clear();
                MessageBox.Show("Course removed successfully.",
                    "Messaage", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("No such course exsists, please select valid input!",
                    "Error Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            lbxArrayList.Items.Clear();
            foreach (string i in arrayList)
            {
                lbxArrayList.Items.Add(i);
            }
        }


        //List
        private void btnAddL_Click(object sender, EventArgs e)
        {
            course c = new course();
            if (txtList.Text == "" || txtScore.Text == "")
            {
                MessageBox.Show("Please enter both the fields.",
                       "ERROR!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
      
            else
            {
                c.Name=txtList.Text;
                c.Score = Int32.Parse(txtScore.Text);

                list.Add(c);
                txtList.Clear();
                txtScore.Clear();
                MessageBox.Show("Course added successfully.",
                    "Messaage", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnRemoveL_Click(object sender, EventArgs e)
        {
            if (txtList.Text == "")
            {
                MessageBox.Show("Please enter both the fields.",
                       "ERROR!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            else
            {

                //lblList.Items.Remove((txtList.Text) + " - " + (txtScore.Text));
                bool found = false;
                foreach (course c in list.ToList()) { 
                    if(c.Name == txtList.Text)
                    {
                        found= true;
                        list.Remove(c);
                    }
                }
                if (!found) {
                    MessageBox.Show("Course not found",
                  "Messaage", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                txtList.Clear();
                txtScore.Clear();
                MessageBox.Show("Course removed successfully",
                    "Messaage", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnDisplayL_Click(object sender, EventArgs e)
        {

            lblList.Items.Clear();
            list.ForEach(x => lblList.Items.Add(x.Name + "-" + x.Score));
        }
    }
}