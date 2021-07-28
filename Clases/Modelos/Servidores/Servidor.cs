using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinalSIM.Clases.Modelos.Estados;

namespace TPFinalSIM.Clases.Modelos.Servidores
{
    abstract class Servidor
    {
        private EstadoServidor estado;

        public Servidor()
        {
            this.estado = new Libre();
        }

        public EstadoServidor Estado { get => estado; set => estado = value; }

        public string getNombreEstado() => this.estado.Nombre;
        public void Ocupar() => this.estado.Ocupar(this);
        public void Desocupar() => this.estado.Desocupar(this);
        public bool EstaLibre() => this.estado.EsLibre();
        public bool EstaOcupado() => this.estado.EsOcupado();
    }
}
