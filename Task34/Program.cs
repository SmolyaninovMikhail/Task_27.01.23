﻿// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.Write("Наш массив: ");
ReleaseArray(array);
int count = 0;

for (int i = 0; i < array.Length; i++)
if (array[i] % 2 == 0)
    count++;

Console.WriteLine($"Всего {array.Length}, {count} из них четные");

void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(100, 1000);
}

void ReleaseArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
    Console.WriteLine();
}