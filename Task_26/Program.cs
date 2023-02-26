// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.WriteLine("Введите число");
long number = Convert.ToInt64(Console.ReadLine());

long count=Count(number);

long Count(long num)
{
    int result=0;
    while (num!=0) 
    {
    num/=10;
    result=result+1;
    }
return result;
}

Console.WriteLine($"количество цифр в числе {number} -> {count}");


// else
// {
//     long thirdDigit = ThirdDigit(number);

//     long ThirdDigit(long num) // создается копия number. number=num
//     {

//         while (num >= 999) num /= 10;
//         long thirdDigit = num % 10;

//         return thirdDigit;
//     }

//     Console.WriteLine($"Третья цифра,заданного числа-> {thirdDigit}");
