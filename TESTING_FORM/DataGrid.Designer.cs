namespace TESTING_FORM
{
    partial class DataGrid
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
            listBox1 = new ListBox();
            button_add = new Button();
            listBox2 = new ListBox();
            button_remove = new Button();
            button_addall = new Button();
            button_removeall = new Button();
            button_finalize = new Button();
            dataGridView1 = new DataGridView();
            button_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(72, 69);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(199, 244);
            listBox1.TabIndex = 0;
            // 
            // button_add
            // 
            button_add.Location = new Point(355, 69);
            button_add.Name = "button_add";
            button_add.Size = new Size(90, 44);
            button_add.TabIndex = 2;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(517, 69);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(199, 244);
            listBox2.TabIndex = 3;
            // 
            // button_remove
            // 
            button_remove.Location = new Point(355, 119);
            button_remove.Name = "button_remove";
            button_remove.Size = new Size(90, 44);
            button_remove.TabIndex = 4;
            button_remove.Text = "Remove";
            button_remove.UseVisualStyleBackColor = true;
            button_remove.Click += button_remove_Click;
            // 
            // button_addall
            // 
            button_addall.Location = new Point(355, 169);
            button_addall.Name = "button_addall";
            button_addall.Size = new Size(90, 44);
            button_addall.TabIndex = 5;
            button_addall.Text = "Add All";
            button_addall.UseVisualStyleBackColor = true;
            // 
            // button_removeall
            // 
            button_removeall.Location = new Point(355, 219);
            button_removeall.Name = "button_removeall";
            button_removeall.Size = new Size(90, 44);
            button_removeall.TabIndex = 6;
            button_removeall.Text = "Remove All";
            button_removeall.UseVisualStyleBackColor = true;
            // 
            // button_finalize
            // 
            button_finalize.Location = new Point(355, 269);
            button_finalize.Name = "button_finalize";
            button_finalize.Size = new Size(90, 44);
            button_finalize.TabIndex = 7;
            button_finalize.Text = "Finalize";
            button_finalize.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 328);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(749, 150);
            dataGridView1.TabIndex = 8;
            // 
            // button_back
            // 
            button_back.Location = new Point(12, 12);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 23);
            button_back.TabIndex = 9;
            button_back.Text = "back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // DataGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 561);
            Controls.Add(button_back);
            Controls.Add(dataGridView1);
            Controls.Add(button_finalize);
            Controls.Add(button_removeall);
            Controls.Add(button_addall);
            Controls.Add(button_remove);
            Controls.Add(listBox2);
            Controls.Add(button_add);
            Controls.Add(listBox1);
            Name = "DataGrid";
            Text = "DataGrid";
            Load += DataGrid_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button_add;
        private ListBox listBox2;
        private Button button_remove;
        private Button button_addall;
        private Button button_removeall;
        private Button button_finalize;
        private DataGridView dataGridView1;
        private Button button_back;
    }
}