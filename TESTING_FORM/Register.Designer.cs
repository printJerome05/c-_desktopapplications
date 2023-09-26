namespace TESTING_FORM
{
    partial class Register
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
            textBox_fname = new TextBox();
            textBox_lname = new TextBox();
            textBox_email = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label_transac = new Label();
            label_report = new Label();
            label5 = new Label();
            label_sms = new Label();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button_confirm = new Button();
            label4 = new Label();
            label_phone = new Label();
            textBox_phone = new TextBox();
            button_back = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_fname
            // 
            textBox_fname.Location = new Point(173, 58);
            textBox_fname.Name = "textBox_fname";
            textBox_fname.Size = new Size(220, 23);
            textBox_fname.TabIndex = 0;
            textBox_fname.TextChanged += textBox_fname_TextChanged;
            // 
            // textBox_lname
            // 
            textBox_lname.Location = new Point(173, 105);
            textBox_lname.Name = "textBox_lname";
            textBox_lname.Size = new Size(220, 23);
            textBox_lname.TabIndex = 1;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(173, 157);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(220, 23);
            textBox_email.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 66);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 3;
            label1.Text = "first name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 113);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 4;
            label2.Text = "last name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 160);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 5;
            label3.Text = "email:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label_transac);
            groupBox1.Controls.Add(label_report);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label_sms);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(102, 243);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(446, 169);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Services";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label_transac
            // 
            label_transac.AutoSize = true;
            label_transac.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label_transac.ForeColor = Color.DarkRed;
            label_transac.Location = new Point(207, 121);
            label_transac.Name = "label_transac";
            label_transac.Size = new Size(26, 21);
            label_transac.TabIndex = 6;
            label_transac.Text = "....";
            // 
            // label_report
            // 
            label_report.AutoSize = true;
            label_report.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label_report.ForeColor = Color.DarkRed;
            label_report.Location = new Point(207, 81);
            label_report.Name = "label_report";
            label_report.Size = new Size(26, 21);
            label_report.TabIndex = 5;
            label_report.Text = "....";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(219, 77);
            label5.Name = "label5";
            label5.Size = new Size(0, 30);
            label5.TabIndex = 4;
            // 
            // label_sms
            // 
            label_sms.AutoSize = true;
            label_sms.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label_sms.ForeColor = Color.DarkRed;
            label_sms.Location = new Point(207, 45);
            label_sms.Name = "label_sms";
            label_sms.Size = new Size(26, 21);
            label_sms.TabIndex = 3;
            label_sms.Text = "....";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkBox3.Location = new Point(33, 117);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(129, 29);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "transaction";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkBox2.Location = new Point(33, 77);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(92, 29);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "reports";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            checkBox1.Location = new Point(33, 37);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(64, 29);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "sms";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button_confirm
            // 
            button_confirm.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_confirm.Location = new Point(652, 392);
            button_confirm.Name = "button_confirm";
            button_confirm.Size = new Size(115, 46);
            button_confirm.TabIndex = 7;
            button_confirm.Text = "Confirm";
            button_confirm.UseVisualStyleBackColor = true;
            button_confirm.Click += button_confirm_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(216, 9);
            label4.Name = "label4";
            label4.Size = new Size(350, 32);
            label4.TabIndex = 8;
            label4.Text = "Passing Data to another form";
            // 
            // label_phone
            // 
            label_phone.AutoSize = true;
            label_phone.Location = new Point(75, 213);
            label_phone.Name = "label_phone";
            label_phone.Size = new Size(91, 15);
            label_phone.TabIndex = 9;
            label_phone.Text = "Phone Number:";
            // 
            // textBox_phone
            // 
            textBox_phone.Location = new Point(173, 205);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(220, 23);
            textBox_phone.TabIndex = 10;
            // 
            // button_back
            // 
            button_back.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_back.Location = new Point(658, 12);
            button_back.Name = "button_back";
            button_back.Size = new Size(115, 46);
            button_back.TabIndex = 11;
            button_back.Text = "back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 457);
            Controls.Add(button_back);
            Controls.Add(textBox_phone);
            Controls.Add(label_phone);
            Controls.Add(label4);
            Controls.Add(button_confirm);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_email);
            Controls.Add(textBox_lname);
            Controls.Add(textBox_fname);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_fname;
        private TextBox textBox_lname;
        private TextBox textBox_email;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label_transac;
        private Label label_report;
        private Label label5;
        private Label label_sms;
        private Button button_confirm;
        private Label label4;
        private Label label_phone;
        private TextBox textBox_phone;
        private Button button_back;
    }
}