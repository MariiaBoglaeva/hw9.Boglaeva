// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int sum = SumNumber(firstNumber, secondNumber);
if (firstNumber == secondNumber) Console.WriteLine("Задан некорректный числовой промежуток");
Console.WriteLine($"Сумма натуральных числе в промежутке от {firstNumber} до {secondNumber} = {sum}");

int SumNumber(int numM, int numN)
{
    int step = 1;
    if (numN < numM) step = -1;
    if (numM != numN) return numM + SumNumber(numM + step, numN);
    return numN;
}
