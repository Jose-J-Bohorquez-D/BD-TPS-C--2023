Console.WriteLine("----------------------------------------------------------");
Console.WriteLine("Programa que permita determinar si una letra es o no vocal");
Console.WriteLine("----------------------------------------------------------\n");
string letra;
Console.WriteLine("ingrese una letra");
letra = Console.ReadLine();
switch (letra)
{
    case "a":
        Console.WriteLine("la letra => " + letra + "es vocal");
    break;

    case "e":
        Console.WriteLine("la letra => " + letra + "es vocal");
    break;

    case "i":
        Console.WriteLine("la letra => " + letra + "es vocal");
    break;

    case "o":
        Console.WriteLine("la letra => " + letra + "es vocal");
    break;

    case "u":
        Console.WriteLine("la letra => " + letra + "es vocal");
    break;

    default:
    Console.WriteLine("la letra ingresada no es una vocal");
    break;
    
}


