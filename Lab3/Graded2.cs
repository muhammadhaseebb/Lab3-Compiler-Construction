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
    public partial class Graded2 : Form
    {
        public Graded2()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            
            dataGridView7.ColumnCount = 2;
            dataGridView7.Columns[0].Name = "Value";
            dataGridView7.Columns[1].Name = "Conversion";

        }

        private void Graded2_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            String var = textBox13.Text;

            // split the input on the basis of space

            String[] words = var.Split(' ');

            // Regular Expression for variables

            Regex regex1 = new Regex(@"^[+-]?\d+(\.\d+)?[eE][+-]?\d+$");


            for (int i = 0; i < words.Length; i++)
            {
                Match match1 = regex1.Match(words[i]);

                if (match1.Success)
                {
                    textBox14.Text += words[i] + " ";
                    double result = Double.Parse(words[i]);

                    // Format output as string
                    string formattedOutput = String.Format("{0:F}", result);

                    String[] row = new String[] { words[i].ToString(), formattedOutput };
                    dataGridView7.Rows.Add(row);

                }

                else
                {
                    MessageBox.Show("invalid " + words[i]);
                }
            }
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
