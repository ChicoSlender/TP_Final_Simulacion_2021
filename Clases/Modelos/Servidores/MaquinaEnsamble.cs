using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinalSIM.Clases.Modelos.Clientes;

namespace TPFinalSIM.Clases.Modelos.Servidores
{
    class MaquinaEnsamble : Servidor
    {
        private Queue<Tapa> colaTapasInf;
        private Queue<Tapa> colaTapasSup;
        private Queue<Pieza> colaPiezas;
        private Tapa tapaInfAtendida;
        private Tapa tapaSupAtendida;
        private Pieza piezaAtendida;

        public MaquinaEnsamble(): base()
        {
            this.colaPiezas = new Queue<Pieza>();
            this.colaTapasInf = new Queue<Tapa>();
            this.colaTapasSup = new Queue<Tapa>();
        }

        public Queue<Tapa> ColaTapasInf { get => colaTapasInf; set => colaTapasInf = value; }
        public Queue<Tapa> ColaTapasSup { get => colaTapasSup; set => colaTapasSup = value; }
        public Queue<Pieza> ColaPiezas { get => colaPiezas; set => colaPiezas = value; }
        public int LargoColaTapasInf { get => colaTapasInf.Count; }
        public int LargoColaTapasSup { get => colaTapasSup.Count; }
        public int LargoColaPiezas { get => colaPiezas.Count; }
        public Tapa TapaInfAtendida { get => tapaInfAtendida; set => tapaInfAtendida = value; }
        public Tapa TapaSupAtendida { get => tapaSupAtendida; set => tapaSupAtendida = value; }
        public Pieza PiezaAtendida { get => piezaAtendida; set => piezaAtendida = value; }

        public void MeterTapaCola(Tapa tapa)
        {
            tapa.MandarAEnsamble();
            if (tapa.EsTapaInferior())
                this.colaTapasInf.Enqueue(tapa);
            else
                this.colaTapasSup.Enqueue(tapa);
        }
        public Tapa SacarTapaInfCola() => this.colaTapasInf.Dequeue();
        public Tapa SacarTapaSupCola() => this.colaTapasSup.Dequeue();
        public void MeterPiezaCola(Pieza pieza)
        {
            this.colaPiezas.Enqueue(pieza);
        }
        public Pieza SacarPiezaCola() => this.colaPiezas.Dequeue();
        public bool ColaTapasInfEstaVacia() => this.LargoColaTapasInf == 0;
        public bool ColaTapasSupEstaVacia() => this.LargoColaTapasSup == 0;
        public bool ColaPiezasEstaVacia() => this.LargoColaPiezas == 0;
        public bool AlgunaColaEstaVacia() => ColaTapasInfEstaVacia() || ColaTapasSupEstaVacia() || ColaPiezasEstaVacia();
        public void EnsamblarSiguientePieza()
        {
            if(this.AlgunaColaEstaVacia())
            {
                this.Desocupar();
                this.piezaAtendida = null;
                this.TapaInfAtendida = null;
                this.tapaSupAtendida = null;
            }
            else
            {
                this.Ocupar();
                this.piezaAtendida = this.SacarPiezaCola();
                this.TapaInfAtendida = this.SacarTapaInfCola();
                this.tapaSupAtendida = this.SacarTapaSupCola();

                this.piezaAtendida.Ensamblar();
                this.tapaInfAtendida.Ensamblar();
                this.tapaSupAtendida.Ensamblar();
            }
        }
    }
}
