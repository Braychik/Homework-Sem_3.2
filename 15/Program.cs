/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.Clear();
Console.Write("Введите номер дня недели: ");
int num=int.Parse(Console.ReadLine());

if(num<1||num>7)           // || = или 
{
    Console.WriteLine("Введен неправильный номер");
    return;
}
if(num == 6 || num == 7)
{
Console.WriteLine($"Да, {num} выходной");
}else
Console.WriteLine("нет");

