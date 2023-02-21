// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int numberR = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100-999 => {numberR}");


int delitSecDigit = DelitSecDigit(numberR);
Console.WriteLine($"Число с удаленной второй цифрой-> {delitSecDigit}");

int DelitSecDigit(int num) // создается копия numberR. number=num
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int secondDigit = (num-(firstDigit*100+thirdDigit))/10;
    int result = firstDigit*10+thirdDigit;
 
    return result;
}