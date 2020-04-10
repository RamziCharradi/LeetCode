using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class MinStack_155
    {
        List<int> list;

        public MinStack_155()
        {
            list = new List<int> { };
        }

        public void Push(int x)
        {
            list.Add(x);
        }

        public void Pop()
        {
            list.RemoveAt(list.Count - 1);
        }

        public int Top()
        {
            return list[list.Count - 1];
        }

        public int GetMin()
        {
            return list.Min();
        }
    }
}
