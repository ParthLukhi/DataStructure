namespace Project
{
    partial class Form4
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
            this.EmployeeSummary = new System.Windows.Forms.ListBox();
            this.empname = new System.Windows.Forms.TextBox();
            this.dispemp = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.btnform1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnform3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeSummary
            // 
            this.EmployeeSummary.FormattingEnabled = true;
            this.EmployeeSummary.ItemHeight = 20;
            this.EmployeeSummary.Location = new System.Drawing.Point(521, 35);
            this.EmployeeSummary.Name = "EmployeeSummary";
            this.EmployeeSummary.Size = new System.Drawing.Size(258, 384);
            this.EmployeeSummary.TabIndex = 42;
            // 
            // empname
            // 
            this.empname.Location = new System.Drawing.Point(259, 93);
            this.empname.Name = "empname";
            this.empname.Size = new System.Drawing.Size(198, 27);
            this.empname.TabIndex = 44;
            // 
            // dispemp
            // 
            this.dispemp.Location = new System.Drawing.Point(259, 147);
            this.dispemp.Name = "dispemp";
            this.dispemp.Size = new System.Drawing.Size(88, 29);
            this.dispemp.TabIndex = 48;
            this.dispemp.Text = "Display";
            this.dispemp.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(363, 147);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(94, 29);
            this.clear.TabIndex = 49;
            this.clear.Text = "Clear List";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // btnform1
            // 
            this.btnform1.Location = new System.Drawing.Point(363, 390);
            this.btnform1.Name = "btnform1";
            this.btnform1.Size = new System.Drawing.Size(94, 29);
            this.btnform1.TabIndex = 50;
            this.btnform1.Text = "Form1";
            this.btnform1.UseVisualStyleBackColor = true;
            this.btnform1.Click += new System.EventHandler(this.btnform1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Summary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "EmployeeName";
            // 
            // btnform3
            // 
            this.btnform3.Location = new System.Drawing.Point(259, 390);
            this.btnform3.Name = "btnform3";
            this.btnform3.Size = new System.Drawing.Size(88, 29);
            this.btnform3.TabIndex = 54;
            this.btnform3.Text = "Form3";
            this.btnform3.UseVisualStyleBackColor = true;
            this.btnform3.Click += new System.EventHandler(this.btnform3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnform3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnform1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.dispemp);
            this.Controls.Add(this.empname);
            this.Controls.Add(this.EmployeeSummary);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox EmployeeSummary;
        private TextBox empname;
        private Button dispemp;
        private Button clear;
        private Button btnform1;
        private Label label1;
        private Label label2;
        private Button btnform3;
    }
}