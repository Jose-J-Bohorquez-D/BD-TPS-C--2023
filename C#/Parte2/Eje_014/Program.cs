Console.WriteLine("\n-------------------------------------------------------");
Console.WriteLine("Programa para saber si un estudiante del \nEnrique Olaya Herrera requiere refrigerio. \nPor disposición de la Secretaria de Educación \nrequieren refrigerio los estudiantes de grado \nsexto hacia abajo.");
Console.WriteLine("-------------------------------------------------------\n");
Console.WriteLine("ingrese por favor Su Curso o Grado:");
int numIng = int.Parse(Console.ReadLine());
if (numIng >= 6)
{
    Console.WriteLine("ingresaste => " + numIng + " tienes derecho a Refrigerio \n");
}
else
{
    Console.WriteLine("ingresaste => " + numIng + " (NO) tienes derecho a Refrigerio \n");
}