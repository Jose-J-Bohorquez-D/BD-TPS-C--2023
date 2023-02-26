//Programa que permita realizar los siguientes requerimientos:\n1. Calcular distancia recorrida \n2. Calcular tiempo \n3. Calcular velocidad
Console.WriteLine("----------------------------------------------------------");
Console.WriteLine("Este Programa permite realizar las siguientes opciones:\n1. Calcular distancia recorrida \n2. Calcular tiempo \n3. Calcular velocidad");
Console.WriteLine("----------------------------------------------------------\n");
Console.WriteLine("el numero de la opercacion que desea realizar");
int operacion = int.Parse(Console.ReadLine());
switch (operacion)
{
    case 1:
        Console.WriteLine("----------------------------");
        Console.WriteLine("Calcular distancia recorrida");
        Console.WriteLine("--------------------------\n");
        Console.WriteLine("ingrese velocidad");
        int vel = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese tiempo");
        int tiempo = int.Parse(Console.ReadLine());
        Console.WriteLine("la distancia recorrida es: " + (vel*tiempo)+"\n");
        
    break;

    case 2:
        Console.WriteLine("--------------------------\n");
        Console.WriteLine("Calcular tiempo");
        Console.WriteLine("--------------------------\n");
        Console.WriteLine("ingrese velocidad");
        int vel2 = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese distancia");
        int dist2 = int.Parse(Console.ReadLine());
        Console.WriteLine("la distancia recorrida es: " + (dist2/vel2)+"\n");
    break;

    case 3:
        Console.WriteLine("Calcular velocidad");
        Console.WriteLine("--------------------------\n");
        Console.WriteLine("ingrese tiempo");
        int tiempo3 = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese distancia");
        int dist3 = int.Parse(Console.ReadLine());
        Console.WriteLine("la velocidad fue: " + (dist3/tiempo3)+"\n");
    break;
    
    default:
        Console.WriteLine("el valor ingresado no corresponde a ninguna de las opciones disponibles");
    break;
}