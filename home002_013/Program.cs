/* Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите любое число: ");
int a = Convert.ToInt32(Console.ReadLine());

//создаю 3 условия, которые проверяют в каком интервале лежит число

if (a > 999)
{
    do
    {
        a = a / 10;
    }
    while (a > 999);
}

if (99 < a && a < 1000)
{
    int a1 = a % 10;
    Console.WriteLine($"третья цифра этого числа {a1}");
}

else
{
    Console.WriteLine("третьей цифры нет"); 
}