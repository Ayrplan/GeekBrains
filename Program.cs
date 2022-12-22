// Напишите программу, которая на вход принимает число
// и выдает его квадрат (число умноженное на само себя).
// Console.WriteLine("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// a = a + a; 
// Console.WriteLine(a);
// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
// int b = Convert.ToInt32(Console.ReadLine());
// if (b + b == a)
//     Console.WriteLine("Да");
// else
//     Console.WriteLine("Нет");


// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница
// Console.WriteLine ("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// while (a<1 || a>7){
    // Console.WriteLine("Вы ошиблись!!! Введите число: ");
    // a = Convert.ToInt32(Console.ReadLine());
// };

// if (a==1) Console.WriteLine ("Понедельник");
// else if (a==2) Console.WriteLine ("Вторник");
// else if (a==3) Console.WriteLine ("Среда");
// else if (a==4) Console.WriteLine ("Четверг");
// else if (a==5) Console.WriteLine ("Пятница");
// else if (a==6) Console.WriteLine ("Суббота");
// else if (a==7) Console.WriteLine ("Воскресенье");


// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе
// показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// Console.WriteLine("Введите число: ");
// int a =  Convert.ToInt32(Console.ReadLine());

// for (int i = -a; i <= a; i++)
// Console.Write(i + " ");





// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


// Console.WriteLine("Введите число: ");-моя попытка решения.(простое, но только для тех которые указаны в условии.)
// int a = Convert.ToInt32(Console.ReadLine());
// if (a==456) Console.WriteLine("6");
// if (a==782) Console.WriteLine("2");
// if (a==918) Console.WriteLine("8");

// Console.WriteLine("Введите число: ");-решение препода.(более гибкое, подойдет для любых чисел)
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Последняя цифра: "+ (a % 10));