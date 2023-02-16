
//                                                  Практическое задание №5

/****************************************************************************************************************************************/

bool isHomeWork = true;
while (isHomeWork)
{
    Console.Write("Введите номер задачи: ");
    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch (i)
        {
            case 1: // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
                    //Напишите программу, которая покажет количество чётных чисел в массиве.
                    //Пример: [345, 897, 568, 234] -> 2

                    //                     Программа вызывающая необходимые методы для выполнения задания:

                {
                  string text = "Задайте длину массива , минимальное - 100 и максимальное - 999 значения для массива трехзначных случайных чисел";
                  Console.WriteLine(text);
                  Console.WriteLine();
                  int[] array = RandomArray(ReadInt("длину массива"), ReadInt("минимальное значение наполнения"), ReadInt("максимальное значение наполнения"));
                  int sumIndex = sumIndexEventElement(array);
                  Console.WriteLine();
                  Console.WriteLine($"Количество чётных чисел в массиве[{string.Join(", ", array)}] -> {sumIndex}");
                  Console.WriteLine();

                  //                                              Подключаемые методы:

                  int ReadInt(string argument)            // Метод ввода и проверка на число 
                  {
	                  Console.Write($"Введите {argument}: ");
                    int number;

	                  while (!int.TryParse(Console.ReadLine(), out number))
	                    {
		                    Console.WriteLine("Ошибка ввода, пожалуйста, введите число");
	                    }
                    return number;
                  }
                 

                  int[] RandomArray(int length, int minValue, int maxValue)   // Метод заполнения массива случайными числами
                  {
                    int[] array = new int[length];
                    Random random = new Random();

                    for (int i = 0;i < array.Length; i++)
                      {
                        array[i] = random.Next(minValue, maxValue + 1);
                      }
                    return array;
                  }


                  int sumIndexEventElement(int[] array)   // Метод подсчета количества четных элементов массива
                  {
                    int sumIndex = 0;
                    for(int i=0;i<array.Length;i++)
                      {
                        if (array[i] % 2 == 0) sumIndex++;
                      }    
                    return sumIndex;
                  }
                }
                break;

            case 2: // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
                    // стоящих на нечётных позициях.
                    // Пример:
                    // [3, 7, 23, 12] -> 19
                    // [-4, -6, 89, 6] -> 0

                    //                     Программа вызывающая необходимые методы для выполнения задания:
                {
                  string text = "Задайте одномерный массив, заполненный случайными числами, а программа покажет сумму элементов, стоящих на нечётных позициях";
                  Console.WriteLine(text);
                  Console.WriteLine();
                  int[] array = RandomArray(ReadInt("длину массива"), ReadInt("минимальное значение наполнения"), ReadInt("максимальное значение наполнения"));
                  int sumElementsNoEvIndex = SumElementNotEventIndex(array);
                  // int sumElementsEvIndex = SumElementEventIndex(array);
                  Console.WriteLine();
                  Console.WriteLine($"Сумма элементов массива c нечетными позициями [{string.Join(", ", array)}] -> {sumElementsNoEvIndex}");
                  Console.WriteLine();
                  // Console.WriteLine($"Сумма  элементов массива с четными позициями [{string.Join(", ", array)}] -> {sumElementsEvIndex}");
                  // 2Console.WriteLine();

                  //                                              Подключаемые методы:

                  int ReadInt(string argument)            // Метод ввода и проверка на число 
                  {
	                  Console.Write($"Введите {argument}: ");
                    int number;

	                  while (!int.TryParse(Console.ReadLine(), out number))
	                    {
		                    Console.WriteLine("Ошибка ввода, пожалуйста, введите число");
	                    }
                    return number;
                  }
                 
                  int[] RandomArray(int length, int minValue, int maxValue)   // Метод заполнения массива случайными числами
                  {
                    int[] array = new int[length];
                    Random random = new Random();

                    for (int i = 0;i < array.Length; i++)
                      {
                        array[i] = random.Next(minValue, maxValue + 1);
                      }
                    return array;
                  }

                  int SumElementNotEventIndex(int[] array)   //    Метод подсчета суммы значений элементов на нечетных позициях массива
                  {
                    int sumElementsNoEvIndex = 0;

                    for(int i=1;i<array.Length;i=i+2)
                      {
                        sumElementsNoEvIndex = sumElementsNoEvIndex + array[i];
                      }    
                    return sumElementsNoEvIndex;
                  }

                  int SumElementEventIndex(int[] array)   // Метод подсчета суммы значений элементов на четных позициях массива
                  {
                    int sumElementsEvIndex = 0;

                    for(int i=0;i<array.Length;i=i+2)
                      {
                        sumElementsEvIndex = sumElementsEvIndex + array[i];
                      }    
                    return sumElementsEvIndex;
                  }
                }
                break;

            case 3: // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
                    // [3 7 22 2 78] -> 76

                    //                     Программа вызывающая необходимые методы для выполнения задания:
                {
                  string text = "Задайте длину массива, минимальное и максимальное значение  для массива случайных чисел, а программа покажет количество чётных чисел в массиве";
                  Console.WriteLine(text);
                  Console.WriteLine();
                  int[] array = RandomArray(ReadInt("длину массива"), ReadInt("минимальное значение в массиве"), ReadInt("максимальное значение в массиве"));
                  int[] minAndMax = FindMinAndMax(array);
                  int difference = Difference(minAndMax[0], minAndMax[1]);
                  Console.WriteLine($"Разница между минимальным и максимальным значение массива [{string.Join(", ", array)}] равна -> {difference}");
                  Console.WriteLine();

                  //                                              Подключаемые методы:

                  int ReadInt(string argument)            // Метод ввода и проверка на число 
                    {
	                    Console.Write($"Введите {argument}: ");
                      int number;

	                    while (!int.TryParse(Console.ReadLine(), out number))
	                      {
		                      Console.WriteLine("Ошибка ввода, пожалуйста, введите число");
	                      }
                      return number;
                    }


                  int[] RandomArray(int length, int minValue, int maxValue)   // Метод заполнения массива случайными числами
                    {
                      int[] array = new int[length];
                      Random random = new Random();

                      for (int i = 0;i < array.Length; i++)
                        {
                          array[i] = random.Next(minValue, maxValue + 1);
                        }
                      return array;
                    }


                  int[] FindMinAndMax(int[] array)
                    {
                      int[] minAndMax = new int[2];
                      minAndMax[0] = array[0];
                      minAndMax[1] = array[1];

                      for (int i = 0; i < array.Length; i++)
                        {
                          if (array[i] >= minAndMax[1]) minAndMax[1] = array[i];
                          else if (array[i] <= minAndMax[0]) minAndMax[0] = array[i];
                        }
                      return minAndMax;
                    }


                  int Difference(int firstNumber, int secondNumber)
                    {
                      int difference = 0;
                      if (firstNumber > secondNumber) difference = firstNumber - secondNumber;
                      else difference = secondNumber - firstNumber;
                      return difference;
                    }
                }
                break;
        }
    }
}