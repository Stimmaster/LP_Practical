// Задача 28: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 8 -> 243 (3⁵)
// 2, 4 -> 16
// Решение:

// int InputNumber(string NumberName)                   // функция принимает число из консоли, преобразуя его в целое
// {
//     int number;
//     Console.Write($"Введите число {NumberName}: ");
//     while(!int.TryParse(Console.ReadLine(), out number))
//     {
//         Console.WriteLine("Ошибка! Введите целое число");
//     }
//     return  number;
// }

// void NaturDegree(int a, int b)                         // Функция возведения в степень
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result = result * a;
//     }
//     Console.WriteLine(result);
// }


// int numberA = InputNumber("A");
// int numberB = InputNumber("B");
// NaturDegree(numberA, numberB);  


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 482 -> 11
// 82 -> 10
// 9012 -> 12
// Решение:

// int InputNumber(string NumberName)                        // функция принимает число из консоли, преобразуя его в целое
// {
//     int numb;
//     Console.Write($"Введите число {NumberName}: ");
//     while(!int.TryParse(Console.ReadLine(), out numb))
//     {
//         Console.WriteLine("Ошибка! Введите целое число");
//     }
//     return numb;
// }

// int sum(int InputNumber)      // функция суммирует результат tempResult = tempResult + (InputNumber % 10) пока введенное число делится на 10 
// {
//     int tempResult = 0;
//         while (InputNumber > 0)                     
//     {
//         tempResult = tempResult + (InputNumber % 10);   
//         InputNumber = InputNumber / 10;                 
//     }
//     return tempResult;
// }

//                                 // сама программа 
// Console.WriteLine();
// int number = InputNumber("");
// int result = sum(number);
// Console.WriteLine();
// Console.WriteLine($"Сумма цифр числа {number} равна {result}");
// Console.WriteLine();


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 8, 7, 19 -> [1, 2, 8, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Решение:

// int[] CreateArray(int size)
// {
//     int[] arr = new int[size];
//     for (int i=0; i < size; i++)
//     {
//         arr[i] = InputNumber("" + i + " элемент массива");
//     }
//     return arr;
// }

// int InputNumber(string NumberName)                        // метод принимает число из консоли  преобразуя в int
// {
//     int numb;
//     Console.Write($"Введите {NumberName} <-- ");
//     while(!int.TryParse(Console.ReadLine(), out numb))
//     {
//         Console.WriteLine("Ошибка! Введите целое число");
//     }
//     return numb;
// }

// void PrintArray(int[] array)                              // метод вывода массива в консоль
// {
//     string str = "";
//     for (int i = 0; i <= array.Length; i++)
//     {
//         if (i != array.Length )
//         {
//             str = str  + array[i] + " ";
//         }
//     }
//     Console.WriteLine(str);
// }

// Console.WriteLine();
// int[] Array = CreateArray(8);                 //заполнение пользовательскими числами массива размерностью 8
// Console.WriteLine();
// PrintArray(Array);
// Console.WriteLine();

