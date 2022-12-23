// ДОМАШНЕЕ ЗАДАНИЕ
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите числa a и b: ");
// Console.WriteLine("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(a > b ? "Первое число больше второго" : "Второе число больше первого");






// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int thirdNumber = Convert.ToInt32(Console.ReadLine());
// if (firstNumber > secondNumber)
// {
//     if (firstNumber > thirdNumber)
//     {
//         Console.WriteLine("Максимальное число: " + firstNumber);
//     }
//     else
//     {
//         Console.WriteLine("Максимальное число: " + thirdNumber);
//     }
// }

// else if (secondNumber > thirdNumber)
// {
//     Console.WriteLine("Максимальное число: " + secondNumber);
// }
// else
// {
//     Console.WriteLine("Максимальное число: " + thirdNumber);
// }


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число: "); - возникает ошибка при вводе числа со значением минус, к примеру (-3,-7 и т.д), не могу понять где ошибка
// int a = Convert.ToInt32(Console.ReadLine());
// if (a % 2 == 1)
//      {
//         Console.WriteLine("Число " + a + " является: НЕЧЁТНЫМ");
//       }
//             else
//             {
//                 Console.WriteLine("Число " + a + " является: ЧЁТНЫМ");
//             }





// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// int i = 1;
// bool not = true;

//  Console.WriteLine("Введите число:");
//  int n = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("Чётные числа от 1 до " + n);
//  while (i <= n)
//  {
//    if (i % 2 != 1)
//  {
//    Console.Write(i + ", ");
//      not = false;
//    }
//      i++;
//   }

//   if (not)
//   {
//    Console.WriteLine("Нет чётных чисел!");
  }