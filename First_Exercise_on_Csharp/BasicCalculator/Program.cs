using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
                BasicCalculator();
        }

        static void BasicCalculator()
        {
            string[] operators = { "+", "-", "x", ":" };

            try
            {
                Console.Write("Enter your first number: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());



                Console.Write("Enter your second number: ");
                int secondtNumber = Convert.ToInt32(Console.ReadLine());


                Console.Write("Choose the operator ((+), (-), (:), (x)): ");
                string Myoperator = Console.ReadLine();

                if (operators.Contains(Myoperator))
                {
                    switch (Myoperator)
                    {
                        case "+":
                            Console.WriteLine(firstNumber + secondtNumber);
                            break;
                        case "-":
                            Console.WriteLine(firstNumber - secondtNumber);
                            break;
                        case "x":
                            Console.WriteLine(firstNumber * secondtNumber);
                            break;
                        case ":":
                            Console.WriteLine(firstNumber / secondtNumber);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("choose right operator");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
