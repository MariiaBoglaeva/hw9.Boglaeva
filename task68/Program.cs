//  Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberN >= 0 && numberM >= 0)
{
    int result = AkkermanFunction(numberM, numberN);
    Console.WriteLine($"A({numberM},{numberN}) ={result}");
}
else Console.WriteLine("Заданы некорректные числа");

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    else return 0;
}