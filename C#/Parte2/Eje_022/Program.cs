Console.WriteLine("\n-------------------------------------------------------");
Console.WriteLine("Programa que permita calcular el valor final a pagar en una súper tienda \nen donde se aplican los siguientes descuentos: \na) Por compras entre 10000 y 20000 el 10% \nb) Por compras entre 20001 y 50000 el 30% \nc) Por compras superiores a 50000 el 50%");
Console.WriteLine("-------------------------------------------------------\n");
Console.WriteLine("ingrese por favor el valor a pagar:");
int Total = int.Parse(Console.ReadLine());
int descuento10 = (Total*10)/100;
int descuento30 = (Total*30)/100;
int descuento50 = (Total*50)/100;
if (Total >= 10000){
    if (Total <= 20000){
        Console.WriteLine("subtotal: " + Total + "\naplica descuento 15%: " + descuento10 + "\ntotal a pagar: " + (Total-descuento10) +"\n");
    }else{
        if (Total >= 20001){
            if (Total <= 50000){
                Console.WriteLine("subtotal: " + Total + "\naplica descuento 30%: " + descuento30 + "\ntotal a pagar: " + (Total-descuento30) +"\n");
            }else{
                Console.WriteLine("subtotal: " + Total + "\naplica descuento 50%: " + descuento50 + "\ntotal a pagar: " + (Total-descuento50) +"\n");
            }
        }
    }
}