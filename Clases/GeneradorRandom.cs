using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalSIM.Clases
{
    class GeneradorRandom
    {
        static Random generador = new Random();

        public static double generar()
        {
            return generador.NextDouble();
        }
    }
}
