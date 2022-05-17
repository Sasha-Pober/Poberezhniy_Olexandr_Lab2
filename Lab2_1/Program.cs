using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] clothes = { "jacket", "jumper", "sweater", "coat", "poncho", "dress shirt", "overshirt", "flannel shirt", "office shirt", "wool trousers", "chinos", "linen trousers", "cargo", "chelsea", "sneakers", "oxfords", "boots" };   //"", "", "", ""
            string[] colors = { "brown", "green", "blue", "charcoal grey", "khaki", "purple", "cyan", "beige", "indigo" };
            Random r = new Random();
            Clothes[] wardrobe = new Clothes[40];
            ClothesList list = new ClothesList();

            for(int i = 0; i < 10; i++)
            {
                wardrobe[i] = new Coat(clothes[r.Next(0, 4)], r.Next(25, 45), colors[r.Next(0, 8)]);
                wardrobe[i+10] = new Shirt(clothes[r.Next(5, 8)], r.Next(25, 45), colors[r.Next(0, 8)]);
                wardrobe[i+20] = new Trousers(clothes[r.Next(9, 12)], r.Next(25, 45), colors[r.Next(0, 8)]);
                wardrobe[i+30] = new Shoes(clothes[r.Next(13, 16)], r.Next(25, 45), colors[r.Next(0, 8)]);
            }

            string cont = default;
            while (cont != "end")
            {

                Console.WriteLine("Choose the option:\n1.Show all clothes\n2.Put something on\n3.Show my look\n");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {

                    case 1:
                        wardrobe[0].showAll(wardrobe);
                        break;

                    case 2:
                        Console.WriteLine("Choose the type of clothes you'd like to put on:");
                        string cl = Console.ReadLine();
                        Console.WriteLine("Choose size:");
                        int s = int.Parse(Console.ReadLine());
                        Console.WriteLine("Choose color:");
                        string col = Console.ReadLine();
                        Clothes clothes1 = new Clothes(cl, s, col);
                        wardrobe[0].PutOn(clothes1, list, wardrobe); 
                        break;

                    case 3:
                        list.lookNow();
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
