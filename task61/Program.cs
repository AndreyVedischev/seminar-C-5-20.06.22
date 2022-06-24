using System;
using static System.Console;
Clear();

int[] array = GetArrayFromString(ReadLine());
WriteLine($"[{String.Join(",",array)}]");
WriteLine($"[{String.Join(",", MultiPair(array))}]");

int[] GetArrayFromString(string arrayStr)
{
    string[] arS = arrayStr.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[arS.Length];
    for(int i = 0; i < arS.Length; i++)
    {
        result[i] = int.Parse(arS[i]);

    }
    return result;
}

int[] MultiPair(int[] array)
{
    int[] result = new int[array.Length % 2 == 0?array.Length/2:array.Length/2+1];
    for(int i = 0; i < array.Length % 2 == 0?result.Length : result.Length - 1; i++)
    {
        result[i] = array[i]*array[array.Length - 1];
    }
    return result;

}