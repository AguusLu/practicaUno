using practicaUno.Models;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = new int[5] {1, 2, 3, 4, 9};
        int numero1 = numeros[0];

        Console.WriteLine(numero1);
        Console.WriteLine(numeros.Length);

        for(int i = 0; i < numeros.Length; i++) {
            Console.WriteLine("Iteracion: " + i + " - " + numeros[i]);
        }

        Console.WriteLine("----------------------------");

        foreach(var numero in numeros)
        {
            Console.WriteLine(numero);
        }


        Bebida bebida = new Bebida();
        Bebida bebida2 = new Bebida("fanta", 500);
        //bebida.nombre = "coquita";
        //bebida.cantidad = 500;

        Vino vinoUno = new Vino(50 ,"tinto");
        bebida.SetNombre("Coquita");
        bebida.setCantidad(1000);
        bebida.tomarse(100);
        bebida2.tomarse(100);
        Console.WriteLine("Le quedan "+ bebida.cantidad + " a la bebida: " + bebida.nombre);
        Console.WriteLine(bebida2.cantidad);

       
        mostrarRecomendacion(vinoUno);
        Cerveza cerveza = new Cerveza();
        mostrarRecomendacion(cerveza);
        
    }

    static void mostrarRecomendacion(IBebidaAlcoholica bebidaAlcoholica)
    {
        bebidaAlcoholica.maxRecomendado();
    }
}