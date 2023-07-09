// Задача 60. ...Сформируйте трёхмерный массив из двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] FillMatrix(int row, int col, int deep, int leftRange, int rightRange)
{
    int[,,] tempMatrix = new int[row, col, deep];
    var rand = new Random();
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            for (int m = 0; m < tempMatrix.GetLength(2); m++)
            {
                tempMatrix[i, j, m] = rand.Next(leftRange, rightRange + 1);
            }
        }
    }
    return tempMatrix;
}

//Печать трехмерного массива
void PrintMatrix(int[,,] matrix)
{
    System.Console.WriteLine($"Массив размером {matrix.GetLength(0)} x {matrix.GetLength(1)} x {matrix.GetLength(2)}");

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int m = 0; m < matrix.GetLength(2); m++)
            {
                System.Console.Write($"{matrix[i, j, m]} ({i},{j},{m})" + "\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

//Ввод данных
int[] ReadInt(string text)
{
    System.Console.Write(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(" "), int.Parse); ;
}

// Основной код

int[] size = ReadInt("Задайте трехмерный массив через пробел X X X: ");
int[,,] matrix = FillMatrix(size[0], size[1], size[2], 10, 99);
PrintMatrix(matrix);

