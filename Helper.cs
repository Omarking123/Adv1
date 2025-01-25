using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv1
{
    internal static class Helper
    {


        public static void BubbleSort <T>(T[]Arr)where T : IComparable
        {
            if(Arr?.Length > 0)
            {
                for(int i =0; i <Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length -1; j++)
                    {
                        if (Arr[j].CompareTo(Arr[j + 1]) > 0) 
                        {
                            Swap(ref Arr[j],ref Arr[j + 1]);
                        }
                    }
                }
            }
        }

        public static void Print <T>(T[] arr)
        {
            foreach(T i in arr)
            {
                Console.Write($"{i} ");
            }
        }
        #region video 3
        //public static int linearsearch <T>(T[] arr , T value)
        //{
        //    if(arr?.Length > 0)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            if (arr[i].Equals(value)) return i;

        //        }

        //    }
        //    return -1;
        //} 
        #endregion

        #region generic
        public static void Swap<T>(ref T x, ref T y)

        {
            T Temp = x;
            x = y;
            y = Temp;
        } 
        #endregion



        #region non generic
        //public static void Swap(ref int x, ref int y)

        //{
        //    int Temp = x;
        //    x = y;
        //    y = Temp;
        //}
        //public static void Swap(ref double x, ref double y)

        //{
        //    double Temp = x;
        //    x = y;
        //    y = Temp;
        //}
        //public static void Swap(ref Point x, ref Point y)

        //{
        //    Point Temp = x;
        //    x = y;
        //    y = Temp;
        //} 
        #endregion
    }
}
