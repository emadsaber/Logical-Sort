using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Sort
{
    public static class LogicalSorter
    {
        public static void Sort(this string[] strings)
        {
            Array.Sort(strings, new LogicalComparer());
        }
    }
}
