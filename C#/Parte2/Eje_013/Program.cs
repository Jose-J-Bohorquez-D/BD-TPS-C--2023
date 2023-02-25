Console.WriteLine("\n-------------------------------------------------------");
Console.WriteLine("Programa para determinar cuál es mayor entre 2 números \ncualquiera ingresados por el usuario ");
Console.WriteLine("-------------------------------------------------------\n");
Console.WriteLine("ingrese por favor el primer numero para validar:");
int numIng1 = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese por favor el segundo numero para validar:");
int numIng2 = int.Parse(Console.ReadLine());
if (numIng1 > numIng2)
{
    Console.WriteLine("el numero => " + numIng1 + " es mayor que => " + numIng2);
}
else
{
    Console.WriteLine("el numero => " + numIng2 + " es mayor que => " + numIng1 + "\n");
}