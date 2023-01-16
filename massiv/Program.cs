/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.Clear();
Console.Write("Введите max число = ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min число = ");
int min = Convert.ToInt32(Console.ReadLine());
int[] array = GetRandomArray(8, min, max);
Console.WriteLine($"[{String.Join(", ", array)} ]");

int[] GetRandomArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

