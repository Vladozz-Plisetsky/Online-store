using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glados
{
    public static class Korzina
    {
        
        static int summ;
        public static int Summ
        {
            
            get
            {
                if (File.Exists(Korzina.pathKorz))
                {
                    summ = 0;
                    string[] catalog = File.ReadAllLines(Korzina.pathCat);
                    string[] bought = File.ReadAllLines(Korzina.pathKorz);
                    
                    for (int i = 0; i < bought.Length; i++)
                    {
                        int ind = Array.IndexOf(catalog, bought[i]);
                        summ += Convert.ToInt32(catalog[ind + 1]);
                    }
                    return summ;
                }
                else
                {
                    summ = 0;
                    return summ;
                }
            }
            set
            {
                summ = value;
            }
        }
        

        public static string root = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static string rootKorz = root;
        static string rootCat = root;
        public static string pathKorz = rootKorz += "\\The Best Programm\\Basket.txt";
        public static string pathCat = rootCat += "\\The Best Programm\\Catalog.txt";
    }
}
