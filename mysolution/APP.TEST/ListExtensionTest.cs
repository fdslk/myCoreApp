using System;
using Xunit;
using mylib1;
using System.Collections.Generic;

namespace APP.TEST
{
    public class UnitTest1
    {
        [Fact]
        public void GivenRepeatListThenInputDistinctList()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(1);
            list.Add(2);
            list.Add(2);
            list.Add(3);
            list.Add(3);
            List<int> list1 = list.GetUniqueList<int>();
            Assert.Equal(3, list1.Count);
        }
        [Fact]
        public void GivenAllRepeatListThenInputDistinctList()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            List<int> list1 = list.GetUniqueList<int>();
            Assert.Equal(1, list1.Count);
        }
    }
}
