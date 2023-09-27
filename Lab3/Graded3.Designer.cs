namespace Lab3
{
    partial class Graded3
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
            dataGridView8 = new DataGridView();
            button8 = new Button();
            label9 = new Label();
            textBox15 = new TextBox();
            textBox16 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).BeginInit();
            SuspendLayout();
            // 
            // dataGridView8
            // 
            dataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView8.Location = new Point(155, 178);
            dataGridView8.Name = "dataGridView8";
            dataGridView8.RowHeadersWidth = 51;
            dataGridView8.RowTemplate.Height = 29;
            dataGridView8.Size = new Size(490, 252);
            dataGridView8.TabIndex = 45;
            // 
            // button8
            // 
            button8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(353, 94);
            button8.Name = "button8";
            button8.Size = new Size(94, 49);
            button8.TabIndex = 44;
            button8.Text = "Check";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(304, 20);
            label9.Name = "label9";
            label9.Size = new Size(210, 34);
            label9.TabIndex = 43;
            label9.Text = "Graded Task 3";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(155, 86);
            textBox15.Multiline = true;
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(161, 57);
            textBox15.TabIndex = 42;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(483, 86);
            textBox16.Multiline = true;
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(162, 57);
            textBox16.TabIndex = 41;
            // 
            // Graded3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView8);
            Controls.Add(button8);
            Controls.Add(label9);
            Controls.Add(textBox15);
            Controls.Add(textBox16);
            Name = "Graded3";
            Text = "Graded3";
            ((System.ComponentModel.ISupportInitialize)dataGridView8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView8;
        private Button button8;
        private Label label9;
        private TextBox textBox15;
        private TextBox textBox16;
    }
}