// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write ("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int number =1;

void TableSquare ()
{while (number>=1 && number<=n)
{
    double numberPow= Math.Pow (number,2); 
Console.WriteLine($"{number}   {numberPow}");
number++;
   }
}
TableSquare();