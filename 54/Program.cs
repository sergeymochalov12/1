// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//Генерация массива
int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix = new int[row, col];
    var rand = new Random();
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

//Печать двумерного массива
void PrintMatrix(int[,] matrixForPrint)
{
    for (int i = 0; i < matrixForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < matrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(matrixForPrint[i, j] + "\t");
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


//сортировка элементов массива (элементы каждой строки по убыванию)
void SourtingArray(int[,] matrix1)
{
    int temp = new int { };
    for (int k = 0; k < matrix1.GetLength(0); k++)
    {


        for (int i = 0; i < matrix1.GetLength(1); i++)
        {
            for (int j = i + 1; j < matrix1.GetLength(1); j++)
            {
                if (matrix1[k, i] < matrix1[k, j])
                {
                    temp = matrix1[k, i];
                    matrix1[k, i] = matrix1[k, j];
                    matrix1[k, j] = temp;
                }
            }
        }
    }
}

// Основной код
int[] sizeA = ReadInt("Задайте количество строк и столбцов массива через пробел: ");
int[,] matrix1 = FillMatrix(sizeA[0], sizeA[1], 0, 9);

PrintMatrix(matrix1);
SourtingArray(matrix1);
System.Console.WriteLine("Массив с упорядоченными по убыванию элементами каждой строки:");
PrintMatrix(matrix1);
