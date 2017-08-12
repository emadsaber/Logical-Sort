using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LogicalSort.Core
{
    public static class LogicalSorter
    {
        public static string[] Sort(this string[] strings)
        {
            Array.Sort(strings, new LogicalComparer());
            return strings;
        }
        public static FileInfo[] Sort(this FileInfo[] files)
        {
            Array.Sort<FileInfo>(files, new LogicalComparer());
            return files;
        }
    }
}
