namespace Lab2_StackQueue
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
            this.lblstack = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtscore = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btndisp = new System.Windows.Forms.Button();
            this.lbxStack = new System.Windows.Forms.ListBox();
            this.lbxQueue = new System.Windows.Forms.ListBox();
            this.lblQueue = new System.Windows.Forms.Label();
            this.txtnamequeue = new System.Windows.Forms.TextBox();
            this.txtscorequeue = new System.Windows.Forms.TextBox();
            this.btnenqueue = new System.Windows.Forms.Button();
            this.btndequeue = new System.Windows.Forms.Button();
            this.btndispq = new System.Windows.Forms.Button();
            this.btn_ll = new System.Windows.Forms.Button();
            this.btnpeek = new System.Windows.Forms.Button();
            this.btnpeekstack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblstack
            // 
            this.lblstack.AutoSize = true;
            this.lblstack.Location = new System.Drawing.Point(138, 29);
            this.lblstack.Name = "lblstack";
            this.lblstack.Size = new System.Drawing.Size(44, 20);
            this.lblstack.TabIndex = 0;
            this.lblstack.Text = "Stack";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(23, 75);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(125, 27);
            this.txtname.TabIndex = 1;
            // 
            // txtscore
            // 
            this.txtscore.Location = new System.Drawing.Point(177, 75);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(125, 27);
            this.txtscore.TabIndex = 2;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(43, 131);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(94, 29);
            this.btnPush.TabIndex = 3;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(195, 131);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(94, 29);
            this.btnPop.TabIndex = 4;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // btndisp
            // 
            this.btndisp.Location = new System.Drawing.Point(351, 120);
            this.btndisp.Name = "btndisp";
            this.btndisp.Size = new System.Drawing.Size(94, 29);
            this.btndisp.TabIndex = 5;
            this.btndisp.Text = "Dispaly";
            this.btndisp.UseVisualStyleBackColor = true;
            this.btndisp.Click += new System.EventHandler(this.btndisp_Click);
            // 
            // lbxStack
            // 
            this.lbxStack.FormattingEnabled = true;
            this.lbxStack.ItemHeight = 20;
            this.lbxStack.Location = new System.Drawing.Point(520, 36);
            this.lbxStack.Name = "lbxStack";
            this.lbxStack.Size = new System.Drawing.Size(227, 124);
            this.lbxStack.TabIndex = 6;
            // 
            // lbxQueue
            // 
            this.lbxQueue.FormattingEnabled = true;
            this.lbxQueue.ItemHeight = 20;
            this.lbxQueue.Location = new System.Drawing.Point(518, 218);
            this.lbxQueue.Name = "lbxQueue";
            this.lbxQueue.Size = new System.Drawing.Size(229, 124);
            this.lbxQueue.TabIndex = 7;
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Location = new System.Drawing.Point(138, 203);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(52, 20);
            this.lblQueue.TabIndex = 8;
            this.lblQueue.Text = "Queue";
            // 
            // txtnamequeue
            // 
            this.txtnamequeue.Location = new System.Drawing.Point(23, 246);
            this.txtnamequeue.Name = "txtnamequeue";
            this.txtnamequeue.Size = new System.Drawing.Size(125, 27);
            this.txtnamequeue.TabIndex = 9;
            // 
            // txtscorequeue
            // 
            this.txtscorequeue.Location = new System.Drawing.Point(177, 246);
            this.txtscorequeue.Name = "txtscorequeue";
            this.txtscorequeue.Size = new System.Drawing.Size(125, 27);
            this.txtscorequeue.TabIndex = 10;
            // 
            // btnenqueue
            // 
            this.btnenqueue.Location = new System.Drawing.Point(43, 313);
            this.btnenqueue.Name = "btnenqueue";
            this.btnenqueue.Size = new System.Drawing.Size(94, 29);
            this.btnenqueue.TabIndex = 11;
            this.btnenqueue.Text = "EnQueue";
            this.btnenqueue.UseVisualStyleBackColor = true;
            this.btnenqueue.Click += new System.EventHandler(this.btnenqueue_Click);
            // 
            // btndequeue
            // 
            this.btndequeue.Location = new System.Drawing.Point(195, 313);
            this.btndequeue.Name = "btndequeue";
            this.btndequeue.Size = new System.Drawing.Size(94, 29);
            this.btndequeue.TabIndex = 12;
            this.btndequeue.Text = "DeQueueu";
            this.btndequeue.UseVisualStyleBackColor = true;
            this.btndequeue.Click += new System.EventHandler(this.btndequeue_Click);
            // 
            // btndispq
            // 
            this.btndispq.Location = new System.Drawing.Point(351, 313);
            this.btndispq.Name = "btndispq";
            this.btndispq.Size = new System.Drawing.Size(94, 29);
            this.btndispq.TabIndex = 13;
            this.btndispq.Text = "Display";
            this.btndispq.UseVisualStyleBackColor = true;
            this.btndispq.Click += new System.EventHandler(this.btndispq_Click);
            // 
            // btn_ll
            // 
            this.btn_ll.Location = new System.Drawing.Point(653, 399);
            this.btn_ll.Name = "btn_ll";
            this.btn_ll.Size = new System.Drawing.Size(94, 29);
            this.btn_ll.TabIndex = 14;
            this.btn_ll.Text = "LinkedList";
            this.btn_ll.UseVisualStyleBackColor = true;
            this.btn_ll.Click += new System.EventHandler(this.btn_ll_Click);
            // 
            // btnpeek
            // 
            this.btnpeek.Location = new System.Drawing.Point(351, 246);
            this.btnpeek.Name = "btnpeek";
            this.btnpeek.Size = new System.Drawing.Size(94, 29);
            this.btnpeek.TabIndex = 15;
            this.btnpeek.Text = "Peek";
            this.btnpeek.UseVisualStyleBackColor = true;
            this.btnpeek.Click += new System.EventHandler(this.btnpeek_Click);
            // 
            // btnpeekstack
            // 
            this.btnpeekstack.Location = new System.Drawing.Point(351, 57);
            this.btnpeekstack.Name = "btnpeekstack";
            this.btnpeekstack.Size = new System.Drawing.Size(94, 29);
            this.btnpeekstack.TabIndex = 16;
            this.btnpeekstack.Text = "Peek";
            this.btnpeekstack.UseVisualStyleBackColor = true;
            this.btnpeekstack.Click += new System.EventHandler(this.btnpeekstack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnpeekstack);
            this.Controls.Add(this.btnpeek);
            this.Controls.Add(this.btn_ll);
            this.Controls.Add(this.btndispq);
            this.Controls.Add(this.btndequeue);
            this.Controls.Add(this.btnenqueue);
            this.Controls.Add(this.txtscorequeue);
            this.Controls.Add(this.txtnamequeue);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.lbxQueue);
            this.Controls.Add(this.lbxStack);
            this.Controls.Add(this.btndisp);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblstack);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblstack;
        private TextBox txtname;
        private TextBox txtscore;
        private Button btnPush;
        private Button btnPop;
        private Button btndisp;
        private ListBox lbxStack;
        private ListBox lbxQueue;
        private Label lblQueue;
        private TextBox txtnamequeue;
        private TextBox txtscorequeue;
        private Button btnenqueue;
        private Button btndequeue;
        private Button btndispq;
        private Button btn_ll;
        private Button btnpeek;
        private Button btnpeekstack;
    }
}