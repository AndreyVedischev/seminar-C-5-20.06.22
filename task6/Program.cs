using System;
using static System.Console;
Clear();

// Write("Введите число: ");
// int number = int.Parse(ReadLine());
int[] array = GetRandomArray(5,-5,5);

Write($"[{String.Join(",",array)}] -> {MultiNumber(array)}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int [] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] MultiNumber(int size)
{
    int result = 0;
    for(int i = 0; i < size; i++)
    {
        result = size*i;
    
    }
    return result;
}