using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main()
        {
            MainMenu();
        }

        static void MainMenu()
        {

            string input;

            Console.WriteLine("Hello, here you can check your grades");
            Console.WriteLine("Write \"switch\" if you want to use swith statement to show your grade");
            Console.WriteLine("Write \"if\" if you want to use if statement to show your grade");
            Console.WriteLine("Write \"quit\" if you want exit this program");
            Console.WriteLine();


            do
            {
                Console.Write("Input you choose: ");
                input = Console.ReadLine();
                Console.WriteLine();

                switch (input)
                {
                    case "switch":
                        GradingWithSwitch();
                        break;
                    case "if":
                        GradingWithIf();
                        break;
                    default:
                        Console.WriteLine("wrong input :(");
                        break;
                }
            }
            while (input != "quit");
        }
        static void GradingWithSwitch()
        {
            double grade = 0;


            try
            {
                Console.Write("Enter Your Grade: ");
                grade = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            switch (grade)
            {
                case 9.1:
                    Console.WriteLine("Excelent");
                    break;
                case 7.8:
                    Console.WriteLine("Notable");
                    break;
                case 6:
                    Console.WriteLine("Good");
                    break;
                case 5:
                    Console.WriteLine("Pass");
                    break;
                case 4:
                    Console.WriteLine("Fail");
                    break;
                case 3:
                    Console.WriteLine("Fail");
                    break;
                case 2:
                    Console.WriteLine("Fail");
                    break;
                case 1:
                    Console.WriteLine("Fail");
                    break;
                case 0:
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Wrong graded");
                    break;
            }
            Console.WriteLine();
        }
        static void GradingWithIf()
        {
            double grade = 0;

            try
            {
                Console.Write("Enter Your Grade: ");
                grade = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (grade == 9.1)
                Console.WriteLine("Excelent");

            else if (grade == 7.8)
                Console.WriteLine("Notable");

            else if (grade == 6)
                Console.WriteLine("Good");

            else if (grade == 5)
                Console.WriteLine("Pass");

            else if (grade <= 4 && grade >= 0)
                Console.WriteLine("Fail");

            else
                Console.WriteLine("not graded");

            Console.WriteLine();
        }

    }
}
