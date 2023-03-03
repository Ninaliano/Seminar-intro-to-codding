﻿// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] FillArrayRndInt(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return arr;
}


void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double[] array = FillArrayRndInt(10, 0, 100);
PrintArray(array);


double Diff(double[]arr)
{
    double max=arr[0];
    double min=arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i]>max) 
       max=arr[i];
       if (arr[i]<min)
       min = arr[i];
        }
        return (max-min);
}
Console.WriteLine($" Разница минимального и максимального значения = {Math.Round(Diff(array), 1)}");