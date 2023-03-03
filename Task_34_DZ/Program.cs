// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] FillArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}


void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int[] array = FillArrayRndInt(5, 100, 999);
PrintArray(array);

int Count(int[] arr)
{
    int amount = 0;
    for (int i = 0; i < arr.Length; i++)
    {

        if (arr[i] % 2 == 0)
            amount = amount + 1;
    }
    return amount;

}

 Console.Write($"Количество четных чисел = {Count (array)}");  
