Console.WriteLine("---------------------------------");
Console.WriteLine("Programa que permita determinar \ncuantos hombres y mujeres hay en un curso \nde 25 estudiantes. ");
Console.WriteLine("---------------------------------\n");
int m=0,f=0;
string valIng;
for (int x = 1; x <=25; x++)
{
    Console.WriteLine("ingrese por favor su sexo teniendo en \ncuenta las siguientes convenciones \nM=Masculino(hombre) y F=femenino(mujer)\n ingrese un valor para el estudiante #"+x);
    valIng = Console.ReadLine();
    Console.WriteLine("\n");
    if (valIng == "m" || valIng == "M")
    {
        m = m+1;
    }else
    {
        f = f+1;
    }
}
Console.WriteLine("en el curso hay :\n"+m+" hombres\n"+f+" mujeres\n");
Console.WriteLine("\n");