using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinalSIM.Clases.Modelos.Servidores;

namespace TPFinalSIM.Clases.Modelos.Estados
{
    class Libre : EstadoServidor
    {
        public Libre()
        {
            this.Nombre = "Libre";
        }
        public override void Ocupar(Servidor obj)
        {
            obj.Estado = new Ocupado();
        }
        public override bool EsLibre() => true;
    }
}
