// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());


bool Mod7()
{
    int ostatok = number % 7;
    return (ostatok == 0 ? true : false);
}

bool Mod23()
{
    int ostatok = number % 23;
    return (ostatok == 0 ? true : false);
}


Console.WriteLine(Mod7() == true && Mod23() == true ? ("ДА") : ("НЕТ"));