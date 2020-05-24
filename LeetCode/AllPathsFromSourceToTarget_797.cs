using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class AllPathsFromSourceToTarget_797
    {
        public static IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            var list = new List<IList<int>>();

            Backtrack(list, graph, new List<int> { 0 }, 0);

            return list;
        }

        private static void Backtrack(List<IList<int>> list, int[][] graph, List<int> temp, int p)
        {
            if (temp.Count > 1 && temp[temp.Count - 1] == graph.Length - 1) list.Add(new List<int>(temp));

            for (var i = 0; i < graph[p].Length; i++)
            {
                temp.Add(graph[p][i]);

                Backtrack(list, graph, temp, graph[p][i]);

                temp.RemoveAt(temp.Count - 1);
            }
        }


        //public static IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        //{
        //    IList<IList<int>> Result = new List<IList<int>>();
        //    for (int i = 0; i < graph[0].Length; i++)
        //    {
        //        Result.Add(new List<int> { 0 });
        //    }

        //    for (int i = 0; i < graph.Length; i++)
        //    {
        //        var counter = 0;
        //        IList<int> prev = new List<int>();
        //        while (counter < graph[i].Length)
        //        {
        //            foreach (var x in Result)
        //            {
        //                if (x[x.Count-1]==i)
        //                {
        //                    if (counter == 0)
        //                    {
        //                        prev = x;
        //                        x.Add(graph[i][counter]);
        //                        break;
        //                    }
        //                    else 
        //                    {
        //                        var aux = prev.ToList();
        //                        aux.Add(graph[i][counter]);
        //                        Result.Add( aux );
        //                        break;
        //                    }

        //                }
        //            }
        //            counter++;
        //        }
        //    }

        //    return Result;

        //}
    }
}
