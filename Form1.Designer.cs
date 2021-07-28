
namespace TPFinalSIM
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgSim = new System.Windows.Forms.DataGridView();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_t_llg_tapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_llg_tapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prox_llg_tapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_tipo_tapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_tapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd1_t_fin_pintado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd2_t_fin_pintado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_fin_pintado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prox_fin_pintado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_resultado_pintado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultado_pintado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_tiempo_llg_caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_llg_caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prox_llg_caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_t_fin_desempq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_fin_desempq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prox_fin_desempq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_estado_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_pieza_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_estado_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_pieza_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd_estado_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_pieza_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd1_t_fin_ensamble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rnd2_t_fin_ensamble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t_fin_ensamble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prox_fin_ensamble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_maq_pintura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_maq_pintura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_maq_desempaque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_maq_desempaque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_maq_ensamble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_tapas_inf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_tapas_sup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cola_piezas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ult_fin_ensamble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acum_t_fabricacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant_piezas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMediaTapas = new System.Windows.Forms.TextBox();
            this.txtMediaPintado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesvPintado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMediaCajas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSupDesempaque = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInfDesempaque = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDesvEnsamble = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMediaEnsamble = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIteraciones = new System.Windows.Forms.TextBox();
            this.txtTiempoSim = new System.Windows.Forms.TextBox();
            this.txtHoraDesde = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtIteracionesHasta = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.chkPersistencia = new System.Windows.Forms.CheckBox();
            this.btnSimulacion = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.lblTapasPorMinuto = new System.Windows.Forms.Label();
            this.radIteraciones = new System.Windows.Forms.RadioButton();
            this.radTiempoSim = new System.Windows.Forms.RadioButton();
            this.lblCantPiezas = new System.Windows.Forms.Label();
            this.lblTiempoProm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSim)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgSim
            // 
            this.dtgSim.AllowUserToAddRows = false;
            this.dtgSim.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgSim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgSim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.evento,
            this.reloj,
            this.rnd_t_llg_tapa,
            this.t_llg_tapa,
            this.prox_llg_tapa,
            this.rnd_tipo_tapa,
            this.tipo_tapa,
            this.rnd1_t_fin_pintado,
            this.rnd2_t_fin_pintado,
            this.t_fin_pintado,
            this.prox_fin_pintado,
            this.rnd_resultado_pintado,
            this.resultado_pintado,
            this.rnd_tiempo_llg_caja,
            this.t_llg_caja,
            this.prox_llg_caja,
            this.rnd_t_fin_desempq,
            this.t_fin_desempq,
            this.prox_fin_desempq,
            this.rnd_estado_1,
            this.estado_pieza_1,
            this.rnd_estado_2,
            this.estado_pieza_2,
            this.rnd_estado_3,
            this.estado_pieza_3,
            this.rnd1_t_fin_ensamble,
            this.rnd2_t_fin_ensamble,
            this.t_fin_ensamble,
            this.prox_fin_ensamble,
            this.estado_maq_pintura,
            this.cola_maq_pintura,
            this.estado_maq_desempaque,
            this.cola_maq_desempaque,
            this.estado_maq_ensamble,
            this.cola_tapas_inf,
            this.cola_tapas_sup,
            this.cola_piezas,
            this.ult_fin_ensamble,
            this.acum_t_fabricacion,
            this.cant_piezas});
            this.dtgSim.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgSim.Location = new System.Drawing.Point(12, 230);
            this.dtgSim.Name = "dtgSim";
            this.dtgSim.ReadOnly = true;
            this.dtgSim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgSim.Size = new System.Drawing.Size(1214, 378);
            this.dtgSim.TabIndex = 0;
            // 
            // evento
            // 
            this.evento.HeaderText = "Evento";
            this.evento.Name = "evento";
            this.evento.ReadOnly = true;
            this.evento.Width = 150;
            // 
            // reloj
            // 
            this.reloj.HeaderText = "Reloj (min)";
            this.reloj.Name = "reloj";
            this.reloj.ReadOnly = true;
            this.reloj.Width = 75;
            // 
            // rnd_t_llg_tapa
            // 
            this.rnd_t_llg_tapa.HeaderText = "RND Tiempo Llegada Tapa";
            this.rnd_t_llg_tapa.Name = "rnd_t_llg_tapa";
            this.rnd_t_llg_tapa.ReadOnly = true;
            this.rnd_t_llg_tapa.Width = 75;
            // 
            // t_llg_tapa
            // 
            this.t_llg_tapa.HeaderText = "Tiempo Llegada Tapa";
            this.t_llg_tapa.Name = "t_llg_tapa";
            this.t_llg_tapa.ReadOnly = true;
            this.t_llg_tapa.Width = 75;
            // 
            // prox_llg_tapa
            // 
            this.prox_llg_tapa.HeaderText = "Prox. Llegada Tapa";
            this.prox_llg_tapa.Name = "prox_llg_tapa";
            this.prox_llg_tapa.ReadOnly = true;
            this.prox_llg_tapa.Width = 75;
            // 
            // rnd_tipo_tapa
            // 
            this.rnd_tipo_tapa.HeaderText = "RND Tipo Tapa";
            this.rnd_tipo_tapa.Name = "rnd_tipo_tapa";
            this.rnd_tipo_tapa.ReadOnly = true;
            this.rnd_tipo_tapa.Width = 75;
            // 
            // tipo_tapa
            // 
            this.tipo_tapa.HeaderText = "Tipo Tapa";
            this.tipo_tapa.Name = "tipo_tapa";
            this.tipo_tapa.ReadOnly = true;
            // 
            // rnd1_t_fin_pintado
            // 
            this.rnd1_t_fin_pintado.HeaderText = "RND 1 Tiempo Fin Pintado";
            this.rnd1_t_fin_pintado.Name = "rnd1_t_fin_pintado";
            this.rnd1_t_fin_pintado.ReadOnly = true;
            this.rnd1_t_fin_pintado.Width = 75;
            // 
            // rnd2_t_fin_pintado
            // 
            this.rnd2_t_fin_pintado.HeaderText = "RND 2 Tiempo Fin Pintado";
            this.rnd2_t_fin_pintado.Name = "rnd2_t_fin_pintado";
            this.rnd2_t_fin_pintado.ReadOnly = true;
            this.rnd2_t_fin_pintado.Width = 75;
            // 
            // t_fin_pintado
            // 
            this.t_fin_pintado.HeaderText = "Tiempo Fin Pintado";
            this.t_fin_pintado.Name = "t_fin_pintado";
            this.t_fin_pintado.ReadOnly = true;
            this.t_fin_pintado.Width = 75;
            // 
            // prox_fin_pintado
            // 
            this.prox_fin_pintado.HeaderText = "Prox. Fin Pintado";
            this.prox_fin_pintado.Name = "prox_fin_pintado";
            this.prox_fin_pintado.ReadOnly = true;
            this.prox_fin_pintado.Width = 75;
            // 
            // rnd_resultado_pintado
            // 
            this.rnd_resultado_pintado.HeaderText = "RND Resultado Pintado";
            this.rnd_resultado_pintado.Name = "rnd_resultado_pintado";
            this.rnd_resultado_pintado.ReadOnly = true;
            this.rnd_resultado_pintado.Width = 75;
            // 
            // resultado_pintado
            // 
            this.resultado_pintado.HeaderText = "Resultado Pintado";
            this.resultado_pintado.Name = "resultado_pintado";
            this.resultado_pintado.ReadOnly = true;
            // 
            // rnd_tiempo_llg_caja
            // 
            this.rnd_tiempo_llg_caja.HeaderText = "RND Tiempo Llegada Caja";
            this.rnd_tiempo_llg_caja.Name = "rnd_tiempo_llg_caja";
            this.rnd_tiempo_llg_caja.ReadOnly = true;
            this.rnd_tiempo_llg_caja.Width = 75;
            // 
            // t_llg_caja
            // 
            this.t_llg_caja.HeaderText = "Tiempo Llegada Caja";
            this.t_llg_caja.Name = "t_llg_caja";
            this.t_llg_caja.ReadOnly = true;
            this.t_llg_caja.Width = 75;
            // 
            // prox_llg_caja
            // 
            this.prox_llg_caja.HeaderText = "Prox. Llegada Caja";
            this.prox_llg_caja.Name = "prox_llg_caja";
            this.prox_llg_caja.ReadOnly = true;
            this.prox_llg_caja.Width = 75;
            // 
            // rnd_t_fin_desempq
            // 
            this.rnd_t_fin_desempq.HeaderText = "RND Tiempo Fin Desempaque";
            this.rnd_t_fin_desempq.Name = "rnd_t_fin_desempq";
            this.rnd_t_fin_desempq.ReadOnly = true;
            this.rnd_t_fin_desempq.Width = 75;
            // 
            // t_fin_desempq
            // 
            this.t_fin_desempq.HeaderText = "Tiempo Fin Desempaque";
            this.t_fin_desempq.Name = "t_fin_desempq";
            this.t_fin_desempq.ReadOnly = true;
            this.t_fin_desempq.Width = 75;
            // 
            // prox_fin_desempq
            // 
            this.prox_fin_desempq.HeaderText = "Prox. Fin Desempaque";
            this.prox_fin_desempq.Name = "prox_fin_desempq";
            this.prox_fin_desempq.ReadOnly = true;
            this.prox_fin_desempq.Width = 75;
            // 
            // rnd_estado_1
            // 
            this.rnd_estado_1.HeaderText = "RND Estado Pieza 1";
            this.rnd_estado_1.Name = "rnd_estado_1";
            this.rnd_estado_1.ReadOnly = true;
            this.rnd_estado_1.Width = 75;
            // 
            // estado_pieza_1
            // 
            this.estado_pieza_1.HeaderText = "Estado Pieza 1";
            this.estado_pieza_1.Name = "estado_pieza_1";
            this.estado_pieza_1.ReadOnly = true;
            // 
            // rnd_estado_2
            // 
            this.rnd_estado_2.HeaderText = "RND Estado Pieza 2";
            this.rnd_estado_2.Name = "rnd_estado_2";
            this.rnd_estado_2.ReadOnly = true;
            this.rnd_estado_2.Width = 75;
            // 
            // estado_pieza_2
            // 
            this.estado_pieza_2.HeaderText = "Estado Pieza 2";
            this.estado_pieza_2.Name = "estado_pieza_2";
            this.estado_pieza_2.ReadOnly = true;
            // 
            // rnd_estado_3
            // 
            this.rnd_estado_3.HeaderText = "RND Estado Pieza 3";
            this.rnd_estado_3.Name = "rnd_estado_3";
            this.rnd_estado_3.ReadOnly = true;
            this.rnd_estado_3.Width = 75;
            // 
            // estado_pieza_3
            // 
            this.estado_pieza_3.HeaderText = "Estado Pieza 3";
            this.estado_pieza_3.Name = "estado_pieza_3";
            this.estado_pieza_3.ReadOnly = true;
            // 
            // rnd1_t_fin_ensamble
            // 
            this.rnd1_t_fin_ensamble.HeaderText = "RND 1 Tiempo Fin Ensamble";
            this.rnd1_t_fin_ensamble.Name = "rnd1_t_fin_ensamble";
            this.rnd1_t_fin_ensamble.ReadOnly = true;
            this.rnd1_t_fin_ensamble.Width = 75;
            // 
            // rnd2_t_fin_ensamble
            // 
            this.rnd2_t_fin_ensamble.HeaderText = "RND 2 Tiempo Fin Ensamble";
            this.rnd2_t_fin_ensamble.Name = "rnd2_t_fin_ensamble";
            this.rnd2_t_fin_ensamble.ReadOnly = true;
            this.rnd2_t_fin_ensamble.Width = 75;
            // 
            // t_fin_ensamble
            // 
            this.t_fin_ensamble.HeaderText = "Tiempo Fin Ensamble";
            this.t_fin_ensamble.Name = "t_fin_ensamble";
            this.t_fin_ensamble.ReadOnly = true;
            this.t_fin_ensamble.Width = 75;
            // 
            // prox_fin_ensamble
            // 
            this.prox_fin_ensamble.HeaderText = "Prox. Fin Ensamble";
            this.prox_fin_ensamble.Name = "prox_fin_ensamble";
            this.prox_fin_ensamble.ReadOnly = true;
            this.prox_fin_ensamble.Width = 75;
            // 
            // estado_maq_pintura
            // 
            this.estado_maq_pintura.HeaderText = "Estado Maquina Pintura";
            this.estado_maq_pintura.Name = "estado_maq_pintura";
            this.estado_maq_pintura.ReadOnly = true;
            // 
            // cola_maq_pintura
            // 
            this.cola_maq_pintura.HeaderText = "Cola Maquina Pintura";
            this.cola_maq_pintura.Name = "cola_maq_pintura";
            this.cola_maq_pintura.ReadOnly = true;
            this.cola_maq_pintura.Width = 75;
            // 
            // estado_maq_desempaque
            // 
            this.estado_maq_desempaque.HeaderText = "Estado Maquina Desempaque";
            this.estado_maq_desempaque.Name = "estado_maq_desempaque";
            this.estado_maq_desempaque.ReadOnly = true;
            // 
            // cola_maq_desempaque
            // 
            this.cola_maq_desempaque.HeaderText = "Cola Maquina Desempaque";
            this.cola_maq_desempaque.Name = "cola_maq_desempaque";
            this.cola_maq_desempaque.ReadOnly = true;
            this.cola_maq_desempaque.Width = 75;
            // 
            // estado_maq_ensamble
            // 
            this.estado_maq_ensamble.HeaderText = "Estado Maquina Ensamble";
            this.estado_maq_ensamble.Name = "estado_maq_ensamble";
            this.estado_maq_ensamble.ReadOnly = true;
            // 
            // cola_tapas_inf
            // 
            this.cola_tapas_inf.HeaderText = "Cola Tapas Inferiores";
            this.cola_tapas_inf.Name = "cola_tapas_inf";
            this.cola_tapas_inf.ReadOnly = true;
            this.cola_tapas_inf.Width = 75;
            // 
            // cola_tapas_sup
            // 
            this.cola_tapas_sup.HeaderText = "Cola Tapas Superiores";
            this.cola_tapas_sup.Name = "cola_tapas_sup";
            this.cola_tapas_sup.ReadOnly = true;
            this.cola_tapas_sup.Width = 75;
            // 
            // cola_piezas
            // 
            this.cola_piezas.HeaderText = "Cola Piezas";
            this.cola_piezas.Name = "cola_piezas";
            this.cola_piezas.ReadOnly = true;
            this.cola_piezas.Width = 75;
            // 
            // ult_fin_ensamble
            // 
            this.ult_fin_ensamble.HeaderText = "Ultimo Fin Ensamble";
            this.ult_fin_ensamble.Name = "ult_fin_ensamble";
            this.ult_fin_ensamble.ReadOnly = true;
            this.ult_fin_ensamble.Width = 75;
            // 
            // acum_t_fabricacion
            // 
            this.acum_t_fabricacion.HeaderText = "Acum. Tiempo Fabricacion";
            this.acum_t_fabricacion.Name = "acum_t_fabricacion";
            this.acum_t_fabricacion.ReadOnly = true;
            // 
            // cant_piezas
            // 
            this.cant_piezas.HeaderText = "Cant. Piezas Fabricadas";
            this.cant_piezas.Name = "cant_piezas";
            this.cant_piezas.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTapasPorMinuto);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtDesvEnsamble);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtMediaEnsamble);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtSupDesempaque);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtInfDesempaque);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtMediaCajas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDesvPintado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMediaPintado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMediaTapas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros eventos (minutos)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Llegada tapas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Media:";
            // 
            // txtMediaTapas
            // 
            this.txtMediaTapas.Location = new System.Drawing.Point(65, 46);
            this.txtMediaTapas.Name = "txtMediaTapas";
            this.txtMediaTapas.Size = new System.Drawing.Size(100, 20);
            this.txtMediaTapas.TabIndex = 2;
            this.txtMediaTapas.TextChanged += new System.EventHandler(this.txtMediaTapas_TextChanged);
            // 
            // txtMediaPintado
            // 
            this.txtMediaPintado.Location = new System.Drawing.Point(65, 106);
            this.txtMediaPintado.Name = "txtMediaPintado";
            this.txtMediaPintado.Size = new System.Drawing.Size(100, 20);
            this.txtMediaPintado.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Media:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fin de pintado:";
            // 
            // txtDesvPintado
            // 
            this.txtDesvPintado.Location = new System.Drawing.Point(250, 106);
            this.txtDesvPintado.Name = "txtDesvPintado";
            this.txtDesvPintado.Size = new System.Drawing.Size(100, 20);
            this.txtDesvPintado.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Desviación:";
            // 
            // txtMediaCajas
            // 
            this.txtMediaCajas.Location = new System.Drawing.Point(497, 46);
            this.txtMediaCajas.Name = "txtMediaCajas";
            this.txtMediaCajas.Size = new System.Drawing.Size(100, 20);
            this.txtMediaCajas.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Media:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(438, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Llegada cajas:";
            // 
            // txtSupDesempaque
            // 
            this.txtSupDesempaque.Location = new System.Drawing.Point(537, 134);
            this.txtSupDesempaque.Name = "txtSupDesempaque";
            this.txtSupDesempaque.Size = new System.Drawing.Size(100, 20);
            this.txtSupDesempaque.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Límite superior:";
            // 
            // txtInfDesempaque
            // 
            this.txtInfDesempaque.Location = new System.Drawing.Point(537, 106);
            this.txtInfDesempaque.Name = "txtInfDesempaque";
            this.txtInfDesempaque.Size = new System.Drawing.Size(100, 20);
            this.txtInfDesempaque.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Límite inferior:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(438, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Fin de desempaquetado:";
            // 
            // txtDesvEnsamble
            // 
            this.txtDesvEnsamble.Location = new System.Drawing.Point(250, 170);
            this.txtDesvEnsamble.Name = "txtDesvEnsamble";
            this.txtDesvEnsamble.Size = new System.Drawing.Size(100, 20);
            this.txtDesvEnsamble.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(183, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Desviación:";
            // 
            // txtMediaEnsamble
            // 
            this.txtMediaEnsamble.Location = new System.Drawing.Point(65, 170);
            this.txtMediaEnsamble.Name = "txtMediaEnsamble";
            this.txtMediaEnsamble.Size = new System.Drawing.Size(100, 20);
            this.txtMediaEnsamble.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Media:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Fin de ensamblado:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radTiempoSim);
            this.groupBox2.Controls.Add(this.radIteraciones);
            this.groupBox2.Controls.Add(this.chkPersistencia);
            this.groupBox2.Controls.Add(this.txtIteracionesHasta);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtHoraDesde);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtTiempoSim);
            this.groupBox2.Controls.Add(this.txtIteraciones);
            this.groupBox2.Location = new System.Drawing.Point(753, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 163);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parámetros simulación";
            // 
            // txtIteraciones
            // 
            this.txtIteraciones.Location = new System.Drawing.Point(153, 23);
            this.txtIteraciones.Name = "txtIteraciones";
            this.txtIteraciones.Size = new System.Drawing.Size(100, 20);
            this.txtIteraciones.TabIndex = 1;
            // 
            // txtTiempoSim
            // 
            this.txtTiempoSim.Enabled = false;
            this.txtTiempoSim.Location = new System.Drawing.Point(153, 60);
            this.txtTiempoSim.Name = "txtTiempoSim";
            this.txtTiempoSim.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoSim.TabIndex = 3;
            // 
            // txtHoraDesde
            // 
            this.txtHoraDesde.Enabled = false;
            this.txtHoraDesde.Location = new System.Drawing.Point(104, 130);
            this.txtHoraDesde.Name = "txtHoraDesde";
            this.txtHoraDesde.Size = new System.Drawing.Size(100, 20);
            this.txtHoraDesde.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 133);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Ver desde hora:";
            // 
            // txtIteracionesHasta
            // 
            this.txtIteracionesHasta.Enabled = false;
            this.txtIteracionesHasta.Location = new System.Drawing.Point(321, 130);
            this.txtIteracionesHasta.Name = "txtIteracionesHasta";
            this.txtIteracionesHasta.Size = new System.Drawing.Size(100, 20);
            this.txtIteracionesHasta.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(226, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Iteraciones a ver:";
            // 
            // chkPersistencia
            // 
            this.chkPersistencia.AutoSize = true;
            this.chkPersistencia.Location = new System.Drawing.Point(19, 105);
            this.chkPersistencia.Name = "chkPersistencia";
            this.chkPersistencia.Size = new System.Drawing.Size(138, 17);
            this.chkPersistencia.TabIndex = 8;
            this.chkPersistencia.Text = "Ver estados intermedios";
            this.chkPersistencia.UseVisualStyleBackColor = true;
            this.chkPersistencia.CheckedChanged += new System.EventHandler(this.chkPersistencia_CheckedChanged);
            // 
            // btnSimulacion
            // 
            this.btnSimulacion.Location = new System.Drawing.Point(753, 181);
            this.btnSimulacion.Name = "btnSimulacion";
            this.btnSimulacion.Size = new System.Drawing.Size(473, 43);
            this.btnSimulacion.TabIndex = 3;
            this.btnSimulacion.Text = "Ejecutar simulación";
            this.btnSimulacion.UseVisualStyleBackColor = true;
            this.btnSimulacion.Click += new System.EventHandler(this.btnSimulacion_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(171, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "tapas por hora";
            // 
            // lblTapasPorMinuto
            // 
            this.lblTapasPorMinuto.AutoSize = true;
            this.lblTapasPorMinuto.Location = new System.Drawing.Point(247, 49);
            this.lblTapasPorMinuto.Name = "lblTapasPorMinuto";
            this.lblTapasPorMinuto.Size = new System.Drawing.Size(103, 13);
            this.lblTapasPorMinuto.TabIndex = 22;
            this.lblTapasPorMinuto.Text = "(--- tapas por minuto)";
            // 
            // radIteraciones
            // 
            this.radIteraciones.AutoSize = true;
            this.radIteraciones.Checked = true;
            this.radIteraciones.Location = new System.Drawing.Point(19, 24);
            this.radIteraciones.Name = "radIteraciones";
            this.radIteraciones.Size = new System.Drawing.Size(80, 17);
            this.radIteraciones.TabIndex = 9;
            this.radIteraciones.TabStop = true;
            this.radIteraciones.Text = "Iteraciones:";
            this.radIteraciones.UseVisualStyleBackColor = true;
            this.radIteraciones.CheckedChanged += new System.EventHandler(this.radIteraciones_CheckedChanged);
            // 
            // radTiempoSim
            // 
            this.radTiempoSim.AutoSize = true;
            this.radTiempoSim.Location = new System.Drawing.Point(19, 61);
            this.radTiempoSim.Name = "radTiempoSim";
            this.radTiempoSim.Size = new System.Drawing.Size(130, 17);
            this.radTiempoSim.TabIndex = 10;
            this.radTiempoSim.Text = "Tiempo de simulación:";
            this.radTiempoSim.UseVisualStyleBackColor = true;
            this.radTiempoSim.CheckedChanged += new System.EventHandler(this.radTiempoSim_CheckedChanged);
            // 
            // lblCantPiezas
            // 
            this.lblCantPiezas.AutoSize = true;
            this.lblCantPiezas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantPiezas.Location = new System.Drawing.Point(18, 638);
            this.lblCantPiezas.Name = "lblCantPiezas";
            this.lblCantPiezas.Size = new System.Drawing.Size(233, 17);
            this.lblCantPiezas.TabIndex = 4;
            this.lblCantPiezas.Text = "Cantidad de piezas fabricadas:";
            // 
            // lblTiempoProm
            // 
            this.lblTiempoProm.AutoSize = true;
            this.lblTiempoProm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoProm.Location = new System.Drawing.Point(18, 670);
            this.lblTiempoProm.Name = "lblTiempoProm";
            this.lblTiempoProm.Size = new System.Drawing.Size(246, 17);
            this.lblTiempoProm.TabIndex = 5;
            this.lblTiempoProm.Text = "Tiempo promedio de fabricación:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 706);
            this.Controls.Add(this.lblTiempoProm);
            this.Controls.Add(this.lblCantPiezas);
            this.Controls.Add(this.btnSimulacion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgSim);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "TP Final Simulación - Benjamín Gómez Toledo (78928)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSim)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgSim;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn reloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_t_llg_tapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_llg_tapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn prox_llg_tapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_tipo_tapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_tapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd1_t_fin_pintado;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd2_t_fin_pintado;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_fin_pintado;
        private System.Windows.Forms.DataGridViewTextBoxColumn prox_fin_pintado;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_resultado_pintado;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultado_pintado;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_tiempo_llg_caja;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_llg_caja;
        private System.Windows.Forms.DataGridViewTextBoxColumn prox_llg_caja;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_t_fin_desempq;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_fin_desempq;
        private System.Windows.Forms.DataGridViewTextBoxColumn prox_fin_desempq;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_estado_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_pieza_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_estado_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_pieza_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd_estado_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_pieza_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd1_t_fin_ensamble;
        private System.Windows.Forms.DataGridViewTextBoxColumn rnd2_t_fin_ensamble;
        private System.Windows.Forms.DataGridViewTextBoxColumn t_fin_ensamble;
        private System.Windows.Forms.DataGridViewTextBoxColumn prox_fin_ensamble;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_maq_pintura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_maq_pintura;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_maq_desempaque;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_maq_desempaque;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_maq_ensamble;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_tapas_inf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_tapas_sup;
        private System.Windows.Forms.DataGridViewTextBoxColumn cola_piezas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ult_fin_ensamble;
        private System.Windows.Forms.DataGridViewTextBoxColumn acum_t_fabricacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant_piezas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSupDesempaque;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInfDesempaque;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMediaCajas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDesvPintado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMediaPintado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMediaTapas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesvEnsamble;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMediaEnsamble;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkPersistencia;
        private System.Windows.Forms.TextBox txtIteracionesHasta;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtHoraDesde;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTiempoSim;
        private System.Windows.Forms.TextBox txtIteraciones;
        private System.Windows.Forms.Button btnSimulacion;
        private System.Windows.Forms.Label lblTapasPorMinuto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton radTiempoSim;
        private System.Windows.Forms.RadioButton radIteraciones;
        private System.Windows.Forms.Label lblCantPiezas;
        private System.Windows.Forms.Label lblTiempoProm;
    }
}

