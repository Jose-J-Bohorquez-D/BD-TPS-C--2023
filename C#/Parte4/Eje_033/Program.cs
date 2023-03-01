Console.WriteLine("---------------------------------");
Console.WriteLine("Programa para calcular la edad promedio \nde un grupo de 15 estudiantes");
Console.WriteLine("---------------------------------\n");
int valIng=0,total=0,prom=15,rta=0;
for (int x = 1; x <=5; x++)
{
    Console.WriteLine("ingrese por favor su edad\n ingrese un valor para el estudiante #"+x);
    valIng = int.Parse(Console.ReadLine());
    total = total+valIng;
    rta=total/prom;
    Console.WriteLine("\n");
}
Console.WriteLine("el promedio de edad de los estudiantes\nes de "+rta);
Console.WriteLine("\n");