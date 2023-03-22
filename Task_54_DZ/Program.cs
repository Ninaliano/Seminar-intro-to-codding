// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];   // 0, 1
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)   //rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // columns
            matrix[i, j] = rnd.Next(min, max + 1);
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine();
    }
}
int[,] SortMatrix(int[,] matrix)
{
    int[,] sortedmatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] array = new int[matrix.GetLength(1)];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[j] = matrix[i, j];
        }
        Array.Sort(array);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sortedmatrix[i, j] = array[matrix.GetLength(1) - j - 1];
        }
    }

    return sortedmatrix;
}



int[,] array2d = CreateMatrixRndInt(4, 5, 0, 10);
int[,] arr = SortMatrix(array2d);
PrintMatrix(array2d);
Console.WriteLine();
PrintMatrix(arr);

