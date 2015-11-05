using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Searching.Tests
{
    [TestFixture]
    public class BinarySearcherTests
    {
        [TestCase(new int[] {1,2,3,4,5,6,7,8},1,Result= 0)]
        [TestCase(new int[] { 8,7,6,5,4,3,2,1 }, 1, Result = 7)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 10, Result = -1)]
        public int SearchTestInt(int[] arr,int  key)
        {
            return BinarySearver.Search<int>(arr, key, (x, y) => { if (x > y) return 1; if (x == y) return 0; else return -1; });
        }
        [TestCase(new string[] { "a","ab","abc" }, "ac", Result = -1)]
        [TestCase(new string[] { "a", "b", "c", "d" }, "d", Result = 3)]
        [TestCase(new string[] {"d","c","b","a"},"d", Result = 0)]
        public int SearchTestString(string[] arr, string key)
        {
            return BinarySearver.Search<string>(arr, key, (x, y) => { return String.Compare(x, y); });
            
        }
        [TestCase(new int[] { 8, 7, 6, 5, 4, 3, 2, 1 }, 1, Result = 7)]
        [ExpectedException(typeof(ArgumentNullException))]
        public int SearchTestIntExc(int[] arr, int key)
        {
            return BinarySearver.Search<int>(arr, key,null);
        }
    }
}
