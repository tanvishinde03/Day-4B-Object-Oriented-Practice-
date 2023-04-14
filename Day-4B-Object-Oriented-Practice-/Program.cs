using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4B_Object_Oriented_Practice_
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 2, 5, 6, 3, 7, 8, 7 };
            int count = 0;

            // Loop through each element in the array
            for (int i = 0; i < arr.Length; i++)
            {
                // Loop through each element again starting from i+1
                for (int j = i + 1; j < arr.Length; j++)
                {
                    // If the element at index i is equal to the element at index j, then it's a duplicate
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine("Total number of duplicate elements in the array: {0}", count);
            Console.ReadLine();
        }
    }
}
    

