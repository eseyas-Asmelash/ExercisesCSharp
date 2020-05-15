using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumber
{
    class Program
    {
        static void Main()
        {
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter a number: ");
                int temp = Convert.ToInt32(Console.ReadLine());
                if (temp % 2 == 0)
                    evenNumbers.Add(temp);
            }

            Console.WriteLine("list of even numbers");
            foreach (int a in evenNumbers)
                Console.Write(a + " ");

            Console.ReadKey();
        }
    }
}
