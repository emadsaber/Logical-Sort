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
        public void TestSorting()
        {

            var unSorted = Directory.GetFiles(this.Path);
            
            var sorted = unSorted.Sort();

            Assert.AreEqual(sorted[sorted.Length - 1], this.Path + "\\112.txt");
        }
    }
}
