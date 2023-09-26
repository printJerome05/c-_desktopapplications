namespace TESTING_FORM
{
    partial class RADIOerrorcheck
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
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button_back = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(21, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 166);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ERROR TEST READ ONLY";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Enabled = false;
            radioButton3.Location = new Point(53, 113);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(67, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "ERROR3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Enabled = false;
            radioButton2.Location = new Point(53, 74);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "ERROR2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Enabled = false;
            radioButton1.Location = new Point(53, 34);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "ERROR1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // button_back
            // 
            button_back.Location = new Point(21, 23);
            button_back.Name = "button_back";
            button_back.Size = new Size(75, 23);
            button_back.TabIndex = 1;
            button_back.Text = "BACK";
            button_back.UseVisualStyleBackColor = true;
            button_back.Click += button_back_Click;
            // 
            // RADIOerrorcheck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 450);
            Controls.Add(button_back);
            Controls.Add(groupBox1);
            Name = "RADIOerrorcheck";
            Text = "RADIOerrorcheck";
            Load += RADIOerrorcheck_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private Button button_back;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
    }
}