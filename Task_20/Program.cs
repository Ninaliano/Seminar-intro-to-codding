// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


// Я МЕТОД ПРОМТ. Я ВЫВОЖУ ВОПРОС ПОЛЬЗОВАТЕЛЮ И ВОЗВРАЩАЮ ЕГО ОТВЕТ
// НА ВХОД Я ПРИНИМАЮ ПАРАМЕТР TEXT. ОН БУДЕТ ВЫВЕДЕН НА ЭКРАН
int Promt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine("Введите координаты точки A");
int axc = Promt("Ax: ");
int ayc = Promt("Ay: ");

Console.WriteLine("Введите координаты точки B");
int bxc = Promt("Bx: ");
int byc = Promt("By: ");


double Distance(int ax, int ay, int bx, int by)

{
    double result = Math.Sqrt((ay-by)*(ay-by) + (ax-bx)*(ax-bx));
    return result;
}

double resultRound=Math.Round(Distance(axc, ayc, bxc, byc), 2, MidpointRounding.ToZero);

Console.WriteLine(resultRound);
