using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinalSIM.Clases.Modelos.Eventos;
using TPFinalSIM.Clases.Modelos.Clientes;
using TPFinalSIM.Clases.Modelos.Servidores;

namespace TPFinalSIM.Clases
{
    class GestorSimulacion
    {
        private List<Evento> eventos;
        private double relojMin;
        private int contPiezasFabricadas;
        private double acumTiempoFabricacion;
        private double ultimoFinEnsamble;
        private double randomResultadoPintado;
        private bool? pintadoResultoDefectuoso;
        private List<double> randomsResultadoPiezas;
        private List<Pieza> piezasFabricadas;
        private Tapa nuevaTapa;
        private Caja nuevaCaja;

        private MaquinaPintura maqPintura;
        private MaquinaDesempaque maqDesempaque;
        private MaquinaEnsamble maqEnsamble;

        public List<object[]> Simular(double[][] paramsEventos, double tiempo = Int32.MaxValue, int iteraciones = Int32.MaxValue, double horaVerDesde = -1, int iteracionesVerHasta = 0)
        {
            // Inicializacion de variables

            this.relojMin = 0;
            this.ultimoFinEnsamble = 0;
            this.contPiezasFabricadas = 0;
            this.acumTiempoFabricacion = 0;
            this.randomResultadoPintado = -1;
            this.pintadoResultoDefectuoso = null;
            this.randomsResultadoPiezas = new List<double>() { -1, -1, -1 };
            this.piezasFabricadas = new List<Pieza>();

            this.maqPintura = new MaquinaPintura();
            this.maqDesempaque = new MaquinaDesempaque();
            this.maqEnsamble = new MaquinaEnsamble();

            this.nuevaCaja = null;
            this.nuevaTapa = null;

            Tapa.ResetearCuentaNumeros();
            Pieza.ResetearCuentaNumeros();
            Caja.ResetearCuentaNumeros();

            this.eventos = new List<Evento>();
            this.eventos.Add(new EventoLlegadaTapa(paramsEventos[0][0]));
            this.eventos.Add(new EventoLlegadaCaja(paramsEventos[1][0]));
            this.eventos.Add(new EventoFinPintado(paramsEventos[2][0], paramsEventos[2][1]));
            this.eventos.Add(new EventoFinDesempaque(paramsEventos[3][0], paramsEventos[3][1]));
            this.eventos.Add(new EventoFinEnsamble(paramsEventos[4][0], paramsEventos[4][1]));
            this.eventos.Add(new EventoFinSimulacion(tiempo));

            // Generacion de las proximas llegadas

            this.eventos[0].generarProximoEvento();
            this.eventos[1].generarProximoEvento();

            // Armado del primer vector estado (si la hora ver desde es 0)

            List<object[]> estadosPersistentes = new List<object[]>();

            if (horaVerDesde == 0 && iteracionesVerHasta > 0)
            {
                iteraciones--;
                iteracionesVerHasta--;

                estadosPersistentes.Add(this.armarVectorEstado("Inicializacion"));
            }

            // Simulacion
            bool finalizarSimulacion = false;

            for (int i = 0; i < iteraciones; i++)
            {
                int indexProxEvento = this.decidirProximoEvento();
                this.relojMin = (double)this.eventos[indexProxEvento].ProximoEvento;

                //Elimina los datos que no deben arrastrarse de los eventos
                foreach (Evento evento in this.eventos)
                {
                    evento.borrarDatosTemporales();
                }
                this.nuevaTapa = null;
                this.nuevaCaja = null;
                this.randomResultadoPintado = -1;
                this.randomsResultadoPiezas = new List<double>() { -1, -1, -1 };
                this.pintadoResultoDefectuoso = null;
                this.piezasFabricadas.Clear();

                string subIndexEvento = "";

                // Logica segun evento actual
                switch (indexProxEvento)
                {
                    case 0:
                        // Evento llegada tapa
                        this.eventos[indexProxEvento].generarProximoEvento();
                        this.nuevaTapa = new Tapa();
                        subIndexEvento = this.nuevaTapa.Numero.ToString();
                        this.maqPintura.MeterTapaCola(this.nuevaTapa);

                        if (this.maqPintura.EstaLibre())
                        {
                            this.maqPintura.PintarSiguienteTapa();
                            this.eventos[2].generarProximoEvento(this.relojMin);
                        }
                        break;
                    case 1:
                        // Evento llegada caja
                        this.eventos[indexProxEvento].generarProximoEvento();
                        this.nuevaCaja = new Caja();
                        subIndexEvento = this.nuevaCaja.Numero.ToString();
                        this.maqDesempaque.MeterCajaCola(this.nuevaCaja);

                        if (this.maqDesempaque.EstaLibre())
                        {
                            this.maqDesempaque.DesempacarSiguienteCaja();
                            this.eventos[3].generarProximoEvento(this.relojMin);
                        }
                        break;
                    case 2:
                        // Evento fin de pintado
                        Tapa tapaPintada = this.maqPintura.TapaAtendida;
                        subIndexEvento = tapaPintada.Numero.ToString();
                        this.pintadoResultoDefectuoso = tapaPintada.PintadoFueDefectuoso(out this.randomResultadoPintado);
                        if ((bool)this.pintadoResultoDefectuoso)
                        {
                            this.maqPintura.MeterTapaCola(tapaPintada);
                        }
                        else
                        {
                            this.maqEnsamble.MeterTapaCola(tapaPintada);

                            if (this.maqEnsamble.EstaLibre())
                                this.IntentarMaqEnsamble();
                        }

                        this.maqPintura.PintarSiguienteTapa();
                        if (this.maqPintura.EstaOcupado())
                        {
                            this.eventos[indexProxEvento].generarProximoEvento();
                        }
                        else
                        {
                            this.eventos[indexProxEvento].borrarProximoEvento();
                        }
                        break;
                    case 3:
                        // Evento fin de desempaque
                        Caja cajaDesempaquetada = this.maqDesempaque.CajaAtendida;
                        subIndexEvento = cajaDesempaquetada.Numero.ToString();
                        this.piezasFabricadas = cajaDesempaquetada.GenerarPiezas(out this.randomsResultadoPiezas);

                        this.piezasFabricadas.ForEach(pieza =>
                        {
                            if (pieza != null)
                                this.maqEnsamble.MeterPiezaCola(pieza);
                        });

                        if (this.maqEnsamble.EstaLibre())
                            this.IntentarMaqEnsamble();

                        this.maqDesempaque.DesempacarSiguienteCaja();
                        if (this.maqDesempaque.EstaOcupado())
                        {
                            this.eventos[indexProxEvento].generarProximoEvento();
                        }
                        else
                        {
                            this.eventos[indexProxEvento].borrarProximoEvento();
                        }
                        break;
                    case 4:
                        // Evento fin de ensamble
                        this.acumTiempoFabricacion += this.relojMin - this.ultimoFinEnsamble;
                        this.contPiezasFabricadas++;
                        subIndexEvento = this.contPiezasFabricadas.ToString();
                        this.ultimoFinEnsamble = this.relojMin;
                        this.IntentarMaqEnsamble();
                        break;
                    case 5:
                        // Evento fin de simulación
                        finalizarSimulacion = true;
                        break;
                    default:
                        break;
                }

                // Chequea si la simulacion debe finalizar
                if (finalizarSimulacion)
                    break;

                //Lógica de persistencia de vectores estado seleccionados
                if (this.relojMin >= horaVerDesde && iteracionesVerHasta > 0)
                {
                    iteracionesVerHasta--;
                    estadosPersistentes.Add(this.armarVectorEstado(this.eventos[indexProxEvento].ToString() + "_" + subIndexEvento));
                }
            }

            estadosPersistentes.Add(this.armarVectorEstado("Fin de simulación"));

            return estadosPersistentes;
        }

