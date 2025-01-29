# Find the Second Largest of Ten Numbers

This C# program finds the second largest number from a list of ten numbers entered by the user. The program ensures the correct determination of the second largest value, even if the array contains duplicates.

## Features
- Accepts exactly 10 numerical inputs from the user.
- Identifies the largest and second largest numbers efficiently.


## How It Works
1. The user is prompted to input ten numbers.
2. The program iterates through the numbers while keeping track of the largest and second largest numbers.
3. After processing all inputs, the second largest number is displayed.

## Code
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Tasks.DAY1
{
    public class TASK1
    {
        private int[] arr = new int[10];

        public void getValues()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter Number {i+1} : ");
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
        }

        public int getSecondLargestValue()
        {
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
```

## Example
### Input:
```
Enter Number 1 : 5
Enter Number 2 : 4
Enter Number 3 : 3
Enter Number 4 : 2
Enter Number 5 : 1
Enter Number 6 : 6
Enter Number 7 : 7
Enter Number 8 : 8
Enter Number 9 : 9
Enter Number 10 : 10

ARRAY VALUES :
1 2 3 4 5 6 7 8 9 10
```

### Output:
```
SECOND LARGEST VALUE : 9
```

## How to Run the Program
1. Copy the code into a C# development environment.
2. Build and run the program.
3. Input ten numbers when prompted.
4. View the second largest number in the output.











## Authors

- Shubh Kachhadiya

