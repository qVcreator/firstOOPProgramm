using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstOOPPropgramm.Test
{
    public static class TwoDimensionalArrayMock
    {
        public static int[,] GetMock(Enums.TwoDimensionalArraay type)
        {
            switch (type)
            {
                case Enums.TwoDimensionalArraay.first:
                    return new int[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };
                    break;
                case Enums.TwoDimensionalArraay.second:
                    return new int[,] { { 254,0,3 }, { -1, 21, -54 }, { 32, 4, 5 } };
                    break;
                case Enums.TwoDimensionalArraay.oneOnly:
                    return new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
                    break;
                case Enums.TwoDimensionalArraay.empty:
                    return new int[,] { {}, {}, {} };
                    break;
                default:
                    throw new Exception();
            }
        }
    }
}
