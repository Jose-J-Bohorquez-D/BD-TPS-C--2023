Console.WriteLine("-----------------------------------------------------------------");
Console.WriteLine("Programa que permita determinar el salario a pagar a un empleado \nteniendo como entradas el salario diario y el número de días trabajados. \nTenga en cuenta que al empleado se le debe descontar el 10% \npor concepto de pensión y 15% por concepto de salud");
Console.WriteLine("-----------------------------------------------------------------");
int salarioDia, diasTrabajados, rta, descuentoPension, descuentoSalud, total;
Console.WriteLine("ingrese el valor del salario diario");
salarioDia = int.Parse(Console.ReadLine());
Console.WriteLine("ingresa el numero de dias laborados");
diasTrabajados = int.Parse(Console.ReadLine());
total = salarioDia * diasTrabajados;
descuentoPension = total * 10 / 100;
descuentoSalud = total * 15 / 100;
rta = ((total - descuentoPension) - descuentoSalud); 
Console.WriteLine("el total devengado teniendo en cuenta que el salario base esta sobre \n=> " +salarioDia+ "\nlos dias laborados fueron \n=> "+diasTrabajados+"\ndecontanto pension del 10% asi \n=>"+descuentoPension+"\ndescontanto salud asi \n=> "+descuentoSalud+"\nsu salario neto a recibir sera de \n=> " + rta);

