// 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32 (Console.ReadLine());

if  (number>99&&number<=999)
{
    int secDigit = SecDigit(number);
Console.WriteLine($"Второе число-> {secDigit}");

int SecDigit(int num) // создается копия numberR. number=num
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int secondDigit = (num-(firstDigit*100+thirdDigit))/10;

 
    return secondDigit;
}
}
else
Console.WriteLine("Дурачок!");