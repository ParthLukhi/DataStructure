namespace Lab2_StackQueue
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
            this.btn_sq = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_Disp = new System.Windows.Forms.Button();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblLinkedList = new System.Windows.Forms.ListBox();
            this.btnAddfirst = new System.Windows.Forms.Button();
            this.btnremovefirst = new System.Windows.Forms.Button();
            this.btnremovelast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sq
            // 
            this.btn_sq.Location = new System.Drawing.Point(44, 377);
            this.btn_sq.Name = "btn_sq";
            this.btn_sq.Size = new System.Drawing.Size(155, 29);
            this.btn_sq.TabIndex = 0;
            this.btn_sq.Text = "Stack and Queue";
            this.btn_sq.UseVisualStyleBackColor = true;
            this.btn_sq.Click += new System.EventHandler(this.btn_sq_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(309, 136);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(94, 29);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Add Last";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(241, 189);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(94, 29);
            this.btn_remove.TabIndex = 2;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_find
            // 
            this.btn_find.Location = new System.Drawing.Point(152, 250);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(94, 29);
            this.btn_find.TabIndex = 3;
            this.btn_find.Text = "Find";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_Disp
            // 
            this.btn_Disp.Location = new System.Drawing.Point(309, 250);
            this.btn_Disp.Name = "btn_Disp";
            this.btn_Disp.Size = new System.Drawing.Size(94, 29);
            this.btn_Disp.TabIndex = 4;
            this.btn_Disp.Text = "Display";
            this.btn_Disp.UseVisualStyleBackColor = true;
            this.btn_Disp.Click += new System.EventHandler(this.btn_Disp_Click);
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(121, 79);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(125, 27);
            this.txtCourseName.TabIndex = 5;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(309, 81);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(125, 27);
            this.txtScore.TabIndex = 6;
            // 
            // lblLinkedList
            // 
            this.lblLinkedList.FormattingEnabled = true;
            this.lblLinkedList.ItemHeight = 20;
            this.lblLinkedList.Location = new System.Drawing.Point(565, 59);
            this.lblLinkedList.Name = "lblLinkedList";
            this.lblLinkedList.Size = new System.Drawing.Size(181, 124);
            this.lblLinkedList.TabIndex = 7;
            // 
            // btnAddfirst
            // 
            this.btnAddfirst.Location = new System.Drawing.Point(152, 136);
            this.btnAddfirst.Name = "btnAddfirst";
            this.btnAddfirst.Size = new System.Drawing.Size(94, 29);
            this.btnAddfirst.TabIndex = 8;
            this.btnAddfirst.Text = "Add First";
            this.btnAddfirst.UseVisualStyleBackColor = true;
            this.btnAddfirst.Click += new System.EventHandler(this.btnAddfirst_Click);
            // 
            // btnremovefirst
            // 
            this.btnremovefirst.Location = new System.Drawing.Point(99, 189);
            this.btnremovefirst.Name = "btnremovefirst";
            this.btnremovefirst.Size = new System.Drawing.Size(127, 29);
            this.btnremovefirst.TabIndex = 9;
            this.btnremovefirst.Text = "Remove First";
            this.btnremovefirst.UseVisualStyleBackColor = true;
            this.btnremovefirst.Click += new System.EventHandler(this.btnremovefirst_Click);
            // 
            // btnremovelast
            // 
            this.btnremovelast.Location = new System.Drawing.Point(354, 189);
            this.btnremovelast.Name = "btnremovelast";
            this.btnremovelast.Size = new System.Drawing.Size(128, 29);
            this.btnremovelast.TabIndex = 10;
            this.btnremovelast.Text = "Remove Last";
            this.btnremovelast.UseVisualStyleBackColor = true;
            this.btnremovelast.Click += new System.EventHandler(this.btnremovelast_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnremovelast);
            this.Controls.Add(this.btnremovefirst);
            this.Controls.Add(this.btnAddfirst);
            this.Controls.Add(this.lblLinkedList);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.btn_Disp);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_sq);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_sq;
        private Button btn_Add;
        private Button btn_remove;
        private Button btn_find;
        private Button btn_Disp;
        private TextBox txtCourseName;
        private TextBox txtScore;
        private ListBox lblLinkedList;
        private Button btnAddfirst;
        private Button btnremovefirst;
        private Button btnremovelast;
    }
}