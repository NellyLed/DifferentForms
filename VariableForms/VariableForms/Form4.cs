using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary155;
namespace VariableForms
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(Form f)
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Delivery d = new Delivery(textBox1.Text, dateTimePicker1.Value, textBox3.Text);
            richTextBox1.Text += d.ToString();
            Check c = new Check(textBox4.Text, new Delivery(Convert.ToInt32(textBox2.Text)), textBox6.Text);
            richTextBox1.Text += c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 n1 = new Form5(this);
            n1.Show();
        }
    }
}