        private void IntentarMaqEnsamble()
        {
            this.maqEnsamble.EnsamblarSiguientePieza();
            if (maqEnsamble.EstaOcupado())
            {
                this.eventos[4].generarProximoEvento(this.relojMin);
            }
            else
            {
                this.eventos[4].borrarProximoEvento();
            }
        }

        private int decidirProximoEvento()
        {
            int indexSigEvento = -1;
            double diferenciaTiempoMin = double.MaxValue, diferenciaTiempo;
            for (int i = 0; i < this.eventos.Count; i++)
            {
                if (this.eventos[i].ProximoEvento != null)
                {
                    diferenciaTiempo = (double)this.eventos[i].ProximoEvento - this.relojMin;
                    if (diferenciaTiempo >= 0 && diferenciaTiempo < diferenciaTiempoMin)
                    {
                        diferenciaTiempoMin = diferenciaTiempo;
                        indexSigEvento = i;
                    }
                }

            }

            return indexSigEvento;
        }

        private object[] armarVectorEstado(string etiquetaEvento)
        {
            object[] estado = new object[43];

            estado[0] = etiquetaEvento;
            estado[1] = this.truncar(this.relojMin,4).ToString();
            estado[2] = this.truncar(this.eventos[0].Random,4).ToString() ?? "";
            estado[3] = this.truncar(this.eventos[0].TiempoEntreEventos,4).ToString() ?? "";
            estado[4] = this.truncar(this.eventos[0].ProximoEvento,4).ToString() ?? "";

