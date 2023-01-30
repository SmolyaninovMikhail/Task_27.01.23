// Задайте массив дробных чисел. Найдите разницу между максимальным и минимальным элементом массива

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.Write("Наш массив: ");
ReleaseArray(array);
double max = 0; 
double min = 100;

for (int i = 0; i < array.Length; i++)
{
if (array[i] > max)
{
    max = array[i];
}
if (array[i] < min)
{
    min = array[i];
}
}
Console.WriteLine($"Всего чисел {array.Length}, Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значениями = {max - min}");

void InputArray(double[] array)
{
for (int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
}
}

void ReleaseArray(double[] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
    Console.WriteLine();
}