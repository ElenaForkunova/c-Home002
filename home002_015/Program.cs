/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите число от 1 до 7: ");
int numberWeek = Convert.ToInt32(Console.ReadLine());

if (0 < numberWeek && numberWeek <8)
{
    if (numberWeek == 1) Console.WriteLine("будни");
    if (numberWeek == 2) Console.WriteLine("будни");
    if (numberWeek == 3) Console.WriteLine("будни");
    if (numberWeek == 4) Console.WriteLine("будни");
    if (numberWeek == 5) Console.WriteLine("будни");
    if (numberWeek == 6) Console.WriteLine("выходной");
    if (numberWeek == 7) Console.WriteLine("выходной");
}
else
{
    Console.WriteLine("Введите число от 1 до 7: "); 
}