namespace WinFormsApp2
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
            btnBrowse = new Button();
            btnSubmit = new Button();
            btnExit = new Button();
            listBox1 = new ListBox();
            txtFileName = new TextBox();
            labelBook1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            btnBrowse2 = new Button();
            btnSubmit2 = new Button();
            btnExit2 = new Button();
            listBox2 = new ListBox();
            textBox1 = new TextBox();
            label1 = new Label();
            openFileDialog2 = new OpenFileDialog();
            SuspendLayout();
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(559, 44);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(112, 34);
            btnBrowse.TabIndex = 0;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(559, 345);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(426, 345);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(197, 100);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(474, 229);
            listBox1.TabIndex = 3;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(326, 44);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(212, 31);
            txtFileName.TabIndex = 4;
            // 
            // labelBook1
            // 
            labelBook1.AutoSize = true;
            labelBook1.Location = new Point(252, 49);
            labelBook1.Name = "labelBook1";
            labelBook1.Size = new Size(68, 25);
            labelBook1.TabIndex = 5;
            labelBook1.Text = "Book 1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowse2
            // 
            btnBrowse2.Location = new Point(1192, 49);
            btnBrowse2.Name = "btnBrowse2";
            btnBrowse2.Size = new Size(112, 34);
            btnBrowse2.TabIndex = 6;
            btnBrowse2.Text = "Browse";
            btnBrowse2.UseVisualStyleBackColor = true;
            btnBrowse2.Click += btnBrowse2_Click;
            // 
            // btnSubmit2
            // 
            btnSubmit2.Location = new Point(1192, 359);
            btnSubmit2.Name = "btnSubmit2";
            btnSubmit2.Size = new Size(112, 34);
            btnSubmit2.TabIndex = 7;
            btnSubmit2.Text = "Submit";
            btnSubmit2.UseVisualStyleBackColor = true;
            btnSubmit2.Click += btnSubmit2_Click;
            // 
            // btnExit2
            // 
            btnExit2.Location = new Point(1044, 359);
            btnExit2.Name = "btnExit2";
            btnExit2.Size = new Size(112, 34);
            btnExit2.TabIndex = 8;
            btnExit2.Text = "Exit";
            btnExit2.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(830, 100);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(474, 229);
            listBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(946, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 31);
            textBox1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(861, 58);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 11;
            label1.Text = "Book 2";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1386, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(listBox2);
            Controls.Add(btnExit2);
            Controls.Add(btnSubmit2);
            Controls.Add(btnBrowse2);
            Controls.Add(labelBook1);
            Controls.Add(txtFileName);
            Controls.Add(listBox1);
            Controls.Add(btnExit);
            Controls.Add(btnSubmit);
            Controls.Add(btnBrowse);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowse;
        private Button btnSubmit;
        private Button btnExit;
        private ListBox listBox1;
        private TextBox txtFileName;
        private Label labelBook1;
        private OpenFileDialog openFileDialog1;
        private Button btnBrowse2;
        private Button btnSubmit2;
        private Button btnExit2;
        private ListBox listBox2;
        private TextBox textBox1;
        private Label label1;
        private OpenFileDialog openFileDialog2;
    }
}