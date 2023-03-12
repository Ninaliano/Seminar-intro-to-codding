// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите натуральное число: A =  ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите натуральное число: B =  ");
int numberB = int.Parse(Console.ReadLine());

int Exponentiation(int numA, int numB)
{
   if (numB==0) return 1;
   else return  numA * Exponentiation(numA, numB-1);
  
}
Console.WriteLine( $"{numberA}, {numberB} =>  {Exponentiation(numberA, numberB)}"); 

