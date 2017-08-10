using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSort.Core
{
    public static class LogicalSorter
    {
        public static string[] Sort(this string[] strings)
        {
            Array.Sort(strings, new LogicalComparer());
            return strings;
        }
    }
}
