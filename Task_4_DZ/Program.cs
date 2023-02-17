//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число а");
int number_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int number_b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c");
int number_c = Convert.ToInt32(Console.ReadLine());
int max = number_a;
if (number_b>max)
{
    max = number_b;
    }
    
    if (number_c>max)
    {
    max = number_c;
     }   
    
Console.WriteLine($"max={max}");

    