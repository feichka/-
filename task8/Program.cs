﻿int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= n)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
        i = i + 2;
    }
    else
    {
        i = i + 1;
    }
}