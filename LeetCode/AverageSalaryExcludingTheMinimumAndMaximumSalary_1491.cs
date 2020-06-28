using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class AverageSalaryExcludingTheMinimumAndMaximumSalary_1491
    {
        public static double Average(int[] salary)
        {
            return (double)(salary.Sum() - salary.Max() - salary.Min()) / (salary.Length - 2);
        }
    }
}
