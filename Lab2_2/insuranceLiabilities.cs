using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    class insuranceLiabilities
    {
        public string Name { get; set; }
        public int risk { get; set; }
        public int price { get; set; }

        public Random r = new Random();

        public void Show()
        {
            Console.WriteLine(ToString());
        }
        
        public void Derivative(derivativeList k, insuranceLiabilities[] a)
        {
            k.Create(a);
            k.Sort();
            k.ShowDerivative();
        }

        public void showAll(insuranceLiabilities[] l)
        {
            int j = 1;
            for(int i = 1; i <= 4; i++)
            {
                Console.WriteLine(l[i * 10 - 1].GetType().Name);
                while (j <= i*10)
                {
                    l[j - 1].Show();
                    j++;
                }
            }
        }

        public void Find(int a, int b, int c, int d, insuranceLiabilities[] x)
        {
            for(int i = 0; i < x.Length; i++)
            {
                if ((x[i].risk >= a && x[i].risk <= b) && (x[i].price >= c && x[i].price <= d))
                    x[i].Show();
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            insuranceLiabilities o = obj as insuranceLiabilities;
            return o.risk==this.risk && o.price == this.price;
        }

        public override int GetHashCode()
        {
            return price;
        }

        public override string ToString()
        {
            return $"{Name}, risk: {risk}%, price: {price}";
        }

    }
    class Comparsion<T> : IComparer<T> 
    {
        int IComparer<T>.Compare(T x, T y)
        {
            insuranceLiabilities a1 = (insuranceLiabilities)Convert.ChangeType(x, x.GetType());
            insuranceLiabilities b1 = (insuranceLiabilities)Convert.ChangeType(y, y.GetType());

            if (a1.risk > b1.risk)
                return -1;

            if (a1.risk < b1.risk)
                return 1;

            else
                return 0;

        }

        public static  IComparer<T> comparer()
        {
            return (IComparer<T>)new Comparsion<T>();
        }
    }
}
