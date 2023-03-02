Console.WriteLine("---------------------------------");
Console.WriteLine("Programa para calcular la edad promedio \nde un grupo de 15 estudiantes");
Console.WriteLine("---------------------------------\n");
Console.WriteLine("ingrese el numero de personas para promediar");
int vueltas = int.Parse(Console.ReadLine());
int valIng=0,total=0,rta=0 ;
for (int x = 1; x <=vueltas; x++)
{
    Console.WriteLine("ingrese por favor su edad\n ingrese un valor para el estudiante #"+x);
    valIng = int.Parse(Console.ReadLine());
    total = total+valIng;
    Console.WriteLine("\n");
}
rta=total/vueltas;// las operaciones se deben hacer fuera del ciclo asi como en este caso puntual
Console.WriteLine("el total es ="+total+"\nel promedio de edad de los estudiantes\nes de "+rta);
Console.WriteLine("\n");