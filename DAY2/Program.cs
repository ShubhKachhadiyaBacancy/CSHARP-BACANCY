//Write a program that finds the most frequently occurring character in a string entered by the user. Ignore spaces and make it case-insensitive. - Shubh
//Example:
//Input: programming
//Output: Most Frequent Character: g

using DAY2;

TASK1 task1 = new TASK1();
task1.setString();

string str = task1.occurenceUsingDictionary();
Console.WriteLine("USING DICTIONARY : " + str);

char ch = task1.occurenceUsingArray();
Console.WriteLine("USING ARRAY : " + ch);