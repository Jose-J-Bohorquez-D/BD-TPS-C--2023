Console.WriteLine("--------------------------------------------------------------------");
Console.WriteLine("Programa que encuentre el resultado de la operación potencia donde \nel usuario ingresa el valor de la base y el exponente");
Console.WriteLine("--------------------------------------------------------------------\n");
    Console.WriteLine("Introduzca un nucmero de base: \n");
    int resultado=1, i=1,bas = int.Parse(Console.ReadLine());
    Console.WriteLine("Introduzca un nucmero de exponente: \n");
    int exponente = int.Parse(Console.ReadLine());
    while(i<=exponente){
        resultado = resultado * bas;
        i++;
    }

    Console.WriteLine("El resultado de multiplicar " + bas + " por " +exponente+ " mismo " + exponente+ " veces es igual a:" + resultado);