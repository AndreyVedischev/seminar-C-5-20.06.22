using System;
using static System.Console;
Clear();

WriteLine("Введите размер массива: ");
int size = int.Parse(ReadLine());
int[] array = FillArray(size, 5, 5);

int[] FillArray(int size, int min, int max)
{
    int[]array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}