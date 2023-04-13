using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variable
            int opcionFruta = 0;

            //Presentacion en pantalla
            Console.WriteLine("ES O NO UNA FRUTA?");
            Console.WriteLine("Selecione un opcion");
            Console.WriteLine("Cual es una fruta? ");
            Console.WriteLine("1.Mango\t 2.Zanahoria\t 3.Cebolla\t 4.Rabano");

            //Lectura de datos introducidos por teclado
            opcionFruta = int.Parse(Console.ReadLine());

            //Deteccion de errores
            if (opcionFruta != 1 && opcionFruta != 2 && opcionFruta != 3 && opcionFruta != 4)
            {
                Console.WriteLine("La opcion introducida no es valida");
            }
            //Switch case
            switch (opcionFruta) 
            {
                case 1:
                    Console.WriteLine("El Mango es una fruta");
                    break;
                case 2:
                    Console.WriteLine("La Zanahoria no es una fruta");
                    break;
                case 3:
                    Console.WriteLine("La Cebolla no es una fruta");
                    break;
                case 4:
                    Console.WriteLine("El Rabano no es una fruta");
                    break;
            }

            Console.ReadKey();

        }
    }
}
