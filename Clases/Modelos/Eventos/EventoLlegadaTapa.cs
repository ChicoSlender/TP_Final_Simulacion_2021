using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalSIM.Clases.Modelos.Eventos
{
    class EventoLlegadaTapa : Evento
    {
        private double media;

        public EventoLlegadaTapa(double media)
        {
            this.media = media;
        }

        public override double generarTiempoEntreEventos()
        {
            double variable = this.generador.generarVariableExponencialConMedia(this.media, out double random);
            this.random = random;
            return variable;
        }

        public override string ToString()
        {
            return "Llegada_tapa";  
        }
    }
}
