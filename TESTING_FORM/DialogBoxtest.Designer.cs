namespace TESTING_FORM
{
    partial class DialogBoxtest
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
            button_clickme = new Button();
            label1 = new Label();
            label2 = new Label();
            button_BACK = new Button();
            SuspendLayout();
            // 
            // button_clickme
            // 
            button_clickme.Location = new Point(340, 135);
            button_clickme.Name = "button_clickme";
            button_clickme.Size = new Size(132, 65);
            button_clickme.TabIndex = 0;
            button_clickme.Text = "CLICK ME";
            button_clickme.UseVisualStyleBackColor = true;
            button_clickme.Click += button_clickme_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(229, 243);
            label1.Name = "label1";
            label1.Size = new Size(35, 32);
            label1.TabIndex = 1;
            label1.Text = "...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(256, 50);
            label2.Name = "label2";
            label2.Size = new Size(288, 50);
            label2.TabIndex = 2;
            label2.Text = "CLICK THE BOX";
            // 
            // button_BACK
            // 
            button_BACK.Location = new Point(12, 12);
            button_BACK.Name = "button_BACK";
            button_BACK.Size = new Size(75, 23);
            button_BACK.TabIndex = 3;
            button_BACK.Text = "BACK";
            button_BACK.UseVisualStyleBackColor = true;
            button_BACK.Click += button_BACK_Click;
            // 
            // DialogBoxtest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_BACK);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_clickme);
            Name = "DialogBoxtest";
            Text = "DialogBoxtest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_clickme;
        private Label label1;
        private Label label2;
        private Button button_BACK;
    }
}