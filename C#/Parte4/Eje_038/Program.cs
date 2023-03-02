Console.WriteLine("--------------------------------------------------------------------------------");
Console.WriteLine("Programa que permita determinar si un estudiante que recibe 15 notas gana o no la\nmateria de Programación De Software. Segana la materia si el promedio es mayor o igual a 4.0.");
Console.WriteLine("--------------------------------------------------------------------------------\n");
Console.WriteLine("ingrese el numero de notas a promediar\n");
int vueltas = int.Parse(Console.ReadLine());
float valIng=0,total=0,rta=0 ;
for (int x = 1; x <=vueltas; x++)
{
    Console.WriteLine("ingrese por favor un valor para la nota #"+x);
    valIng = float.Parse(Console.ReadLine());
    total = total+valIng;
    Console.WriteLine("\n");
}
rta=total/vueltas;// las operaciones se deben hacer fuera del ciclo asi como en este caso puntual
if (rta >= 40 )
{
    Console.WriteLine("el promedio es de : " + rta + " pasas la materia ome nea ");
}else
{
    Console.WriteLine("el promedio es de : " + rta +  "paila papi te jodiste mka");
}
Console.WriteLine("\n");