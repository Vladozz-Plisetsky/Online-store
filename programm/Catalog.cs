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
    public partial class Catalog : Form
    {
        public Catalog()
        {
            InitializeComponent();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            string[] readText = File.ReadAllLines(Korzina.pathCat);
            int sch = 0;

            label10.Text += readText[sch].ToString() + "\n";  //1
            sch++;
            label11.Text += readText[sch].ToString() + "\n";
            sch++;
            label20.Text += readText[sch].ToString() + "\n";
            sch++;
            label12.Text += readText[sch].ToString() + "\n";
            sch++;

            label13.Text += readText[sch].ToString() + "\n";  //2
            sch++;
            label14.Text += readText[sch].ToString() + "\n";
            sch++;
            label22.Text += readText[sch].ToString() + "\n";
            sch++;
            label15.Text += readText[sch].ToString() + "\n";
            sch++;

            label16.Text += readText[sch].ToString() + "\n";  //3
            sch++;
            label17.Text += readText[sch].ToString() + "\n";
            sch++;
            label24.Text += readText[sch].ToString() + "\n";
            sch++;
            label18.Text += readText[sch].ToString() + "\n";
            sch++;

            label41.Text += readText[sch].ToString() + "\n";  //4
            sch++;
            label40.Text += readText[sch].ToString() + "\n";  
            sch++;
            label31.Text += readText[sch].ToString() + "\n";
            sch++;
            label39.Text += readText[sch].ToString() + "\n";
            sch++;

            label38.Text += readText[sch].ToString() + "\n";  //5
            sch++;
            label37.Text += readText[sch].ToString() + "\n";
            sch++;
            label29.Text += readText[sch].ToString() + "\n";
            sch++;
            label36.Text += readText[sch].ToString() + "\n";
            sch++;

            label33.Text += readText[sch].ToString() + "\n";  //6
            sch++;
            label34.Text += readText[sch].ToString() + "\n";
            sch++;
            label27.Text += readText[sch].ToString() + "\n";
            sch++;
            label35.Text += readText[sch].ToString() + "\n";
            sch++;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 back = new Form1();
            back.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string[] kassets = File.ReadAllLines(Korzina.pathCat);
            if (Convert.ToInt32(kassets[3]) <= 0)
            {
                MessageBox.Show("Члены закончились!");
                Hide();
                Catalog cc = new Catalog();
                cc.ShowDialog();
                Close();
            }
            else
            {
                kassets[3] = (Convert.ToInt32(kassets[3]) - 1).ToString();
                File.Delete(Korzina.pathCat);
                using (StreamWriter stream = new StreamWriter(Korzina.pathCat, true))
                {
                    for (int i = 0; i < kassets.Length; i++)
                    {
                        stream.WriteLine(kassets[i]);
                    }

                }
                using (StreamWriter str = new StreamWriter(Korzina.pathKorz, true))
                {
                    str.Write(label10.Text);
                }

                Hide();
                Catalog cc = new Catalog();
                cc.ShowDialog();
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] kassets = File.ReadAllLines(Korzina.pathCat);
            if (Convert.ToInt32(kassets[7]) <= 0)
            {
                MessageBox.Show("Члены закончились!");
                Hide();
                Catalog cc = new Catalog();
                cc.ShowDialog();
                Close();
            }
            else
            {
                kassets[7] = (Convert.ToInt32(kassets[7]) - 1).ToString();
                File.Delete(Korzina.pathCat);
                using (StreamWriter stream = new StreamWriter(Korzina.pathCat, true))
                {
                    for (int i = 0; i < kassets.Length; i++)
                    {
                        stream.WriteLine(kassets[i]);
                    }

                }
                using (StreamWriter str = new StreamWriter(Korzina.pathKorz, true))
                {
                    str.Write(label13.Text);
                }

                Hide();
                Catalog cc = new Catalog();
                cc.ShowDialog();
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] kassets = File.ReadAllLines(Korzina.pathCat);
            if (Convert.ToInt32(kassets[11]) <= 0)
            {
                MessageBox.Show("Члены закончились!");
                Hide();
                Catalog cc = new Catalog();
                cc.ShowDialog();
                Close();
            }
            else
            {
                kassets[11] = (Convert.ToInt32(kassets[11]) - 1).ToString();
                File.Delete(Korzina.pathCat);
                using (StreamWriter stream = new StreamWriter(Korzina.pathCat, true))
                {
                    for (int i = 0; i < kassets.Length; i++)
                    {
                        stream.WriteLine(kassets[i]);
                    }

                }
                using (StreamWriter str = new StreamWriter(Korzina.pathKorz, true))
                {
                    str.Write(label16.Text);
                }

                Hide();
                Catalog cc = new Catalog();
                cc.ShowDialog();
                Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] kassets = File.ReadAllLines(Korzina.pathCat);
            if (Convert.ToInt32(kassets[15]) <= 0)
            {
                MessageBox.Show("Члены закончились!");
                Hide();
                Catalog cc = new Catalog();
                cc.ShowDialog();
                Close();
            }
            else
            {
                kassets[15] = (Convert.ToInt32(kassets[15]) - 1).ToString();
                File.Delete(Korzina.pathCat);
                using (StreamWriter stream = new StreamWriter(Korzina.pathCat, true))
                {
                    for (int i = 0; i < kassets.Length; i++)
                    {
                        stream.WriteLine(kassets[i]);
                    }

                }
                using (StreamWriter str = new StreamWriter(Korzina.pathKorz, true))
                {
                    str.Write(label41.Text);
                }

                Hide();
                Catalog cc = new Catalog();
                cc.ShowDialog();
                Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] kassets = File.ReadAllLines(Korzina.pathCat);
            if (Convert.ToInt32(kassets[19]) <= 0)
            {
                MessageBox.Show("Члены закончились!");
                Hide();
                Catalog cc = new Catalog();
                cc.ShowDialog();
                Close();
            }
            else
            {
                kassets[19] = (Convert.ToInt32(kassets[19]) - 1).ToString();
                File.Delete(Korzina.pathCat);
                using (StreamWriter stream = new StreamWriter(Korzina.pathCat, true))
                {
                    for (int i = 0; i < kassets.Length; i++)
                    {
                        stream.WriteLine(kassets[i]);
                    }

                }
                using (StreamWriter str = new StreamWriter(Korzina.pathKorz, true))
                {
                    str.Write(label38.Text);
                }

                Hide();
                Catalog cc = new Catalog();
                cc.ShowDialog();
                Close();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] kassets = File.ReadAllLines(Korzina.pathCat);
            if (Convert.ToInt32(kassets[23]) <= 0)
            {
                MessageBox.Show("Члены закончились!");
                Hide();
                Catalog cc = new Catalog();
                cc.ShowDialog();
                Close();
            }
            else
            {
                kassets[23] = (Convert.ToInt32(kassets[23]) - 1).ToString();
                File.Delete(Korzina.pathCat);
                using (StreamWriter stream = new StreamWriter(Korzina.pathCat, true))
                {
                    for (int i = 0; i < kassets.Length; i++)
                    {
                        stream.WriteLine(kassets[i]);
                    }

                }
                using (StreamWriter str = new StreamWriter(Korzina.pathKorz, true))
                {
                    str.Write(label33.Text);
                }

                Hide();
                Catalog cc = new Catalog();
                cc.ShowDialog();
                Close();
            }
        }
    }
}
