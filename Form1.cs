using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPFinalSIM.Clases;

namespace TPFinalSIM
{
    public partial class Form1 : Form
    {
        private GestorSimulacion gestor;
        private List<string> tapasOrd;
        private List<string> cajasOrd;
        private List<string> piezasOrd;
        public Form1()
        {
            InitializeComponent();
            this.gestor = new GestorSimulacion();
            this.tapasOrd = new List<string>();
            this.cajasOrd = new List<string>();
            this.piezasOrd = new List<string>();
        }

        private void chkPersistencia_CheckedChanged(object sender, EventArgs e)
        {
            bool v = this.chkPersistencia.Checked;
            this.txtHoraDesde.Enabled = v;
            this.txtIteracionesHasta.Enabled = v;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double mediaTapas = 5.0;
            this.txtMediaTapas.Text = mediaTapas.ToString();
            double mediaPintado = 9;
            double desvPintado = 3;
            this.txtMediaPintado.Text = mediaPintado.ToString();
            this.txtDesvPintado.Text = desvPintado.ToString();
            double mediaEnsamble = 15;
            double desvEnsamble = 10;
            this.txtMediaEnsamble.Text = mediaEnsamble.ToString();
            this.txtDesvEnsamble.Text = desvEnsamble.ToString();
            double mediaCajas = 64;
            this.txtMediaCajas.Text = mediaCajas.ToString();
            double infDesempaque = 30;
            double supDesempaque = 50;
            this.txtInfDesempaque.Text = infDesempaque.ToString();
            this.txtSupDesempaque.Text = supDesempaque.ToString();
        }

        private void txtMediaTapas_TextChanged(object sender, EventArgs e)
        {
            if (Double.TryParse(this.txtMediaTapas.Text, out double tapasPorMin))
            {
                tapasPorMin = Math.Floor(tapasPorMin / 60.0 * 10000) / 10000;
                string strTapasPorMin = tapasPorMin.ToString();
                this.lblTapasPorMinuto.Text = "( " + strTapasPorMin + " tapas por minuto )";
            }
        }

        private void btnSimulacion_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
                return;

            

            double mediaTapas = Convert.ToDouble(this.txtMediaTapas.Text);
            double mediaCajas = Convert.ToDouble(this.txtMediaCajas.Text);
            double mediaPintado = Convert.ToDouble(this.txtMediaPintado.Text);
            double desvPintado = Convert.ToDouble(this.txtDesvPintado.Text);
            double infDesempaque = Convert.ToDouble(this.txtInfDesempaque.Text);
            double supDesempaque = Convert.ToDouble(this.txtSupDesempaque.Text);
            double mediaEnsamble = Convert.ToDouble(this.txtMediaEnsamble.Text);
            double desvEnsamble = Convert.ToDouble(this.txtDesvEnsamble.Text);

            double[][] parametros = new double[][]
            {
                new double[] {60/mediaTapas},
                new double[] {mediaCajas},
                new double[] {mediaPintado, desvPintado},
                new double[] {infDesempaque, supDesempaque},
                new double[] {mediaEnsamble, desvEnsamble},
            };

            double horaDesde = -1;
            int iteracionesHasta = 0;
            if (this.chkPersistencia.Checked)
            {
                horaDesde = Convert.ToDouble(this.txtHoraDesde.Text);
                iteracionesHasta = Convert.ToInt32(this.txtIteracionesHasta.Text);
            }

            List<object[]> resultado;
            if (this.radIteraciones.Checked)
            {
                int iteraciones = Convert.ToInt32(this.txtIteraciones.Text);
                resultado = this.gestor.Simular(parametros, iteraciones: iteraciones, horaVerDesde: horaDesde, iteracionesVerHasta: iteracionesHasta);
            }
            else
            {
                double tiempoSim = Convert.ToDouble(this.txtTiempoSim.Text);
                resultado = this.gestor.Simular(parametros, tiempo: tiempoSim, horaVerDesde: horaDesde, iteracionesVerHasta: iteracionesHasta);
            }

            this.establecerOrdenObjTemp(resultado);

            for(int i = 0; i < resultado.Count; i++)
            {
                resultado[i] = this.formatearVector(resultado[i]);
            }

            this.llenarGrilla(resultado);

            double cantFabricada = Convert.ToDouble(resultado[resultado.Count - 1][39]);
            double acumTiempoFab = Convert.ToDouble(resultado[resultado.Count - 1][38]);
            double promTiempoFab = 0;
            if (cantFabricada != 0)
                promTiempoFab = Math.Floor((acumTiempoFab / cantFabricada) * 10000) / 10000;

            this.lblCantPiezas.Text = "Cantidad de piezas fabricadas: " + cantFabricada.ToString();
            this.lblTiempoProm.Text = "Tiempo promedio de fabricación: " + promTiempoFab.ToString();

