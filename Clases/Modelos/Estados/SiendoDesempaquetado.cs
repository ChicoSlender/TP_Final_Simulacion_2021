using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalSIM.Clases.Modelos.Estados
{
    class SiendoDesempaquetado : EstadoCaja
    {
        public SiendoDesempaquetado()
        {
            this.Nombre = "Siendo desempaquetado";
        }
        public override bool EsSiendoDesempaquetado() => true;
    }
}
