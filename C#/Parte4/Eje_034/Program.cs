Console.WriteLine("--------------------------------------------------------------------------------");
Console.WriteLine("Programa que permita calcular la estatura promedio de un grupo de 18 \nestudiantes y luego tomar las siguientes decisiones: \na) Si la estatura promedio es menor a 140 cm imprimir un mensaje que diga “Estudiantes muy bajos”. \nb) Si la estatura promedio se encuentra entre 140 y 170 cm imprimir “Estudiantes de estatura normal”. \nc) Si la estatura promedio es mayor de 170 cm imprimir “Estudiantes muy altos”.");
Console.WriteLine("--------------------------------------------------------------------------------\n");
Console.WriteLine("ingrese el numero de personas para promediar recuerda que la convencion es en cm\n");
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
if (rta < 140)
{
    Console.WriteLine("Estudiantes muy bajos");
}else
{
    if (rta >= 140)
    {
        if (rta < 170)
        {
           Console.WriteLine("Estudiantes de estatura normal"); 
        }else
        {
            Console.WriteLine("Estudiantes muy altos");
        }
    }
}
/*Console.WriteLine("el total es = "+total+"\nel promedio de estatura de los estudiantes\nes de "+rta);
Console.WriteLine("\n");*/