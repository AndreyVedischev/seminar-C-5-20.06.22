using System;
using static System.Console;
Clear();

// int length = int.Parse(ReadLine());
// int min = int.Parse(ReadLine());
// int max = int.Parse(ReadLine());
 
int[] array = GetRandomArray(12, -1, 1); //GetRandomArray(length, min, max)
WriteLine($"[{String.Join(",",array)}]");
WriteLine($"Сумма отр эл = {GetNegativeSum(array)} , Сумма пол эл = {GetPositiveSum(array)}");

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