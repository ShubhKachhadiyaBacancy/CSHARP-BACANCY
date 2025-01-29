//Create a C# program that demonstrates the use of extension methods to enhance
//built-in types like string and int. The program will not only implement common
//string and numeric operations using extension methods but also integrate some
//extra functionality that makes the extension methods more flexible and dynamic.

//Scenario:

//You are working on a custom logging utility for a web application.
//The utility needs to:
//1.Add a timestamp to each log message (using string extension).
//2.Filter log messages based on whether they contain certain keywords
//  (using string extension).
//3.Log even numbers and calculate the sum of odd numbers (using int extension).

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
keywords.Add("Delete");

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