# Most Frequent Character Finder 

## Description

This C# program takes a string input from the user, ignores spaces, and performs case-insensitive character frequency analysis to find the most frequently occurring character in the string.

## Features

- **Case-insensitive:** The program compares characters without considering their case.
- **Ignores spaces:** All spaces in the string are excluded from the character count.
- **Efficient frequency counting:** The program uses a dictionary to count the frequency of each character.

 ## Code

```csharp
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
            str = Console.ReadLine().ToLower();
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

        public char occurence()
        {
            int[] arr = new int[26];
            int loc=0, max = int.MinValue;
            for (int i = 0; i < str.Length; i++)
            {
                loc = (int)(str[i] - 97);
                arr[loc] += 1;
            }

            for (int i = 0;i < arr.Length;i++)
            {
                if(arr[i] > max)
                {
                    loc = i;
                    max = arr[i];
                }
            }

            return (char)(loc + 97);
        } 
    }
}
```


## How to Run

1. Clone or download the repository to your local machine.
2. Open the solution in Visual Studio or any other C# IDE.
3. Build and run the program.
4. Enter a string when prompted.

## Example Usage

**Input:**  
`programmingg`

**Output:**  
`g`  

















## Authors

- Shubh Kachhadiya

