using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseArray();
        }
        static void ReverseArray()
        {
            int[] orderedarray = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Write a number: ");
                int temp = Convert.ToInt32(Console.ReadLine());
                orderedarray[i] = temp;
            }

            Console.WriteLine("Numbers in the order of input");
            foreach (int a in orderedarray)
                Console.Write(a + " ");

            Array.Reverse(orderedarray);

            Console.WriteLine("\nNumbers in reversed order");
            foreach (int a in orderedarray)
                Console.Write(a + " ");

            Console.ReadKey();
        }
    }
}
