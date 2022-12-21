/*Задача 13: Напишите программу, 
которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.WriteLine("Введите любое целое число");
int number = Convert.ToInt32(Console.ReadLine());
// Для положительных чисел
if (number < 100 && number > 0)
{
    Console.WriteLine("Третьей цифры нет");
}
if (number > 99 && number < 1000)
{
    int result = (number % 10);
    Console.WriteLine($"Третья цифра равна {result}");
}
if (number > 999)
{
    while (number > 999)
    {
        number = number / 10;
    }
    Console.WriteLine($"Третья цифра равна {number % 10}");
}

//Для отрицательных чисел
if (number > -100 && number < 0)
{
    Console.WriteLine("Третьей цифры нет");
}
if (number < -99 && number > -1000)
{
    int result = (number % 10);
    Console.WriteLine($"Третья цифра равна {-(result)}");
}
if (number < -999)
{
    while (number < -999)
    {
        number = number / 10;
    }
    Console.WriteLine($"Третья цифра равна {-(number % 10)}");
}





