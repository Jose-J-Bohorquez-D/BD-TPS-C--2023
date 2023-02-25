Console.WriteLine("\n-------------------------------------------------------");
Console.WriteLine("Programa que permita determinar el \ntotal a pagar por una compra del la cual se \nsabe el valor unitario y la cantidad. Se debe \ntener en cuanta que se realiza un descuento \ndel 15% por compra inferiores a $20000 y del \n35% por compras mayores o iguales a \n$20000");
Console.WriteLine("-------------------------------------------------------\n");
Console.WriteLine("ingrese por favor la cantidad de articulos:");
int cantArt = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese por favor el valor unitario de el articulo:");
int valUnitArt = int.Parse(Console.ReadLine());
int total = cantArt*valUnitArt;
int descuento15 = (total*15)/100;
int descuento35 = (total*35)/100;
if (total < 20000)
{
    Console.WriteLine("subtotal: " + total + "\naplica descuento 15%: " + descuento15 + "\ntotal a pagar: " + (total-descuento15) +"\n");
}
else
{
    Console.WriteLine("subtotal: " + total + "\naplica descuento 35%: " + descuento35 + "\ntotal a pagar: " + (total-descuento35) +"\n");
}