// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// Первые два элемента последовательности задаются пользователем

int a = ReadInt("Введите первое число: ");
int b = ReadInt("Введите второе число: ");
int n = ReadInt("Введите количество чисел: ");

int NumbersRec(int n)
{
    if (n == 0) return a;
    else if (n == 1) return b;
    else return NumbersRec(n - 1) + NumbersRec(n - 2);   
}

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"f({i}) = {NumbersRec(i)} ");
}
   


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}