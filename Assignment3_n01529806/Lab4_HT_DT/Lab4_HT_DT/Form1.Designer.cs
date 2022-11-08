namespace Lab4_HT_DT
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
            this.txtkey = new System.Windows.Forms.TextBox();
            this.txtvalue = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDisp = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddDT = new System.Windows.Forms.Button();
            this.btnRemovedt = new System.Windows.Forms.Button();
            this.btndispDT = new System.Windows.Forms.Button();
            this.btnClearDT = new System.Windows.Forms.Button();
            this.lbxresult = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtscore = new System.Windows.Forms.TextBox();
            this.btnform2 = new System.Windows.Forms.Button();
            this.btn_value = new System.Windows.Forms.Button();
            this.btn_chkv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtkey
            // 
            this.txtkey.Location = new System.Drawing.Point(28, 66);
            this.txtkey.Name = "txtkey";
            this.txtkey.Size = new System.Drawing.Size(125, 27);
            this.txtkey.TabIndex = 0;
            // 
            // txtvalue
            // 
            this.txtvalue.Location = new System.Drawing.Point(175, 66);
            this.txtvalue.Name = "txtvalue";
            this.txtvalue.Size = new System.Drawing.Size(126, 27);
            this.txtvalue.TabIndex = 1;
            this.txtvalue.TextChanged += new System.EventHandler(this.txtvalue_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 157);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(128, 157);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 29);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDisp
            // 
            this.btnDisp.Location = new System.Drawing.Point(228, 157);
            this.btnDisp.Name = "btnDisp";
            this.btnDisp.Size = new System.Drawing.Size(94, 29);
            this.btnDisp.TabIndex = 4;
            this.btnDisp.Text = "Display";
            this.btnDisp.UseVisualStyleBackColor = true;
            this.btnDisp.Click += new System.EventHandler(this.btnDisp_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(328, 157);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddDT
            // 
            this.btnAddDT.Location = new System.Drawing.Point(28, 278);
            this.btnAddDT.Name = "btnAddDT";
            this.btnAddDT.Size = new System.Drawing.Size(94, 29);
            this.btnAddDT.TabIndex = 6;
            this.btnAddDT.Text = "Add";
            this.btnAddDT.UseVisualStyleBackColor = true;
            this.btnAddDT.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnRemovedt
            // 
            this.btnRemovedt.Location = new System.Drawing.Point(128, 278);
            this.btnRemovedt.Name = "btnRemovedt";
            this.btnRemovedt.Size = new System.Drawing.Size(94, 29);
            this.btnRemovedt.TabIndex = 7;
            this.btnRemovedt.Text = "Remove";
            this.btnRemovedt.UseVisualStyleBackColor = true;
            this.btnRemovedt.Click += new System.EventHandler(this.btnRemovedt_Click);
            // 
            // btndispDT
            // 
            this.btndispDT.Location = new System.Drawing.Point(228, 278);
            this.btndispDT.Name = "btndispDT";
            this.btndispDT.Size = new System.Drawing.Size(94, 29);
            this.btndispDT.TabIndex = 8;
            this.btndispDT.Text = "Display";
            this.btndispDT.UseVisualStyleBackColor = true;
            this.btndispDT.Click += new System.EventHandler(this.btndispDT_Click);
            // 
            // btnClearDT
            // 
            this.btnClearDT.Location = new System.Drawing.Point(328, 278);
            this.btnClearDT.Name = "btnClearDT";
            this.btnClearDT.Size = new System.Drawing.Size(81, 29);
            this.btnClearDT.TabIndex = 9;
            this.btnClearDT.Text = "Clear";
            this.btnClearDT.UseVisualStyleBackColor = true;
            this.btnClearDT.Click += new System.EventHandler(this.btnClearDT_Click);
            // 
            // lbxresult
            // 
            this.lbxresult.FormattingEnabled = true;
            this.lbxresult.ItemHeight = 20;
            this.lbxresult.Location = new System.Drawing.Point(595, 66);
            this.lbxresult.Name = "lbxresult";
            this.lbxresult.Size = new System.Drawing.Size(150, 104);
            this.lbxresult.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "HashTable";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Dictionery";
            // 
            // txtscore
            // 
            this.txtscore.Location = new System.Drawing.Point(307, 66);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(125, 27);
            this.txtscore.TabIndex = 15;
            // 
            // btnform2
            // 
            this.btnform2.Location = new System.Drawing.Point(630, 388);
            this.btnform2.Name = "btnform2";
            this.btnform2.Size = new System.Drawing.Size(94, 29);
            this.btnform2.TabIndex = 16;
            this.btnform2.Text = "Form2";
            this.btnform2.UseVisualStyleBackColor = true;
            this.btnform2.Click += new System.EventHandler(this.btnform2_Click);
            // 
            // btn_value
            // 
            this.btn_value.Location = new System.Drawing.Point(428, 157);
            this.btn_value.Name = "btn_value";
            this.btn_value.Size = new System.Drawing.Size(94, 29);
            this.btn_value.TabIndex = 17;
            this.btn_value.Text = "Values";
            this.btn_value.UseVisualStyleBackColor = true;
            this.btn_value.Click += new System.EventHandler(this.btn_value_Click);
            // 
            // btn_chkv
            // 
            this.btn_chkv.Location = new System.Drawing.Point(415, 278);
            this.btn_chkv.Name = "btn_chkv";
            this.btn_chkv.Size = new System.Drawing.Size(118, 29);
            this.btn_chkv.TabIndex = 18;
            this.btn_chkv.Text = "Check Value";
            this.btn_chkv.UseVisualStyleBackColor = true;
            this.btn_chkv.Click += new System.EventHandler(this.btn_chkv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_chkv);
            this.Controls.Add(this.btn_value);
            this.Controls.Add(this.btnform2);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxresult);
            this.Controls.Add(this.btnClearDT);
            this.Controls.Add(this.btndispDT);
            this.Controls.Add(this.btnRemovedt);
            this.Controls.Add(this.btnAddDT);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisp);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtvalue);
            this.Controls.Add(this.txtkey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtkey;
        private TextBox txtvalue;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnDisp;
        private Button btnClear;
        private Button btnAddDT;
        private Button btnRemovedt;
        private Button btndispDT;
        private Button btnClearDT;
        private ListBox lbxresult;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtscore;
        private Button btnform2;
        private Button btn_value;
        private Button btn_chkv;
    }
}