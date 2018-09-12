using System;
using System.Linq;
using System.Collections.Generic;

public delegate int done (int i);

namespace Transform
{
    public static class Transform 
    {
        public static int[] Map(this int [] a, done fun)
        {
            //throw new NotImplementedException();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = fun(a[i]);
            }
            return a;
        }
    }
}
