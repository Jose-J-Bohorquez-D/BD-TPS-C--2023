Console.WriteLine("---------------------------------------------------------------------------------------");
Console.WriteLine("Programa que muestre un menú que tenga las siguientes opciones: \n1. Pasa o no la materia? \n2. Es mayor o menor de edad? \nCaso 1: Solicitar 3 notas y determinar si el promedio es mayor a 3.0, en ese caso el estudiante pasa. \nCaso 2: Se debe solicitar el año de nacimiento y el año actual y determinar si es o no mayor de edad.");
Console.WriteLine("---------------------------------------------------------------------------------------\n");
Console.WriteLine("ingrese por favor ingrese el numero de la opcion:");
int opc = int.Parse(Console.ReadLine());
switch (opc)
{
    case 1:
        Console.WriteLine("esta opcion le permite ver si Pasa o no la materia?:");
        Console.WriteLine("-------------------------------------------------------\n");
        Console.WriteLine("ingrese por favor la nota 1:");
        float n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("ingrese por favor la nota 2:");
        float n2 = float.Parse(Console.ReadLine());
        Console.WriteLine("ingrese por favor la nota 3:");
        float n3 = float.Parse(Console.ReadLine());
        float prom = (n1+n2+n3)/3;
        if (prom >= 30 /*|| prom >= 4.0 || prom >= 4,0*/)
        {
            Console.WriteLine("el promedio es de : " + prom + " con el cual APRUEBA\n");
        }
        else
        {
            Console.WriteLine("el promedio es de : " + prom + " con el cual NO APRUEBA\n");
        }
    break;

    case 2:
        Console.WriteLine("esta opcion le permite ver si Es mayor o menor de edad?:");
        Console.WriteLine("-------------------------------------------------------\n");
        Console.WriteLine("ingrese año de nacimiento");
        int añoN= int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese año actual");
        int añoA= int.Parse(Console.ReadLine());
        int edad = añoA-añoN;
        if (edad>=18)
        {
            Console.WriteLine("eres mayor de edad");
        }
        else
        {
            Console.WriteLine("eres menor de edad");
        }
    break;

    default:
        Console.WriteLine("el valor ingresado no corresponde a ninguna de las opciones disponibles\n");
    break;
}