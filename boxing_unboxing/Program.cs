using System;
using System.Collections.Generic;

namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> lists = new List<object>();
            lists.Add(7);
            lists.Add(28);
            lists.Add(-1);
            lists.Add(true);
            lists.Add("Chair");

            int sum = 0;
            foreach(var list in lists) 
            {
                if (list is int) {
                    System.Console.WriteLine("Integer: " + list);
                    sum += (int)list;

                }
                if (list is bool) {
                    System.Console.WriteLine("Boolean: " + list);
                }
                if (list is string) {
                    System.Console.WriteLine("String: " + list);
                }
            }
            System.Console.WriteLine("Sum of all integers: " + sum);
        }
    }
}
