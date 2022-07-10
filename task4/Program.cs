int a;
a = Convert.ToInt32(Console.ReadLine());
int b;
b = Convert.ToInt32(Console.ReadLine());
int c;
c = Convert.ToInt32(Console.ReadLine());
int i = 0;
if (a > b)
{
    i = a;
}
else
{
    i = b;
}
if (c > i)
{
    Console.WriteLine(c);
}
else
{
    Console.WriteLine(i);
}