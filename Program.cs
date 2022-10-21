// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Задача 47");
Console.WriteLine();
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
double[,] array = GetArrayDouble(rows, columns, -10, 10);
PrintArrayDouble(array);
Console.WriteLine();


double[,] GetArrayDouble(int n, int m, double MinValue, double MaxValue)
{
    double[,] result = new double[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i, j] = new Random().NextDouble() * (MaxValue - MinValue) + MinValue;
        }

    }
    return result;
}
void PrintArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f1} ");
        }
        Console.WriteLine();
    }
}
// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2
Console.WriteLine("Задача 50");
Console.WriteLine();
int row = new Random().Next(2, 15);
int column = new Random().Next(1, 15);
Console.WriteLine("Сгенерированный массив: ");
int[,] array50 = GetArrayInt(row, column, 1, 50);
PrintArrayInt(array50);
Console.WriteLine();
Console.WriteLine("Введите номер строки i: ");
int Row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите номер столбца j: ");
int Column = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetItemFromArray(array50, Row, Column));
Console.WriteLine();



String GetItemFromArray(int[,] array, int I, int J){
    if((I >= array.GetLength(0) || I < 0) || (J >= array.GetLength(1) || J < 0)){
        return $"i = {I}, j = {J} -> эемента с указанными индексами нет в сгенерированном массиве";
    }
    else{
        return $"i = {I}, j = {J} -> {array[I,J]}";
    }
}

int[,] GetArrayInt(int n, int m, int minValue, int maxValue){
    int[,] result = new int[n, m];
    for (int i = 0; i < n; i++)
    {for (int j = 0; j < m; j++){
    result[i, j] = new Random().Next(minValue, maxValue + 1);
    }
        
    }
    return result;
}
void PrintArrayInt(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
}


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Задача 52");
Console.WriteLine();
int rowAr = new Random().Next(2, 10);
int columnAr = new Random().Next(1, 10);
Console.WriteLine("Сгенерированный массив: ");
int[,] array52 = GetArrayInt(rowAr, columnAr, 1, 10);
PrintArrayInt(array52);
Console.WriteLine();
GetMeanOfColumns(array52);
Console.WriteLine();

void GetMeanOfColumns(int[,] array){
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.GetLength(1); j++){
        double total = 0;
         for (int i = 0; i < array.GetLength(0); i++){
            total += array[i, j];
    }
    Console.Write($"{(double)total/array.GetLength(0):f1}");
    if(j == array.GetLength(1) - 1){
            Console.Write(".");
    }
    else{
        Console.Write("; ");
    }
}

}


