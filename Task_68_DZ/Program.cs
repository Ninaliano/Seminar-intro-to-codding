// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Promt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
    if (m == 0)
        return Akkerman(n - 1, 1);
    else
        return Akkerman(n - 1, Akkerman(n, m - 1));
}


int n = Promt("Задайте значение N:");
int m = Promt("Задайте значение M:");
int akk = Akkerman(n, m);
Console.WriteLine($"n = {n}, m = {m}, --> A(n,m) = {akk} ");