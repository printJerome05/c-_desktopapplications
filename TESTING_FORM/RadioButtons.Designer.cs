namespace TESTING_FORM
{
    partial class RadioButtons
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            button_test = new Button();
            groupBox1 = new GroupBox();
            button_back = new Button();
            groupBox2 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            button_error = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(68, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(55, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "TEST1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(68, 70);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(51, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Test2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(64, 119);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(55, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "TEST3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // button_test
            // 
            button_test.Location = new Point(210, 254);
            button_test.Name = "button_test";
            button_test.Size = new Size(75, 23);
            button_test.TabIndex = 3;
            button_test.Text = "SUBMIT";
            button_test.UseVisualStyleBackColor = true;
            button_test.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Location = new Point(146, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(183, 172);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "TEST_messagebox";
            // 
            // button_back
            // 
            button_back.Location = new Point(12, 12);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 23);
            button_back.TabIndex = 5;
            button_back.Text = "back";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Location = new Point(453, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(183, 172);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Submit to other form";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(68, 22);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(67, 19);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "ERROR1";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(68, 70);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(67, 19);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "ERROR2";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(64, 119);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(67, 19);
            radioButton6.TabIndex = 2;
            radioButton6.TabStop = true;
            radioButton6.Text = "ERROR3";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // button_error
            // 
            button_error.Location = new Point(500, 254);
            button_error.Name = "button_error";
            button_error.Size = new Size(75, 23);
            button_error.TabIndex = 6;
            button_error.Text = "SUBMIT";
            button_error.UseVisualStyleBackColor = true;
            button_error.Click += button_error_Click;
            // 
            // RadioButtons
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(button_error);
            Controls.Add(button_back);
            Controls.Add(groupBox1);
            Controls.Add(button_test);
            Name = "RadioButtons";
            Text = "RadioButtons";
            Load += RadioButtons_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button button_test;
        private GroupBox groupBox1;
        private Button button_back;
        private GroupBox groupBox2;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Button button_error;
    }
}