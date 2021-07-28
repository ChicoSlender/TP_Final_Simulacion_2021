using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinalSIM.Clases.Modelos.Estados;

namespace TPFinalSIM.Clases.Modelos.Clientes
{
    class Pieza
    {
        private EstadoPieza estado;
        private int numero;
        static int ultimoNumero;

        public Pieza()
        {
            this.numero = ++ultimoNumero;
            this.estado = new EsperandoEnsamblePieza();
        }

        public static void ResetearCuentaNumeros()
        {
            ultimoNumero = 0;
        }
        public EstadoPieza Estado { get => estado; set => estado = value; }
        public int Numero { get => numero; set => numero = value; }
        public void Ensamblar() => this.estado.Ensamblar(this);
        public bool EstaEsperandoEnsamble() => this.estado.EsEsperandoEnsamble();
        public bool EstaSiendoEnsamblada() => this.estado.EsSiendoEnsamblada();
        public string getNombreEstado() => this.estado.Nombre;
    }
}
