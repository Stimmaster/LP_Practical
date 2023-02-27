//                                                  Практическое задание №8. Двумерные массивы. Продолжение

/****************************************************************************************************************************************/

bool isHomeWork = true;
while (isHomeWork)
{
    Console.Write("Введите номер задачи: ");
    if (int.TryParse(Console.ReadLine(), out int w))
    {
        switch (w)
        {
            case 1: //Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
                    // Например, задан массив:
                    // 1 4 7 2
                    // 5 9 2 3
                    // 8 4 2 4                  
                    // В итоге получается вот такой массив:                    
                    // 7 4 2 1
                    // 9 5 3 2
                    // 8 4 4 2
          
                {
                    Console.Clear(); 
	                Console.WriteLine("Введите размер двумерного прмоугольного массива размером m x n, введите диапазон случайных чисел от и до ");
                    Console.WriteLine();
                    int m = ReadInt("кол-во строк - m");
                    int n = ReadInt("кол-во столбцов - n");
                    int rangeFrom = ReadInt("диапазон от ");
                    int rangeTo = ReadInt("диапазон до ");
                   
                    int[,] firstArray = new int[m, n];
                    CreateArray(firstArray);
                    Console.WriteLine($"\nЗадан массив: ");
                    PrintArray(firstArray);

                    Console.WriteLine($"\nВ итоге получается вот такой массив: ");
                    SortArrayRows(firstArray);
                    PrintArray(firstArray);
                    Console.WriteLine();

                    void SortArrayRows(int[,] firstArray) 	                  // Модуль сортировки строк массива
                        {
                            for (int i = 0; i < firstArray.GetLength(0); i++)
                                {
                                    for (int j = 0; j < firstArray.GetLength(1); j++)
                                        {
                                            for (int k = 0; k < firstArray.GetLength(1) - 1; k++)
                                                {
                                                    if (firstArray[i, k] < firstArray[i, k + 1])
                                                        {
                                                            int temp = firstArray[i, k + 1];
                                                            firstArray[i, k + 1] = firstArray[i, k];
                                                            firstArray[i, k] = temp;
                                                        }
                                                }
                                        }
                                }
                        }

                    int ReadInt(string argument)                              // Модуль ввода данных
                        {
	                        Console.Write($" Введите {argument}: ");
	                        int result = 0;

	                        while (!int.TryParse(Console.ReadLine(), out result))
	                            {
		                            Console.WriteLine("Try again");
	                            }
	                      return result;
                        }

                    void CreateArray(int[,] firstArray)			              // Модуль заполнения массива случайными числами
                        {
                            for (int i = 0; i < firstArray.GetLength(0); i++)
                                {
                                    for (int j = 0; j < firstArray.GetLength(1); j++)
                                        {
                                            firstArray[i, j] = new Random().Next(rangeFrom, rangeTo);        
                                        }
                                }
                        }

                    void PrintArray(int[,] firstArray)		                  // Модуль печати  массива
                        {
                            for (int i = 0; i < firstArray.GetLength(0); i++)
                                {
                                    for (int j = 0; j < firstArray.GetLength(1); j++)
                                        {
                                            Console.Write(firstArray[i, j] + " ");
                                        }
                                    Console.WriteLine();
                                }
                        }
                }
                break;

            case 2: // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
                    //Например, задан массив:
                    // 1 4 7 2
                    // 5 9 2 3
                    // 8 4 2 4
                    // 5 2 6 7
                    // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

                {   
                    
                    Console.Clear(); 
	                Console.WriteLine("Введите размер двумерного прмоугольного массива размером m x n, введите диапазон случайных чисел от и до ");
                    Console.WriteLine();
                    int m = ReadInt("кол-во строк - m");
                    int n = ReadInt("кол-во столбцов - n");
                    int rangeFrom = ReadInt("диапазон от ");
                    int rangeTo = ReadInt("диапазон до ");
                   
                    int[,] firstArray = new int[m, n];
                    CreateArray(firstArray);
                    Console.WriteLine($"\nЗадан массив: ");
                    PrintArray(firstArray);
                    FindRowSumMinElements(firstArray);


                    void FindRowSumMinElements(int[,] firstArray)             // Модуль поиска строки с минимальной суммой значений элементов 
                        {
                            int minRow = 0;
                            int minSumRow = 0;
                            int sumRow = 0;
                            for (int i = 0; i < firstArray.GetLength(1); i++)
                                {
                                    minRow += firstArray[0, i];
                                }
                            for (int i = 0; i < firstArray.GetLength(0); i++)
                                {
                                    for (int j = 0; j < firstArray.GetLength(1); j++) sumRow += firstArray[i, j];
                                        if (sumRow < minRow)
                                            {
                                                minRow = sumRow;
                                                minSumRow = i;
                                                Console.WriteLine($"\n {minSumRow+1}-я строка с наименьшей суммой элементов, равной {sumRow}");
                                                Console.WriteLine();
                                            }
                                    sumRow = 0;
                                }    
                        }          


                    int ReadInt(string argument)                              // Модуль ввода данных
                        {
	                        Console.Write($"Введите {argument}: ");
	                        int result = 0;

	                        while (!int.TryParse(Console.ReadLine(), out result))
	                            {
		                            Console.WriteLine("Try again");
	                            }
	                      return result;
                        }

                    void CreateArray(int[,] firstArray)			              // Модуль заполнения массива случайными числами
                        {
                            for (int i = 0; i < firstArray.GetLength(0); i++)
                                {
                                    for (int j = 0; j < firstArray.GetLength(1); j++)
                                        {
                                            firstArray[i, j] = new Random().Next(rangeFrom, rangeTo);        
                                        }
                                }
                        }

                    void PrintArray(int[,] firstArray)		                  // Модуль печати  массива
                        {
                            for (int i = 0; i < firstArray.GetLength(0); i++)
                                {
                                    for (int j = 0; j < firstArray.GetLength(1); j++)
                                        {
                                            Console.Write(firstArray[i, j] + " ");
                                        }
                                    Console.WriteLine();
                                }
                        }
                }
                break;
                
            case 3: // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
                    //Например, даны 2 матрицы:
                    //2 4 | 3 4
                    //3 2 | 3 3
                    //Результирующая матрица будет:
                    //18 20
                    //15 18

                {
                    Console.Clear(); 
	                Console.WriteLine("Матрицу A можно умножить на матрицу B только в том случае, если число столбцов матрицы A равняется числу строк матрицы B");
                    Console.WriteLine();
                    int rows = ReadInt("количество строк");
                    int columns = ReadInt("количество столбцов");
                    int rows1 = ReadInt("количество строк");
                    int columns1 = ReadInt("количество столбцов");
                    // int rangeFrom = ReadInt("диапазон от ");
                    // int rangeTo = ReadInt("диапазон до ");

                    int[,] firstArray = new int[rows, columns];
                    int[,] secondArray = new int[rows1, columns1];
                    int[,] resultArray = new int[rows, columns];
                           
                    FillArrayRandom(firstArray);
                    PrintArray(firstArray);
                    Console.WriteLine();

                    FillArrayRandom(secondArray);
                    PrintArray(secondArray);
                    Console.WriteLine();

                    if (firstArray.GetLength(0) != secondArray.GetLength(1))         //проверка условия возможности перемножение матриц
                        {
                            Console.WriteLine(" Нельзя перемножить ");
                            return;
                        }
                    for (int i = 0; i < firstArray.GetLength(0); i++)
                        {
                            for (int j = 0; j < secondArray.GetLength(1); j++)
                                {
                                    resultArray[i, j] = 0;
                                    for (int k = 0; k < firstArray.GetLength(1); k++)
                                        {
                                            resultArray[i, j] += firstArray[i, k] * secondArray[k, j]; // вычисление по формуле перемножение матриц
                                        }
                                }
                        }

                    PrintArray(resultArray);
                    Console.WriteLine();



                    int ReadInt(string argument)                   // Модуль ввода данных
                        {
	                        Console.Write($"Введте {argument}: ");
	                        int result = 0;

	                        while (!int.TryParse(Console.ReadLine(), out result))
	                            {
		                            Console.WriteLine("Try again");
	                            }
	                      return result;
                        }


                    void FillArrayRandom(int[,] array)        // Функция заполнения массива рандомными числами
                        {
                            for (int i = 0; i < array.GetLength(0); i++)
                                {
                                    for (int j = 0; j < array.GetLength(1); j++)
                                        {
                                            array[i, j] = new Random().Next(0, 10);       
                                        }
                                }
                        }


                    void PrintArray(int[,] array)             // Функция вывода массива
                        {
                            for (int i = 0; i < array.GetLength(0); i++)
                                {
                                    for (int j = 0; j < array.GetLength(1); j++)
                                        {
                                            Console.Write($"{array[i, j]} ");
                                        }
                                    Console.WriteLine();
                                }
                        }
                }
                break;

            case 4: // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
                    //Массив размером 2 x 2 x 2
                    // 66(0,0,0) 25(0,1,0)
                    // 34(1,0,0) 41(1,1,0)
                    // 27(0,0,1) 90(0,1,1)
                    // 26(1,0,1) 55(1,1,1)

                {
	                Console.Clear(); 
                    Console.WriteLine($"\nВведите размер массива X x Y x Z:");
	                int x = ReadInt("x");
                    int y = ReadInt("y");
                    int z = ReadInt("z");
                    Console.WriteLine();
                    int[,,] array = new int[x, y, z];  
                    FillArrayRandom(array);
                    PrintArray(array);
                    Console.WriteLine();
                    
                    int ReadInt(string argument)               // Модуль ввода данных
                        {
	                        Console.Write($"Введте {argument}: ");
	                        int result = 0;

	                        while (!int.TryParse(Console.ReadLine(), out result))
	                            {
		                            Console.WriteLine("Try again");
	                            }
	                      return result;
                        }


                    void FillArrayRandom(int[,,] array)        // Функция заполнения массива рандомными числами
                        {
                            int count = 10;
                            for (int i = 0; i < array.GetLength(0); i++)
                                {
                                    for (int j = 0; j < array.GetLength(1); j++)
                                        {
                                            for (int k = 0; k < array.GetLength(2); k++)
                                                {
                                                    array[k, i, j] += count;
                                                    count += 1;
                                                }
                                        }
                                }
                        }


                    void PrintArray(int[,,] array)             // Функция вывода массива
                        {
                            for (int i = 0; i < array.GetLength(0); i++)
                                {
                                    for (int j = 0; j < array.GetLength(1); j++)
                                        {
                                            for (int k = 0; k < array.GetLength(2); k++)
                                            {
                                                Console.Write($"{array[i, j, k]} ");
                                            }
                                        }
                                }
                            
                        }
                    Console.WriteLine();
                }
                break;

            case 5: // TODO нехватило времени разробраться с заполнением 
                    
                    // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.     
                    // Например, на выходе получается вот такой массив:
                    // 01 02 03 04
                    // 12 13 14 05
                    // 11 16 15 06
                    // 10 09 08 07

                {
                   Console.Clear(); 
                    Console.WriteLine($"\nВведите размер массива X x Y x Z:");
	                int x = ReadInt("x");
                    int y = ReadInt("y");
                    int z = ReadInt("z");
                    Console.WriteLine();
                    int[,,] array = new int[x, y, z];  
                    FillArrayRandom(array);
                    PrintArray(array);
                    Console.WriteLine();
                    
                    int ReadInt(string argument)               // Модуль ввода данных
                        {
	                        Console.Write($"Введте {argument}: ");
	                        int result = 0;

	                        while (!int.TryParse(Console.ReadLine(), out result))
	                            {
		                            Console.WriteLine("Try again");
	                            }
	                      return result;
                        }


                    void FillArrayRandom(int[,,] array)        // Функция заполнения массива рандомными числами
                        {
                            int count = 10;
                            for (int i = 0; i < array.GetLength(0); i++)
                                {
                                    for (int j = 0; j < array.GetLength(1); j++)
                                        {
                                            for (int k = 0; k < array.GetLength(2); k++)
                                                {
                                                    array[k, i, j] += count;
                                                    count += 2;
                                                }
                                        }
                                }
                        }


                    void PrintArray(int[,,] array)             // Функция вывода массива
                        {
                            for (int i = 0; i < array.GetLength(0); i++)
                                {
                                    for (int j = 0; j < array.GetLength(1); j++)
                                        {
                                            for (int k = 0; k < array.GetLength(2); k++)
                                            {
                                                Console.Write($"{array[i, j, k]} ");
                                            }
                                        }
                                }
                            
                        }
                    Console.WriteLine();
                

                }
                break;
        }
    }
}