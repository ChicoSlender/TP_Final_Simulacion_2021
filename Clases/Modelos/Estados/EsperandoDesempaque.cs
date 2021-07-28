using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinalSIM.Clases.Modelos.Clientes;

namespace TPFinalSIM.Clases.Modelos.Estados
{
    class EsperandoDesempaque : EstadoCaja
    {
        public EsperandoDesempaque()
        {
            this.Nombre = "Esperando desempaque";
        }
        public override void Desempaquetar(Caja obj)
        {
            obj.Estado = new SiendoDesempaquetado();
        }
        public override bool EsEsperandoDesempaque() => true;
    }
}
