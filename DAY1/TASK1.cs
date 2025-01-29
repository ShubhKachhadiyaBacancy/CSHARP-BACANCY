
//Find the second Largest of ten Numbers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DAY1
{
    public class TASK1
    {
        private int[] arr = new int[5];

        public void getValues()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter Number {i + 1} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                //arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public void printAllValues()
        {
            Console.WriteLine("\nARRAY VALUES : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            //foreach (var item in arr)
            //{
            //    Console.Write(item);
            //}
        }

        public int getSecondLargestValue()
        {
            //int max = int.MinValue, secondMax = int.MinValue;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        secondMax = max;
            //        max = arr[i];
            //    }
            //}

            int max = int.MinValue, secondMax = int.MinValue;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] > max)
                {
                    secondMax = max;
                    max = arr[i];
                }
                else if (arr[i] > secondMax && arr[i] < max)
                {
                    secondMax = arr[i];
                }
            }
            return secondMax;
        }
    }
}
