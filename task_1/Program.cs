// Задайте массив заполненный случайными положительными трёхзначными числами
// Напишите программу, которая покажет количество чётных чисел в массиве


int n;
// Спрашиваем у пользователя сколько чисел будет в массиве
Console.Write("Напишите количество чисел: ");
n = Convert.ToInt32(Console.ReadLine());
// Создаём массив на указанное пользователем количество элементов
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
// Вводим переменную, чтобы обозначитьразделение пар (чтобы код не перемножал дважды среднюю пару
// при четном количестве элементов)
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) count++;
}
Console.WriteLine(count);
