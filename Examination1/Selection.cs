using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination1
{
    internal class Selection
    {
        public static string[] Under4(string[] arr) => arr.Select(x => x).Where(x => x.Length < 4).ToArray();
    }
}
