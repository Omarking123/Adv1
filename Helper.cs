using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv1
{
    internal static class Helper
    {


        public static int linearsearch <T>(T[] arr , T value)
        {
            if(arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Equals(value)) return i;
                    
                }
                
            }
            return -1;
        }

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
