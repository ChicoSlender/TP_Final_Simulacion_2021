using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinalSIM.Clases.Modelos.Estados;

namespace TPFinalSIM.Clases.Modelos.Clientes
{
    class Caja
    {
        private EstadoCaja estado;
        private int numero;
        static int ultimoNumero = 0;
        static double probPiezaDefectuosa = 0.1;
        static int cantPiezas = 3;

        public Caja()
        {
            this.numero = ++ultimoNumero;
            this.estado = new EsperandoDesempaque();
        }

        public static void ResetearCuentaNumeros()
        {
            ultimoNumero = 0;
        }

        public EstadoCaja Estado { get => estado; set => estado = value; }
        public int Numero { get => numero; set => numero = value; }

        public void Desempaquetar() => this.estado.Desempaquetar(this);
        public List<Pieza> GenerarPiezas(out List<double> randoms)
        {
            randoms = new List<double>();
            List<Pieza> piezas = new List<Pieza>();
            for (int i = 0; i < cantPiezas; i++)
            {
                randoms.Add(GeneradorRandom.generar());
                if (randoms[i] < probPiezaDefectuosa)
                    piezas.Add(null);
                else
                    piezas.Add(new Pieza());
            }
            return piezas;
        }
        public bool EstaEsperandoDesempaque() => this.estado.EsEsperandoDesempaque();
        public bool EstaSiendoDesempaquetada() => this.estado.EsSiendoDesempaquetado();
        public string getNombreEstado() => this.estado.Nombre;
    }
}
