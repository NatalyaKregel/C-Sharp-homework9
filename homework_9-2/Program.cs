/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int Sum(int min, int max)
{   
    if( min < max ) 
    {   
        Console.Write($"{min},");
        return min + Sum(++min, max);
    }
        if( min > max ) 
    {   
        Console.Write($"{min},");
        return min + Sum(--min, max);
    }
    else 
    {   
        Console.Write($"{min}");
        return min;
    }
}

Console.WriteLine("Введите первое число:");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите последнее число:");
int max = int.Parse(Console.ReadLine());

int sumNumbers = Sum(min, max);
Console.WriteLine($" - Сумма представленных чисел равна {sumNumbers}");