Console.WriteLine("\n-------------------------------------------------------");
Console.WriteLine("Programa para determinar si un deportista es aceptado en el quipo de \nbaloncesto de Bogotá. Las condiciones para ser aceptado son: \na) La edad debe ser menor o igual a 18 años \nb) La estatura debe ser mayor a 180 cm \nc) El peso debe ser menor o igual a 80 kg \nSi el aspirante cumple las 3 condiciones aceptarlo si no rechazarlo");
Console.WriteLine("-------------------------------------------------------\n");
Console.WriteLine("ingrese por favor su edad:");
int? edad = int.Parse(Console.ReadLine());
if (edad <= 18)
{
    Console.WriteLine("ingrese por favor su estatura en cm:");
    int? est = int.Parse(Console.ReadLine());
    if (est >= 180)
    {
        Console.WriteLine("ingrese por favor su peso:");
        int? pes = int.Parse(Console.ReadLine());
        if (pes <= 80)
        {
            Console.WriteLine("aspirante aceptado cumples con los 3 requisitos");
        }
        else
        {
            Console.WriteLine("aspirante RECHAZADO NO cumples con el peso requerido");
        }
    }
    else
    {
        Console.WriteLine("aspirante RECHAZADO NO cumples con la estatura requerida");
    }
}
else
{
    Console.WriteLine("aspirante RECHAZADO NO cumples la edad requerida");
}