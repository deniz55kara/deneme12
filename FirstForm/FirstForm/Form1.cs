using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PROCESSOR_COMBOBOX.Items.Add("Intel i7");
            PROCESSOR_COMBOBOX.Items.Add("Intel i3");
            PROCESSOR_COMBOBOX.Items.Add("Intel i5");
            PROCESSOR_COMBOBOX.Items.Add("Ryzen 3 3100");




        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("bbbbb");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tıkklandı");
        }

        private void PROCESSOR_COMBOBOX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string islemci;
            islemci = (string)PROCESSOR_COMBOBOX.SelectedItem;

            

            if (string.Equals(islemci, "Intel i3"))  
            {
                textBox1.Text = "GİRİS SEVİYE";

            }

            if (string.Equals(islemci, "Intel i7"))
            {
                textBox1.Text = "OYUN BİLGİSAYARI";

            }

            if (string.Equals(islemci, "Ryzen 3 3100"))
            {
                textBox1.Text = "GİRİŞ SEVİYE";

            }

            if (string.Equals(islemci, "Intel i5"))
            {
                textBox1.Text = "İŞ BİLGİSAYARI";

            }







        }

        
    }
}
