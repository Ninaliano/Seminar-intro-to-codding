// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

Console.WriteLine("Введите размер массива");
int size =Convert.ToInt32(Console.ReadLine());

void FillArray(int[]collection)
{
    int length = collection.Length;
    int index=0;
    while (index<length)
    {
        collection[index]=new Random().Next(0,100);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int [] CopyArray(int[] arrayToCopy)
{
    int[] copyarray=new int [arrayToCopy.Length];
    for (int i=0; i<arrayToCopy.Length; i++)
    {
        copyarray[i] = arrayToCopy[i];
    }
    return copyarray;
}

int[] array=new int [size];


FillArray(array);
PrintArray(array);
Console.WriteLine();
int[] copiedArray = CopyArray(array);
PrintArray(copiedArray);