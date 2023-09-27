using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Graded3 : Form
    {
        public Graded3()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dataGridView8.ColumnCount = 1;
            dataGridView8.Columns[0].Name = "Filtered Words Starting with T and M";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String var = textBox15.Text;

            // split the input on the basis of space

            String[] words = var.Split(' ');

            // Regular Expression for variables

            Regex regex1 = new Regex(@"^\b[tm]\w*\b$");


            for (int i = 0; i < words.Length; i++)
            {
                Match match1 = regex1.Match(words[i]);

                if (match1.Success)
                {
                    textBox16.Text += words[i] + " ";
                    String[] row = new String[] { words[i].ToString(), "1" };
                    dataGridView8.Rows.Add(row);

                }
            }
        }
    }
}
