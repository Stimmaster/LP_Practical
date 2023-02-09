// Практическое задание к семинару №1 "Знакомство с языками прогрпммирования".

//                                             Задача 2: 
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Пример:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

/*************************************Решение: (с if & else)*****************************************/

// Console.WriteLine("Введите первое число  ");
// int.TryParse(Console.ReadLine(), out int a);
// int numberA = a;

// Console.WriteLine("Введите второе число  ");
// int.TryParse(Console.ReadLine(), out int b);
// int numberB = b;

// if (numberA > numberB) Console.WriteLine("Большее число равно " + numberA);
// else Console.WriteLine("Большее число равно " + numberB);




//                                              Задача 4: 
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Пример:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

/************************************Решение: (с if & else)*****************************************/
// Console.WriteLine("Введите первое число  ");
// int.TryParse(Console.ReadLine(), out int a);
// int numberA = a;

// Console.WriteLine("Введите второе число  ");
// int.TryParse(Console.ReadLine(), out int b);
// int numberB = b;

// Console.WriteLine("Введите первое число  ");
// int.TryParse(Console.ReadLine(), out int c);
// int numberC = c;
// int max = numberA;
// if (numberA > numberB) 
//     {
//         if (numberA > numberC) Console.WriteLine("Большее число равно " + numberA);
//         else Console.WriteLine("Большее число равно " + numberC);
//         }
// else 
//     {
//         if (numberB > numberC) Console.WriteLine("Большее число равно " + numberB);
//         else Console.WriteLine("Большее число равно " + numberC);
//     }


//                                              Задача 6: 
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Пример:
// 4 -> да
// -3 -> нет
// 7 -> нет

/************************************Решение: ( с % , if & else )*****************************************/

// Console.WriteLine("Введите число ");
// int.TryParse(Console.ReadLine(), out int  i);
// int number = i % 2;
// if (number == 0) Console.WriteLine("четное число");
// else Console.WriteLine("нечетное число");


//                                              Задача 8: 
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Пример:
//5 -> 2, 4
//8 -> 2, 4, 6, 8

/************************************Решение: ( с while)*****************************************/

Console.WriteLine("Введите число N ");
 int.TryParse(Console.ReadLine(), out int n);
 var  number = 2;
 while (number <= n)
 {
  Console.Write(number + " ");
  number = number + 2;
 }