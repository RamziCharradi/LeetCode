using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class NumberComplement_476
    {
        public static int FindComplement(int num)
        {

            int i = 0;
            for (; i < 32; i++) if((num >> i) == 1) break;
            int result = (1 << (i + 1)) - 1;
            return num ^ result;

             /* c++ - Solution 
              
                int i = 0;
                for (; i < 32; i++) if((num >> i) == 1) break;
        
                uint32_t result;
                result = (UINT32_C(1) << (i + 1)) - 1;
            
                return num ^ result;

            */

        }
    }
}
