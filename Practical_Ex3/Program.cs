// Задача 19 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Решение:

// Console.WriteLine ("Введи пятизначное число");       //  вывыод текста в консоль "Введи пятизначное число"
// string number = Console.ReadLine();                  //  переменной number с типом string присваиваем введенное значение

// int len = number.Length;                             //  переменной len с типом int присваиваем длину введенного string number

// if (len == 5)                                        // проверяем, пятизначное ли число.
//     {
//         if (number[0] == number[4] && number [1] == number[3]) Console.WriteLine(number + " -> Да"); 
           // проверяем, симметрично равен ли 0-й  4-му и  1-й  3-му элементу значения string number, если да то " ЧИСЛО -> ДА", 
//         else Console.Write(number + " ->  Нет");   //если нет, то "ЧИСЛО -> Нет"
//     }
// else Console.WriteLine ("Ошибка!!! Введено не пятизначное число"); // Если число не пятизначное, то выводим в консоль "Ошибка!!! Введено не пятизначное число"
    

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Решение:

// int x1 = PointCoord("x", "A");
// int y1 = PointCoord("y", "A");
// int z1 = PointCoord("z", "A");
// int x2 = PointCoord("x", "B");
// int y2 = PointCoord("y", "B");
// int z2 = PointCoord("z", "B");

// int PointCoord(string coordName, string pointName)        // метод ввода координат
// {
//     Console.Write($"Введите координату {coordName} для точки {pointName}: ");
//     return Convert.ToInt32(Console.ReadLine());
// }

// double Result(double x1, double x2, double y1, double y2, double z1, double z2)          // метод вычисления результата по формуле
// {
//     return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)); 
//     //возвращаем результат расчитанный по формуле вычисления расстояния между точками в 3D пространстве
// }

// double distance = Math.Round(Result(x1, x2, y1, y2, z1, z2), 2);                  // округлим значение distance с двумя знаками после запятой
// Console.WriteLine(); // пустая строка
// Console.WriteLine($"Расстояние между точками =  {distance}"); 


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// Решение:

// Console.Write("Введите число: ");                        //  вывыод текста в консоль "Введи число"
// int numberN = Convert.ToInt32(Console.ReadLine());       //  переменной numberТ с типом int присваиваем конвертированное в int введенное значени 

// void MatPowN(int[] numberN)                              // метод возведения числа в степень
// {
//     for (int i = 1; i < numberN.Length; i++)             // задаем цикл от i = 1; i < numberN.Length; i++  
//     {
//         numberN[i] = Convert.ToInt32(Math.Pow(i, 3));    // возводим в степень
//     }
// }

// void PrintArray(int[] coll)                              // метод вывода результата в консоль
// {
//     for (int index = 1; index < coll.Length; index++)    // задаем цикл от index = 1; i < numberN.Length; index++  
//     {
//         Console.WriteLine(coll[index]);                  // выводим в консоль элементы массива
//     }
// }

// int[] array = new int[numberN + 1];                      // создаем новый массив и заливаем
// MatPowN(array);                                          // включаем метод возведения числа в степень
// PrintArray(array);                                       // включаем метод вывода результата в консоль














