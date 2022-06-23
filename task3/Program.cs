using System;
using static System.Console;
Clear();

Write("Введите число: ");
int number = int.Parse(ReadLine());
int[] array = GetRandomArray(5,-5,5);

Write($"{number}; массив [{String.Join(",",array)}] -> {FindeNumber(array, number)}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int [] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

string FindeNumber(int[]array, int numbers)
{
    string flag = "нет";
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] == numbers)
        {
            flag = "да";
            break;
        }
    }
    return flag;
}