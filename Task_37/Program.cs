// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] array = FillArrayRndInt(9, -10, 10);
PrintArray(array);

// int[] a = new int [5];
// int[] b = new int[] {45, 52};

int [] ProductOfNumbers(int [] arr)
{
    int [] productOfNumbers=new int [(arr.Length+1)/2];
    for (int i = 0; i < (arr.Length+1)/2; i++)
    {
        productOfNumbers[i]=(arr[i]*arr[(arr.Length-1)-i]);
    }
    return productOfNumbers;
}
    ProductOfNumbers(array); 
    
  Console.Write($"Произведение пар чисел =  ");  
PrintArray(ProductOfNumbers (array));