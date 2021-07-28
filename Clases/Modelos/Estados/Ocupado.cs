using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinalSIM.Clases.Modelos.Servidores;

namespace TPFinalSIM.Clases.Modelos.Estados
{
    class Ocupado : EstadoServidor
    {
        public Ocupado()
        {
            this.Nombre = "Ocupado";
        }
        public override void Desocupar(Servidor obj)
        {
            obj.Estado = new Libre();
        }
        public override bool EsOcupado() => true;
    }
}
