namespace Lab3
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
            button6 = new Button();
            label7 = new Label();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            SuspendLayout();
            // 
            // button6
            // 
            button6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(465, 219);
            button6.Name = "button6";
            button6.Size = new Size(94, 49);
            button6.TabIndex = 33;
            button6.Text = "Check";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(410, 140);
            label7.Name = "label7";
            label7.Size = new Size(210, 34);
            label7.TabIndex = 32;
            label7.Text = "Graded Task 1";
            label7.Click += label7_Click;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(57, 211);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(367, 57);
            textBox11.TabIndex = 31;
            textBox11.TextChanged += textBox11_TextChanged;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(594, 210);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(382, 57);
            textBox12.TabIndex = 30;
            textBox12.TextChanged += textBox12_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 450);
            Controls.Add(button6);
            Controls.Add(label7);
            Controls.Add(textBox11);
            Controls.Add(textBox12);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button6;
        private Label label7;
        private TextBox textBox11;
        private TextBox textBox12;
    }
}