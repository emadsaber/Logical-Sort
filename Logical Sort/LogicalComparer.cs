using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSort.Core
{
    public class LogicalComparer : IComparer<string>, IComparer<FileInfo>
    {

        [DllImport("shlwapi.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        static extern int StrCmpLogicalW(String x, String y);

        public int Compare(FileInfo x, FileInfo y)
        {
            return StrCmpLogicalW(x.Name, y.Name);
        }

        public int Compare(string x, string y)
        {
            return StrCmpLogicalW(x, y);
        }

    }
}
