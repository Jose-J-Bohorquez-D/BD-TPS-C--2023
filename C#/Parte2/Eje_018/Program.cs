Console.WriteLine("\n-------------------------------------------------------");
Console.WriteLine("Programa para determinar cuánto pagara \nuna persona por una compra de la cual se \nsabe la cantidad de artículos y el valor \nunitario. Se debe tener en cuenta que el \nalmacén hace un 20% de descuento cuando \nla compra supera $100000");
Console.WriteLine("-------------------------------------------------------\n");
Console.WriteLine("ingrese por favor la cantidad de articulos:");
int cantArt = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese por favor el valor unitario de el articulo:");
int valUnitArt = int.Parse(Console.ReadLine());
int total = cantArt*valUnitArt;
int descuento = (total*20)/100;
if (total >= 100000)
{
    Console.WriteLine("subtotal: " + total + "\naplica descuento 20%: " + descuento + "\ntotal a pagar: " + (total-descuento) +"\n");
}
else
{
    Console.WriteLine("subtotal: " + total + "\nNO aplica descuento: 0 \ntotal a pagar: " + total +"\n");
}
