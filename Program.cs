Console.ReadLine();


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


// Console.Write("введите колличество строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите Колличество столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// Console.WriteLine("Ваш массив:");
// Console.WriteLine();
// int[,] array = GetArray(row, column);
// PrintArray(array);
// array = MaxToMinArray(array);
// Console.WriteLine();
// Console.WriteLine("массив по строкам: от наибольшего к меньшему");
// Console.WriteLine();
// PrintArray(array);

// int[,] GetArray(int row, int column)
// {
//     int[,] array = new int[row, column];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             array[i, j] = new Random().Next(0, 100);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             Console.Write($"{Array[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] MaxToMinArray(int[,] Array)
// {
//     int temp = 0;
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1) - 1; j++)
//         {
//             for (int t = j + 1; t < Array.GetLength(1); t++)
//             {
//                 if (Array[i, t] > Array[i, j])
//                 {
//                     temp = Array[i, j];
//                     Array[i, j] = Array[i, t];
//                     Array[i, t] = temp;
//                 }
//             }
//         }
//     }
//     return Array;
// }


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.Write("введите колличество строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите колличество столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ваш массив:");
// Console.WriteLine();
// int[,] array = GetArray(row, column);
// PrintArray(array);
// Console.WriteLine();
// Console.Write($"Строки с наименьшей суммой: {MinSumStringIn(array)}");


// int[,] GetArray(int row, int column)
// {
//     int[,] array = new int[row, column];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             array[i, j] = new Random().Next(0, 100);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] Array)
// {
//     int shiftRow = 1;
//     int shiftColumn = 1;

//     Console.Write(" \t");
//     for (int k = 0; k < Array.GetLength(1); k++)
//     {
//         Console.Write($"({shiftColumn}) \t");
//         shiftColumn++;
//     }
//     Console.WriteLine();
//     Console.WriteLine();
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             if (j == 0)
//             {
//                 Console.Write($"|{shiftRow}| \t");
//                 shiftRow++;
//             }
//             Console.Write($"{Array[i, j]}  \t");
//         }
//         Console.WriteLine();
//     }
// }

// string MinSumStringIn(int[,] Array)
// {
//     int[] arraySum = new int[Array.GetLength(0)];
//     int sum = 0;
//     for (int i = 0; i < Array.GetLength(0); i++)
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             sum += Array[i, j];
//         }
//         arraySum[i] = sum;
//         sum = 0;
//     }
//     int minSum = arraySum[0];
//     int rowMin = 0;
//     string positions = "";
//     for (int i = 1; i < arraySum.Length; i++)
//     {

//         if (arraySum[i] < minSum)
//         {
//             minSum = arraySum[i];
//             rowMin = i;
//         }
//     }
//     for (int j = 0; j < arraySum.Length; j++)
//     {
//         if (minSum == arraySum[j])
//         {
//             positions += $"{j + 1} ";
//         }
//     }

//     return positions;
// }



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// Console.Write("Колличество строк 1-й матрицы: ");
// int rowFirst = Convert.ToInt32(Console.ReadLine());
// Console.Write("Колличество столбцов 1-й матрицы: ");
// int columnFirst = Convert.ToInt32(Console.ReadLine());
// Console.Write("Колличество строк 2-й матрицы: ");
// int rowSecond = Convert.ToInt32(Console.ReadLine());
// Console.Write("Колличество столбцов 2-й матрицы: ");
// int columnSecond = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int[,] arrayFirst = GetArray(rowFirst, columnFirst);
// Console.WriteLine("1-й Массив:");
// Console.WriteLine();
// PrintArray(arrayFirst);
// Console.WriteLine();
// Console.WriteLine("\t X \t");
// Console.WriteLine();
// Console.WriteLine("2-й Массив:");
// Console.WriteLine();
// int[,] arraySecond = GetArray(rowSecond, columnSecond);
// PrintArray(arraySecond);
// Console.WriteLine();
// Console.Write("\t = \t");
// Console.WriteLine();
// Console.WriteLine();
// int[,] arrayResult = FirstArrayOnSecondArray(arrayFirst, arraySecond);
// PrintArray(arrayResult);


// int[,] GetArray(int row, int column)
// {
//     int[,] array = new int[row, column];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             array[i, j] = new Random().Next(0, 100);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] Array)
// {
//     int shiftRow = 1;
//     int shiftColumn = 1;

