using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalSIM.Clases.Modelos.Eventos
{
    class EventoFinEnsamble : EventoConNormal
    {
        public EventoFinEnsamble(double media, double desviacion) : base(media, desviacion)
        {
        }

        public override string ToString()
        {
            return "Fin_ensamble";
        }
    }
}
