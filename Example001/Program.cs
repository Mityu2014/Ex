// int firstaber = 2;
// int secondaber = 2;
// if(firstaber == secondaber)
// {
//     Console.WriteLine($"Веденные числа равны {firstaber}");
// }
// else if(firstaber > secondaber)
// {
//     Console.WriteLine("Первое число " + firstaber+" больше чем второе число " + secondaber);
// }
// else 
// {
//     Console.WriteLine("Первое число " + firstaber+" меньше чем второе число " + secondaber);
// }

// int num = 6;
// int b = 4;
// int c = 2;

// if((num>b)&&(num>c))
// {
//     Console.WriteLine(num);
// }
// else if(b>c)
// {
//     Console.WriteLine(b);
// }
// else
// {
//     Console.WriteLine (c);
// }


// int aber = -8;

// if(aber == 0)
// {
//     Console.WriteLine("Число 0 не определяется четность");
// }
// else if(aber%2 == 0)
// {
//     Console.WriteLine("Число " + aber +" чётное");
// }
// else
// {
//     Console.WriteLine("Число " + aber +" не чётное");
// }

// int aber = 8;
// int i = 1;
// while(aber >= i)
// {
//     if(i%2 == 0)
//     {
//         Console.Write(i+"\t");
//     }
//     i++;
// }

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// int num = new Random().Next(100,1000);
// Console.WriteLine(num/10%10);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int num = new Random().Next(10,100000);
// Console.WriteLine(num);
// if (100 <= num && num < 1000)
// {
//     Console.WriteLine(num%10);
// }
// else if (num < 100)
// {
//     Console.WriteLine("третьей цифры нет");
// }
// else
// {
//     while(num > 1000)
//     {
//         num = num/10;
//     }
//     Console.WriteLine(num%10);
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Введите цифру, обозначающую день недели");
// int num= Convert.ToInt32(Console.ReadLine());
// if (num < 1 || num > 7)
// {
//     Console.WriteLine("Введено неверное число");
// }
// else if (num < 6)
// {
//     Console.WriteLine("нет");
// }
// else
// {
//     Console.WriteLine("да");
// }

// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход пятизначное число aber 
// и проверяет, является ли оно палиндромом.
// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное
// и False в следующей строке.
// Для остальных чисел вернуть True или False.

// int aber = 23231;
// bool result = false;
// if(aber < 10000 || aber > 100000)
// {
//     Console.WriteLine("Число не пятизначное " + result);
// }
// else if (aber/10000 == aber%10 && aber/1000%10 == aber%100/10)
// {
//     result = true;
//     Console.WriteLine(result);
// }
// else
// {
//     Console.WriteLine(result);
// }


// Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты двух точек
// pointA и pointB в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.

// int x1 = 7;
// int x2 = -5;
// int x3 = 0;
// int y1 = 1;
// int y2 = -1;
// int y3 = 9;
// double d = Math.Sqrt(Math.Pow(x1-y1,2)+ Math.Pow(x2-y2,2) + Math.Pow(x3-y3,2));

// Console.WriteLine(d);

// public class Answer
// {
//     private static double Length(int[] pointA, int[] pointB)
//     {
//       // Введите свое решение ниже
// double d = Math.Sqrt(Math.Pow(pointA[0]-pointB[0],2)+ Math.Pow(pointA[1]-pointB[1],2) + Math.Pow(pointA[2]-pointB[2],2));
//       return d;
//     }

//   // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args) {
//         int x1, x2, x3, y1, y2, y3;

//         if (args.Length >= 6) {
//             x1 = int.Parse(args[0]);
//             x2 = int.Parse(args[1]);
//             x3 = int.Parse(args[2]);
//             y1 = int.Parse(args[3]);
//             y2 = int.Parse(args[4]);
//             y3 = int.Parse(args[5]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             x1 = 7;
//             x2 = -5;
//             x3 = 0;
//             y1 = 1;
//             y2 = -1;
//             y3 = 9;
//         }

//         // Не удаляйте строки ниже
//         double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
//         Console.WriteLine($"{result:F2}");
//     }
// }

// public class Answer
// {
//    static void ShowCube(int N)
//     {
//       // Введите свое решение ниже
//         int i = 1;
//         while(i<=N)
//         {
//             Console.WriteLine(Math.Pow(i,3));
//             i=i+1;
//         }
//     }

//   // Не удаляйте и не меняйте метод Main! 
//       static public void Main(string[] args) {
//         int N;

//         if (args.Length >= 1) {
//             N = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             N = 6;
//         }

//         // Не удаляйте строки ниже
//         ShowCube(N);
//     }
// }

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите возводимое число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число степени");
int b = Convert.ToInt32(Console.ReadLine());
GetDeg();

void GetDeg()
{
    int result = num;
    for (int i = 1; i < b; i++)
    {
        result = result * num;
        
    }
    System.Console.WriteLine(result);
}

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите возводимое число");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(GetSum(a));

int GetSum (int num)
{
    int result = 0;
    for (int i = 0; num > 1; i++)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result;
}

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];

GetArray();

void GetArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length -1)
        {
            array[i] = new Random().Next(0,1000);
            System.Console.Write(array[i]);
        }
        else
        {
            array[i] = new Random().Next(0,1000);
            System.Console.Write(array[i]+ ", ");
        }
    }
}