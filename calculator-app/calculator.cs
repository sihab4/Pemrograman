using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilih Menu Calculator : ");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine();


            Console.Write("Input nomor Menu [1-4] : ");

            string pilihan = Console.ReadLine();
            int a, b;
            float answer;

            if (pilihan ==  "1" )
            {
                Console.Write("Inputkan nilai a = ");
                a = Convert.ToInt32(Console.ReadLine());


                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());

                answer = a + b;
                Console.WriteLine("Hasil Penambahan {0}", a+b);

                Console.ReadKey();
            }

            else if(pilihan == "2")
            {
                Console.Write("Inputkan nilai a = ");
                a = Convert.ToInt32(Console.ReadLine());


                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());

                answer = a - b;
                Console.WriteLine("Hasil Pengurangan {0}", a - b);
            }

            else if (pilihan == "3")
            {
                Console.Write("Inputkan nilai a = ");
                a = Convert.ToInt32(Console.ReadLine());


                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());

                answer = a * b;
                Console.WriteLine("Hasil Perkalian {0}", a * b);
            }

            else if (pilihan == "4")
            {
                Console.Write("Inputkan nilai a = ");
                a = Convert.ToInt32(Console.ReadLine());


                Console.Write("Inputkan nilai b = ");
                b = Convert.ToInt32(Console.ReadLine());

                answer = a / b;
                Console.WriteLine("Hasil Pembagian {0}", a / b);
            }
            else
            {
                Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
            }
            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
    }
}
