/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6   */

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
string numStr = Convert.ToString(num);
int numL = numStr.Length;
if (numL > 2) 
Console.WriteLine($"Третья цифра введённого числа: {numStr[2]}");
else 
Console.WriteLine("третьей цифры нет");
