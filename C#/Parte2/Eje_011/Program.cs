Console.WriteLine("\n-------------------------------------------------------");
Console.WriteLine("Programa que determine si una persona es mayor de edad \no no teniendo en cuenta el año actual y su año de nacimiento");
Console.WriteLine("-------------------------------------------------------\n");
Console.WriteLine("ingrese año de nacimiento");
int añoN= int.Parse(Console.ReadLine());
Console.WriteLine("ingrese año actual");
int añoA= int.Parse(Console.ReadLine());
if ((añoN-añoA)>=18)
{
    Console.WriteLine("eres mayor de edad");
}
else
{
    Console.WriteLine("eres menor de edad");
}