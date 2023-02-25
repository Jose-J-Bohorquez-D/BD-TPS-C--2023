Console.WriteLine("\n-------------------------------------------------------");
Console.WriteLine("Programa el cual permita ingresar los valores de temperatura de cada día durante \nuna semana. Le programa debe calcular la temperatura promedio y luego mostrar los \nsiguientes mensajes: \na) Si el promedio es mayor a 35° mostrar el mensaje “Que semana tan calurosa” \nb) Si el promedio esta entre 15° y 35° mostrar el mensaje “Que clima tan delicioso” \nc) Si el promedio es menor de 15° mostrar el mensaje “Que semana tan fría”");
Console.WriteLine("-------------------------------------------------------\n");
Console.WriteLine("ingrese por favor la temperatura del dia lunes:");
float lunes = float.Parse(Console.ReadLine());
Console.WriteLine("ingrese por favor la temperatura del dia martes:");
float martes = float.Parse(Console.ReadLine());
Console.WriteLine("ingrese por favor la temperatura del dia miercoles:");
float miercoles = float.Parse(Console.ReadLine());
Console.WriteLine("ingrese por favor la temperatura del dia jueves:");
float jueves = float.Parse(Console.ReadLine());
Console.WriteLine("ingrese por favor la temperatura del dia viernes:");
float viernes = float.Parse(Console.ReadLine());
Console.WriteLine("ingrese por favor la temperatura del dia sabado:");
float sabado = float.Parse(Console.ReadLine());
Console.WriteLine("ingrese por favor la temperatura del dia domingo:");
float domingo = float.Parse(Console.ReadLine());
float prom = (lunes+martes+miercoles+jueves+viernes+sabado+domingo)/7;
//test float prom = 5;
if (prom < 15)
{
    Console.WriteLine("el promedio es: " + prom + "que semana tan fria\n");
} 
else
{
    if (prom > 15)
    {
        if (prom < 35)
        {
            Console.WriteLine("el promedio es: " + prom + "que clima tan delicioso\n");
        }
        else
        {
            Console.WriteLine("el promedio es: " + prom + "que semana tan calurosa\n");
        }     
    }
}