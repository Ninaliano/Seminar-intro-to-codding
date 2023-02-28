// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
 


Console.WriteLine("Введите количество первых чисел в ряде Фибоначи");
int n=Convert.ToInt32(Console.ReadLine());

int[] array=new int [n];
array[0]=0;
array[1]=1;


void FillArray(int[] collection)
{
 for (int i = 2; i < array.Length; i++)
 {
    array[i]=array[i-2]+array[i-1];
 }
}
Console.Write("Ряд Фибоначи: ");
void PrintArray(int[] col)
{
int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col [position] + " ");
        position++;
    }
}


FillArray(array);
PrintArray(array);