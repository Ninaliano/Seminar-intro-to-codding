// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int Promt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int M, int N)
{
    if (N >= M)
    {
        return M + Sum(M + 1, N);
    }
    return 0;
}

int m = Promt("Задайте значение M:");
int n = Promt("Задайте значение N:");
int sum = 0;
if (n > m)
    sum = Sum(m, n);
else
    sum = Sum(n, m);

Console.WriteLine($"M={m}, N={n}, --> {sum}");


