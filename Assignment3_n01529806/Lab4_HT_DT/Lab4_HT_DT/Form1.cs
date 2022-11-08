using System.Collections;

namespace Lab4_HT_DT
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        private Hashtable hashtable;
        private Dictionary<int, course>dict;
        public Form1()
        {
            InitializeComponent();
            hashtable = new Hashtable();
            dict = new Dictionary<int, course>();
            this.form2 = new Form2(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dict.ContainsKey(Int32.Parse(txtkey.Text)))
            {
                MessageBox.Show("Value already present", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            else if (txtkey.Text == "")
            {
                MessageBox.Show("Key field cannot be null", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            else
            {
                dict.Add(Int32.Parse(txtkey.Text), new course(txtvalue.Text, txtscore.Text));   
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (hashtable.ContainsKey((txtkey.Text)))
            {
                MessageBox.Show("Value already present", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            else if(txtkey.Text == "")
            {
                MessageBox.Show("Key field cannot be null", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            else
            {
                hashtable.Add(txtkey.Text, new course(txtvalue.Text, txtscore.Text));
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (hashtable.ContainsKey((txtkey.Text)))
            {
                hashtable.Remove(txtkey.Text);
            }
            else if (txtkey.Text == "" || txtvalue.Text == "")
            {
                MessageBox.Show("Key field or values cannot be null", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("List is empty", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDisp_Click(object sender, EventArgs e)
        {
            lbxresult.Items.Clear();
            if (hashtable.Count != 0)
            {
                foreach (DictionaryEntry de in hashtable)
                {
                    lbxresult.Items.Add(de.Key + ": " + ((course)de.Value).CourseName + "-" + ((course)de.Value).Score);
                }
            }
            else
            {
                MessageBox.Show("List is empty", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (hashtable.Count != 0)
            {
                hashtable.Clear();
            }
            else
            {
                MessageBox.Show("List is empty", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            
        }

        private void btnRemovedt_Click(object sender, EventArgs e)
        {
            if (dict.ContainsKey(Int32.Parse(txtkey.Text)))
            {
                dict.Remove(Int32.Parse(txtkey.Text));
            }
            else if(txtkey.Text == "" || txtvalue.Text == "")
            {
                MessageBox.Show("Key field or values cannot be null", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("List is empty", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
            
        }

        private void btndispDT_Click(object sender, EventArgs e)
        {
            lbxresult.Items.Clear();
            foreach(KeyValuePair<int, course>kvp in dict)
            {
                lbxresult.Items.Add(kvp.Key +":"+ kvp.Value.CourseName +"-"+ kvp.Value.Score);
            }

        }

        private void btnClearDT_Click(object sender, EventArgs e)
        {
            if(dict.Count != 0)
            {
                dict.Clear();
            }
            else
            {
                MessageBox.Show("Dictionary is empty", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
        }

        private void btnform2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void btn_value_Click(object sender, EventArgs e)
        {
            lbxresult.Items.Clear();
            if(hashtable.Count != 0)
            {
                foreach (DictionaryEntry de in hashtable)
                {
                    lbxresult.Items.Add("Values: "+((course)de.Value).CourseName + "-" + ((course)de.Value).Score);
                }
            }
            else
            {
                MessageBox.Show("List is empty", "Error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
        }

        private void btn_chkv_Click(object sender, EventArgs e)
        {
            lbxresult.Items.Clear();
            if (dict.Count != 0)
            {
                foreach (KeyValuePair<int, course> kvp in dict)
                {
                    if (kvp.Value.CourseName == txtvalue.Text && kvp.Value.Score.ToString() == txtscore.Text)
                    {
                        lbxresult.Items.Add("Vaue found.");


                        lbxresult.Items.Add(kvp.Key + ":" + kvp.Value.CourseName + "-" + kvp.Value.Score);
                    }
                    else
                    {
                        lbxresult.Items.Add ("Vaue no found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("List is empty", "Error", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Error);
            }
        }

        private void txtvalue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}