using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vize3
{
    class Program
    {

        static void Main(string[] args)
        {
            int boyut;
            double ort = 0;
            Console.WriteLine("Kac sayi girmek istiyorsunuz?");
            boyut = Convert.ToInt16(Console.ReadLine());
            int[] numbers = new int[boyut];
            for (int i = 0; i < boyut; i++)
            {
                numbers[i] = Convert.ToInt16(Console.ReadLine());
            }
            Minmaxort minmaxort = new Minmaxort(ref ort, numbers);
            Console.WriteLine(ort);
            Console.ReadLine();
        }
    }
    class Minmaxort
    {
        public Minmaxort(ref double ort, params int[] numbers)
        {
            int buyuk, kucuk;
            buyuk = numbers.Max();
            kucuk = numbers.Min();
            ort = ((double)buyuk + (double)kucuk) / 2;
        }

    }
}