            estado[5] = "";
            estado[6] = "";
            if(this.nuevaTapa != null)
            {
                estado[5] = this.truncar(this.nuevaTapa.Random, 4).ToString();
                estado[6] = this.nuevaTapa.Tipo.ToString();
            }

            estado[7] = this.truncar(this.eventos[2].Random, 4).ToString() ?? "";
            estado[8] = this.truncar((this.eventos[2] as EventoConNormal).Random2, 4).ToString() ?? "";
            estado[9] = this.truncar(this.eventos[2].TiempoEntreEventos,4).ToString() ?? "";
            estado[10] = this.truncar(this.eventos[2].ProximoEvento,4).ToString() ?? "";
            estado[11] = this.randomResultadoPintado >= 0 ? this.truncar(this.randomResultadoPintado,4).ToString() : "";

            if (this.pintadoResultoDefectuoso == null)
                estado[12] = "";
            else if ((bool)this.pintadoResultoDefectuoso)
                estado[12] = "Defectuoso";
            else
                estado[12] = "Exitoso";

            estado[13] = this.truncar(this.eventos[1].Random, 4).ToString() ?? "";
            estado[14] = this.truncar(this.eventos[1].TiempoEntreEventos,4).ToString() ?? "";
            estado[15] = this.truncar(this.eventos[1].ProximoEvento,4).ToString() ?? "";

            estado[16] = this.truncar(this.eventos[3].Random, 4).ToString() ?? "";
            estado[17] = this.truncar(this.eventos[3].TiempoEntreEventos,4).ToString() ?? "";
            estado[18] = this.truncar(this.eventos[3].ProximoEvento,4).ToString() ?? "";

            if(this.piezasFabricadas.Count > 0)
            {
                for (int i = 19; i <= 23; i += 2)
                {
                    estado[i] = "";
                    estado[i + 1] = "";

                    int j = (i - 19) / 2;
                    if (this.randomsResultadoPiezas[j] >= 0)
                    {
                        estado[i] = this.truncar(this.randomsResultadoPiezas[j], 4).ToString();
                        estado[i + 1] = this.piezasFabricadas[j] == null ? "Defectuosa" : "Correcta";
                    }
                }
            }

            estado[25] = this.truncar(this.eventos[4].Random, 4).ToString() ?? "";
            estado[26] = this.truncar((this.eventos[4] as EventoConNormal).Random2, 4).ToString() ?? "";
            estado[27] = this.truncar(this.eventos[4].TiempoEntreEventos,4).ToString() ?? "";
            estado[28] = this.truncar(this.eventos[4].ProximoEvento,4).ToString() ?? "";

