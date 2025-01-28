//Write a program that finds the most frequently occurring character in a string entered by the user. Ignore spaces and make it case-insensitive. - Shubh
//Example:
//Input: programming
//Output: Most Frequent Character: g

using DAY2;

TASK1 task1 = new TASK1();
task1.setString();
char ch = task1.occurence();
Console.WriteLine(ch);