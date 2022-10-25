// // Задача 47. Задайте двумерный массив размером m×n, 
// // заполненный случайными вещественными числами.

// // m = 3, n = 4.
// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9
// Console.WriteLine("Задача 47");
// Console.WriteLine();
// Console.WriteLine("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);
// double[,] array = GetArrayDouble(rows, columns, -10, 10);
// PrintArrayDouble(array);
// Console.WriteLine();


// double[,] GetArrayDouble(int n, int m, double MinValue, double MaxValue)
// {
//     double[,] result = new double[n, m];
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             result[i, j] = new Random().NextDouble() * (MaxValue - MinValue) + MinValue;
//         }

//     }
//     return result;
// }
// void PrintArrayDouble(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]:f1} ");
//         }
//         Console.WriteLine();
//     }
// }
// // Задача 50. Напишите программу, которая на вход 
// // принимает позиции элемента в двумерном массиве, и 
// // возвращает значение этого элемента или же указание, 
// // что такого элемента нет.

// // Например, задан массив:

// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4

// // i = 4, j = 2 -> такого числа в массиве нет
// // i = 1, j = 2 -> 2
// Console.WriteLine("Задача 50");
// Console.WriteLine();
// int row = new Random().Next(2, 15);
// int column = new Random().Next(1, 15);
// Console.WriteLine("Сгенерированный массив: ");
// int[,] array50 = GetArrayInt(row, column, 1, 50);
// PrintArrayInt(array50);
// Console.WriteLine();
// Console.WriteLine("Введите номер строки i: ");
// int Row = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите номер столбца j: ");
// int Column = int.Parse(Console.ReadLine()!);
// Console.WriteLine(GetItemFromArray(array50, Row, Column));
// Console.WriteLine();



// String GetItemFromArray(int[,] array, int I, int J)
// {
//     if ((I >= array.GetLength(0) || I < 0) || (J >= array.GetLength(1) || J < 0))
//     {
//         return $"i = {I}, j = {J} -> эемента с указанными индексами нет в сгенерированном массиве";
//     }
//     else
//     {
//         return $"i = {I}, j = {J} -> {array[I, J]}";
//     }
// }

// int[,] GetArrayInt(int n, int m, int minValue, int maxValue)
// {
//     int[,] result = new int[n, m];
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }

//     }
//     return result;
// }
// void PrintArrayInt(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// // Задача 52. Задайте двумерный массив из целых чисел. 
// // Найдите среднее арифметическое элементов в каждом столбце.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Задача 52");
// Console.WriteLine();
// int rowAr = new Random().Next(2, 10);
// int columnAr = new Random().Next(1, 10);
// Console.WriteLine("Сгенерированный массив: ");
// int[,] array52 = GetArrayInt(rowAr, columnAr, 1, 10);
// PrintArrayInt(array52);
// Console.WriteLine();
// GetMeanOfColumns(array52);
// Console.WriteLine();

// void GetMeanOfColumns(int[,] array)
// {
//     Console.Write("Среднее арифметическое каждого столбца: ");
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double total = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             total += array[i, j];
//         }
//         Console.Write($"{(double)total / array.GetLength(0):f1}");
//         if (j == array.GetLength(1) - 1)
//         {
//             Console.Write(".");
//         }
//         else
//         {
//             Console.Write("; ");
//         }
//     }

// }

// Задача 60. ...Сформируйте трёхмерный массив из 
// неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы 
// каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.WriteLine("Задача 60");
// Console.WriteLine();
// Console.WriteLine("Введите размеры трехмерного массива:");
// Console.WriteLine("первый: ");
// int x = int.Parse(Console.ReadLine()!);
// Console.WriteLine("второй: ");
// int y = int.Parse(Console.ReadLine()!);
// Console.WriteLine("третий: ");
// int z = int.Parse(Console.ReadLine()!);
// int[,,] array60 = GetArrayThreeD(x, y, z);
// PrintArrayInt3D(array60);


//получение 3-х мерного массива из двухзначных уникальных чисел
// int[,,] GetArrayThreeD(int n, int m, int p){
//     int[,,] result = new int[n, m, p];
//     int[] Temparray = GetUniqeNum(n, m, p);
//     if(Temparray[0] < 0){
//         Console.WriteLine("Количество элементов массива превышает количество уникальных двухзначных чисел. Поробуйте уменьшить размеры массива");
//         return new int[,,]{};}
//     else{
//     int index = 0;
//     while(index < n*m*p){
//         for (int i = 0; i < n; i++)
//             {for (int j = 0; j < m; j++)
//                 {for (int k = 0; k < p; k++){
//                     result[i, j, k] = Temparray[index];
//                     index++;
//             }
//         }}}
//         return result;}
//         }
 // метод для получения уникальных двухзначных чисел    
//  int[] GetUniqeNum(int n, int m, int p)
//  {  int index = 0;
//     int[] result = new int[n*m*p];
//     if(m*n*p > 90){
//         return new int[]{-1};
//     }
//     else{
//     while(index < n*m*p){
//     {int temp = new Random().Next(10, 100);
//         if(Array.IndexOf(result, temp) == -1){
//             result[index] = temp;
//             index++;
//         }
//  }}}
//  return result;}

//метод печати 3-х мерного массива
// void PrintArrayInt3D(int[,,] array)
// {
//         for (int k = 0; k < array.GetLength(2); k++)
//             {for (int i = 0; i < array.GetLength(0); i++)
//                 {for (int j = 0; j < array.GetLength(1); j++){
        
//             Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
//             }
//         Console.WriteLine();
//     }
// }
// }
    

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

PrintIntArrayAsString(GetArraySpiral(4,4));

int[,] GetArraySpiral(int n, int m){
    int size = n * m;
    int[,] result = new int[n, m];
    int row = 0;
    int col = 0;
    int dx = 1;
    int dy = 0;
    int ChangeDirection = 0;
    int count = m;
    
    for(int i = 0; i < size; i++){
        result[row, col] = i + 1;
        count--;
    if(count == 0){
        count = m * (ChangeDirection % 2) + n * ((ChangeDirection + 1) % 2) - (ChangeDirection / 2 + 1);
        int temp = dx;
        dx = -dy;
        dy = temp;
        ChangeDirection++;
    }
    col += dx;
    row += dy;
    }
    return result;
}
void PrintIntArrayAsString(int[,] array)
{   int size = array.GetLength(0)*array.GetLength(1);
    int lenSize = (size.ToString()).Length;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j].ToString().Length < lenSize){
                int index = 0;
                while(index < lenSize - array[i, j].ToString().Length){
                    Console.Write($"0");
                    index++;
                }
            }
        Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
