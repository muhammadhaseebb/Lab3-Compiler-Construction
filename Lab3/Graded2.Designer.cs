namespace Lab3
{
    partial class Graded2
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
            dataGridView7 = new DataGridView();
            button7 = new Button();
            label8 = new Label();
            textBox13 = new TextBox();
            textBox14 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            SuspendLayout();
            // 
            // dataGridView7
            // 
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Location = new Point(191, 289);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.RowHeadersWidth = 51;
            dataGridView7.RowTemplate.Height = 29;
            dataGridView7.Size = new Size(490, 88);
            dataGridView7.TabIndex = 40;
            dataGridView7.CellContentClick += dataGridView7_CellContentClick;
            // 
            // button7
            // 
            button7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(389, 205);
            button7.Name = "button7";
            button7.Size = new Size(94, 49);
            button7.TabIndex = 39;
            button7.Text = "Check";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(340, 133);
            label8.Name = "label8";
            label8.Size = new Size(210, 34);
            label8.TabIndex = 38;
            label8.Text = "Graded Task 2";
            label8.Click += label8_Click;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(191, 197);
            textBox13.Multiline = true;
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(161, 57);
            textBox13.TabIndex = 37;
            textBox13.TextChanged += textBox13_TextChanged;
            // 
            // textBox14
            // 
            textBox14.Location = new Point(519, 197);
            textBox14.Multiline = true;
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(162, 57);
            textBox14.TabIndex = 36;
            textBox14.TextChanged += textBox14_TextChanged;
            // 
            // Graded2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 511);
            Controls.Add(dataGridView7);
            Controls.Add(button7);
            Controls.Add(label8);
            Controls.Add(textBox13);
            Controls.Add(textBox14);
            Name = "Graded2";
            Text = "Graded2";
            Load += Graded2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView7;
        private Button button7;
        private Label label8;
        private TextBox textBox13;
        private TextBox textBox14;
    }
}