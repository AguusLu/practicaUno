using practicaUno.Models;

class Program
{

    static void Main(string[] args)
    {
        Bebida bebida = new Bebida("coquita", 500);
        Bebida bebida2 = new Bebida("fanta", 500);
        //bebida.nombre = "coquita";
        //bebida.cantidad = 500;

        bebida.tomarse(100);
        bebida2.tomarse(100);
        Console.WriteLine("Le quedan "+ bebida.cantidad + " a la bebida: " + bebida.nombre);
        Console.WriteLine(bebida2.cantidad);
    }
}