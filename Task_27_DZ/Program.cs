// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите натуральное число:  ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >0)
{
int sum = SumNumbers(number);
Console.WriteLine($"Сумма цифр в числе: {number} = {sum}");
}
else
{
Console.WriteLine($" Число {number} ненатуральное ");
};


int SumNumbers(int num)
{
   int sum=0;
    while (num!=0) 
    {
        sum=sum+num%10;
        num/=10;
             
    }
    return sum;
}
   
   
   
