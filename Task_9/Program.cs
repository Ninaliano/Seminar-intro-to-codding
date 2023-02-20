//  9. Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99]
// 2. показывает наибольшую цифру числа.
//  78 -> 8
//  12-> 2
//  85 -> 8

int numberR=new Random().Next(10,100);
Console.WriteLine ($"Случайное число из отрезка 10-99 => {numberR}");
int firstDigit=numberR/10;
int secondDigit=numberR%10;

if(firstDigit>secondDigit) Console.WriteLine($"Наибольшая цифра числа-> {firstDigit}");
else Console.WriteLine($"наибольшая цифра числа-> {secondDigit}");