            estado[29] = this.maqPintura.getNombreEstado();
            estado[30] = this.maqPintura.LargoCola.ToString();

            estado[31] = this.maqDesempaque.getNombreEstado();
            estado[32] = this.maqDesempaque.LargoCola.ToString();

            estado[33] = this.maqEnsamble.getNombreEstado();
            estado[34] = this.maqEnsamble.LargoColaTapasInf.ToString();
            estado[35] = this.maqEnsamble.LargoColaTapasSup.ToString();
            estado[36] = this.maqEnsamble.LargoColaPiezas.ToString();

            estado[37] = this.truncar(this.ultimoFinEnsamble,4).ToString();
            estado[38] = this.truncar(this.acumTiempoFabricacion,4).ToString();
            estado[39] = this.truncar(this.contPiezasFabricadas,4).ToString();

            List<string[]> datosTapas = new List<string[]>();

            foreach(Tapa tapa in this.maqPintura.Cola)
            {
                datosTapas.Add(new string[] { 
                    tapa.Numero.ToString(),
                    tapa.getNombreEstado(),
                    tapa.Tipo.ToString()
                });
            }

            Tapa tapaAtendida = this.maqPintura.TapaAtendida;
            if (tapaAtendida != null)
                datosTapas.Add(new string[] {
                    tapaAtendida.Numero.ToString(),
                    tapaAtendida.getNombreEstado(),
                    tapaAtendida.Tipo.ToString()
                });

            foreach (Tapa tapa in this.maqEnsamble.ColaTapasInf)
                datosTapas.Add(new string[] {
                    tapa.Numero.ToString(),
                    tapa.getNombreEstado(),
                    tapa.Tipo.ToString()
                });

            tapaAtendida = this.maqEnsamble.TapaInfAtendida;
            if(tapaAtendida != null)
                datosTapas.Add(new string[] {
                    tapaAtendida.Numero.ToString(),
                    tapaAtendida.getNombreEstado(),
                    tapaAtendida.Tipo.ToString()
                });

            foreach (Tapa tapa in this.maqEnsamble.ColaTapasSup)
                datosTapas.Add(new string[] {
                    tapa.Numero.ToString(),
                    tapa.getNombreEstado(),
                    tapa.Tipo.ToString()
                });

            tapaAtendida = this.maqEnsamble.TapaSupAtendida;
            if (tapaAtendida != null)
                datosTapas.Add(new string[] {
                    tapaAtendida.Numero.ToString(),
                    tapaAtendida.getNombreEstado(),
                    tapaAtendida.Tipo.ToString()
                });

            estado[40] = datosTapas;

            List<string[]> datosCajas = new List<string[]>();
            
            foreach(Caja caja in this.maqDesempaque.Cola)
            {
                datosCajas.Add(new string[] {
                    caja.Numero.ToString(),
                    caja.getNombreEstado()
                });
            }

            if (this.maqDesempaque.CajaAtendida != null)
                datosCajas.Add(new string[] {
                    this.maqDesempaque.CajaAtendida.Numero.ToString(),
                    this.maqDesempaque.CajaAtendida.getNombreEstado()
                });

            estado[41] = datosCajas;

            List<string[]> datosPiezas = new List<string[]>();

            foreach (Pieza pieza in this.maqEnsamble.ColaPiezas)
                datosPiezas.Add(new string[] {
                    pieza.Numero.ToString(),
                    pieza.getNombreEstado()
                });

            if(this.maqEnsamble.PiezaAtendida != null)
                datosPiezas.Add(new string[] {
                    this.maqEnsamble.PiezaAtendida.Numero.ToString(),
                    this.maqEnsamble.PiezaAtendida.getNombreEstado()
                });

            estado[42] = datosPiezas;

            return estado;
        }

        private double? truncar(double? num, int decimales)
        {
            if (num == null)
                return null;
            return Math.Floor((double)num * Math.Pow(10, decimales)) / Math.Pow(10, decimales);
        }
    }
}
