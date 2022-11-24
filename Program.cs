using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTACIONAMIENTO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pago, tiempo_en_horas;
            Console.Write("Ingresa el valor de tiempo en horas: ");
            tiempo_en_horas = int.Parse(Console.ReadLine());
            pago = 0;
            if (tiempo_en_horas == 1)
                pago = 15;
            if (tiempo_en_horas > 1)
                pago = 15 + 10 * (tiempo_en_horas - 1);
            Console.WriteLine("Valor de pago: " + pago);
            Console.WriteLine();
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
        }
    }
}
        