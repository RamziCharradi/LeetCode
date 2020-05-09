using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class DestinationCity_1436
    {
        public string DestCity(IList<IList<string>> paths)
        {
            var d = new Dictionary<string, string>();
            foreach (var path in paths)
                d[path[0]] = path[1];
            return d.First(keyValue => !d.ContainsKey(keyValue.Value)).Value;

        }
    }
}
