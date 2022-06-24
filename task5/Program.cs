using System;
using static System.Console;
Clear();

WriteLine("Введите размер массива: ");
int size = int.Parse(ReadLine());
int[] array = FillArray(size, 0, 1000);
WriteLine($"[{String.Join(",",array)}] -> {FindNumberArray(array,10,99)}");

int[] FillArray(int size, int min, int max)
{
    int[]array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int FindNumberArray( int[] arr, int left, int right)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= left && arr[i] <= right)
        {
            count++;

        }
    }
    return count;

}