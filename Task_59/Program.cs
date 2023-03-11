//  Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

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

int FindMin(int[,] matrix)
{
    int min = int.MaxValue;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min) min = matrix[i, j];
        }
    }
    return min;
}
int[,] CreateNewMatrix(int[,] matrix, int min)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    bool found = false;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == min && found == false) found = true;
            else
            {
                if (found) newMatrix[i-1, j-1] = matrix[i, j];
                else
                {
                    newMatrix[i, j] = matrix[i, j];

                }
            }
        }

    }
    return newMatrix;

}


int[,] array2d = CreateMatrixRndInt(4, 5, -10, 10);
PrintMatrix(array2d);
Console.WriteLine();
int min = FindMin(array2d);
Console.WriteLine(min);
int[,] newMatrixx = CreateNewMatrix(array2d, min);
PrintMatrix(newMatrixx);