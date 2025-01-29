# Custom Logging Utility with Extension Methods

## Overview
This C# program demonstrates the use of extension methods to enhance built-in types (`string` and `int`). It implements a custom logging utility that:
1. Adds a timestamp to log messages.
2. Filters log messages based on specific keywords.
3. Logs even numbers from a list and calculates the sum of odd numbers.

## Features
- **Timestamped Log Messages**: Adds the current timestamp to log messages.
- **Keyword-Based Filtering**: Filters logs based on a list of keywords.
- **Even/Odd Number Operations**: Logs even numbers and calculates the sum of odd numbers from a list of integers.

## Program Structure

### 1. String Extensions
The `StringExtensions` class provides two methods:
- **AddTimeStamp**: Adds the current timestamp to a string.
- **FilterLogMessages**: Filters log messages based on a list of keywords.

### 2. Integer Extensions
The `IntegerExtensions` class provides the method:
- **LogEvenAndSumOdd**: Logs even numbers from a list of integers and calculates the sum of odd numbers.

### 3. Main Program
In the `Main` method, the program performs the following operations:
- Adds a timestamp to a string.
- Filters log messages based on keywords.
- Logs even numbers and calculates the sum of odd numbers from a list of integers.

## Example Usage

### Code : Program.cs 
```csharp
using DAY3;

string str = "hello world";
Console.WriteLine("TimeStamped Log Messages : ");
Console.WriteLine(str.AddTimeStamp()); 

List<string> logsList = new List<string>();
logsList.Add("Error: Unable to connect to the database.");
logsList.Add("Warning: Low disk space.");
logsList.Add("Information: Scheduled backup completed.");

List<string> keywords = new List<string>();
keywords.Add("Error");
keywords.Add("Warning");

var filteredLogs = logsList.Where(msg => msg.FilterLogMessages(keywords)).ToList();

Console.WriteLine("\nFiltered Log Messages:");
foreach (var filteredLog in filteredLogs)
{
    Console.WriteLine(filteredLog);
}

List<int> numbersList = new List<int>();
for (int i = 0; i < 5; i++)
{
    numbersList.Add(i);
}

Console.WriteLine("\nEven Numbers : ");
int oddSum = numbersList.LogEvenAndSumOdd();
Console.WriteLine($"\n\nSum Of Odd Numbers : {oddSum}");
```

### Code : StringExtensions.cs
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY3
{
    public static class StringExtensions
    {
        public static string AddTimeStamp(this string str)
        {
            string strWithTimeStamp = $"{DateTime.Now} : {str}";
            return strWithTimeStamp;
        }

        public static bool FilterLogMessages(this string str,List<string> keywords)
        {
            if(str == "" || keywords.Count() == 0)
            {
                return false;
            }
            
            return keywords.Any(keyword => str.IndexOf(keyword,0) >= 0);
        }
    }
}

```
### Code : IntegerExtensions
``` 
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
```

## How to Use

1. Open a C# development environment, such as Visual Studio or any text editor with a .NET compiler.
2. Copy the provided code into a new C# Console Application project.
3. Build and run the program.
4. Enter the list members and show the older and sorted list.

## Example Usage



**Output:**  
```
TimeStamped Log Messages :
29-01-2025 14:26:15 : hello world

Filtered Log Messages:
Error: Unable to connect to the database.
Warning: Low disk space.

Even Numbers :
0 2 4

Sum Of Odd Numbers : 4


## Authors

- Shubh Kachhadiya
```
