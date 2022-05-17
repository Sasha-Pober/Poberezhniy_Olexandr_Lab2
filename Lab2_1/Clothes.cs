using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    class Clothes
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }

        public Random r = new Random();

        public Clothes() { }
        public Clothes(string name, int size, string color)
        {
            Name = name;
            Size = size;
            Color = color;
        }
        public void ShowStats()
        {
            Console.WriteLine(ToString());
        }


        public void showAll(Clothes[] l)
        {
            int j = 1;
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("\n" + l[i * 10 - 1].GetType().Name);
                while(j <= i*10)
                {
                    l[j - 1].ShowStats();
                    j++;
                }
            }
        }

        public Clothes Find(Clothes[] k, Clothes t)
        {
            for (int i = 0; i < k.Length; i++)
            {
                if (k[i].Equals(t))
                {
                    return k[i];
                    break;
                }
            }
            return null;
        }

        public void PutOn(Clothes b, ClothesList k, Clothes[] a)
        {
            k.Add(b.Find(a, b));

            if (b.Find(a, b) == null) Console.WriteLine("looks like we haven't this item");
            else Console.WriteLine("You've successfully dressed up");
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Clothes a = obj as Clothes;
            return Size == a.Size && Color == a.Color && Name.ToLower() == a.Name;
        }

        public override int GetHashCode()
        {
            string name = GetType().Name;
            int code = 0;
            switch (name)
            {
                case "Coat":
                    code = 1;
                    break;
                case "Shirt":
                    code = 2;
                    break;
                case "Shoes":
                    code = 3;
                    break;
                case "Trousers":
                    code = 4;
                    break;
                default:
                    code = 0;
                    break;

            }
            return code;
        }

        public override string ToString()
        {
            return $"{Name} has {Size} size and {Color} color";
        }
    }



}

                    