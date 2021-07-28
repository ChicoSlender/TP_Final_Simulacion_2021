using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinalSIM.Clases.Modelos.Clientes;

namespace TPFinalSIM.Clases.Modelos.Estados
{
    class SiendoPintada : EstadoTapa
    {
        public SiendoPintada()
        {
            this.Nombre = "Siendo pintada";
        }
        public override void VolverAPintado(Tapa obj)
        {
            obj.Estado = new EsperandoPintado();
        }
        public override void MandarAEnsamble(Tapa obj)
        {
            obj.Estado = new EsperandoEnsambleTapa();
        }
        public override bool EsSiendoPintada() => true;
    }
}
