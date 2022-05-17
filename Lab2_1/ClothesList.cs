using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    class ClothesList : Clothes
    {
        private List<Clothes> clothes = new List<Clothes>(0);

        public void Add(Clothes a)
        {
            clothes.Add(a);
        }

        public void lookNow()
        {
            if (clothes.Count == 0)
                Console.WriteLine("You're wearing nothing");
            else
            {
                if (clothes.Count < 4)
                    Console.WriteLine("Excuse me, but... you're particulary naked");

                Console.WriteLine($"\nNow, you're wearing:");
                foreach (var a in clothes)
                {
                    a.ShowStats();
                }
            }
        }
    }
}
