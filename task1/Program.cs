using System;
using static System.Console;
Clear();

int[] array = GetRandomArray(12, -9, 9);
WriteLine($"[{String.Join(",",array)}]");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int [] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int GetPositiveSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i< array.Length; i++)
    {
        sum+= array[i]>0?array[i]:0; 
    }
    return sum;
}

int GetNegativeSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i< array.Length; i++)
    {
        sum+= array[i]<0?array[i]:0; 
    }
    return sum;
}