using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY2
{
    public class TASK1
    {
        private string str;

        public void setString()
        {
            Console.Write("Enter a word : ");
            str = Console.ReadLine().Replace(" ", "").ToLower();
        }

        public char occurence()
        {
            int[] arr = new int[26];
            int loc = 0, max = int.MinValue;
            for (int i = 0; i < str.Length; i++)
            {
                loc = (int)(str[i] - 97);
                arr[loc] += 1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    loc = i;
                    max = arr[i];
                }
            }

            return (char)(loc + 97);
        }
    }
}
