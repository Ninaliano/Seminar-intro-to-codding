// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int number = 1;

void TableCube()
{
    Console.WriteLine("Число     Куб числа");
    while (number >= 1 && number <= n)
    {
        double numberPow = Math.Pow(number, 3);
        Console.WriteLine($"{number}          {numberPow}");
        number++;
    }
}
TableCube();