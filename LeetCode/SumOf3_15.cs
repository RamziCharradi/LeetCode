using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public class SumOf3_15
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);

            IList<IList<int>> Result = new List<IList<int>>() { };
            if (nums.Count() < 3) return Result;

            if (nums.Where(x => x == 0).Count() > 2)
            {
                Result.Add(new List<int> { 0, 0, 0 });
            }

            var negative = nums.Select(x => x).Where(x => x < 0);
            var positive = nums.Select(x => x).Where(x => x > 0);


            foreach (var n in negative)
            {
                foreach (var p in positive)
                {
                    var X = -(n + p);
                    var l = new List<int> { n, p, X }.OrderBy(x=>x).ToList();

                    if (X==p)
                    {
                        if (positive.Where(x => x == p).Count() > 1)
                        {
                            if (!Result.Any(x => x.SequenceEqual(l)))
                            {
                                Result.Add(l);
                            }
                           
                        }
                    }
                    else if(X == n)
                    {
                        if (negative.Where(x => x == n).Count() > 1)
                        {
                            if (!Result.Any(x => x.SequenceEqual(l)))
                            {
                                Result.Add(l);
                            }
                            
                        }
                    }
                    else if (nums.Contains(X)){

                        if (!Result.Any(x => x.SequenceEqual(l)))
                        {
                            Result.Add(l);
                        }
                        
                    }
                }
            }

            return Result;
        }
    }
}
