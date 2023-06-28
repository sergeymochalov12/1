// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 

// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void PrintArray(int[] arrayForPrint)// метод для вывода массива на экран
{
    System.Console.WriteLine($"b1 = {arrayForPrint[0]}, k1 = {arrayForPrint[1]}, b2 = {arrayForPrint[2]}, k2 = {arrayForPrint[3]}");
}

int[] EnterArray(string text)// фунция для ввода массива
{
    System.Console.WriteLine(text);
    int[] tempArray = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);// ввод одной строкой
    return tempArray;
}

void FoudCrossPoint(int[] tempArray, out double tempX, out double tempY)
{
    double b1 = Convert.ToInt32(tempArray[0]);
    double k1 = Convert.ToInt32(tempArray[1]);
    double b2 = Convert.ToInt32(tempArray[2]);
    double k2 = Convert.ToInt32(tempArray[3]);

    tempX = (-b2 + b1) / (-k1 + k2);
    tempY = k1 * tempX + b1;

}

// ________________ ОСНОВНОЙ КОД_____________________________________________
int[] array = EnterArray("Введите значения b1, k1, b2 и k2 через пробел");
PrintArray(array);
FoudCrossPoint(array, out double x, out double y);
System.Console.WriteLine($"Точка пересечения двух прямых ({x}, {y})");
