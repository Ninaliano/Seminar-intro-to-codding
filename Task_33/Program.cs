// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int [] array = new int [] {6, 7,19,345,1};
Console.WriteLine($"Задан массив:  ");

PrintArray(array);

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

Console.WriteLine("Введите искомое число");
int number = Convert.ToInt32(Console.ReadLine());


bool Contain(int [] arr, int num)
{
  for (int i = 0; i < arr.Length; i++)
  {
   if (arr[i] == num) return true;
   }
   return false;
}
bool contain = Contain(array, number);

Console.WriteLine(contain ? "да" : "нет" );
