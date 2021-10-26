using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int> { 10, 12, 50 };
            List<int> b = new List<int> { 20, 20, 10 };
            List<int> res = compareTriplets(a, b);
            foreach (var item in res)
            {
                Console.Write(item);
            }
        }

        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int counta = 0;
            int countb = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = i; j < b.Count; j++)
                {
                    if (a[i] > b[j])
                    {
                        counta++;
                        break;
                    }
                    else if(a[i] == b[j])
                    {
                        break;
                    }
                    else
                    {
                        countb++;
                        break;
                    }
                }
            }
            if (counta >= countb)
            {
                list.Add(counta);
                list.Add(countb);
            }
            else
            {
                list.Add(countb);
                list.Add(counta);
            }

            return list;
        }
    }
}
