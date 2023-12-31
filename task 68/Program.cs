﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermanFunkc(int numM, int numN)
{
    if (numM == 0) return numN+1;
    else if (numN == 0) 
    {
        return AckermanFunkc(numM - 1, 1);
    }
    else
    {
        return AckermanFunkc(numM - 1, AckermanFunkc(numM, numN -1));
    }

}
Console.WriteLine("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int result = AckermanFunkc(numberM, numberN);
Console.Write($"M = {numberM}, N = {numberN} -> {result}");