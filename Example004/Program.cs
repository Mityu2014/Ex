﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username == "Маша")
{
    Console.WriteLine("Ура, это МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}