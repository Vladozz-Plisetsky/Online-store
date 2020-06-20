using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string newDir = Path.Combine(Korzina.root, "The Best Programm");
            Directory.CreateDirectory(newDir);
            label1.Text = Korzina.Summ.ToString();
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Catalog go = new Catalog();
            go.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Bascet go = new Bascet();
            go.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(Korzina.pathCat))
            {
                string[] readText = File.ReadAllLines(Korzina.pathCat);
                int sch = 0;
                for (int i = 0; i < readText.Length; i += 4)
                {
                    if (readText[i] == textBox3.Text) sch++;
                }
                if (sch == 0) MessageBox.Show(" Совпадений не найдено");
                else
                {
                    int ind = Array.IndexOf(readText, textBox3.Text);
                    string price = readText[ind + 1];
                    string size = readText[ind + 2];
                    string pcs = readText[ind + 3];
                    MessageBox.Show(" Есть в наличии " + pcs + " шт. , размер: " + size + " , по цене:  " + price);
                }
            }
            else MessageBox.Show("галя , жрать");
        }
    }
}