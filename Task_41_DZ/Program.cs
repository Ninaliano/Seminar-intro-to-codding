// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



int Promt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


int [] InputArray(int length)
{
    int []array = new int [length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Promt ($"Введите {i+1} -й элемент:   ");
    }
    return array;
}
// void PrintArray(int[] arr)
// {   
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.WriteLine("]");
// }

int Count(int [] array)
{
    int amount=0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i]>0)
    amount+=1;
  }
  return amount;
}

int length=Promt("Введите количество элементов ->   ");
int [] array = InputArray(length);
Console.WriteLine($" Количество положительных значений = {Count(array)}");
// PrintArray(array);