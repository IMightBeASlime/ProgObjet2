using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_exercice3
{
    public class TrucDeMath
    {
        public int PlusGrandDiviseurCommun(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            for(; ; )
            {
                int reste = a % b;
                if (reste == 0) return b;
                a = b;
                b = reste;
            }
        }
    }
}
