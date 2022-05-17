using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Страхування. Визначити ієрархію страхових зобов'язань. 
    Зібрати із зобов'язань дериватив. Підрахувати вартість. 
    Провести сортування зобов'язань в деривативів на основі зменшення ступеня ризику.
    Знайти зобов'язання в деривативів, відповідне заданому діапазону параметрів.

 */

namespace Lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            string[] duties = { "health insurance", "life insurance", "body insurance", "accident insurance", "kidnaping insurance", "damaging insurance", "natural disasters insurance", "disease insurance", "job loss insurance", "unemployment insurance", "eld insurance" }; //" ", " ", " ", " "
            insuranceLiabilities[] k = new insuranceLiabilities[40];
            derivativeList list = new derivativeList();

            for(int i = 0; i < 10; i++)
            {
                k[i] = new health(duties[r.Next(0, 3)], r.Next(1,99), r.Next(500, 5000));
                k[i+10] = new property(duties[r.Next(3, 6)], r.Next(1, 99), r.Next(500, 25000));
                k[i+20] = new realEstate(duties[r.Next(3, 6)], r.Next(1, 99), r.Next(500, 15000));
                k[i+30] = new social(duties[r.Next(7, 10)], r.Next(1, 99), r.Next(500, 5000));
            }

            string cont = default;
            while (cont != "end")
            {

                Console.WriteLine("Choose the option:\n1. Show all liabilities\n2. Form derivative\n3. Count price of derivative\n4. Find liability");

                int option = int.Parse(Console.ReadLine());
                switch (option)
                {

                    case 1:
                        k[0].showAll(k);
                        break;

                    case 2:
                        k[0].Derivative(list, k);
                        break;

                    case 3:
                        list.countPrice();
                        break;

                    case 4:
                        Console.WriteLine("Enter the edges of search:\nFor risk:\nFrom:");
                        int aa = int.Parse(Console.ReadLine());
                        Console.WriteLine("To:");
                        int bb = int.Parse(Console.ReadLine());
                        Console.WriteLine("For price:\nFrom:");
                        int cc = int.Parse(Console.ReadLine());
                        Console.WriteLine("To:");
                        int dd = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        k[0].Find(aa, bb, cc, dd, k);
                        break;

                    default:
                        Console.WriteLine("Returning to menu...");
                        break;

                }
                Console.WriteLine("\nType \"end\" for closing program");
                cont = Console.ReadLine();
            }
        }
    }
}

                   
