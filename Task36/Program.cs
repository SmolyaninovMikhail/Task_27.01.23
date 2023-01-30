// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.Write("Наш массив: ");
ReleaseArray(array);
int sum = 0;

for (int i = 0; i < array.Length; i+=2)
{
        sum += array[i];
}    
Console.WriteLine($"Всего чисел {array.Length}, сумма элементов на нечетных позициях = {sum}");

void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1, 10);
}

void ReleaseArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
    Console.WriteLine();
}