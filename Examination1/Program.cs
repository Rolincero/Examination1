using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination1
{
    internal class Program
    {
        static void Main()
        {
            var arr = new string[]
            {
            "hello",
            "2",
            "World",
            ":-)"
            };

            arr = Selection.Under4(arr);

            Console.Write("Результат: ");
            foreach (var item in arr) 
            {
                Console.Write(item + " ");
            }
        }
    }
}
