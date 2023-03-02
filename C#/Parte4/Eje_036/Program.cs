Console.WriteLine("--------------------------------------------------------------------------------");
Console.WriteLine("Programa que imprima la tabla de multiplicar hasta 10 \nde un número cualquiera ingresado por el usuario.");
Console.WriteLine("--------------------------------------------------------------------------------\n");
Console.WriteLine("ingrese la tabla de multiplicar que desea ver\n");
int tabla = int.Parse(Console.ReadLine());
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(" "+tabla+" * "+ i +" = "+ (tabla*i));
    Console.ReadKey();
}
Console.WriteLine("\n");