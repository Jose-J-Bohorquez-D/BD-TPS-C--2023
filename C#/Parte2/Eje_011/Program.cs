Console.WriteLine("\n-------------------------------------------------------");
Console.WriteLine("Programa que determine si una persona es mayor de edad \no no teniendo en cuenta el año actual y su año de nacimiento");
Console.WriteLine("-------------------------------------------------------\n");
Console.WriteLine("ingrese su edad");
int edad= int.Parse(Console.ReadLine());
if (edad >= 18)
{
    Console.WriteLine("eres mayor de edad");
}
else
{
    Console.WriteLine("eres menor de edad");
}