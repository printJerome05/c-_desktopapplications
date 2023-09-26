namespace TESTING_FORM
{
    partial class DateandTime
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
            dateTimePicker1 = new DateTimePicker();
            label_datetime = new Label();
            button_show = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label_custom = new Label();
            button_back = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(233, 55);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(360, 35);
            dateTimePicker1.TabIndex = 0;
            // 
            // label_datetime
            // 
            label_datetime.AutoSize = true;
            label_datetime.Location = new Point(182, 127);
            label_datetime.Name = "label_datetime";
            label_datetime.Size = new Size(35, 13);
            label_datetime.TabIndex = 1;
            label_datetime.Text = "label1";
            // 
            // button_show
            // 
            button_show.Location = new Point(565, 410);
            button_show.Name = "button_show";
            button_show.Size = new Size(167, 60);
            button_show.TabIndex = 2;
            button_show.Text = "Show";
            button_show.UseVisualStyleBackColor = true;
            button_show.Click += button_show_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 171);
            label1.Name = "label1";
            label1.Size = new Size(35, 13);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 219);
            label2.Name = "label2";
            label2.Size = new Size(35, 13);
            label2.TabIndex = 4;
            label2.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 261);
            label3.Name = "label3";
            label3.Size = new Size(35, 13);
            label3.TabIndex = 5;
            label3.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(182, 313);
            label4.Name = "label4";
            label4.Size = new Size(35, 13);
            label4.TabIndex = 6;
            label4.Text = "label1";
            // 
            // label_custom
            // 
            label_custom.AutoSize = true;
            label_custom.Location = new Point(397, 219);
            label_custom.Name = "label_custom";
            label_custom.Size = new Size(35, 13);
            label_custom.TabIndex = 7;
            label_custom.Text = "label1";
            // 
            // button_back
            // 
            button_back.Location = new Point(12, 12);
            button_back.Name = "button_back";
            button_back.Size = new Size(128, 40);
            button_back.TabIndex = 8;
            button_back.Text = "BACK";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // DateandTime
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 515);
            Controls.Add(button_back);
            Controls.Add(label_custom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_show);
            Controls.Add(label_datetime);
            Controls.Add(dateTimePicker1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "DateandTime";
            Text = "DateandTime";
            Load += DateandTime_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label_datetime;
        private Button button_show;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label_custom;
        private Button button_back;
    }
}