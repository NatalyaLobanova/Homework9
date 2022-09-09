// Найти сумму элементов от M до N, N и M заданы

int SumRec(int m, int n)
{
    if (m == n) return n;
    else if (m > n) return m + SumRec(m - 1, n);
    else return  m + SumRec(m + 1, n);
}
Console.WriteLine(SumRec(1, 5));


