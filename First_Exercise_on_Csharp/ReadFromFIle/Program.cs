using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromFIle
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFile();
        }

        static void ReadFile()
        {
            string[] textOne = System.IO.File.ReadAllLines(@"txtOne.txt");

            string[] textTwo = System.IO.File.ReadAllLines(@"txtTwo.txt");

            List<string> addTxt = new List<string>();

            addTxt.AddRange(textTwo);
            addTxt.AddRange(textOne);


            addTxt.Sort();

            foreach (string temp in addTxt)
                Console.WriteLine(temp);

            Console.ReadKey();
        }
    }
}
