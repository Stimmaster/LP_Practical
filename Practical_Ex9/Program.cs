//                                                  Практическое задание №9

/****************************************************************************************************************************************/

bool isHomeWork = true;
while (isHomeWork)
{
    Console.Write("Введите номер задачи: ");
    if (int.TryParse(Console.ReadLine(), out int w))
    {
        switch (w)
        {
            case 1: // Задача 64: Задайте значение N. 
                    //Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
                    // Выполнить с помощью рекурсии.
                    // N = 5 -> "5, 4, 3, 2, 1"
                    // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

                {
                    Console.Clear();
                    int n = ReadInt("Введите значение N");
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
                    
                    string NumbersRec(int a, int b)
                        {
                            if (a >= b )return $"{a}, " + NumbersRec(a-1, b);
                            else return  String.Empty;
                        }

                    System.Console.WriteLine(NumbersRec(n,1)); //10 9 8 7 6 5 4 3 2 1
                    System.Console.WriteLine(); 
                }
                break;

            case 2: // Задача 66: Задайте значения M и N. 
                    //Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
                    // M = 1; N = 15 -> 120
                    // M = 4; N = 8. -> 30

                {
                    Console.Clear();
                    int m = ReadInt("Введите значение M");
                    int n = ReadInt("Введите значение N");
                    Console.WriteLine();

                    int ReadInt(string argument)                  // Модуль ввода данных
                        {
	                        Console.Write($"Введте {argument}: ");
	                        int result = 0;

	                        while (!int.TryParse(Console.ReadLine(), out result))
	                            {
		                            Console.WriteLine("Try again");
	                            }
	                      return result;
                        }
                    Console.WriteLine();
                    

                    void SumElements (int m, int n, int sum)      //Метод нахождения суммы натуральных элементов в промежутке от M до N
                        {
                            if (m > n) 
                                {
                                    Console.WriteLine($"Сумма натуральных элементов в промежутке от M =  до N: {sum}"); 
                                    return;
                                }
                            sum = sum + (m++);
                            SumElements(m, n, sum);
                        }

                    SumElements(m, n, 0);

                }
                break;

            case 3: // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
                    // Даны два неотрицательных числа m и n.
                    // m = 2, n = 3 -> A(m,n) = 9
                    // m = 3, n = 2 -> A(m,n) = 29 

                {
                    Console.Clear();
                    int m = ReadInt("Введите значение M");
                    int n = ReadInt("Введите значение N");
                    Console.WriteLine();
                    AkkermanFunction(m,n);
                    Console.WriteLine();
                    
                    int ReadInt(string argument)                        // Модуль ввода данных
                        {
	                        Console.Write($"Введте {argument}: ");
	                        int result = 0;

	                        while (!int.TryParse(Console.ReadLine(), out result))
	                            {
		                            Console.WriteLine("Try again");
	                            }
	                      return result;
                        }
                    Console.WriteLine();


                    void AkkermanFunction(int m, int n)                 // вызов функции Аккермана
                        {
                            Console.Write(Akkerman(m, n)); 
                        }

                    int Akkerman(int m, int n)                          // функция Аккермана
                        {
                            if (m == 0)
                                {
                                    return n + 1;
                                }
                            else if (n == 0 && m > 0)
                                {
                                    return Akkerman(m - 1, 1);
                                }
                            else
                                {
                                    return (Akkerman(m - 1, Akkerman(m, n - 1)));
                                }
                        }
                
                }
                break;
        }
    }
}





