using System;
using static System.Console;
Clear();

int[] array = GetRandomArray(12, -9, 9);



int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int [] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}