/* Задача 64: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8"" */

int Count(int min, int max)
{   
    if( min < max ) 
    {   
        Console.Write($"{min},");
        return min + Count(++min, max);
    }
        if( min > max ) 
    {   
        Console.Write($"{min},");
        return min + Count(--min, max);
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

int countNumbers = Count(min, max);
