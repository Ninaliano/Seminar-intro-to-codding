// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int index=1;
Console.Write("Ряд четных чисел: ");
while (index <=N)
{
      if (index%2==0)
        Console.Write($"{index}, ");
    index++;
    }
       