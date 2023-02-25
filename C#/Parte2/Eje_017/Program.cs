Console.WriteLine("\n-------------------------------------------------------");
Console.WriteLine("Programa en el cual reciba como \nentradas la siguiente información: Código del \nEstudiante, Nombre del Estudiante, \nNombrede la Materia y Tres Notas de 1.0 a 5.0. \nCon esta información el programa debe calcular \nla nota definitiva (promedio) y determinar si \nel estudiante aprueba o no la materia \n(Definitiva mayor a 4.0). Debe imprimir coma \nsalidas el nombre, el código, la materia y \nsi aprobó o no.");
Console.WriteLine("-------------------------------------------------------\n");
Console.WriteLine("ingrese por favor codigo del estudiante:");
int codEst = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese por favor el nombre del estudiante:");
string nomEst = Console.ReadLine();
Console.WriteLine("ingrese por favor el nombre de la Materia:");
string nomMat = Console.ReadLine();
Console.WriteLine("ingrese por favor la nota 1:");
float n1 = float.Parse(Console.ReadLine());
Console.WriteLine("ingrese por favor la nota 2:");
float n2 = float.Parse(Console.ReadLine());
Console.WriteLine("ingrese por favor la nota 3:");
float n3 = float.Parse(Console.ReadLine());
float prom = (n1+n2+n3)/3;
if (prom >= 40 /*|| prom >= 4.0 || prom >= 4,0*/)
{
    Console.WriteLine("el promedio del estudiante: " + nomEst + "\ncon el codigo: " + codEst + "\nen la materia: " + nomMat + "\nes de : " + prom + "con el cual APRUEBA\n");
}
else
{
    Console.WriteLine("el promedio del estudiante: " + nomEst + "\ncon el codigo: " + codEst + "\nen la materia: " + nomMat + "\nes de : " + prom + " con el cual NO APRUEBA\n");
}