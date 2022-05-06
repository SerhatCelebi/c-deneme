using System;
using System.Linq;

namespace calisma
{
    class Program
    {
        static void Main(string[] args)

        {
            Add();
            Console.WriteLine(Add2(10, 20));
            
            int number1 = 10;
            int number2 = 20;
            int asal;
            for (int i = 2; i < 1000; i++)
            {
                asal = 0;
                for (int j = 2; j < 1000; j++)
                {

                    if (i <= j)
                    {
                        j = 2;
                        break;
                    }
                    if (i % j == 0)
                    {
                        asal++;
                        j = 2;
                        break;
                    }

                }
                if (asal == 0)
                {
                    Console.WriteLine("{0} bir asal sayidir", i);
                }
                
            }

            var result99 = Add2(number1, number2);
            Console.WriteLine(Multiply(10, 20));
            Console.WriteLine(Multiply(10, 20,30));
            Console.WriteLine(Add4(1, 3, 4, 5, 65, 6, 7,123));
            string[] students = new string[3];
            students[0] = "engin";
            students[1] = "salih";
            students[2] = "derin";
            string[,] regions = new string[5, 3]
            {
                {"Istanbul","Edirne","Kocaeli" },
                {"Antalya","Adana","Mugla" },
                {"Ankara","Konya","Kayseri" },
                {"Rize","Trabzon","Zonguldak" },
                {"Izmir","Mersin","Aydin" },
               
            };

            for (int i = 0; i <= 100; i++)
            {
                Console.Write("{0}.sayi:{1} ",i+1,i);
            }
            Console.WriteLine();
            Console.WriteLine("*********");
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("*********");
            }
            
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("*********");
            string kelime = "Naber kanka nasilsin";
            string kelime2 = "iyidir knk";
            var result1 = kelime.Length;
            var result2 = kelime.Clone();
            var result3 = kelime.EndsWith("n");
            var result4 = kelime.StartsWith("Naber");
            var result5 = kelime.IndexOf(" ");
            var result6 = kelime.LastIndexOf(" ");
            var result7 = kelime.Insert(0, "hello, ");
            var result8 = kelime.Substring(4);
            var result9 = kelime.ToLower();
            var result10 = kelime.ToUpper();
            var result11 = kelime.Replace(" ", "-");
            var result12 = kelime.Remove(2, 4);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);
            Console.WriteLine(result9);
            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.WriteLine(result12);


            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int sayi1,int sayi2=30)
        {
            sayi1 = 30;
            return (sayi1 + sayi2);
        }
        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2*number3;
        }
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }


    }
}


