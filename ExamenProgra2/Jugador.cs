using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgra2
{
    class Jugador
    {
        public static  int incluirElemento()
        {
            Console.Write("Es tu turno: ");
            Console.WriteLine("Escoge un numero del (1-9): ")
            int posicion = int.Parse(Console.ReadLine());
            return posicion;
        }

    }
}