            this.dtgSim.Rows[this.dtgSim.Rows.Count - 1].DefaultCellStyle.BackColor = System.Drawing.Color.CornflowerBlue;

            MessageBox.Show("Simulación finalizada con éxito");
        }

        private object[] formatearVector(object[] vector)
        {
            object[] vectorEstatico = new object[40];
            Array.Copy(vector, vectorEstatico, 40);

            //Parte tapas
            List<string[]> listaTapas = (vector[40] as List<string[]>).ToList();
            List<string> datosTapas = new List<string>();
            foreach(string num in this.tapasOrd)
            {
                bool encontrado = false;
                for (int i = 0; i < listaTapas.Count; i++)
                {
                    if(num == listaTapas[i][0])
                    {
                        encontrado = true;
                        datosTapas.Add(listaTapas[i][1]);
                        datosTapas.Add(listaTapas[i][2]);
                        listaTapas.RemoveAt(i);
                        break;
                    }
                }
                if(!encontrado)
                {
                    datosTapas.Add("");
                    datosTapas.Add("");
                }
            }

            //Parte cajas
            List<string[]> listaCajas = (vector[41] as List<string[]>).ToList();
            List<string> datosCajas = new List<string>();

            foreach (string num in this.cajasOrd)
            {
                bool encontrado = false;
                for (int i = 0; i < listaCajas.Count; i++)
                {
                    if (num == listaCajas[i][0])
                    {
                        encontrado = true;
                        datosCajas.Add(listaCajas[i][1]);
                        listaCajas.RemoveAt(i);
                        break;
                    }
                }
                if (!encontrado)
                {
                    datosCajas.Add("");
                }
            }

            //Parte piezas
            List<string[]> listaPiezas = (vector[42] as List<string[]>).ToList();
            List<string> datosPiezas = new List<string>();

            foreach (string num in this.piezasOrd)
            {
                bool encontrado = false;
                for (int i = 0; i < listaPiezas.Count; i++)
                {
                    if (num == listaPiezas[i][0])
                    {
                        encontrado = true;
                        datosPiezas.Add(listaPiezas[i][1]);
                        listaPiezas.RemoveAt(i);
                        break;
                    }
                }
                if (!encontrado)
                {
                    datosPiezas.Add("");
                }
            }

            // Unir vectores

            object[] vectorFormat = new object[40 + datosTapas.Count + datosCajas.Count + datosPiezas.Count];
            Array.Copy(vectorEstatico, 0, vectorFormat, 0, 40);
            Array.Copy(datosTapas.ToArray(), 0, vectorFormat, 40, datosTapas.Count);
            Array.Copy(datosCajas.ToArray(), 0, vectorFormat, 40 + datosTapas.Count, datosCajas.Count);
            Array.Copy(datosPiezas.ToArray(), 0, vectorFormat, 40 + datosTapas.Count + datosCajas.Count, datosPiezas.Count);

            return vectorFormat;
        }

