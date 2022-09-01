// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int numberM = Convert.ToInt32(Console.ReadLine());
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int start, int end)
{
    if (start == end) return end;
    return start + SumNumbers(start + 1, end);
   
}

Console.WriteLine($"M = {numberM}, N = {numberN} -> {SumNumbers(numberM, numberN)}");