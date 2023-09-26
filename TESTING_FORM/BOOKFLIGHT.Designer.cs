namespace TESTING_FORM
{
    partial class BOOKFLIGHT
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
            button_back = new Button();
            button_submit = new Button();
            label1 = new Label();
            textBox_to = new TextBox();
            textBox_from = new TextBox();
            label2 = new Label();
            monthCalendar1 = new MonthCalendar();
            textBox_fname = new TextBox();
            label3 = new Label();
            textBox_lname = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            radioButton_id = new RadioButton();
            radioButton_passport = new RadioButton();
            textBox_docu = new TextBox();
            label_doc = new Label();
            label_dateissue = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label_dateexpire = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button_back
            // 
            button_back.Location = new Point(12, 12);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 23);
            button_back.TabIndex = 0;
            button_back.Text = "back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // button_submit
            // 
            button_submit.BackColor = SystemColors.ActiveCaption;
            button_submit.Dock = DockStyle.Bottom;
            button_submit.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button_submit.ForeColor = SystemColors.ButtonHighlight;
            button_submit.Location = new Point(0, 697);
            button_submit.Name = "button_submit";
            button_submit.Size = new Size(969, 83);
            button_submit.TabIndex = 1;
            button_submit.Text = "submit";
            button_submit.UseVisualStyleBackColor = false;
            button_submit.Click += button_submit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(146, 35);
            label1.Name = "label1";
            label1.Size = new Size(36, 25);
            label1.TabIndex = 2;
            label1.Text = "TO";
            // 
            // textBox_to
            // 
            textBox_to.Location = new Point(188, 35);
            textBox_to.Multiline = true;
            textBox_to.Name = "textBox_to";
            textBox_to.Size = new Size(156, 25);
            textBox_to.TabIndex = 3;
            // 
            // textBox_from
            // 
            textBox_from.Location = new Point(467, 35);
            textBox_from.Multiline = true;
            textBox_from.Name = "textBox_from";
            textBox_from.Size = new Size(156, 25);
            textBox_from.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(395, 35);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 4;
            label2.Text = "FROM";
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(2, 1);
            monthCalendar1.Location = new Point(165, 72);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.SelectionRange = new SelectionRange(new DateTime(2023, 9, 26, 0, 0, 0, 0), new DateTime(2023, 10, 2, 0, 0, 0, 0));
            monthCalendar1.TabIndex = 6;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // textBox_fname
            // 
            textBox_fname.Location = new Point(165, 258);
            textBox_fname.Multiline = true;
            textBox_fname.Name = "textBox_fname";
            textBox_fname.Size = new Size(156, 25);
            textBox_fname.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(63, 258);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 7;
            label3.Text = "firstname";
            // 
            // textBox_lname
            // 
            textBox_lname.Location = new Point(467, 258);
            textBox_lname.Multiline = true;
            textBox_lname.Name = "textBox_lname";
            textBox_lname.Size = new Size(156, 25);
            textBox_lname.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(353, 258);
            label4.Name = "label4";
            label4.Size = new Size(91, 25);
            label4.TabIndex = 9;
            label4.Text = "lastname";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton_id);
            groupBox1.Controls.Add(radioButton_passport);
            groupBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(64, 313);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 131);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "TRAVEL DOCUMENT";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton_id
            // 
            radioButton_id.AutoSize = true;
            radioButton_id.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radioButton_id.Location = new Point(115, 73);
            radioButton_id.Name = "radioButton_id";
            radioButton_id.Size = new Size(46, 29);
            radioButton_id.TabIndex = 1;
            radioButton_id.TabStop = true;
            radioButton_id.Text = "id";
            radioButton_id.UseVisualStyleBackColor = true;
            radioButton_id.CheckedChanged += radioButton_id_CheckedChanged;
            // 
            // radioButton_passport
            // 
            radioButton_passport.AutoSize = true;
            radioButton_passport.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            radioButton_passport.Location = new Point(82, 38);
            radioButton_passport.Name = "radioButton_passport";
            radioButton_passport.Size = new Size(122, 29);
            radioButton_passport.TabIndex = 0;
            radioButton_passport.TabStop = true;
            radioButton_passport.Text = "PASSPORT";
            radioButton_passport.UseVisualStyleBackColor = true;
            radioButton_passport.CheckedChanged += radioButton_passport_CheckedChanged;
            // 
            // textBox_docu
            // 
            textBox_docu.Location = new Point(577, 358);
            textBox_docu.Multiline = true;
            textBox_docu.Name = "textBox_docu";
            textBox_docu.Size = new Size(156, 25);
            textBox_docu.TabIndex = 13;
            // 
            // label_doc
            // 
            label_doc.AutoSize = true;
            label_doc.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_doc.Location = new Point(432, 358);
            label_doc.Name = "label_doc";
            label_doc.Size = new Size(139, 25);
            label_doc.TabIndex = 12;
            label_doc.Text = "Document no:";
            // 
            // label_dateissue
            // 
            label_dateissue.AutoSize = true;
            label_dateissue.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_dateissue.Location = new Point(48, 477);
            label_dateissue.Name = "label_dateissue";
            label_dateissue.Size = new Size(197, 25);
            label_dateissue.TabIndex = 14;
            label_dateissue.Text = "Document date issue";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(261, 477);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(217, 23);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(700, 479);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(204, 23);
            dateTimePicker2.TabIndex = 17;
            // 
            // label_dateexpire
            // 
            label_dateexpire.AutoSize = true;
            label_dateexpire.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_dateexpire.Location = new Point(484, 477);
            label_dateexpire.Name = "label_dateexpire";
            label_dateexpire.Size = new Size(210, 25);
            label_dateexpire.TabIndex = 16;
            label_dateexpire.Text = "Document expire date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(48, 546);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 18;
            label5.Text = "baggage";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(144, 548);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 19;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // BOOKFLIGHT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(969, 780);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(dateTimePicker2);
            Controls.Add(label_dateexpire);
            Controls.Add(dateTimePicker1);
            Controls.Add(label_dateissue);
            Controls.Add(textBox_docu);
            Controls.Add(label_doc);
            Controls.Add(groupBox1);
            Controls.Add(textBox_lname);
            Controls.Add(label4);
            Controls.Add(textBox_fname);
            Controls.Add(label3);
            Controls.Add(monthCalendar1);
            Controls.Add(textBox_from);
            Controls.Add(label2);
            Controls.Add(textBox_to);
            Controls.Add(label1);
            Controls.Add(button_submit);
            Controls.Add(button_back);
            Name = "BOOKFLIGHT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BOOKFLIGHT";
            Load += BOOKFLIGHT_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_back;
        private Button button_submit;
        private Label label1;
        private TextBox textBox_to;
        private TextBox textBox_from;
        private Label label2;
        private MonthCalendar monthCalendar1;
        private TextBox textBox_fname;
        private Label label3;
        private TextBox textBox_lname;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton radioButton_id;
        private RadioButton radioButton_passport;
        private TextBox textBox_docu;
        private Label label_doc;
        private Label label_dateissue;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label_dateexpire;
        private Label label5;
        private NumericUpDown numericUpDown1;
    }
}