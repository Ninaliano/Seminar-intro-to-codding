// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите сторону А");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите сторону B");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите сторону C");
int numberC = Convert.ToInt32(Console.ReadLine());


bool Triangle(int numA, int numB, int numC)
{
if (numberA + numberB > numberC && numberB + numberC > numberA && numberA + numberC > numberB) return true;

else return false;

}

bool result = Triangle(numberA,numberB,numberC);
Console.WriteLine(result ? "Да" : "Нет");

