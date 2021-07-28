using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalSIM.Clases.Modelos.Estados
{
    class SiendoEnsambladaTapa : EstadoTapa
    {
        public SiendoEnsambladaTapa()
        {
            this.Nombre = "Siendo ensamblada";
        }
        public override bool EsSiendoEnsamblada() => true;
    }
}
