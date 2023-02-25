Console.WriteLine("\n-------------------------------------------------------");
Console.WriteLine("Programa para determinar la mitad de un \nnúmero ingresado por el usuario es mayor o \nmenor de 100. ");
Console.WriteLine("-------------------------------------------------------\n");
Console.WriteLine("ingrese por favor un numero:");
int numIng = int.Parse(Console.ReadLine());
int calculo = numIng / 2;
if ( calculo >= 100)
{
    Console.WriteLine("el valor ingresado es: " + numIng + "\nla mitad es " + calculo + " Por Tanto es MAYOR a 100\n" );
}
else
{
    Console.WriteLine("el valor ingresado es: " + numIng + "\nla mitad es " + calculo + " Por Tanto es MENOR a 100\n" );
}