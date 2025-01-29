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

        public string occurenceUsingDictionary()
        {
            Dictionary<Char, int> count = new Dictionary<Char, int>();
            int max = int.MinValue;
            string ch = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (count.ContainsKey(str[i]))
                {
                    count[str[i]] = count[str[i]] + 1;
                }
                else
                {
                    count.Add(str[i], 1);
                }
            }

            foreach (char c in count.Keys)
            {
                if (count[c] > max)
                {
                    max = count[c];
                    ch =  c.ToString();
                }
            }

            return ch;
        }

        public char occurenceUsingArray()
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
