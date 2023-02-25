Console.WriteLine("\n-------------------------------------------------------");
Console.WriteLine("Programa para determinar si un número cualquiera \ningresado por el usuario es o no positivo");
Console.WriteLine("-------------------------------------------------------\n");
Console.WriteLine("ingrese por favor un numero para validar:");
int numIng = int.Parse(Console.ReadLine());
if (numIng >= 0)
{
    Console.WriteLine("el numero ingresado=> " + numIng + " es PSITIVO");
}
else
{
    Console.WriteLine("el numero ingresado => " + numIng + " es NEGATIVO \n");
}