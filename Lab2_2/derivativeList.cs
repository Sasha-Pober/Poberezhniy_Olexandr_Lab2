using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    class derivativeList : insuranceLiabilities
    {
        private List<insuranceLiabilities> list = new List<insuranceLiabilities>(0);

        public void Create(insuranceLiabilities[] a)
        {
            list.Clear();
            list.Add(a[r.Next(0, 9)]);
            list.Add(a[r.Next(10, 19)]);
            list.Add(a[r.Next(20, 29)]);
            list.Add(a[r.Next(30, 39)]);
        }

        public void ShowDerivative()
        {
            Console.WriteLine("The Derivative is");
            foreach (var i in list)
            {
                i.Show();
            }
        }

        public void Sort()
        {
            list.Sort(Comparsion<insuranceLiabilities>.comparer());
        }

        public void countPrice()
        {
            int sum = 0;
            for (int i = 0; i < list.Capacity; i++)
            {
                sum += list[i].GetHashCode();
            }
            Console.WriteLine($"The price is: {sum}");
        }
    }
}
