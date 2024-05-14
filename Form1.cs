using System.Reflection.Emit;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                double val1 = Convert.ToDouble(textBox1.Text);
                double val2 = Convert.ToDouble(textBox2.Text);
                double output = val1 + val2;
                { label3.Text = Convert.ToString(output); label3.Refresh(); }
                textBox1.Clear();
                textBox2.Clear();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message);
            textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double val1 = Convert.ToDouble(textBox1.Text);
                double val2 = Convert.ToDouble(textBox2.Text);
                double output = val1 - val2;
                { label3.Text = Convert.ToString(output); label3.Refresh(); }
                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);
            textBox1.Focus();}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double val1 = Convert.ToDouble(textBox1.Text);
                double val2 = Convert.ToDouble(textBox2.Text);
                double output = val1 * val2;
                { label3.Text = Convert.ToString(output); label3.Refresh(); }
                textBox1.Clear();
                textBox2.Clear();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); textBox1.Focus();}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double val1 = Convert.ToDouble(textBox1.Text);
                double val2 = Convert.ToDouble(textBox2.Text);
                double output = val1 / val2;
                { label3.Text = Convert.ToString(output); label3.Refresh(); }
                textBox1.Clear();
                textBox2.Clear();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message);textBox1.Focus();}
            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
