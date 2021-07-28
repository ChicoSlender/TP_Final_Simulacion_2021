using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinalSIM.Clases.Modelos.Servidores;
using TPFinalSIM.Clases.Modelos.Clientes;

namespace TPFinalSIM.Clases.Modelos.Estados
{
    abstract class Estado
    {
        private string nombre;

        public string Nombre { get => nombre; set => nombre = value; }

    }

    abstract class EstadoServidor : Estado
    {
        public virtual void Ocupar(Servidor obj)
        {

        }
        public virtual void Desocupar(Servidor obj)
        {

        }
        public virtual bool EsOcupado() => false;
        public virtual bool EsLibre() => false;
    }

    abstract class EstadoTapa : Estado
    {
        public virtual void Pintar(Tapa obj)
        {

        }
        public virtual void VolverAPintado(Tapa obj)
        {

        }
        public virtual void MandarAEnsamble(Tapa obj)
        {

        }
        public virtual void Ensamblar(Tapa obj)
        {

        }
        public virtual bool EsEsperandoPintado() => false;
        public virtual bool EsSiendoPintada() => false;
        public virtual bool EsEsperandoEnsamble() => false;
        public virtual bool EsSiendoEnsamblada() => false;
    }

    abstract class EstadoCaja : Estado
    {
        public virtual void Desempaquetar(Caja obj)
        {

        }
        public virtual bool EsEsperandoDesempaque() => false;
        public virtual bool EsSiendoDesempaquetado() => false;
    }

    abstract class EstadoPieza : Estado
    {
        public virtual void Ensamblar(Pieza obj)
        {

        }
        public virtual bool EsEsperandoEnsamble() => false;
        public virtual bool EsSiendoEnsamblada() => false;
    }
}
