//                                                  Практическое задание №6

/****************************************************************************************************************************************/

bool isHomeWork = true;
while (isHomeWork)
{
    Console.Write("Введите номер задачи: ");
    if (int.TryParse(Console.ReadLine(), out int a))
    {
        switch (a)
        {
            case 1: // Задача 41: Пользователь вводит с клавиатуры m чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
                    //Пример:// 0, 7, 8, -2, -2 -> 2
                             // 1, -7, 567, 89, 223-> 3
                    
                    //                     Программа вызывающая необходимые методы для выполнения задания:

                {
                  Console.Write("Введите целые числа в массив через пробел: ");
                  int[] numbers = StringToNum(Console.ReadLine());
                  
                  int sum = 0;
                  for (int i = 0; i < numbers.Length; i++)
                    {
                     if (numbers[i] > 0)
                        {
                          sum++;
                        }
                    }
                  Console.Write("В массиве ");
                  PrintArray(numbers);
                  Console.WriteLine($" количество значений больше 0  -> {sum}");

                int[] StringToNum(string input)
                  {
                    int count = 1;
                    for (int i = 0; i < input.Length; i++)
                      {
                         if (input[i] == ' ')
                          {
                            count++;
                          }
                      }

                    int[] numbers = new int [count];
                    int index = 0;

                    for (int i = 0; i < input.Length; i++)
                      {
                        string temp = "";

                        while (input [i] != ' ')
                          {
                             if(i != input.Length - 1)
                                {
                                  temp += input [i].ToString();
                                 i++;
                                }
                             else
                                {
                                  temp += input [i].ToString();
                                  break;
                                }
                          }
                        numbers[index] = Convert.ToInt32(temp);
                        index++;
                     }
                    return numbers;
                 }


                void PrintArray(int[] array)
                  {
                    Console.Write("[ ");
                    for (int i = 0; i < array.Length; i++)
                      {
                        Console.Write(array[i] + " ");
                      }
                    Console.Write("]");
                  }
                }
                break;

            case 2: // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
                    // Пример: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

                    //                     Программа вызывающая необходимые методы для выполнения задания:
                {
                  
                  double b1 = ReadInt("Введите число  - значение B1");
                  double k1 = ReadInt("Введите число  - значение K1");
                  double b2 = ReadInt("Введите число  - значение B2");
                  double k2 = ReadInt("Введите число  - значение K2");
                  CalculatePoint(b1, k1, b2, k2);


                  int ReadInt(string arg)
                  {
                    int i;
                    Console.Write($"Введите {arg}: ");

                    while (!int.TryParse(Console.ReadLine(), out i))
                      {
                        Console.Write("Неверное значение. Повторите: ");
                      }
                    return i;
                  }

                  void CalculatePoint(double b1, double k1, double b2, double k2)
                  {
                    double x = (b2-b1)/(k1-k2);
                    Console.WriteLine ();
                    double y = k1*x+b1;
                    Console.WriteLine ("Точка пересечения 2-х прямых с заданными коэффициентами k и b имеет координаты:  ("+x+"; "+y+")");
                    Console.WriteLine();
                  }
                }
                break;

        }
                
    }
                
}






