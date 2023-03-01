Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("Programa que imprima los números impares entre 201 y 499");
Console.WriteLine("--------------------------------------------------------");
for (int i = 201; i <= 499; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}