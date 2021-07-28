using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalSIM.Clases.Modelos.Eventos
{
    class EventoFinSimulacion : Evento
    {
        public EventoFinSimulacion(double horaFinSim)
        {
            this.proximoEvento = horaFinSim;
        }

        public override double generarTiempoEntreEventos()
        {
            throw new NotImplementedException();
        }
    }
}
