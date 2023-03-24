// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Promt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumber(int R)
{
    if (R > 0)
    {
        Console.Write($"{R}");
        if (R > 1)
        {
            Console.Write(", ");
        }
        PrintNumber(R - 1);
    }
}


int n = Promt("Задайте значение:");
PrintNumber(n);







