﻿Console.Clear();
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3-ое число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if( max < b )
    max = b;

if( max < c )
    max = c;

Console.WriteLine(max);