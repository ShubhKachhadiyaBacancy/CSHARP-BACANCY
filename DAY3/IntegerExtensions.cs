using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY3
{
    public static class IntegerExtensions
    {
        public static int LogEvenAndSumOdd(this List<int> intList)
        {
            if (intList.Count() == 0)
            {
                return 0;
            }

            int sum = 0;
            foreach(int element in intList){
                if (element % 2 == 0)
                {
                    Console.Write(element + " ");
                }
                else
                {
                    sum += element;
                }
            }
            return sum;
        }
    }
}
