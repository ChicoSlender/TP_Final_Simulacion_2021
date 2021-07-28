using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinalSIM.Clases.Modelos.Clientes;

namespace TPFinalSIM.Clases.Modelos.Estados
{
    class EsperandoEnsambleTapa : EstadoTapa
    {
        public EsperandoEnsambleTapa()
        {
            this.Nombre = "Esperando ensamble";
        }
        public override void Ensamblar(Tapa obj)
        {
            obj.Estado = new SiendoEnsambladaTapa();
        }
        public override bool EsEsperandoEnsamble() => true;
    }
}
