// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральную степень В");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB>0)
{
  int result =Exponentiation(numberA, numberB);
  Console.WriteLine($"{numberA} в степени {numberB} = {result}");
}
else 
{
    Console.WriteLine($"{numberB} - ненатуральное число, попробуйте снова");
};

int Exponentiation(int numA, int numB)
{
    double result = Math.Pow (numA,numB);

return Convert.ToInt32(result);
};