using practicaUno.Models;

class Program
{
    static void Main(string[] args)
    {
        /* int[] numeros = new int[5] {1, 2, 3, 4, 9};
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
         mostrarRecomendacion(cerveza);*/

        CervezaBD cervezaBD = new CervezaBD();

        //universo sólo existe acá
        /*{ 
              Cerveza cerveza = new Cerveza(15, "Ipa");
              cerveza.marca = "Antares";
              cerveza.alcohol = 6;
              cervezaBD.agregarCerveza(cerveza);
        }

        
          {
              Cerveza cerveza = new Cerveza(12, "roja");
              cerveza.marca = "Corona";
              cerveza.alcohol = 8;

              cervezaBD.Edit(cerveza, 3);
          }
        */
           {
               cervezaBD.Delete(1002);
           }

      

        var cervezas = cervezaBD.getCervezas();

        foreach(var c in cervezas)
        {
            Console.WriteLine(c.nombre +" " + "hola");
        }
        
    }

    static void mostrarRecomendacion(IBebidaAlcoholica bebidaAlcoholica)
    {
        bebidaAlcoholica.maxRecomendado();
    }


}