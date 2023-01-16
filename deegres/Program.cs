/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

void Count(int A,int B)
{
    int result=1;
    for (int i = 1; i <= Math.Abs(B); i++)
    {
        result=result*A;
    }
   Console.WriteLine ($"Число {A} в степени {B} = {result}");
}

Console.Clear();
Console.Write("Введите число A = ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B = ");
int B = Convert.ToInt32(Console.ReadLine());
Count(A,B);