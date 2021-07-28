using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinalSIM.Clases.Modelos.Clientes;

namespace TPFinalSIM.Clases.Modelos.Servidores
{
    class MaquinaDesempaque : Servidor
    {
        private Queue<Caja> cola;
        private Caja cajaAtendida;

        public MaquinaDesempaque(): base()
        {
            this.cola = new Queue<Caja>();
        }

        public Queue<Caja> Cola { get => cola; set => cola = value; }
        public int LargoCola { get => cola.Count; }
        public Caja CajaAtendida { get => cajaAtendida; set => cajaAtendida = value; }

        public void MeterCajaCola(Caja caja)
        {
            this.cola.Enqueue(caja);
        }
        public Caja SacarCajaCola() => this.cola.Dequeue();
        public bool ColaEstaVacia() => this.LargoCola == 0;
        public void DesempacarSiguienteCaja()
        {
            if (this.ColaEstaVacia())
            {
                this.Desocupar();
                this.cajaAtendida = null;
            }
            else
            {
                this.Ocupar();
                this.cajaAtendida = this.SacarCajaCola();
                this.cajaAtendida.Desempaquetar();
            }
        }
    }
}
