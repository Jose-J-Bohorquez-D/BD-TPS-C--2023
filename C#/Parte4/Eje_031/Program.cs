Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("Programa que permita determinar cuantos estudiantes \nson mayores de edad en un grupo de 20 estudiantes.");
Console.WriteLine("--------------------------------------------------------");
int M=0,m=0;
for (int i = 1; i <= 20; i++)
{
    Console.WriteLine("ingrese la edad del estuadinate "+i);
    int edad = int.Parse(Console.ReadLine());
    if (edad >= 18)
    {
        M = M+1;
    }
    else
    {
        m = m+1;
    }
    
}
Console.WriteLine("en estos momentos hay \n"+M+" estudiantes mayores de edad y \n"+m+" estudiantes menores de edad \n");