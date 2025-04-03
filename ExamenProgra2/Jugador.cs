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
            int posicion = int.Parse(Console.ReadLine());
            return posicion;
        }

    }
}
