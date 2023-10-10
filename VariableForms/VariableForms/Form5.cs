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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public Form5(Form f)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Company c = new Company(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            richTextBox1.Text += c.ToString();
            Accept b = new Accept(textBox4.Text, dateTimePicker1.Value, dateTimePicker2.Value, textBox1.Text);
            richTextBox1.Text += b.ToString();
        }
    }
}
