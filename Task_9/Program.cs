//  9. Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99]
// 2. показывает наибольшую цифру числа.
//  78 -> 8
//  12-> 2
//  85 -> 8

int numberR = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 => {numberR}");

// int firstDigit=numberR/10;
// int secondDigit=numberR%10;

// if(firstDigit>secondDigit) Console.WriteLine($"Наибольшая цифра числа-> {firstDigit}");
// else Console.WriteLine($"наибольшая цифра числа-> {secondDigit}");

int maxDigit = MaxDigit(numberR);
Console.WriteLine($"Наибольшая цифра числа-> {maxDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    
    // if (firstDigit > secondDigit) return firstDigit;
    // return secondDigit;   //else можно не использовать после return


    // int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    // return result;

    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
