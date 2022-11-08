namespace Project
{
    partial class Form3
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
            this.btnform2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnform4 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.dispmgr = new System.Windows.Forms.Button();
            this.rmmgr = new System.Windows.Forms.Button();
            this.asnmgr = new System.Windows.Forms.Button();
            this.ManagerName = new System.Windows.Forms.TextBox();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ManagerList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnform2
            // 
            this.btnform2.Location = new System.Drawing.Point(284, 390);
            this.btnform2.Name = "btnform2";
            this.btnform2.Size = new System.Drawing.Size(94, 29);
            this.btnform2.TabIndex = 40;
            this.btnform2.Text = "Form2";
            this.btnform2.UseVisualStyleBackColor = true;
            this.btnform2.Click += new System.EventHandler(this.btnform2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "ManagerAssign";
            // 
            // btnform4
            // 
            this.btnform4.Location = new System.Drawing.Point(384, 391);
            this.btnform4.Name = "btnform4";
            this.btnform4.Size = new System.Drawing.Size(94, 29);
            this.btnform4.TabIndex = 38;
            this.btnform4.Text = "Form4";
            this.btnform4.UseVisualStyleBackColor = true;
            this.btnform4.Click += new System.EventHandler(this.btnform4_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(394, 282);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(88, 29);
            this.clear.TabIndex = 37;
            this.clear.Text = "Clear List";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // dispmgr
            // 
            this.dispmgr.Location = new System.Drawing.Point(394, 225);
            this.dispmgr.Name = "dispmgr";
            this.dispmgr.Size = new System.Drawing.Size(88, 29);
            this.dispmgr.TabIndex = 36;
            this.dispmgr.Text = "Display";
            this.dispmgr.UseVisualStyleBackColor = true;
            // 
            // rmmgr
            // 
            this.rmmgr.Location = new System.Drawing.Point(245, 225);
            this.rmmgr.Name = "rmmgr";
            this.rmmgr.Size = new System.Drawing.Size(143, 29);
            this.rmmgr.TabIndex = 35;
            this.rmmgr.Text = "RemoveManager";
            this.rmmgr.UseVisualStyleBackColor = true;
            // 
            // asnmgr
            // 
            this.asnmgr.Location = new System.Drawing.Point(105, 225);
            this.asnmgr.Name = "asnmgr";
            this.asnmgr.Size = new System.Drawing.Size(134, 29);
            this.asnmgr.TabIndex = 34;
            this.asnmgr.Text = "AssignManager";
            this.asnmgr.UseVisualStyleBackColor = true;
            // 
            // ManagerName
            // 
            this.ManagerName.Location = new System.Drawing.Point(280, 142);
            this.ManagerName.Name = "ManagerName";
            this.ManagerName.Size = new System.Drawing.Size(198, 27);
            this.ManagerName.TabIndex = 33;
            // 
            // EmpName
            // 
            this.EmpName.Location = new System.Drawing.Point(280, 94);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(198, 27);
            this.EmpName.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "ManagerName";
            // 
            // ManagerList
            // 
            this.ManagerList.FormattingEnabled = true;
            this.ManagerList.ItemHeight = 20;
            this.ManagerList.Location = new System.Drawing.Point(521, 36);
            this.ManagerList.Name = "ManagerList";
            this.ManagerList.Size = new System.Drawing.Size(258, 384);
            this.ManagerList.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "EmployeeName";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnform2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnform4);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.dispmgr);
            this.Controls.Add(this.rmmgr);
            this.Controls.Add(this.asnmgr);
            this.Controls.Add(this.ManagerName);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ManagerList);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnform2;
        private Label label1;
        private Button btnform4;
        private Button clear;
        private Button dispmgr;
        private Button rmmgr;
        private Button asnmgr;
        private TextBox ManagerName;
        private TextBox EmpName;
        private Label label3;
        private ListBox ManagerList;
        private Label label2;
    }
}