// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Promt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine("Введите координаты точки A");
int axc = Promt("Ax: ");
int ayc = Promt("Ay: ");
int azc = Promt("Az: ");

Console.WriteLine("Введите координаты точки B");
int bxc = Promt("Bx: ");
int byc = Promt("By: ");
int bzc = Promt("Bz: ");




double Distance(int ax, int ay, int az, int bx, int by, int bz)

{
    double result = Math.Sqrt(Math.Pow((ay-by),2) + Math.Pow((ax-bx),2)+Math.Pow((az-bz),2));
    return result;
}

double resultRound=Math.Round(Distance(axc, ayc, azc, bxc, byc, bzc), 2, MidpointRounding.ToZero);

Console.WriteLine(resultRound);