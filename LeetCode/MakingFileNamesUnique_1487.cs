using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class MakingFileNamesUnique_1487
    {
        public static string[] GetFolderNames(string[] names)
        {
            HashSet<string> prev = new HashSet<string>();
            string[] ans = new string[names.Length];
            int i = 0;
            foreach (var name in names)
            {
                if (!prev.Contains(name)) 
                {
                    prev.Add(name);
                    ans[i] = name;
                } 
                else
                {
                    int j = 1;
                    while (1 == 1)
                    {
                        if (prev.Contains(name + "(" + j + ")")) j++;
                        else
                        {
                            ans[i] = name + "(" + j + ")";
                            prev.Add(name + "(" + j + ")");
                            break;
                        }
                    }
                }
                i++;
            }

            return ans;
        }
    }
}
