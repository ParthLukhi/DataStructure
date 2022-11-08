namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataList = new System.Windows.Forms.ListBox();
            this.EmployeeID = new System.Windows.Forms.Label();
            this.emp_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emp_fname = new System.Windows.Forms.TextBox();
            this.emp_lname = new System.Windows.Forms.TextBox();
            this.mgr_fname = new System.Windows.Forms.TextBox();
            this.addemp = new System.Windows.Forms.Button();
            this.rmemp = new System.Windows.Forms.Button();
            this.dispemp = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.btnform2 = new System.Windows.Forms.Button();
            this.mgr_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mgr_lname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dispm = new System.Windows.Forms.Button();
            this.removemgr = new System.Windows.Forms.Button();
            this.mnageradd = new System.Windows.Forms.Button();
            this.taskid = new System.Windows.Forms.TextBox();
            this.t_name = new System.Windows.Forms.TextBox();
            this.disptask = new System.Windows.Forms.Button();
            this.taskname = new System.Windows.Forms.Button();
            this.task_id = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.emp_d = new System.Windows.Forms.TextBox();
            this.emp_sal = new System.Windows.Forms.TextBox();
            this.empdpt = new System.Windows.Forms.Label();
            this.empsal = new System.Windows.Forms.Label();
            this.mgr_dept = new System.Windows.Forms.TextBox();
            this.mgr_sal = new System.Windows.Forms.TextBox();
            this.mgrdpt = new System.Windows.Forms.Label();
            this.mgrsal = new System.Windows.Forms.Label();
            this.t_project = new System.Windows.Forms.TextBox();
            this.t_desp = new System.Windows.Forms.TextBox();
            this.t_stat = new System.Windows.Forms.TextBox();
            this.Project = new System.Windows.Forms.Label();
            this.dptname = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.clear_mgr = new System.Windows.Forms.Button();
            this.clear_task = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DataList
            // 
            this.DataList.FormattingEnabled = true;
            this.DataList.ItemHeight = 20;
            this.DataList.Location = new System.Drawing.Point(649, 6);
            this.DataList.Name = "DataList";
            this.DataList.Size = new System.Drawing.Size(324, 324);
            this.DataList.TabIndex = 0;
            // 
            // EmployeeID
            // 
            this.EmployeeID.AutoSize = true;
            this.EmployeeID.Location = new System.Drawing.Point(12, 36);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(58, 20);
            this.EmployeeID.TabIndex = 1;
            this.EmployeeID.Text = "Emp ID";
            // 
            // emp_id
            // 
            this.emp_id.Location = new System.Drawing.Point(12, 6);
            this.emp_id.Name = "emp_id";
            this.emp_id.Size = new System.Drawing.Size(74, 27);
            this.emp_id.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Emp First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Emp Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mgr First Name";
            // 
            // emp_fname
            // 
            this.emp_fname.Location = new System.Drawing.Point(92, 6);
            this.emp_fname.Name = "emp_fname";
            this.emp_fname.Size = new System.Drawing.Size(125, 27);
            this.emp_fname.TabIndex = 6;
            // 
            // emp_lname
            // 
            this.emp_lname.Location = new System.Drawing.Point(223, 6);
            this.emp_lname.Name = "emp_lname";
            this.emp_lname.Size = new System.Drawing.Size(135, 27);
            this.emp_lname.TabIndex = 7;
            // 
            // mgr_fname
            // 
            this.mgr_fname.Location = new System.Drawing.Point(92, 158);
            this.mgr_fname.Name = "mgr_fname";
            this.mgr_fname.Size = new System.Drawing.Size(125, 27);
            this.mgr_fname.TabIndex = 8;
            // 
            // addemp
            // 
            this.addemp.Location = new System.Drawing.Point(12, 79);
            this.addemp.Name = "addemp";
            this.addemp.Size = new System.Drawing.Size(134, 29);
            this.addemp.TabIndex = 9;
            this.addemp.Text = "Add Employee";
            this.addemp.UseVisualStyleBackColor = true;
            this.addemp.Click += new System.EventHandler(this.addemp_Click);
            // 
            // rmemp
            // 
            this.rmemp.Location = new System.Drawing.Point(152, 79);
            this.rmemp.Name = "rmemp";
            this.rmemp.Size = new System.Drawing.Size(143, 29);
            this.rmemp.TabIndex = 10;
            this.rmemp.Text = "Remove Employee";
            this.rmemp.UseVisualStyleBackColor = true;
            // 
            // dispemp
            // 
            this.dispemp.Location = new System.Drawing.Point(301, 79);
            this.dispemp.Name = "dispemp";
            this.dispemp.Size = new System.Drawing.Size(139, 29);
            this.dispemp.TabIndex = 11;
            this.dispemp.Text = "Display Employee";
            this.dispemp.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(446, 79);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(94, 29);
            this.clear.TabIndex = 12;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // btnform2
            // 
            this.btnform2.Location = new System.Drawing.Point(879, 522);
            this.btnform2.Name = "btnform2";
            this.btnform2.Size = new System.Drawing.Size(94, 29);
            this.btnform2.TabIndex = 13;
            this.btnform2.Text = "Form 2";
            this.btnform2.UseVisualStyleBackColor = true;
            this.btnform2.Click += new System.EventHandler(this.btnform2_Click);
            // 
            // mgr_id
            // 
            this.mgr_id.Location = new System.Drawing.Point(12, 158);
            this.mgr_id.Name = "mgr_id";
            this.mgr_id.Size = new System.Drawing.Size(74, 27);
            this.mgr_id.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mgr ID";
            // 
            // mgr_lname
            // 
            this.mgr_lname.Location = new System.Drawing.Point(223, 158);
            this.mgr_lname.Name = "mgr_lname";
            this.mgr_lname.Size = new System.Drawing.Size(135, 27);
            this.mgr_lname.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mgr Last Name";
            // 
            // dispm
            // 
            this.dispm.Location = new System.Drawing.Point(301, 241);
            this.dispm.Name = "dispm";
            this.dispm.Size = new System.Drawing.Size(139, 29);
            this.dispm.TabIndex = 20;
            this.dispm.Text = "Display Manager";
            this.dispm.UseVisualStyleBackColor = true;
            // 
            // removemgr
            // 
            this.removemgr.Location = new System.Drawing.Point(152, 241);
            this.removemgr.Name = "removemgr";
            this.removemgr.Size = new System.Drawing.Size(143, 29);
            this.removemgr.TabIndex = 19;
            this.removemgr.Text = "Remove Manager";
            this.removemgr.UseVisualStyleBackColor = true;
            // 
            // mnageradd
            // 
            this.mnageradd.Location = new System.Drawing.Point(12, 241);
            this.mnageradd.Name = "mnageradd";
            this.mnageradd.Size = new System.Drawing.Size(134, 29);
            this.mnageradd.TabIndex = 18;
            this.mnageradd.Text = "Add Manager";
            this.mnageradd.UseVisualStyleBackColor = true;
            // 
            // taskid
            // 
            this.taskid.Location = new System.Drawing.Point(12, 303);
            this.taskid.Name = "taskid";
            this.taskid.Size = new System.Drawing.Size(74, 27);
            this.taskid.TabIndex = 21;
            // 
            // t_name
            // 
            this.t_name.Location = new System.Drawing.Point(92, 303);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(125, 27);
            this.t_name.TabIndex = 22;
            // 
            // disptask
            // 
            this.disptask.Location = new System.Drawing.Point(301, 387);
            this.disptask.Name = "disptask";
            this.disptask.Size = new System.Drawing.Size(139, 29);
            this.disptask.TabIndex = 26;
            this.disptask.Text = "Display Task";
            this.disptask.UseVisualStyleBackColor = true;
            // 
            // taskname
            // 
            this.taskname.Location = new System.Drawing.Point(152, 387);
            this.taskname.Name = "taskname";
            this.taskname.Size = new System.Drawing.Size(143, 29);
            this.taskname.TabIndex = 25;
            this.taskname.Text = "Remove Task";
            this.taskname.UseVisualStyleBackColor = true;
            // 
            // task_id
            // 
            this.task_id.Location = new System.Drawing.Point(12, 387);
            this.task_id.Name = "task_id";
            this.task_id.Size = new System.Drawing.Size(134, 29);
            this.task_id.TabIndex = 24;
            this.task_id.Text = "Add Task";
            this.task_id.UseVisualStyleBackColor = true;
            this.task_id.Click += new System.EventHandler(this.task_id_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Task ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Task Name";
            // 
            // emp_d
            // 
            this.emp_d.Location = new System.Drawing.Point(364, 6);
            this.emp_d.Name = "emp_d";
            this.emp_d.Size = new System.Drawing.Size(125, 27);
            this.emp_d.TabIndex = 30;
            // 
            // emp_sal
            // 
            this.emp_sal.Location = new System.Drawing.Point(495, 6);
            this.emp_sal.Name = "emp_sal";
            this.emp_sal.Size = new System.Drawing.Size(125, 27);
            this.emp_sal.TabIndex = 31;
            // 
            // empdpt
            // 
            this.empdpt.AutoSize = true;
            this.empdpt.Location = new System.Drawing.Point(366, 36);
            this.empdpt.Name = "empdpt";
            this.empdpt.Size = new System.Drawing.Size(123, 20);
            this.empdpt.TabIndex = 32;
            this.empdpt.Text = "Emp Department";
            // 
            // empsal
            // 
            this.empsal.AutoSize = true;
            this.empsal.Location = new System.Drawing.Point(537, 36);
            this.empsal.Name = "empsal";
            this.empsal.Size = new System.Drawing.Size(49, 20);
            this.empsal.TabIndex = 33;
            this.empsal.Text = "Salary";
            // 
            // mgr_dept
            // 
            this.mgr_dept.Location = new System.Drawing.Point(364, 158);
            this.mgr_dept.Name = "mgr_dept";
            this.mgr_dept.Size = new System.Drawing.Size(125, 27);
            this.mgr_dept.TabIndex = 34;
            // 
            // mgr_sal
            // 
            this.mgr_sal.Location = new System.Drawing.Point(495, 158);
            this.mgr_sal.Name = "mgr_sal";
            this.mgr_sal.Size = new System.Drawing.Size(125, 27);
            this.mgr_sal.TabIndex = 35;
            // 
            // mgrdpt
            // 
            this.mgrdpt.AutoSize = true;
            this.mgrdpt.Location = new System.Drawing.Point(369, 188);
            this.mgrdpt.Name = "mgrdpt";
            this.mgrdpt.Size = new System.Drawing.Size(120, 20);
            this.mgrdpt.TabIndex = 36;
            this.mgrdpt.Text = "Mgr Department";
            // 
            // mgrsal
            // 
            this.mgrsal.AutoSize = true;
            this.mgrsal.Location = new System.Drawing.Point(528, 188);
            this.mgrsal.Name = "mgrsal";
            this.mgrsal.Size = new System.Drawing.Size(49, 20);
            this.mgrsal.TabIndex = 37;
            this.mgrsal.Text = "Salary";
            // 
            // t_project
            // 
            this.t_project.Location = new System.Drawing.Point(223, 303);
            this.t_project.Name = "t_project";
            this.t_project.Size = new System.Drawing.Size(135, 27);
            this.t_project.TabIndex = 38;
            // 
            // t_desp
            // 
            this.t_desp.Location = new System.Drawing.Point(364, 303);
            this.t_desp.Name = "t_desp";
            this.t_desp.Size = new System.Drawing.Size(125, 27);
            this.t_desp.TabIndex = 39;
            // 
            // t_stat
            // 
            this.t_stat.Location = new System.Drawing.Point(495, 303);
            this.t_stat.Name = "t_stat";
            this.t_stat.Size = new System.Drawing.Size(125, 27);
            this.t_stat.TabIndex = 40;
            // 
            // Project
            // 
            this.Project.AutoSize = true;
            this.Project.Location = new System.Drawing.Point(235, 333);
            this.Project.Name = "Project";
            this.Project.Size = new System.Drawing.Size(99, 20);
            this.Project.TabIndex = 41;
            this.Project.Text = "Project Name";
            // 
            // dptname
            // 
            this.dptname.AutoSize = true;
            this.dptname.Location = new System.Drawing.Point(378, 333);
            this.dptname.Name = "dptname";
            this.dptname.Size = new System.Drawing.Size(85, 20);
            this.dptname.TabIndex = 42;
            this.dptname.Text = "Description";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(528, 333);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(49, 20);
            this.status.TabIndex = 43;
            this.status.Text = "Status";
            // 
            // clear_mgr
            // 
            this.clear_mgr.Location = new System.Drawing.Point(446, 241);
            this.clear_mgr.Name = "clear_mgr";
            this.clear_mgr.Size = new System.Drawing.Size(94, 29);
            this.clear_mgr.TabIndex = 44;
            this.clear_mgr.Text = "Clear";
            this.clear_mgr.UseVisualStyleBackColor = true;
            // 
            // clear_task
            // 
            this.clear_task.Location = new System.Drawing.Point(446, 387);
            this.clear_task.Name = "clear_task";
            this.clear_task.Size = new System.Drawing.Size(94, 29);
            this.clear_task.TabIndex = 45;
            this.clear_task.Text = "Clear";
            this.clear_task.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 563);
            this.Controls.Add(this.clear_task);
            this.Controls.Add(this.clear_mgr);
            this.Controls.Add(this.status);
            this.Controls.Add(this.dptname);
            this.Controls.Add(this.Project);
            this.Controls.Add(this.t_stat);
            this.Controls.Add(this.t_desp);
            this.Controls.Add(this.t_project);
            this.Controls.Add(this.mgrsal);
            this.Controls.Add(this.mgrdpt);
            this.Controls.Add(this.mgr_sal);
            this.Controls.Add(this.mgr_dept);
            this.Controls.Add(this.empsal);
            this.Controls.Add(this.empdpt);
            this.Controls.Add(this.emp_sal);
            this.Controls.Add(this.emp_d);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.disptask);
            this.Controls.Add(this.taskname);
            this.Controls.Add(this.task_id);
            this.Controls.Add(this.t_name);
            this.Controls.Add(this.taskid);
            this.Controls.Add(this.dispm);
            this.Controls.Add(this.removemgr);
            this.Controls.Add(this.mnageradd);
            this.Controls.Add(this.mgr_lname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mgr_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnform2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.dispemp);
            this.Controls.Add(this.rmemp);
            this.Controls.Add(this.addemp);
            this.Controls.Add(this.mgr_fname);
            this.Controls.Add(this.emp_lname);
            this.Controls.Add(this.emp_fname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emp_id);
            this.Controls.Add(this.EmployeeID);
            this.Controls.Add(this.DataList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox DataList;
        private Label EmployeeID;
        private TextBox emp_id;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox emp_fname;
        private TextBox emp_lname;
        private TextBox mgr_fname;
        private Button addemp;
        private Button rmemp;
        private Button dispemp;
        private Button clear;
        private Button btnform2;
        private TextBox mgr_id;
        private Label label4;
        private TextBox mgr_lname;
        private Label label5;
        private Button dispm;
        private Button removemgr;
        private Button mnageradd;
        private TextBox taskid;
        private TextBox t_name;
        private Button disptask;
        private Button taskname;
        private Button task_id;
        private Label label6;
        private Label label7;
        private TextBox emp_d;
        private TextBox emp_sal;
        private Label empdpt;
        private Label empsal;
        private TextBox mgr_dept;
        private TextBox mgr_sal;
        private Label mgrdpt;
        private Label mgrsal;
        private TextBox t_project;
        private TextBox t_desp;
        private TextBox t_stat;
        private Label Project;
        private Label dptname;
        private Label status;
        private Button clear_mgr;
        private Button clear_task;
    }
}