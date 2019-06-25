using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationYeild
{
    class Program
    {
        static void Main(string[] args)
        {
            //tet
            A a = new A();   
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            foreach(int i in a.GetEnumerator1())
            {

            }
            List<int> list = new List<int>()
            {
                1,23,43,43,53,5,465,46,546,546,5,756,765,765,7,657,34567
            };
            list.TESTWhere(p=>p>5);

            StringExtension.Foo("123");
            Console.ReadKey();
        }


    }
    public static class B
    {
        public static IEnumerable TESTWhere(this List<int> lst, Func<int, bool> func)
        {
            List<int> lst1 = new List<int>();
            foreach (int i in lst)
            {
                if (func.Invoke(i))
                {
                    lst1.Add(i);
                }
            }
            return lst1;

        }

    }

    public  class A : IEnumerable
    {
        private static int[] array = { 1, 2, 4, 5, 6, 7, 11, 23, 45, 456 };

        public static IEnumerable<int> lst = new List<int>();

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return array[i];
            }
        }
        public IEnumerable GetEnumerator1()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return array[i];
            }
        }
    }


    

    public static class StringExtension
    {
        public static void Foo(this string s)
        {
            Console.WriteLine("Foo invoked for {0}", s);
        }
    }
}
