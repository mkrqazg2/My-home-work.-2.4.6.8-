//  Показать чётные числа от 1 до N (Show even numbers from 1 to N)
Console.WriteLine ("введите макимальное число:");
int min = 2;
int max ;
max = int.Parse(Console.ReadLine());
while ( min <= max)
{
    Console.Write (min + ",");
    min = min + 2;
}