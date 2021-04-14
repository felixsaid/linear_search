using System;
using System.Collections.Generic;

namespace LinearSearch
{
    public static class Program
    {
        
        public static int? LinearSearch(int[] data, int value)
        {
            foreach(int item in data)
            {
                if(item == value)
                {
                    return data[item];
                }

            }

            return -1;
        }

        public static void Main(string[] args)
        {
            int[] data = new int[] { 1, 4, 6, 4, 9, 9, 4, 5, 3 };

            int? pos = LinearSearch(data, 6);

            Console.WriteLine(pos);
        }
    }
}
