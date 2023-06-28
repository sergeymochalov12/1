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


// ________________ ОСНОВНОЙ КОД_____________________________________________
int[] array = EnterArray("Введите значения b1, k1, b2 и k2 через пробел");
PrintArray(array);

double b1 = Convert.ToInt32(array[0]);
double k1 = Convert.ToInt32(array[1]);
double b2 = Convert.ToInt32(array[2]);
double k2 = Convert.ToInt32(array[3]);
   
double x = (-b2 + b1)/(-k1 + k2);
double y = k1 * x + b1;
System.Console.WriteLine($"Точка пересечения двух прямых ({x}, {y})");