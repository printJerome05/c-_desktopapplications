namespace TESTING_FORM
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
            label1 = new Label();
            label2 = new Label();
            btn_set = new Button();
            btn_cancel = new Button();
            btn_logout = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(370, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "TEST";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(788, 161);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // btn_set
            // 
            btn_set.Location = new Point(778, 207);
            btn_set.Name = "btn_set";
            btn_set.Size = new Size(75, 23);
            btn_set.TabIndex = 2;
            btn_set.Text = "SET";
            btn_set.UseVisualStyleBackColor = true;
            btn_set.Click += btn_set_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(859, 207);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 3;
            btn_cancel.Text = "CANCEL";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_logout
            // 
            btn_logout.Location = new Point(12, 5);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(75, 23);
            btn_logout.TabIndex = 4;
            btn_logout.Text = "LOGOUT";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(316, 458);
            dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 738);
            Controls.Add(dataGridView1);
            Controls.Add(btn_logout);
            Controls.Add(btn_cancel);
            Controls.Add(btn_set);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "MainForm";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_set;
        private Button btn_cancel;
        private Button btn_logout;
        private DataGridView dataGridView1;
    }
}