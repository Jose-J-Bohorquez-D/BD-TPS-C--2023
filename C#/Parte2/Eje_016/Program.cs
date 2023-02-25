Console.WriteLine("\n-------------------------------------------------------");
Console.WriteLine("Programa en el cual se ingresen 2 números \ny luego realice las siguientes operaciones: \na) Si los números son iguales restarlos \nb) Si los números son diferentes sumarlos");
Console.WriteLine("-------------------------------------------------------\n");
Console.WriteLine("ingrese por favor el primer valor:");
int numIng1 = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese por favor el segundo valor:");
int numIng2 = int.Parse(Console.ReadLine());
if (numIng1 == numIng2)
{
    Console.WriteLine("los numeros son iguales asi que el resultado de la resta es: " + (numIng1-numIng2)+"\n");
}
else
{
    Console.WriteLine("los numeros son diferentes asi que el resultado de la SUMA es: " + (numIng1+numIng2)+"\n");
}