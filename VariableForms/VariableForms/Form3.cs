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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Form f)
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Client v = new Client(textBox1.Text, textBox2.Text, dateTimePicker1.Value);
            v.ShowFoto(pictureBox1);
            v.Selected(richTextBox1);
            Document d = new Document(textBox3.Text, textBox4.Text, textBox5.Text);
            List<string> Specifications = new List<string>();
            listBox1.Items.Add(d.Format(Specifications));
            richTextBox1.Text += d.Client;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 n1 = new Form4(this);
            n1.Show();
        }
    }
}
