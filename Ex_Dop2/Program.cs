﻿// Решаем задачу циклом и рекурсией

// Вычислить a в степени n

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)
{
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
    // В C# это можно заменить одной строкой
    // return n == 0 ? 1 : PowerRec(a, n - 1) * a;
}

// А теперь решим тоже самое, но с применением математичесих знаний

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}


Console.WriteLine(PowerFor(2, 10));
Console.WriteLine(PowerRec(2, 10));
Console.WriteLine(PowerRecMath(2, 10));