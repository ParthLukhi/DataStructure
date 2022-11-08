namespace Lab4_HT_DT
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
            this.HSet1 = new System.Windows.Forms.ListBox();
            this.HSet2 = new System.Windows.Forms.ListBox();
            this.btndisp = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnintersect = new System.Windows.Forms.Button();
            this.btnunion = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnsuper = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnadd_hs1 = new System.Windows.Forms.Button();
            this.btnremove_hs1 = new System.Windows.Forms.Button();
            this.btnadd_hs2 = new System.Windows.Forms.Button();
            this.btnremove_hs2 = new System.Windows.Forms.Button();
            this.btnform1 = new System.Windows.Forms.Button();
            this.btn_form3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HSet1
            // 
            this.HSet1.FormattingEnabled = true;
            this.HSet1.ItemHeight = 20;
            this.HSet1.Location = new System.Drawing.Point(46, 33);
            this.HSet1.Name = "HSet1";
            this.HSet1.Size = new System.Drawing.Size(167, 124);
            this.HSet1.TabIndex = 0;
            // 
            // HSet2
            // 
            this.HSet2.FormattingEnabled = true;
            this.HSet2.ItemHeight = 20;
            this.HSet2.Location = new System.Drawing.Point(570, 33);
            this.HSet2.Name = "HSet2";
            this.HSet2.Size = new System.Drawing.Size(177, 124);
            this.HSet2.TabIndex = 1;
            // 
            // btndisp
            // 
            this.btndisp.Location = new System.Drawing.Point(264, 33);
            this.btndisp.Name = "btndisp";
            this.btndisp.Size = new System.Drawing.Size(94, 29);
            this.btndisp.TabIndex = 2;
            this.btndisp.Text = "Display";
            this.btndisp.UseVisualStyleBackColor = true;
            this.btndisp.Click += new System.EventHandler(this.btndisp_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(425, 33);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(94, 29);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnintersect
            // 
            this.btnintersect.Location = new System.Drawing.Point(264, 68);
            this.btnintersect.Name = "btnintersect";
            this.btnintersect.Size = new System.Drawing.Size(94, 29);
            this.btnintersect.TabIndex = 4;
            this.btnintersect.Text = "Intersection";
            this.btnintersect.UseVisualStyleBackColor = true;
            this.btnintersect.Click += new System.EventHandler(this.btnintersect_Click);
            // 
            // btnunion
            // 
            this.btnunion.Location = new System.Drawing.Point(425, 68);
            this.btnunion.Name = "btnunion";
            this.btnunion.Size = new System.Drawing.Size(94, 29);
            this.btnunion.TabIndex = 5;
            this.btnunion.Text = "Union";
            this.btnunion.UseVisualStyleBackColor = true;
            this.btnunion.Click += new System.EventHandler(this.btnunion_Click);
            // 
            // btnsub
            // 
            this.btnsub.Location = new System.Drawing.Point(264, 103);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(94, 29);
            this.btnsub.TabIndex = 6;
            this.btnsub.Text = "SubSet?";
            this.btnsub.UseVisualStyleBackColor = true;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnsuper
            // 
            this.btnsuper.Location = new System.Drawing.Point(425, 103);
            this.btnsuper.Name = "btnsuper";
            this.btnsuper.Size = new System.Drawing.Size(94, 31);
            this.btnsuper.TabIndex = 7;
            this.btnsuper.Text = "SuperSet?";
            this.btnsuper.UseVisualStyleBackColor = true;
            this.btnsuper.Click += new System.EventHandler(this.btnsuper_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Result";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 197);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 27);
            this.textBox1.TabIndex = 9;
            // 
            // btnadd_hs1
            // 
            this.btnadd_hs1.Location = new System.Drawing.Point(46, 195);
            this.btnadd_hs1.Name = "btnadd_hs1";
            this.btnadd_hs1.Size = new System.Drawing.Size(94, 29);
            this.btnadd_hs1.TabIndex = 10;
            this.btnadd_hs1.Text = "Add";
            this.btnadd_hs1.UseVisualStyleBackColor = true;
            this.btnadd_hs1.Click += new System.EventHandler(this.btnadd_hs1_Click);
            // 
            // btnremove_hs1
            // 
            this.btnremove_hs1.Location = new System.Drawing.Point(146, 195);
            this.btnremove_hs1.Name = "btnremove_hs1";
            this.btnremove_hs1.Size = new System.Drawing.Size(79, 29);
            this.btnremove_hs1.TabIndex = 11;
            this.btnremove_hs1.Text = "Remove";
            this.btnremove_hs1.UseVisualStyleBackColor = true;
            this.btnremove_hs1.Click += new System.EventHandler(this.btnremove_hs1_Click);
            // 
            // btnadd_hs2
            // 
            this.btnadd_hs2.Location = new System.Drawing.Point(553, 197);
            this.btnadd_hs2.Name = "btnadd_hs2";
            this.btnadd_hs2.Size = new System.Drawing.Size(94, 29);
            this.btnadd_hs2.TabIndex = 12;
            this.btnadd_hs2.Text = "Add";
            this.btnadd_hs2.UseVisualStyleBackColor = true;
            this.btnadd_hs2.Click += new System.EventHandler(this.btnadd_hs2_Click);
            // 
            // btnremove_hs2
            // 
            this.btnremove_hs2.Location = new System.Drawing.Point(653, 197);
            this.btnremove_hs2.Name = "btnremove_hs2";
            this.btnremove_hs2.Size = new System.Drawing.Size(94, 29);
            this.btnremove_hs2.TabIndex = 13;
            this.btnremove_hs2.Text = "Remove";
            this.btnremove_hs2.UseVisualStyleBackColor = true;
            this.btnremove_hs2.Click += new System.EventHandler(this.btnremove_hs2_Click);
            // 
            // btnform1
            // 
            this.btnform1.Location = new System.Drawing.Point(553, 386);
            this.btnform1.Name = "btnform1";
            this.btnform1.Size = new System.Drawing.Size(94, 29);
            this.btnform1.TabIndex = 14;
            this.btnform1.Text = "Form1";
            this.btnform1.UseVisualStyleBackColor = true;
            this.btnform1.Click += new System.EventHandler(this.btnform1_Click);
            // 
            // btn_form3
            // 
            this.btn_form3.Location = new System.Drawing.Point(653, 386);
            this.btn_form3.Name = "btn_form3";
            this.btn_form3.Size = new System.Drawing.Size(94, 29);
            this.btn_form3.TabIndex = 15;
            this.btn_form3.Text = "Form3";
            this.btn_form3.UseVisualStyleBackColor = true;
            this.btn_form3.Click += new System.EventHandler(this.btn_form3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_form3);
            this.Controls.Add(this.btnform1);
            this.Controls.Add(this.btnremove_hs2);
            this.Controls.Add(this.btnadd_hs2);
            this.Controls.Add(this.btnremove_hs1);
            this.Controls.Add(this.btnadd_hs1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsuper);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnunion);
            this.Controls.Add(this.btnintersect);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndisp);
            this.Controls.Add(this.HSet2);
            this.Controls.Add(this.HSet1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox HSet1;
        private ListBox HSet2;
        private Button btndisp;
        private Button btnclear;
        private Button btnintersect;
        private Button btnunion;
        private Button btnsub;
        private Button btnsuper;
        private Label label1;
        private TextBox textBox1;
        private Button btnadd_hs1;
        private Button btnremove_hs1;
        private Button btnadd_hs2;
        private Button btnremove_hs2;
        private Button btnform1;
        private Button btn_form3;
    }
}