using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalSIM.Clases.Modelos.Eventos
{
    class EventoFinDesempaque : Evento
    {
        private double limInf, limSup;

        public EventoFinDesempaque(double limInf, double limSup)
        {
            this.limInf = limInf;
            this.limSup = limSup;
        }

        public override double generarTiempoEntreEventos()
        {
            double variable = this.generador.generarVariableUniforme(this.limInf, this.limSup, out double random);
            this.random = random;
            return variable;
        }

        public override string ToString()
        {
            return "Fin_desempaque";
        }
    }
}
