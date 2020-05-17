using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class NumberOfStudentsDoingHomeworkAtAGivenTime_1450
    {
        public static int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            var counter = 0;
            
            for (int i = 0; i < startTime.Length; i++)
            {
                if (startTime[i] <= queryTime && queryTime <= endTime[i]) counter++;
            }
            return counter;
        }
    }
}
