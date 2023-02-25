Console.WriteLine("\n-------------------------------------------------------");
Console.WriteLine("Programa para determinar si un número \ncualquiera ingresado por el usuario es par o \nimpar.(Usar operación Modulo)");
Console.WriteLine("-------------------------------------------------------\n");
Console.WriteLine("ingrese por favor ingrese un numero:");
int numIng = int.Parse(Console.ReadLine());
if (numIng % 2 == 0)
{
    Console.WriteLine("el numero: " + numIng + "\nes un numero PAR");
}
else
{
    Console.WriteLine("el numero: " + numIng + "\nes un numero IMPAR");
}