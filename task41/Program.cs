using System;
using static System.Console;
Clear();

// Write("Введите 2 элемента через пробел: ");
// string[] array = ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
// WriteLine(array.Length);
// int a1 =int.Parse(array[0]);
// int a2 =int.Parse(array[1]);
// WriteLine($"{a1} -> {a2}");

Write("Введите элементы массива через пробел: ");
int[] array = GetArrayFromString(ReadLine());
WriteLine($"[{String.Join(",",array)}]");

int[] GetArrayFromString(string arrayStr)
{
    string[] arS = arrayStr.Split(new char[]{" ",'&',"!","*",','},StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[arS.Length];
    for(int i = 0; i < arS.Length; i++)
    {
        result[i] = int.Parse(arS[i]);

    }
    return result;

}

