using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class _17_Exponent_Method
    {
        public static int GetPow(int baseNum,int PowNum) 
        {
            int result = 1;
            for (int i = 0; i < PowNum; i++)
                result *= baseNum;
            return result;
        }

    }
}
