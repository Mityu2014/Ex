// int firstNumber = 2;
// int secondNumber = 2;
// if(firstNumber == secondNumber)
// {
//     Console.WriteLine($"Веденные числа равны {firstNumber}");
// }
// else if(firstNumber > secondNumber)
// {
//     Console.WriteLine("Первое число " + firstNumber+" больше чем второе число " + secondNumber);
// }
// else 
// {
//     Console.WriteLine("Первое число " + firstNumber+" меньше чем второе число " + secondNumber);
// }

// int a = 6;
// int b = 4;
// int c = 2;

// if((a>b)&&(a>c))
// {
//     Console.WriteLine(a);
// }
// else if(b>c)
// {
//     Console.WriteLine(b);
// }
// else
// {
//     Console.WriteLine (c);
// }


// int number = -8;

// if(number == 0)
// {
//     Console.WriteLine("Число 0 не определяется четность");
// }
// else if(number%2 == 0)
// {
//     Console.WriteLine("Число " + number +" чётное");
// }
// else
// {
//     Console.WriteLine("Число " + number +" не чётное");
// }

// int number = 8;
// int i = 1;
// while(number >= i)
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

int num = new Random().Next(100,1000);
Console.WriteLine(num/10%10);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num = new Random().Next(10,100000);
Console.WriteLine(num);
if (100 <= num && num < 1000)
{
    Console.WriteLine(num%10);
}
else if (num < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while(num > 1000)
    {
        num = num/10;
    }
    Console.WriteLine(num%10);
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели");
int num= Convert.ToInt32(Console.ReadLine());
if (num < 1 || num > 7)
{
    Console.WriteLine("Введено неверное число");
}
else if (num < 6)
{
    Console.WriteLine("нет");
}
else
{
    Console.WriteLine("да");
}