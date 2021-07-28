using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinalSIM.Clases.Modelos.Estados;

namespace TPFinalSIM.Clases.Modelos.Clientes
{
    enum TipoTapa
    {
        Superior, Inferior
    }
    class Tapa
    {
        private EstadoTapa estado;
        private TipoTapa tipo;
        private double random;
        private int numero;
        static double probTapaInf = 0.5;
        static double probPintadoDefectuoso = 0.05;
        static int ultimoNumero = 0;

        public static void ResetearCuentaNumeros()
        {
            ultimoNumero = 0;
        }

        public Tapa()
        {
            this.numero = ++ultimoNumero;
            this.estado = new EsperandoPintado();
            this.random = GeneradorRandom.generar();
            if (this.random < probTapaInf)
                this.tipo = TipoTapa.Inferior;
            else
                this.tipo = TipoTapa.Superior;
        }

        public EstadoTapa Estado { get => estado; set => estado = value; }
        public TipoTapa Tipo { get => tipo; set => tipo = value; }
        public double Random { get => random; set => random = value; }
        public int Numero { get => numero; set => numero = value; }

        public bool PintadoFueDefectuoso(out double randomResultado)
        {
            randomResultado = GeneradorRandom.generar();
            if (randomResultado < probPintadoDefectuoso)
                return true;
            return false;
        }
        public void Pintar() => this.estado.Pintar(this);
        public void VolverAPintado() => this.estado.VolverAPintado(this);
        public void MandarAEnsamble() => this.estado.MandarAEnsamble(this);
        public void Ensamblar() => this.estado.Ensamblar(this);
        public bool EstaEsperandoPintado() => this.estado.EsEsperandoPintado();
        public bool EstaSiendoPintada() => this.estado.EsSiendoPintada();
        public bool EstaEsperandoEnsamble() => this.estado.EsEsperandoEnsamble();
        public bool EstaSiendoEnsamblada() => this.estado.EsSiendoEnsamblada();
        public bool EsTapaInferior() => this.tipo == TipoTapa.Inferior;

        public string getNombreEstado() => this.estado.Nombre;
    }
}
