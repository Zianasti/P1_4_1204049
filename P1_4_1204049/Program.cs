using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_4_1204049
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("MENU PERSEGI PANJANG");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Hitung Panjang Diagonal");

                Console.Write("\nMenu Pilihan : ");
                int n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("\n\nLUAS PERSEGI PANJANG");
                        Console.Write("Masukan Panjang :");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Masukan Lebar :");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nLuas Persegi Panjang : " + (a * b) + "\n");
                        break;
                    case 2:
                        Console.WriteLine("\n\nKELILING PERSEGI PANJANG");
                        Console.Write("Masukan Panjang :");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Masukan Lebar :");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nKeliling Persegi Panjang : " + (2*(c+d)) + "\n");
                        break;
                    case 3:
                        Console.WriteLine("\n\nDIAGONAL PERSEGI PANJANG");
                        Console.Write("Masukan Panjang :");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Masukan Lebar :");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nDiagonal Persegi Panjang : " + (Math.Sqrt((e*e) + (f*f))) + "\n");
                        break;
                }
                Console.WriteLine("\nKembali ke Menu Pilihan ? (Y/T)");
            }
            while (Console.ReadLine() == "Y");
        }
    }
}
