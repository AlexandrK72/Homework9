// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в
// промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumDidgit(int numM, int numN)
{
    if (numM == numN) return numN;
    return numM + SumDidgit(numM + 1, numN);

}
int numberM = 0;
int numberN = 0;
Console.WriteLine("Введите натуральное число M: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());
if (numberFirst < 1 && numberSecond < 1)
{
    Console.WriteLine("Ошибка ввода. Введите натуральные числа!");
    return;
}
if (numberFirst < numberSecond)
{
    numberM = numberFirst;
    numberN = numberSecond;
}
else
{
    numberN = numberFirst;
    numberM = numberSecond;
}
int result = SumDidgit(numberM, numberN);
Console.Write($"M = {numberM}, N = {numberN} -> {result}");