// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.WriteLine("Введите десятичное число ");
int number = Convert.ToInt32(Console.ReadLine());

string СonversionTo2(int num)
{
    string result = string.Empty;
    
    while (num > 0)
    {
                {
            result = num%2 + result;
            num = num / 2;            
        } 
    }
    return result;
}


string result=СonversionTo2(number);
Console.WriteLine($" Получено двоичное число: {result}");



// Console.Write("Введите десятичное число: ");
// int decimalNumber = Convert.ToInt32(Console.ReadLine());

// string ConverDecimalToBinary(int num)
// {
//     string number = "";
    
//     while (num > 0)
//     {
//         if (num % 2 == 0)
//         {
//             number = number + "0";
//             num = num / 2;            
//         } else {
//             number = number + "1";
//             num = num / 2;            
//         }

//     }
//     return number;
// }

// Console.Write(ConverDecimalToBinary(decimalNumber));
