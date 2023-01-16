/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
int SumNum(int num)
{
    int result = 0;
    for (int i = 0; num > 0; i++)
    {
        result = result + num % 10; ;
        num = num / 10;
    }
    Console.WriteLine($"Сумма цифр в числе = {result}");
    return result;
}

Console.Clear();
Console.Write("Введите число = ");
int num = Convert.ToInt32(Console.ReadLine());
SumNum(num);