//     Console.Write(" \t");                                    
//     for (int k = 0; k < Array.GetLength(1); k++)            
//     {
//         Console.Write($"({shiftColumn}) \t");
//         shiftColumn++;
//     }
//     Console.WriteLine();                                    
//     Console.WriteLine();                                    
//     for (int i = 0; i < Array.GetLength(0); i++)            
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             if (j == 0)                                     
//             {
//                 Console.Write($"|{shiftRow}| \t");
//                 shiftRow++;
//             }
//             Console.Write($"{Array[i, j]}  \t");            
//         }
//         Console.WriteLine();
//     }
// }

// int[,] FirstArrayOnSecondArray(int[,] ArrayFirst, int[,] ArraySecond)
// {
//     int[,] result = new int[ArraySecond.GetLength(0), ArraySecond.GetLength(1)];
//     if (ArrayFirst.GetLength(1) != ArraySecond.GetLength(0))
//     {
//         Console.WriteLine("Число столбцов первой матрицы должно совпадать с числом строк второй матрицы");
//     }
//     else
//     {
//         for (int i = 0; i < ArrayFirst.GetLength(0); i++)
//         {
//             for (int j = 0; j < ArraySecond.GetLength(1); j++)
//             {

//                 for (int k = 0; k < ArrayFirst.GetLength(1); k++)
//                 {
//                     result[i, j] += ArrayFirst[i, k] * ArraySecond[k, j];
//                 }
//             }
//         }
//     }
//     return result;
// }


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Console.Write("введите колличество строк: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите колличество столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите глубину массива: ");
// int deep = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Ваш массив:");
// int[,,] array = GetArray(row, column, deep);
// PrintArray(array);


// int[,,] GetArray(int row, int column, int deep)
// {
//     int[,,] array = new int[row, column, deep];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             for (int k = 0; k < deep; k++)
//             {
//                 array[i, j, k] = new Random().Next(0, 100);
//             }
//         }
//     }
//     return array;
// }

// void PrintArray(int[,,] Array)
// {
//     for (int i = 0; i < Array.GetLength(0); i++)            
//     {
//         for (int j = 0; j < Array.GetLength(1); j++)
//         {
//             for (int k = 0; k < Array.GetLength(2); k++)
//             {
                
//                 Console.Write($"{Array[i, j, k]} ({i}, {j}, {k})  \t");             
//             }
//         }
//         Console.WriteLine(" \t");
//     }
// }


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// int row = Convert.ToInt32(Console.ReadLine());
// int column = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[row, column];
// int count = 1;
// int x = 0;
// int y = 0;
// int corner = 0;

// Console.Clear();
// PrintSpiralW(array, corner, y, x, count);

// void PrintSpiralW(int[,] array, int corner, int i, int j, int counter)
// {  
//     int numColumn = array.GetLength(1);
//     int numRow = array.GetLength(0);
//     int sleep = 100;
//     const int width = 5;
//     Console.CursorVisible = false;
//     while (counter <= numColumn * numRow+1)
//     {
//         Thread.Sleep(sleep);
//         if (counter == numColumn * numRow+1)
//         {
//             Console.SetCursorPosition(0, numRow + 1);
//             return;
//         }
      
//         if (i == corner && j < numColumn - corner - 1)
//         {
//             if (j == 0 && i == 0)
//             {
//                 array[i, j] = counter;
//                 Console.Write($"{array[i, j].ToString().PadLeft(width - 1, '0'),width}");
//                 counter++;
//             }
//             j++;
//             array[i, j] = counter;
//             Console.Write($"{array[i, j].ToString().PadLeft(width - 1, '0'),width}");
//         }
//         else if (j == numColumn - corner - 1 && i < numRow - corner - 1)
//         {
//             Console.SetCursorPosition(Console.CursorLeft - width, Console.CursorTop + 1);
//             i++;
//             array[i, j] = counter;
//             Console.Write($"{array[i, j].ToString().PadLeft(width - 1, '0'),width}");
//         }
//         else if (i == numRow - corner - 1 && j > corner)
//         {
//             Console.SetCursorPosition(Console.CursorLeft - 2 * width, Console.CursorTop);
//             j--;
//             array[i, j] = counter;
//             Console.Write($"{array[i, j].ToString().PadLeft(width - 1, '0'),width}");
//         }
//         else
//         {
//             Console.SetCursorPosition(Console.CursorLeft - width, Console.CursorTop - 1);
//             i--;
//             array[i, j] = counter;
//             Console.Write($"{array[i, j].ToString().PadLeft(width - 1, '0'),width}");
//         }
//         counter++;

//         if ((i == corner + 1) && (j == corner) && (corner != numColumn - corner - 1)) corner++;
//     }
//     return;
// }
