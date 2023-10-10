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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Processor a1 = new Processor(textBox1.Text, Convert.ToDouble(textBox2.Text), Convert.ToDecimal(textBox3.Text), Convert.ToInt32(textBox4.Text));
            a1.StampCheck(richTextBox1);
            a1.FrequencyCheck(richTextBox1);
            a1.KeshCheck(richTextBox1);
            a1.CostCheck(richTextBox1);
            MotherBoard a2 = new MotherBoard(textBox1.Text, Convert.ToDouble(textBox2.Text), Convert.ToDecimal(textBox3.Text), Convert.ToInt32(textBox4.Text), textBox5.Text, Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text));
            List<string> Formad = new List<string>();
            Convert.ToString(listBox2.Items.Add(a2.Standard(Formad)));
            List<string> Specifications = new List<string>();
            listBox1.Items.Add(a2.Quantity(Specifications));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 n = new Form2(this);
            n.Show();
        }
    }
}
