// Показать натуральные числа от N до 1, N задано

string NumbersRec(int n)
{
    if (n < 1) return string.Empty;
    else return $"{n} " + NumbersRec(n - 1);   
}

Console.WriteLine(NumbersRec(15));
