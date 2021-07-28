using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalSIM.Clases.Modelos.Estados
{
    class SiendoEnsambladaPieza : EstadoPieza
    {
        public SiendoEnsambladaPieza()
        {
            this.Nombre = "Siendo ensamblada";
        }
        public override bool EsSiendoEnsamblada() => true;
    }
}
