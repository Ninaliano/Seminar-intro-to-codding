// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



int Promt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double k1 = Promt("Введите значение k1 ->   ");
double k2 = Promt("Введите значение k2 ->   ");
double b1 = Promt("Введите значение b1 ->   ");
double b2 = Promt("Введите значение b2 ->   ");


double FindX(double ki1, double ki2, double bi1, double bi2)
{
    double resultXi = (bi2 - bi1) / (ki1 - ki2);
    return resultXi;
}

double FindY(double ki2, double bi2, double x)
{
    double resultYi = ki2 * x + bi2;
    return resultYi;
}

double resultX = FindX(k1, k2, b1, b2);
double resultY = FindY(k1, b1, resultX);

Console.WriteLine($"Координаты точки пересечения двух прямых ({k1}, {k2}); ({b1}, {b2}) ->  ({resultX};{resultY})");