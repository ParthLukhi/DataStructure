namespace Lab4_HT_DT
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
            this.btn_form2 = new System.Windows.Forms.Button();
            this.SortedSet1 = new System.Windows.Forms.ListBox();
            this.SortedSet2 = new System.Windows.Forms.ListBox();
            this.btnremove_ss1 = new System.Windows.Forms.Button();
            this.text_ss = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.btn_super = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_union = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_disp = new System.Windows.Forms.Button();
            this.btn_addss = new System.Windows.Forms.Button();
            this.btn_addss2 = new System.Windows.Forms.Button();
            this.btn_removess2 = new System.Windows.Forms.Button();
            this.btn_inter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_form2
            // 
            this.btn_form2.Location = new System.Drawing.Point(658, 391);
            this.btn_form2.Name = "btn_form2";
            this.btn_form2.Size = new System.Drawing.Size(94, 29);
            this.btn_form2.TabIndex = 0;
            this.btn_form2.Text = "Form2";
            this.btn_form2.UseVisualStyleBackColor = true;
            this.btn_form2.Click += new System.EventHandler(this.btn_form2_Click);
            // 
            // SortedSet1
            // 
            this.SortedSet1.FormattingEnabled = true;
            this.SortedSet1.ItemHeight = 20;
            this.SortedSet1.Location = new System.Drawing.Point(41, 46);
            this.SortedSet1.Name = "SortedSet1";
            this.SortedSet1.Size = new System.Drawing.Size(150, 104);
            this.SortedSet1.TabIndex = 1;
            // 
            // SortedSet2
            // 
            this.SortedSet2.FormattingEnabled = true;
            this.SortedSet2.ItemHeight = 20;
            this.SortedSet2.Location = new System.Drawing.Point(602, 46);
            this.SortedSet2.Name = "SortedSet2";
            this.SortedSet2.Size = new System.Drawing.Size(150, 104);
            this.SortedSet2.TabIndex = 2;
            // 
            // btnremove_ss1
            // 
            this.btnremove_ss1.Location = new System.Drawing.Point(145, 208);
            this.btnremove_ss1.Name = "btnremove_ss1";
            this.btnremove_ss1.Size = new System.Drawing.Size(79, 29);
            this.btnremove_ss1.TabIndex = 20;
            this.btnremove_ss1.Text = "Remove";
            this.btnremove_ss1.UseVisualStyleBackColor = true;
            this.btnremove_ss1.Click += new System.EventHandler(this.btnremove_ss1_Click);
            // 
            // text_ss
            // 
            this.text_ss.Location = new System.Drawing.Point(295, 209);
            this.text_ss.Name = "text_ss";
            this.text_ss.Size = new System.Drawing.Size(187, 27);
            this.text_ss.TabIndex = 19;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(365, 173);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(49, 20);
            this.lbl.TabIndex = 18;
            this.lbl.Text = "Result";
            // 
            // btn_super
            // 
            this.btn_super.Location = new System.Drawing.Point(424, 119);
            this.btn_super.Name = "btn_super";
            this.btn_super.Size = new System.Drawing.Size(94, 31);
            this.btn_super.TabIndex = 17;
            this.btn_super.Text = "SuperSet?";
            this.btn_super.UseVisualStyleBackColor = true;
            this.btn_super.Click += new System.EventHandler(this.btn_super_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(263, 119);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(94, 29);
            this.btn_sub.TabIndex = 16;
            this.btn_sub.Text = "SubSet?";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_union
            // 
            this.btn_union.Location = new System.Drawing.Point(424, 84);
            this.btn_union.Name = "btn_union";
            this.btn_union.Size = new System.Drawing.Size(94, 29);
            this.btn_union.TabIndex = 15;
            this.btn_union.Text = "Union";
            this.btn_union.UseVisualStyleBackColor = true;
            this.btn_union.Click += new System.EventHandler(this.btn_union_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(424, 49);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(94, 29);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_disp
            // 
            this.btn_disp.Location = new System.Drawing.Point(263, 49);
            this.btn_disp.Name = "btn_disp";
            this.btn_disp.Size = new System.Drawing.Size(94, 29);
            this.btn_disp.TabIndex = 12;
            this.btn_disp.Text = "Display";
            this.btn_disp.UseVisualStyleBackColor = true;
            this.btn_disp.Click += new System.EventHandler(this.btn_disp_Click);
            // 
            // btn_addss
            // 
            this.btn_addss.Location = new System.Drawing.Point(33, 208);
            this.btn_addss.Name = "btn_addss";
            this.btn_addss.Size = new System.Drawing.Size(94, 29);
            this.btn_addss.TabIndex = 21;
            this.btn_addss.Text = "Add";
            this.btn_addss.UseVisualStyleBackColor = true;
            this.btn_addss.Click += new System.EventHandler(this.btn_addss_Click);
            // 
            // btn_addss2
            // 
            this.btn_addss2.Location = new System.Drawing.Point(562, 208);
            this.btn_addss2.Name = "btn_addss2";
            this.btn_addss2.Size = new System.Drawing.Size(94, 29);
            this.btn_addss2.TabIndex = 23;
            this.btn_addss2.Text = "Add";
            this.btn_addss2.UseVisualStyleBackColor = true;
            this.btn_addss2.Click += new System.EventHandler(this.btn_addss2_Click);
            // 
            // btn_removess2
            // 
            this.btn_removess2.Location = new System.Drawing.Point(674, 208);
            this.btn_removess2.Name = "btn_removess2";
            this.btn_removess2.Size = new System.Drawing.Size(79, 29);
            this.btn_removess2.TabIndex = 22;
            this.btn_removess2.Text = "Remove";
            this.btn_removess2.UseVisualStyleBackColor = true;
            this.btn_removess2.Click += new System.EventHandler(this.btn_removess2_Click);
            // 
            // btn_inter
            // 
            this.btn_inter.Location = new System.Drawing.Point(263, 82);
            this.btn_inter.Name = "btn_inter";
            this.btn_inter.Size = new System.Drawing.Size(94, 33);
            this.btn_inter.TabIndex = 24;
            this.btn_inter.Text = "Intersect";
            this.btn_inter.UseVisualStyleBackColor = true;
            this.btn_inter.Click += new System.EventHandler(this.btn_inter_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_inter);
            this.Controls.Add(this.btn_addss2);
            this.Controls.Add(this.btn_removess2);
            this.Controls.Add(this.btn_addss);
            this.Controls.Add(this.btnremove_ss1);
            this.Controls.Add(this.text_ss);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btn_super);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_union);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_disp);
            this.Controls.Add(this.SortedSet2);
            this.Controls.Add(this.SortedSet1);
            this.Controls.Add(this.btn_form2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_form2;
        private ListBox SortedSet1;
        private ListBox SortedSet2;
        private Button btnremove_ss1;
        private TextBox text_ss;
        private Label lbl;
        private Button btn_super;
        private Button btn_sub;
        private Button btn_union;
        private Button btn_clear;
        private Button btn_disp;
        private Button btn_addss;
        private Button btn_addss2;
        private Button btn_removess2;
        private Button btn_inter;
    }
}