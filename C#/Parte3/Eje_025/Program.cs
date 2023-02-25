//Programa que permita realizar los siguientes requerimientos:\n1. Calcular distancia recorrida \n2. Calcular tiempo \n3. Calcular velocidad
Console.WriteLine("----------------------------------------------------------");
Console.WriteLine("Este Programa permite realizar las siguientes opciones:\n1. Calcular distancia recorrida \n2. Calcular tiempo \n3. Calcular velocidad");
Console.WriteLine("----------------------------------------------------------\n");
int distancia=0,velocidad=0,tiempo=0,rta=0,operacion=0;
Console.WriteLine("el numero de la opercacion que desea realizar");
operacion = int.Parse(Console.ReadLine());
switch (operacion)
{
    case 1:
        Console.WriteLine("Calcular distancia recorrida");
        
    break;

    case 2:
        Console.WriteLine("Calcular tiempo");
    break;

    case 3:
        Console.WriteLine("Calcular velocidad");
    break;
    
    default:
        Console.WriteLine("el valor ingresado no corresponde a ninguna de las opciones disponibles");
    break;
}