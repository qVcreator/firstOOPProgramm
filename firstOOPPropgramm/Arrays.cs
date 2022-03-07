using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPPropgramm
{
    static class Arrays
    {
        public static int FindMinOfArray(int[] arr)
        {
            if (arr == null)
            {
                throw new Exception("arr can't be null");
            }

            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
    }
}
