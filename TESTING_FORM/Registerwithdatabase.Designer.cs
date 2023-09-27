namespace TESTING_FORM
{
    partial class Registerwithdatabase
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            textBox_name = new TextBox();
            textBox_email = new TextBox();
            textBox_password = new TextBox();
            button1 = new Button();
            button_back = new Button();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            textBox_id = new TextBox();
            button_delete = new Button();
            button_update = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(306, 101);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "NAME:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 136);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "EMAIL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 174);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "PASSWORD:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 219);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 3;
            label4.Text = "COUNTRY:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Select Country", "PHILIPPINESS", "USA", "JAPAN", "CHINA" });
            comboBox1.Location = new Point(371, 211);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(371, 98);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(121, 23);
            textBox_name.TabIndex = 5;
            textBox_name.TextChanged += textBox_name_TextChanged;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(371, 136);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(121, 23);
            textBox_email.TabIndex = 6;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(371, 174);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(121, 23);
            textBox_password.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(286, 261);
            button1.Name = "button1";
            button1.Size = new Size(206, 30);
            button1.TabIndex = 8;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(56, 338);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 11;
            label5.Text = "Display User";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 384);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(787, 292);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
          
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(371, 60);
            textBox_id.Name = "textBox_id";
            textBox_id.ReadOnly = true;
            textBox_id.Size = new Size(37, 23);
            textBox_id.TabIndex = 13;
            // 
            // button_delete
            // 
            button_delete.Location = new Point(540, 206);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(206, 30);
            button_delete.TabIndex = 14;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_update
            // 
            button_update.Location = new Point(540, 261);
            button_update.Name = "button_update";
            button_update.Size = new Size(206, 30);
            button_update.TabIndex = 15;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // Registerwithdatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 783);
            Controls.Add(button_update);
            Controls.Add(button_delete);
            Controls.Add(textBox_id);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(button_back);
            Controls.Add(button1);
            Controls.Add(textBox_password);
            Controls.Add(textBox_email);
            Controls.Add(textBox_name);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
   
            Text = "Registerwithdatabase";
            Load += Registerwithdatabase_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox_email;
        private TextBox textBox_password;
        private Button button1;
        private Button button_back;
        public TextBox textBox_name;
        private Label label5;
        private DataGridView dataGridView1;
        public TextBox textBox_id;
        private Button button_delete;
        private Button button_update;
    }
}