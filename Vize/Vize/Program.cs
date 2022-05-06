using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize
{
    class Program
    {
        static void Main(string[] args)
        {
            Dortgen dortgen  = new Dortgen();
            Dortgen dortgen1 = new Dortgen(3);
            Dortgen dortgen2 = new Dortgen(3,4);
            Dortgen dortgen3 = new Dortgen(3,4,5);
            Dortgen dortgen4 = new Dortgen(3, 4, 5, 6);
            Console.WriteLine("Parametre girilmeyen dortgenin cevresi:{0}", dortgen.cevreHesapla());
            Console.WriteLine("Tek parametre girilen dortgenin cevresi:{0}", dortgen1.cevreHesapla());
            Console.WriteLine("Iki parametre girilen dortgenin cevresi:{0}", dortgen2.cevreHesapla());
            Console.WriteLine("Uc parametre girilen dortgenin cevresi:{0}", dortgen3.cevreHesapla());
            Console.WriteLine("Dort parametre girilen dortgenin cevresi:{0}", dortgen4.cevreHesapla());
            Console.ReadLine();
        }
    }
    class Dortgen
    {
        private int _kenar1,_kenar2,_kenar3,_kenar4;
        public Dortgen()
        {
            _kenar1 = _kenar2 = _kenar3 = _kenar4 = 0;
        }
        public Dortgen(int kenar1)
        {
            _kenar1 = kenar1;
            _kenar2 = kenar1;
            _kenar3 = kenar1;
            _kenar4 = kenar1;
        }
        public Dortgen(int kenar1,int kenar2)
        {
            _kenar1 = _kenar3 = kenar1;
            _kenar2 = _kenar4 = kenar2;
        }
        public Dortgen(int kenar1,int kenar2,int kenar3)
        {
            _kenar1 = _kenar3 = kenar1;
            _kenar2 = _kenar4 = kenar2;
        }
        public Dortgen(int kenar1,int kenar2,int kenar3,int kenar4)
        {
            _kenar1 = kenar1;
            _kenar2 = kenar2;
            _kenar3 = kenar3;
            _kenar4 = kenar4;
        }
         public int cevreHesapla()
    {
         var cevre = _kenar1 + _kenar2 + _kenar3 + _kenar4;
         return cevre;
    }
}
    }

