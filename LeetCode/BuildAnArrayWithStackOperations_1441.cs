using System;
using System.Collections.Generic;
using System.Text;


namespace LeetCode
{
    public class BuildAnArrayWithStackOperations_1441
    {
        public static IList<string> BuildArray(int[] target, int n)
        {
            IList<string> Result = new List<string>();
            var counter = 1;
            foreach (var x in target)
            {
                if (x == counter) Result.Add("Push");
                else
                {
                    while (counter <= n)
                    {
                        if (x!= counter)
                        {
                            Result.Add("Push");
                            Result.Add("Pop");
                        }
                        else
                        {
                            Result.Add("Push");
                            break;
                        }
                        
                        counter++;
                    }
                    
                }
                counter++;
            }
            return Result;
        }
    }
}
