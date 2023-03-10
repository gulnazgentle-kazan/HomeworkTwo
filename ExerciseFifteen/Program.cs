/*Задача 15: Напишите программу, 
которая принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите любое целое число от 1 до 7");
int date = Convert.ToInt32(Console.ReadLine());

// В этом случае указаны действия, 
// которые сделает программа на случай,
// если пользователь введет корректное число"
if (date > 0 && date < 8)
{
    switch (date)
    {
        case 1:
            Console.WriteLine("Понедельник не является выходным");
            break;
        case 2:
            Console.WriteLine("Вторник не является выходным");
            break;
        case 3:
            Console.WriteLine("Среда не является выходным");
            break;
        case 4:
            Console.WriteLine("Четверг не является выходным");
            break;
        case 5:
            Console.WriteLine("Пятница не является выходным");
            break;
        case 6:
            Console.WriteLine("Суббота является выходным");
            break;
        case 7:
            Console.WriteLine("Воскресение является выходным");
            break;
    }
}

//// В этом случае указаны действия, 
// которые сделает программа на случай,
// если пользователь введет некорректное отрицательное число"
if (date < 1)
{
    Console.WriteLine("Вы ввели некорректное число.");
    Console.WriteLine("Введите любое целое число от 1 до 7");
}
// В этом случае указаны действия, 
// которые сделает программа на случай,
// если пользователь введет некорректное положительное число"
if (date >= 8)
{
    Console.WriteLine("Вы ввели некорректное число.");
    Console.WriteLine("Введите любое целое число от 1 до 7");
}