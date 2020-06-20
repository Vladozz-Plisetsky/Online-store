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
    public partial class Bascet : Form
    {
        public Bascet()
        {
            InitializeComponent();
        }

        private void Bascet_Load(object sender, EventArgs e)
        {
            if (File.Exists(Korzina.pathKorz))
            {
                string[] readText = File.ReadAllLines(Korzina.pathKorz);
                for (int i = 0; i < readText.Length; i++)
                {
                    label1.Text += readText[i].ToString() + "\n";
                }

                label4.Text = Korzina.Summ.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 back = new Form1();
            back.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] catalog = File.ReadAllLines(Korzina.pathKorz);
            int ind1 = Array.IndexOf(catalog, textBox1.Text);
            File.Delete(Korzina.pathKorz);
            for (int i = 0; i < catalog.Length; i++)
            {
                if (i != ind1)
                {
                    using (StreamWriter stream = new StreamWriter(Korzina.pathKorz, true))
                    {
                        stream.WriteLine(catalog[i]);
                    }
                }
            }

            catalog = File.ReadAllLines(Korzina.pathCat);
            ind1 = Array.IndexOf(catalog, textBox1.Text);
            File.Delete(Korzina.pathCat);
            catalog[ind1+3] = (Convert.ToInt32(catalog[ind1+3]) + 1).ToString();
            for (int i = 0; i < catalog.Length; i++)
            {
                    using (StreamWriter stream = new StreamWriter(Korzina.pathCat, true))
                    {
                        stream.WriteLine(catalog[i]);
                    }                
            }

            Hide();
            Bascet go = new Bascet();
            go.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Sell go = new Sell();
            go.ShowDialog();
            Close();
        }
    }
}
