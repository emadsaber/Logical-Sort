using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogicalSort.Core;
using System.IO;
using System.Linq;
using System.Diagnostics;

namespace LogicalSort.Tests
{
    [TestClass]
    public class MainTests
    {
        public string Path { get { return @"test"; } }
        [TestMethod]
        public void TestSortingStrings()
        {

            var unSorted = Directory.GetFiles(this.Path);
            
            var sorted = unSorted.Sort();

            Assert.AreEqual(sorted[sorted.Length - 1], this.Path + "\\112.txt");
        }

        [TestMethod]
        public void TestSortingFileInfo()
        {
            var unsortedFiles = from file in new DirectoryInfo(this.Path).GetFiles()
                        select file;

            var sortedFiles = unsortedFiles.ToArray<FileInfo>().Sort();

            Assert.AreEqual(sortedFiles[sortedFiles.Length - 1].Name, "112.txt");
        }
    }
}
