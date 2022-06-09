Console.WriteLine("Ведите число а ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число b ");
int b = Convert.ToInt32(Console.ReadLine());

int max;
int min;

if(a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);
