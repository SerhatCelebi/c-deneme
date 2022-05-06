using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var liste = new ArrayList();
            
            while (true)
            {

                Console.WriteLine("Diziye sayı gir");
                int num = Convert.ToInt32(Console.ReadLine());
                liste.Add(num);
                string str;
                Console.WriteLine("Döngüyü durdurmak icin('b' ya da 'B' yazin.Devam etmek icin enter");
                str = (Console.ReadLine());
                if(str=="b" || str == "B")
                {
                    break;
                }
            }
            Console.WriteLine();

            Sayilar ob = new Sayilar();
            foreach(int x in ob.Tekler(liste))
            {
                Console.Write("\t {0}",x);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
    class Sayilar
    {
        public ArrayList Tekler(ArrayList liste)
        {

            var tekler = new ArrayList();
            foreach (int x in liste)
            {
                if (x % 2 == 1)
                {
                    tekler.Add(+x);
                }
            }
            return tekler;
        }
        
    }
}
