//  13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
long number = Convert.ToInt64(Console.ReadLine());

if (number < 100)
    Console.WriteLine("третьей цифры нет");

else
{
    long thirdDigit = ThirdDigit(number);

    long ThirdDigit(long num) // создается копия number. number=num
    {

        while (num >= 999) num /= 10;
        long thirdDigit = num % 10;

        return thirdDigit;
    }

    Console.WriteLine($"Третья цифра,заданного числа-> {thirdDigit}");
}


