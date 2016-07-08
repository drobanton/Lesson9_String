using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string oldString = "Nikolay Oleg";
            string newString=oldString.Replace("Nikolay", "Oleg");
            Console.WriteLine(newString);

            Console.ReadKey();
        }
    }
}
