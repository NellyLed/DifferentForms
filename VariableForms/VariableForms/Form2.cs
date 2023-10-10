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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form f)
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
              IProcessor m = new Management(textBox17.Text, Convert.ToInt32(textBox14.Text), textBox18.Text, Convert.ToInt32(textBox13.Text),
                Convert.ToInt32(textBox15.Text), Convert.ToInt32(textBox16.Text));
            m.CostCheck(richTextBox1);
            List<int> Components = new List<int>();
            listBox1.Items.Add(m.Quantity(Components));
            IProcessor c = new Computer(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text),
                Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text),
                Convert.ToInt32(textBox10.Text), Convert.ToInt32(textBox11.Text));
            List<int> Cont = new List<int>();
            listBox2.Items.Add(c.Quantity(Cont));
            c.CostCheck(richTextBox1);
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 n1 = new Form3(this);
            n1.Show();
        }
    }
}
