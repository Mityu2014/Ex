// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int n;

Console.WriteLine("Введите целое натуральное число");

while (true)
{
    var input = Console.ReadLine();
    if (int.TryParse(input, out n) && int.Parse(input) > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Введенное число не является натуральным, попробуй снова");
    }
}

RangeNum(n);

int RangeNum(int n)
{
    if (n < 2)
    {
        Console.Write(n);
        return n;
    }
    Console.Write(n + ", ");
    return RangeNum(n - 1);
}


// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// int m = 1;
// int n = 1;

// Console.WriteLine("Введите целое натуральное число начала промежутка");
// m = ChecNaturalNum(m);
// Console.WriteLine("Введите целое натуральное число окочания промежутка");
// n = ChecNaturalNum(n);

// if (m > n)
// {
//     Console.WriteLine("Число М больше N");
// }
// else
// {
//     Console.WriteLine(SumNumbers(m,n));
// }

// int ChecNaturalNum(int num)
// {
//     while (true)
//     {
//         var input = Console.ReadLine();
//         if (int.TryParse(input, out num) && int.Parse(input) > 0)
//         {
//             return num;
//             break;
//         }
//         else
//         {
//             Console.WriteLine("Введенное число не является натуральным, попробуй снова");
//         }
//     }
// }

// int SumNumbers(int m, int n)
// {
//     if (m == n)
//     {
//         return m;
//     }
//     else
//     {        
//         return m = m + SumNumbers(m + 1, n);
//     }
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// int m = 0;
// int n = 0;

// Console.WriteLine("Введите целое не отрицательное число М");
// m = ChecNaturalNum(m);
// Console.WriteLine("Введите целое не отрицательное число N");
// n = ChecNaturalNum(n);

// Console.WriteLine(AckermanFun(m,n));

// int ChecNaturalNum(int num)
// {
//     while (true)
//     {
//         var input = Console.ReadLine();
//         if (int.TryParse(input, out num) && int.Parse(input) >= 0)
//         {
//             return num;
//             break;
//         }
//         else
//         {
//             Console.WriteLine("Введенно не положительное число, либо не число вовсе. Попробуй снова");
//         }
//     }
// }

// int AckermanFun(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0)
//     {
//         return AckermanFun(m - 1, 1);
//     }      
//     return AckermanFun(m - 1, AckermanFun(m, n - 1));
// }