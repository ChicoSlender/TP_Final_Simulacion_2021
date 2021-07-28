using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinalSIM.Clases.Modelos.Clientes;

namespace TPFinalSIM.Clases.Modelos.Estados
{
    class EsperandoPintado : EstadoTapa
    {
        public EsperandoPintado()
        {
            this.Nombre = "Esperando pintado";
        }
        public override void Pintar(Tapa obj)
        {
            obj.Estado = new SiendoPintada();
        }
        public override bool EsEsperandoPintado() => true;
    }
}
