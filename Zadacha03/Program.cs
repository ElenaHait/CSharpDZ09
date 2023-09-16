// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


System.Console.WriteLine(SolutionAkkermanFunction(3, 3));

int SolutionAkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0)
    {
        return SolutionAkkermanFunction(m-1, 1); 
    }
    return SolutionAkkermanFunction(m-1, SolutionAkkermanFunction(m, n-1));
}
