using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glados
{
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы начнём собирать Ваш заказ в ближайшее время! \nПосле получения оплаты" +
                " с вами свяжется наш оператор!");

            File.Delete(Korzina.pathKorz);
            Hide();
            Form1 back = new Form1();
            back.ShowDialog();
            Close();
        }
    }
}
