// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите число а");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int numberB = Convert.ToInt32(Console.ReadLine());


int multiplicity = Multiplicity(numberA,numberB);
// if (multiplicity==0)
// {
//     Console.WriteLine($"кратно");
// }
// else  Console.WriteLine($"не кратно, остаток: {multiplicity}" );

 Console.WriteLine(multiplicity==0?"кратно": $"не кратно, остаток: {multiplicity}");


int Multiplicity (int numA,int numB) // создается копия numberR. number=num
{
    int numberR = numA%numB;
    
return numberR;
    
}
   