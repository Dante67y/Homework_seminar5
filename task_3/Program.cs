// Задайте массив вещественных чисел
// Найдите разницу между максимальным и минимальным элементов массива

// // Целлочисленные
// int n;
// // Спрашиваем у пользователя сколько чисел будет в массиве
// Console.Write("Напишите количество чисел: ");
// n = Convert.ToInt32(Console.ReadLine());
// // Создаём массив на указанное пользователем количество элементов
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 100);
// }
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// int max = 0, min = 50;
// for (int i = 0; i < array.Length; i++)
// {
//     if (max < array[i]) max = array[i];
//     if (min > array[i]) min = array[i];
// }
// Console.Write("Максимальное значение равно: ");
// Console.WriteLine(max);
// Console.Write("Минимальное значение равно: ");
// Console.WriteLine(min);
// int result = max - min;
// Console.Write("Разница максимума и минимума массива получается: ");
// Console.WriteLine(result);

// Вещественные
int n;
// Спрашиваем у пользователя сколько чисел будет в массиве
Console.Write("Напишите количество чисел: ");
n = Convert.ToInt32(Console.ReadLine());
// Создаём массив на указанное пользователем количество элементов
double[] array = new double[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble();
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
double max = 0, min = 50;
for (int i = 0; i < array.Length; i++)
{
    if (max < array[i]) max = array[i];
    if (min > array[i]) min = array[i];
}
Console.Write("Максимальное значение равно: ");
Console.WriteLine(max);
Console.Write("Минимальное значение равно: ");
Console.WriteLine(min);
double result = max - min;
Console.Write("Разница максимума и минимума массива получается: ");
Console.WriteLine(result);
