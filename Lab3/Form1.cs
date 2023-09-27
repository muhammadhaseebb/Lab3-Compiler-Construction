using System.Text.RegularExpressions;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            String var = textBox11.Text;

            // split the input on the basis of space

            String[] words = var.Split(' ');

            // Regular Expression for variables

            Regex regex1 = new Regex(@"^\d+(\.\d{1,6})$");

            for (int i = 0; i < words.Length; i++)
            {
                Match match1 = regex1.Match(words[i]);

                if (match1.Success)
                {
                    textBox12.Text += words[i] + " ";

                }

                else
                {
                    MessageBox.Show("invalid " + words[i]);
                }
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }
    }
}