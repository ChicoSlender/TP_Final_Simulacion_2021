using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinalSIM.Clases.Modelos.Clientes;

namespace TPFinalSIM.Clases.Modelos.Servidores
{
    class MaquinaPintura : Servidor
    {
        private Queue<Tapa> cola;
        private Tapa tapaAtendida;

        public MaquinaPintura(): base()
        {
            this.cola = new Queue<Tapa>();
        }

        public Queue<Tapa> Cola { get => cola; set => cola = value; }
        public int LargoCola { get => cola.Count; }
        public Tapa TapaAtendida { get => tapaAtendida; set => tapaAtendida = value; }

        public void MeterTapaCola(Tapa tapa)
        {
            this.cola.Enqueue(tapa);
        }
        public Tapa SacarTapaCola() => this.cola.Dequeue();
        public bool ColaEstaVacia() => this.LargoCola == 0;
        public void PintarSiguienteTapa()
        {
            if (this.ColaEstaVacia())
            {
                this.Desocupar();
                this.TapaAtendida = null;
            }
            else
            {
                this.Ocupar();
                this.tapaAtendida = this.SacarTapaCola();
                this.tapaAtendida.Pintar();
            }
        }
    }
}
