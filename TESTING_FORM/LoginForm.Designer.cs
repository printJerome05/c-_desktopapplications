﻿namespace TESTING_FORM
{
    partial class LoginForm
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
            textBox_id = new TextBox();
            textBox_pass = new TextBox();
            btn_login = new Button();
            btn_reset = new Button();
            button_reg = new Button();
            button1 = new Button();
            button_radio = new Button();
            button_dialogbox = new Button();
            button_book = new Button();
            button_datatables = new Button();
            button_datagrid = new Button();
            label3 = new Label();
            button_registerdatabase = new Button();
            label4 = new Label();
            textBox_emaildatabase = new TextBox();
            textBox_passworddatabase = new TextBox();
            label5 = new Label();
            label6 = new Label();
            button_logindatabase = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(564, 177);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 32);
            label1.TabIndex = 0;
            label1.Text = "User:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(505, 227);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 32);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(652, 183);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(282, 26);
            textBox_id.TabIndex = 2;
            // 
            // textBox_pass
            // 
            textBox_pass.Location = new Point(652, 233);
            textBox_pass.Name = "textBox_pass";
            textBox_pass.Size = new Size(282, 26);
            textBox_pass.TabIndex = 3;
            textBox_pass.UseSystemPasswordChar = true;
            textBox_pass.KeyPress += textBox_pass_KeyPress;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(652, 277);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(92, 32);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(842, 277);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(92, 32);
            btn_reset.TabIndex = 5;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // button_reg
            // 
            button_reg.Location = new Point(652, 329);
            button_reg.Name = "button_reg";
            button_reg.Size = new Size(92, 32);
            button_reg.TabIndex = 6;
            button_reg.Text = "Register";
            button_reg.UseVisualStyleBackColor = true;
            button_reg.Click += button_reg_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(121, 32);
            button1.TabIndex = 7;
            button1.Text = "Date and Time";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button_radio
            // 
            button_radio.Location = new Point(183, 12);
            button_radio.Name = "button_radio";
            button_radio.Size = new Size(145, 32);
            button_radio.TabIndex = 8;
            button_radio.Text = "Radio Buttons";
            button_radio.UseVisualStyleBackColor = true;
            button_radio.Click += button_radio_Click;
            // 
            // button_dialogbox
            // 
            button_dialogbox.Location = new Point(369, 12);
            button_dialogbox.Name = "button_dialogbox";
            button_dialogbox.Size = new Size(145, 32);
            button_dialogbox.TabIndex = 9;
            button_dialogbox.Text = "dialog Box";
            button_dialogbox.UseVisualStyleBackColor = true;
            button_dialogbox.Click += button_dialogbox_Click;
            // 
            // button_book
            // 
            button_book.Location = new Point(547, 12);
            button_book.Name = "button_book";
            button_book.Size = new Size(145, 32);
            button_book.TabIndex = 10;
            button_book.Text = "BOOK FLIGHT";
            button_book.UseVisualStyleBackColor = true;
            button_book.Click += button_book_Click;
            // 
            // button_datatables
            // 
            button_datatables.Location = new Point(715, 12);
            button_datatables.Name = "button_datatables";
            button_datatables.Size = new Size(145, 32);
            button_datatables.TabIndex = 11;
            button_datatables.Text = "DATA TABLES";
            button_datatables.UseVisualStyleBackColor = true;
            button_datatables.Click += button_datatables_Click;
            // 
            // button_datagrid
            // 
            button_datagrid.Location = new Point(872, 12);
            button_datagrid.Name = "button_datagrid";
            button_datagrid.Size = new Size(145, 32);
            button_datagrid.TabIndex = 12;
            button_datagrid.Text = "DATA GRID";
            button_datagrid.UseVisualStyleBackColor = true;
            button_datagrid.Click += button_datagrid_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(676, 136);
            label3.Name = "label3";
            label3.Size = new Size(234, 32);
            label3.TabIndex = 13;
            label3.Text = "Without Database";
            // 
            // button_registerdatabase
            // 
            button_registerdatabase.Location = new Point(87, 345);
            button_registerdatabase.Name = "button_registerdatabase";
            button_registerdatabase.Size = new Size(202, 32);
            button_registerdatabase.TabIndex = 14;
            button_registerdatabase.Text = "Register with database";
            button_registerdatabase.UseVisualStyleBackColor = true;
            button_registerdatabase.Click += button_registerdatabase_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(78, 136);
            label4.Name = "label4";
            label4.Size = new Size(241, 31);
            label4.TabIndex = 15;
            label4.Text = "login with database";
            // 
            // textBox_emaildatabase
            // 
            textBox_emaildatabase.Location = new Point(56, 199);
            textBox_emaildatabase.Name = "textBox_emaildatabase";
            textBox_emaildatabase.Size = new Size(282, 26);
            textBox_emaildatabase.TabIndex = 16;
            textBox_emaildatabase.TextChanged += textBox_emaildatabase_TextChanged;
            // 
            // textBox_passworddatabase
            // 
            textBox_passworddatabase.Location = new Point(56, 262);
            textBox_passworddatabase.Name = "textBox_passworddatabase";
            textBox_passworddatabase.Size = new Size(282, 26);
            textBox_passworddatabase.TabIndex = 17;
            textBox_passworddatabase.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 177);
            label5.Name = "label5";
            label5.Size = new Size(45, 19);
            label5.TabIndex = 18;
            label5.Text = "email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 240);
            label6.Name = "label6";
            label6.Size = new Size(71, 19);
            label6.TabIndex = 19;
            label6.Text = "password";
            // 
            // button_logindatabase
            // 
            button_logindatabase.Location = new Point(142, 294);
            button_logindatabase.Name = "button_logindatabase";
            button_logindatabase.Size = new Size(92, 32);
            button_logindatabase.TabIndex = 20;
            button_logindatabase.Text = "Login";
            button_logindatabase.UseVisualStyleBackColor = true;
            button_logindatabase.Click += button_logindatabase_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 570);
            Controls.Add(button_logindatabase);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox_passworddatabase);
            Controls.Add(textBox_emaildatabase);
            Controls.Add(label4);
            Controls.Add(button_registerdatabase);
            Controls.Add(label3);
            Controls.Add(button_datagrid);
            Controls.Add(button_datatables);
            Controls.Add(button_book);
            Controls.Add(button_dialogbox);
            Controls.Add(button_radio);
            Controls.Add(button1);
            Controls.Add(button_reg);
            Controls.Add(btn_reset);
            Controls.Add(btn_login);
            Controls.Add(textBox_pass);
            Controls.Add(textBox_id);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_id;
        private TextBox textBox_pass;
        private Button btn_login;
        private Button btn_reset;
        private Button button_reg;
        private Button button1;
        private Button button_radio;
        private Button button_dialogbox;
        private Button button_book;
        private Button button_datatables;
        private Button button_datagrid;
        private Label label3;
        private Button button_registerdatabase;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button_logindatabase;
        public TextBox textBox_emaildatabase;
        public TextBox textBox_passworddatabase;
    }
}