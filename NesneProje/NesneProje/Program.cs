using System;
//stack(yığın) özelliğini kullanabilmemiz için gereken collections kütüphanesi
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneProje
{
    class Program
    {
        // Karakterin operand(a,b,c vb...) olup olmadıgıı anlayan fonksiyon
        static Boolean Buoperandmı(char o)
        {
            if ((o >= 'a' && o <= 'z') || (o >= 'A' && o <= 'Z')) {
                //Karakter operand ise 1 döner ve bu if içersinde olduğu için if in içine girer.
                return true;
             }
            else return false;
        }
        //Gönderdiğimiz postfix ifadeyi infix döndüren fonksiyon
        static String InfixDonusturme(String ifade)
        {
            //Yeni bir s isminde stack(yığın)  
            Stack s = new Stack();

            for (int i = 0; i < ifade.Length; i++)
            {
                if (Buoperandmı(ifade[i]))
                {
                    //Stackin içine eğer karakter operand ise push ile atar.
                    s.Push(ifade[i] + "");
                }
                    //Karakter operand değilse son ifadeyi alır ve referans bir değere atar.
                    //Daha sonra pop ile ifadeyi stacktan atar.
                    //Daha sonra ifadeyi " ( referans2 (operand) referans1 ) " şeklinde stackin içine geri atar.
                else
                {
                    String referans1 = (String)s.Peek();
                    s.Pop();
                    String referans2 = (String)s.Peek();
                    s.Pop();
                    s.Push("(" + referans2 + ifade[i] +referans1 + ")");
                }
            }
            // Döngü bittikten sonra elimizdeki kalan son ifade infix olur ve stack içersinden peek ile son ifade döndürülür.
            return (String)s.Peek();
        }

    
        public static void Main(String[] args)
        {
            String ifade;
            ifade = Console.ReadLine();
            // Girdiğimiz ifade fonksiyona main içinden gönderilir ve dönülen ifade konsola yazdırılır.
            Console.WriteLine(InfixDonusturme(ifade));
            //programın hemen kapanmaması için deger girmemizi bekleyen kod
            Console.ReadLine();
        }
    }
}
