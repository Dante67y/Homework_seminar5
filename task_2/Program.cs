// Задайте одномерный массив, заполненный случайными числами
// Найдите сумму элементов, стоящих на нечётных позициях

int n;
// Спрашиваем у пользователя сколько чисел будет в массиве
Console.Write("Напишите количество чисел: ");
n = Convert.ToInt32(Console.ReadLine());
// Создаём массив на указанное пользователем количество элементов
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
// Вводим переменную, чтобы обозначитьразделение пар (чтобы код не перемножал дважды среднюю пару
// при четном количестве элементов)
int sum = 0;
for (int i = 1; i < array.Length; i = i + 2)
{
    sum = sum + array[i];
}
Console.WriteLine(sum);
