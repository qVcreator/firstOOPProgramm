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
                    return new int[,]
                    {   { 1, 2, 3 },
                        { 2, 3, 4 },
                        { 3, 4, 5 } };
                    break;
                case Enums.TwoDimensionalArraay.second:
                    return new int[,]
                    { { 254,0,3 },
                    { -1, 21, -54 },
                    { 32, 4, 5 } };
                    break;
                case Enums.TwoDimensionalArraay.oneOnly:
                    return new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
                    break;
                case Enums.TwoDimensionalArraay.firstSwap:
                    return new int[,]
                    {   { 1, 2, 3 },
                        { 2, 3, 4 },
                        { 3, 4, 5 } };
                    break;
                case Enums.TwoDimensionalArraay.secondSwap:
                    return new int[,]
                    { { 254,-1,32 },
                    { 0, 21, 4 },
                    { 3, -54, 5 } };
                    break;
                case Enums.TwoDimensionalArraay.oneOnlySwap:
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
