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

            string oldText = "Сегодня мы с вами рассмотрели, как работать со строками в Си - шарп.Были описаны основные операторы и методы, которые используются для работы со строками";
            int start = oldText.IndexOf("Были");
            string newText = oldText.Substring(start, oldText.IndexOf(", которые")-start);
            Console.WriteLine(newText);

            Console.ReadKey();
        }
    }
}
