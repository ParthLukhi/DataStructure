namespace Project
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        public Form1()
        {
            this.form2 = new Form2(this);
            InitializeComponent();
        }

        private void btnform2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }

        private void task_id_Click(object sender, EventArgs e)
        {

        }

        private void addemp_Click(object sender, EventArgs e)
        {
            Employee.AddEmp(new Employee(
                emp_id.Text,
                emp_fname.Text,
                emp_lname.Text,
                emp_d.Text,
                emp_sal.Text
                ));
            emp_id
        }
    }
}