        private void establecerOrdenObjTemp(List<object[]> vectores)
        {
            // Limpiar orden de sim anterior
            this.tapasOrd.Clear();
            this.cajasOrd.Clear();
            this.piezasOrd.Clear();

            // Establecer nuevo orden
            foreach (object[] fila in vectores)
            {
                foreach(string[] tapa in (fila[40] as List<string[]>))
                {
                    bool encontrado = false;
                    foreach(string num in this.tapasOrd)
                    {
                        if(num == tapa[0])
                        {
                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                        this.tapasOrd.Add(tapa[0]);
                }

                foreach(string[] caja in (fila[41] as List<string[]>))
                {
                    bool encontrado = false;
                    foreach (string num in this.cajasOrd)
                    {
                        if (num == caja[0])
                        {
                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                        this.cajasOrd.Add(caja[0]);
                }

                foreach (string[] pieza in (fila[42] as List<string[]>))
                {
                    bool encontrado = false;
                    foreach (string num in this.piezasOrd)
                    {
                        if (num == pieza[0])
                        {
                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                        this.piezasOrd.Add(pieza[0]);
                }
            }
        }

        private void llenarGrilla(List<object[]> vectores)
        {
            // Resetear grilla
            this.dtgSim.Rows.Clear();
            for (int i = this.dtgSim.Columns.Count - 1; i >= 40; i--)
                this.dtgSim.Columns.RemoveAt(i);

            //Crear columnas para obj temporales
            foreach(string num in this.tapasOrd)
            {
                this.dtgSim.Columns.Add("estado_tapa_" + num, "Estado Tapa " + num);
                this.dtgSim.Columns.Add("tipo_tapa_" + num, "Tipo Tapa " + num);
            }

            foreach (string num in this.cajasOrd)
                this.dtgSim.Columns.Add("estado_caja_" + num, "Estado Caja " + num);

            foreach (string num in this.piezasOrd)
                this.dtgSim.Columns.Add("estado_pieza_" + num, "Estado Pieza " + num);

            //Llenar grilla
            foreach(object[] fila in vectores)
            {
                this.dtgSim.Rows.Add(fila);
            }
        }

        private bool validarCampos()
        {
            if(!Double.TryParse(this.txtMediaTapas.Text, out double mediaTapas))
            {
                MessageBox.Show("El valor de la media poisson de la llegada de tapas debe ser numérico", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(mediaTapas <= 0)
            {
                MessageBox.Show("El valor de la media poisson de la llegada de tapas debe ser positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Double.TryParse(this.txtMediaCajas.Text, out double mediaCajas))
            {
                MessageBox.Show("El valor de la media exponencial de la llegada de cajas debe ser numérico", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (mediaCajas <= 0)
            {
                MessageBox.Show("El valor de la media exponencial de la llegada de cajas debe ser positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Double.TryParse(this.txtMediaPintado.Text, out double mediaPintado))
            {
                MessageBox.Show("El valor de la media del tiempo del proceso de pintado debe ser numérico", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (mediaPintado <= 0)
            {
                MessageBox.Show("El valor de la media del tiempo del proceso de pintado debe ser positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Double.TryParse(this.txtDesvPintado.Text, out double desvPintado))
            {
                MessageBox.Show("El valor de la desviación del tiempo del proceso de pintado debe ser numérico", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (desvPintado <= 0)
            {
                MessageBox.Show("El valor de la desviación del tiempo del proceso de pintado debe ser positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Double.TryParse(this.txtMediaEnsamble.Text, out double mediaEnsamble))
            {
                MessageBox.Show("El valor de la media del tiempo del proceso de ensamblado debe ser numérico", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (mediaEnsamble <= 0)
            {
                MessageBox.Show("El valor de la media del tiempo del proceso de ensamblado debe ser positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Double.TryParse(this.txtDesvEnsamble.Text, out double desvEnsamble))
            {
                MessageBox.Show("El valor de la desviación del tiempo del proceso de ensamblado debe ser numérico", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (desvEnsamble <= 0)
            {
                MessageBox.Show("El valor de la desviación del tiempo del proceso de ensamblado debe ser positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Double.TryParse(this.txtInfDesempaque.Text, out double infDesempaque))
            {
                MessageBox.Show("El valor inferior del tiempo del proceso de desempaquetado debe ser numérico", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (infDesempaque <= 0)
            {
                MessageBox.Show("El valor inferior del tiempo del proceso de desempaquetado debe ser positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Double.TryParse(this.txtSupDesempaque.Text, out double supDesempaque))
            {
                MessageBox.Show("El valor superior del tiempo del proceso de desempaquetado debe ser numérico", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (supDesempaque <= 0)
            {
                MessageBox.Show("El valor superior del tiempo del proceso de desempaquetado debe ser positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if(this.radIteraciones.Checked)
            {
                if (!Int32.TryParse(this.txtIteraciones.Text, out int iteraciones))
                {
                    MessageBox.Show("El número de iteraciones debe ser un número entero", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (iteraciones <= 0)
                {
                    MessageBox.Show("El número de iteraciones debe ser positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if(this.radTiempoSim.Checked)
            {
                if (!Double.TryParse(this.txtTiempoSim.Text, out double tiempoSim))
                {
                    MessageBox.Show("El valor del tiempo de simulación debe ser numérico", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (tiempoSim <= 0)
                {
                    MessageBox.Show("El valor del tiempo de simulación debe ser positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if(this.chkPersistencia.Checked)
            {
                if (!Double.TryParse(this.txtHoraDesde.Text, out double horaDesde))
                {
                    MessageBox.Show("El valor de la hora de simulación desde la que mostrar estados intermedios debe ser numérico", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (horaDesde < 0)
                {
                    MessageBox.Show("El valor de la hora de simulación desde la que mostrar estados intermedios  debe ser positivo o 0", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!Int32.TryParse(this.txtIteracionesHasta.Text, out int iteracionesHasta))
                {
                    MessageBox.Show("El número de iteraciones a mostrar en la grilla debe ser un número entero", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (iteracionesHasta <= 0)
                {
                    MessageBox.Show("El número de iteraciones a mostrar en la grilla debe ser positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void radIteraciones_CheckedChanged(object sender, EventArgs e)
        {
            this.txtIteraciones.Enabled = this.radIteraciones.Checked;
        }

        private void radTiempoSim_CheckedChanged(object sender, EventArgs e)
        {
            this.txtTiempoSim.Enabled = this.radTiempoSim.Checked;
        }
    }
}
