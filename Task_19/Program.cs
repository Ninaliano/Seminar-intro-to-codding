// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Promt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = Promt("Введите 5-ти значное число: ");

int Digit(int num, int delitel)                // тело метода начало
{
    int n = 1;
    while (n > 0 && n <= delitel)
    {
        num = num / 10;
        n++;
    }
    return num % 10;

}                                               //тело метода конец

if (number < 100000 && number > 9999)
{

    int firstDigit = Digit(number, 4);          //вызов метода
    int secondDigit = Digit(number, 3);         //вызов метода
    int fourthDigit = Digit(number, 1);         //вызов метода
    int fifthDigit = Digit(number, 0);          //вызов метода
   if (firstDigit==fifthDigit && secondDigit==fourthDigit)
   {
    Console.WriteLine("Это палиндром");
   }
   else 
   {
     Console.WriteLine("Это не палиндром");
   }
}
else 
{
    Console.WriteLine("Это не 5-ти значное число, введите заново.");
}



