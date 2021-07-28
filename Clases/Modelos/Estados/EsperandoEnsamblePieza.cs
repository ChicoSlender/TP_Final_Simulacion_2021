using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinalSIM.Clases.Modelos.Clientes;

namespace TPFinalSIM.Clases.Modelos.Estados
{
    class EsperandoEnsamblePieza : EstadoPieza
    {
        public EsperandoEnsamblePieza()
        {
            this.Nombre = "Esperando ensamble";
        }
        public override void Ensamblar(Pieza obj)
        {
            obj.Estado = new SiendoEnsambladaPieza();
        }
        public override bool EsEsperandoEnsamble() => true;
    }
}
