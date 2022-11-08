namespace Project
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TaskList = new System.Windows.Forms.ListBox();
            this.btnform3 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.disptask = new System.Windows.Forms.Button();
            this.rmtask = new System.Windows.Forms.Button();
            this.asntask = new System.Windows.Forms.Button();
            this.empname = new System.Windows.Forms.TextBox();
            this.Taskname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnform1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskList
            // 
            this.TaskList.FormattingEnabled = true;
            this.TaskList.ItemHeight = 20;
            this.TaskList.Location = new System.Drawing.Point(530, 28);
            this.TaskList.Name = "TaskList";
            this.TaskList.Size = new System.Drawing.Size(258, 384);
            this.TaskList.TabIndex = 0;
            // 
            // btnform3
            // 
            this.btnform3.Location = new System.Drawing.Point(388, 383);
            this.btnform3.Name = "btnform3";
            this.btnform3.Size = new System.Drawing.Size(94, 29);
            this.btnform3.TabIndex = 26;
            this.btnform3.Text = "Form3";
            this.btnform3.UseVisualStyleBackColor = true;
            this.btnform3.Click += new System.EventHandler(this.btnform3_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(398, 270);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(84, 29);
            this.clear.TabIndex = 25;
            this.clear.Text = "Clear List";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // disptask
            // 
            this.disptask.Location = new System.Drawing.Point(398, 220);
            this.disptask.Name = "disptask";
            this.disptask.Size = new System.Drawing.Size(88, 29);
            this.disptask.TabIndex = 24;
            this.disptask.Text = "Display";
            this.disptask.UseVisualStyleBackColor = true;
            // 
            // rmtask
            // 
            this.rmtask.Location = new System.Drawing.Point(249, 220);
            this.rmtask.Name = "rmtask";
            this.rmtask.Size = new System.Drawing.Size(143, 29);
            this.rmtask.TabIndex = 23;
            this.rmtask.Text = "Remove Task";
            this.rmtask.UseVisualStyleBackColor = true;
            // 
            // asntask
            // 
            this.asntask.Location = new System.Drawing.Point(109, 220);
            this.asntask.Name = "asntask";
            this.asntask.Size = new System.Drawing.Size(134, 29);
            this.asntask.TabIndex = 22;
            this.asntask.Text = "AssignTask";
            this.asntask.UseVisualStyleBackColor = true;
            // 
            // empname
            // 
            this.empname.Location = new System.Drawing.Point(284, 137);
            this.empname.Name = "empname";
            this.empname.Size = new System.Drawing.Size(198, 27);
            this.empname.TabIndex = 21;
            // 
            // Taskname
            // 
            this.Taskname.Location = new System.Drawing.Point(284, 89);
            this.Taskname.Name = "Taskname";
            this.Taskname.Size = new System.Drawing.Size(198, 27);
            this.Taskname.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "EmployeeName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "TaskName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Employee Task Assign";
            // 
            // btnform1
            // 
            this.btnform1.Location = new System.Drawing.Point(288, 382);
            this.btnform1.Name = "btnform1";
            this.btnform1.Size = new System.Drawing.Size(94, 29);
            this.btnform1.TabIndex = 28;
            this.btnform1.Text = "Form1";
            this.btnform1.UseVisualStyleBackColor = true;
            this.btnform1.Click += new System.EventHandler(this.btnform1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnform1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnform3);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.disptask);
            this.Controls.Add(this.rmtask);
            this.Controls.Add(this.asntask);
            this.Controls.Add(this.empname);
            this.Controls.Add(this.Taskname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TaskList);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox TaskList;
        private Button btnform3;
        private Button clear;
        private Button disptask;
        private Button rmtask;
        private Button asntask;
        private TextBox empname;
        private TextBox Taskname;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnform1;
    }
}