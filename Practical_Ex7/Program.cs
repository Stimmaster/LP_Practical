//                                                  Практическое задание №7. Двумерные массивы

/****************************************************************************************************************************************/

bool isHomeWork = true;
while (isHomeWork)
{
    Console.Write("Введите номер задачи: ");
    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch (i)
        {
            case 1: // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
                    // m = 3, n = 4.
                    // 0,5 7 -2 -0,2
                    // 1 -3,3 8 -9,9
                    // 8 7,8 -7,1 9
          
                {
                    Console.WriteLine();
                    int m = ReadInt("кол-во строк - m");
                    int n = ReadInt("кол-во столбцов - n");
                    Console.WriteLine();
                    double[,] randomArray = Array(m, n);
                    Console.WriteLine(PrintArray(randomArray));

                    int ReadInt(string argument)
                        {
	                        Console.Write($"Введте {argument}: ");
	                        int result = 0;

	                        while (!int.TryParse(Console.ReadLine(), out result))
	                            {
		                            Console.WriteLine("Try again");
	                            }
	                      return result;
                        }

                    double[,] Array(int m, int n)
                    {
                        double[,] randomArray = new double[m, n];
                        Random random = new Random();

                        for (int i = 0; i < randomArray.GetLength(0); i++)
                            {
                              for (int j = 0; j < randomArray.GetLength(1); j++)
                                {
                                    randomArray[i, j] = Math.Round(random.NextDouble() * 10, 2); // [0,1)
                                }
                            }
                         return randomArray;
                    }

                    string PrintArray(double[,] randomArray)
                    {
                        string result = string.Empty;
                        for (int i = 0; i < randomArray.GetLength(0); i++)
                            {
                                for (int j = 0; j < randomArray.GetLength(1); j++)
                                    {
                                      result += $" {randomArray[i, j]} ";
                                    }
                                result += Environment.NewLine;
                            }

                         return result;
                    }
           
                }
                break;

            case 2: // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
                    // Например, задан массив:
                    // 1 4 7 2
                    // 5 9 2 3
                    // 8 4 2 4
                    // 17 -> такого числа в массиве нет

                {
	                Console.WriteLine();
                    int m = ReadInt("кол-во строк - m");
                    int n = ReadInt("кол-во столбцов - n");
                    int indexI = ReadInt("номер строки запрашиваемого элемента");
                    int indexJ = ReadInt("номер строки запрашиваемого элемента");
                    Console.WriteLine();
                    int[,] randomArray = Array(m, n);
                    Console.WriteLine(PrintArray(randomArray));
                    if (indexI > m || indexJ > n) Console.WriteLine($"Такого элемента в массиве нет или введенные координаты {indexI}, {indexJ} выходят за пределы заданного массива");
                    else Console.WriteLine($"Значение элемента в строке {indexI} и в столбце {indexJ} равно --> {randomArray[indexI-1,indexJ-1]} ");

                    int ReadInt(string argument)
                        {
	                        Console.Write($"Введте {argument}: ");
	                        int result = 0;

	                        while (!int.TryParse(Console.ReadLine(), out result))
	                            {
		                            Console.WriteLine("Try again");
	                            }
	                      return result;
                        }

                    int[,] Array(int m, int n)
                    {
                        int[,] randomArray = new int[m, n];
                        Random random = new Random();

                        for (int i = 0; i < randomArray.GetLength(0); i++)
                            {
                              for (int j = 0; j < randomArray.GetLength(1); j++)
                                {
                                    randomArray[i, j] = random.Next(10,99);
                                }
                            }
                         return randomArray;
                    }

                    string PrintArray(int[,] randomArray)
                    {
                        string result = string.Empty;
                        for (int i = 0; i < randomArray.GetLength(0); i++)
                            {
                                for (int j = 0; j < randomArray.GetLength(1); j++)
                                    {
                                      result += $" {randomArray[i, j]} ";
                                    }
                                result += Environment.NewLine;
                            }

                         return result;
                    }
                       
                 
                }
                break;

            case 3: // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
                    // Например, задан массив:
                    // 1 4 7 2
                    // 5 9 2 3
                    // 8 4 2 4
                    // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


                {
                    Console.WriteLine();
                    int m = ReadInt("кол-во строк - m");
                    int n = ReadInt("кол-во столбцов - n");
                    Console.WriteLine();
                    int[,] randomArray = Array(m, n);
                    Console.WriteLine(PrintArray(randomArray));
                    double result = 0;
                    Console.Write($"Среднее арифметическое каждого столбца:");
                    for (int j = 0; j < n; j++)
                        {
                            result = ArithmeticMean(j);
                            Console.Write($" {result} ");
                            
                        }
                    Console.WriteLine();
                    Console.WriteLine();                        

                    int ReadInt(string argument)
                        {
	                        Console.Write($"Введте {argument}: ");
	                        int result = 0;

	                        while (!int.TryParse(Console.ReadLine(), out result))
	                            {
		                            Console.WriteLine("Try again");
	                            }
	                      return result;
                        }

                    int[,] Array(int m, int n)
                    {
                        int[,] randomArray = new int[m, n];
                        Random random = new Random();
                        
                        for (int i = 0; i < randomArray.GetLength(0); i++)
                            {
                              for (int j = 0; j < randomArray.GetLength(1); j++)
                                {
                                    randomArray[i, j] = random.Next(10,99);
                                }
                            }
                         return randomArray;
                    }

                    double ArithmeticMean (int column)
                        {
                            double sumNumbersInColumn = 0;
                            double resArithmeticMean = 0;
                            for (int i = 0; i < m; i++)
                                {
                                    sumNumbersInColumn += randomArray[i, column];
                                }
                                resArithmeticMean = sumNumbersInColumn / m;
                            return resArithmeticMean;
                        }

                    string PrintArray(int[,] randomArray)
                    {
                        string result = string.Empty;
                        string arithmeticMean = string.Empty;
                        for (int i = 0; i < randomArray.GetLength(0); i++)
                            {
                                for (int j = 0; j < randomArray.GetLength(1); j++)
                                    {
                                      result += $" {randomArray[i, j]} ";
                                    }
                                result += Environment.NewLine;
                            }

                         return result;
                    }
                       
                }
                break;
        }
    }
}