using System;
using static System.Console;
Clear();

Write("Введите 2 элемента через пробел: ");
string[] array = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
WriteLine(array.Length);
int a1 =int.Parse(array[0]);
int a2 =int.Parse(array[1]);

WriteLine($"{a1} -> {a2}");

