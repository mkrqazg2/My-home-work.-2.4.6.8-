﻿// Найти максимальное из трёх чисел (Find the maximum of three numbers)
int A = 3;
int B = 7;
int C = 15;
int max = A;
{
if (A >= max) max = A;
if (B >= max) max = B;
if (C >= max) max = C;
}
Console.Write (" max = ");
Console.WriteLine( max );
