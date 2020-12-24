using System;
using System.Collections.Generic;

namespace Lesson022_HT
{
    class MainClass
    {
        
        public static List<int> GetArr (int[] arr)
        {
            List<int> list = new List<int>();
            for (int i =0;i<5; i++)
            {
                if(arr[i] % 2 == 0)
                {
                    list.Add(arr[i]);
                    return list;
                }
            }
            return default;
        }
        public static void Main(string[] args)
        {
            List<int> list2 = new List<int>();
            int[] arr = new int[5];
            arr[0] = 2;
            arr[1] = 3;
            arr[2] = 6;
            arr[3] = 8;
            arr[4] = 1;
            list2 = GetArr(arr);
            Console.WriteLine(list2);
        }
    }
}
