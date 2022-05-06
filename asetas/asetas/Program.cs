using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalSoru2
{
    class Kesir
    {
        private int pay;
        private int payda;
        public Kesir() { pay = payda = 1; }
        public Kesir(int py, int pyd)
        {
            pay = py;
            payda = (pyd == 0) ? 1 : pyd;
        }
        public static Kesir operator +(Kesir ilk, Kesir ikinci)
        {
            if (ilk.payda == ikinci.payda)
            {
                return new Kesir(ilk.pay + ikinci.pay,
                    ilk.payda);
            }
            int caprazCarpım = ilk.pay * ikinci.payda;
            int caprazCarpım1 = ikinci.pay * ilk.payda;
            return new Kesir(
                caprazCarpım + caprazCarpım1,
                ilk.payda * ikinci.payda
                );
        }
        public override string ToString()
        {
            String s = pay.ToString() + "/" + payda.ToString();
            return s;
        }
    }
    public class Program
    {
        static void Main()
        {
            Kesir kesir1 = new Kesir(3, 5);
            Console.WriteLine("kesir1: {0}", kesir1.ToString());
            Kesir kesir2 = new Kesir(4, 14);
            Console.WriteLine("kesir2: {0}", kesir2.ToString());
            Kesir kesir3 = kesir1 + kesir2;
            Console.WriteLine("kesir1 + kesir = kesir3: {0}", kesir3.ToString());
            Console.ReadLine();
        }
    }

}
