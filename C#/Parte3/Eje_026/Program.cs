Console.WriteLine("---------------------------------------------------------------------------------------");
Console.WriteLine("Programa que permita ingresar un número cualquiera \ny luego mostrar el siguiente menú: \n1. Determinar si es positivo o negativo \n2. Determinar si es par o impar \nEl programa debe realizar las operaciones que el usuario seleccione del menú");
Console.WriteLine("---------------------------------------------------------------------------------------\n");
Console.WriteLine("ingrese por favor ingrese el numero de la opcion:");
int opc = int.Parse(Console.ReadLine());
switch (opc)
{
    case 1:
        Console.WriteLine("esta opcion le permite Determinar si es positivo o negativo");
        Console.WriteLine("------------------------------------------------------------\n");
        Console.WriteLine("ingrese por favor un numero para validar:");
        int numIng = int.Parse(Console.ReadLine());
        if (numIng >= 0)
        {
            Console.WriteLine("el numero ingresado=> " + numIng + " es PSITIVO \n");
        }
        else
        {
            Console.WriteLine("el numero ingresado => " + numIng + " es NEGATIVO \n");
        }
    break;
    
    case 2:
        Console.WriteLine("esta opcion le permite Determinar si el valor ingresado es par o impa");
        Console.WriteLine("---------------------------------------------------------------------\n");
        Console.WriteLine("ingrese por favor ingrese un numero:");
        int numIng2 = int.Parse(Console.ReadLine());
        if (numIng2 % 2 == 0)
        {
            Console.WriteLine("el numero: " + numIng2 + "\nes un numero PAR\n");
        }
        else
        {
            Console.WriteLine("el numero: " + numIng2 + "\nes un numero IMPAR\n");
        }
    break;

    default:
        Console.WriteLine("el valor ingresado no corresponde a ninguna de las opciones disponibles\n");
    break;
}