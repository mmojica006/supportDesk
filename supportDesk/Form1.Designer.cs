namespace supportDesk
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblEstadoWFResult = new System.Windows.Forms.Label();
            this.txtEstadoWF = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTipoCredito = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstadoActual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSolicitud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NuevoEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblResult = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(956, 631);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblResult);
            this.tabPage1.Controls.Add(this.lblEstadoWFResult);
            this.tabPage1.Controls.Add(this.txtEstadoWF);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtTipoCredito);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbEstados);
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.txtComment);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtEstadoActual);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtCliente);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.txtSolicitud);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(948, 598);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modificar Estado";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblEstadoWFResult
            // 
            this.lblEstadoWFResult.AutoSize = true;
            this.lblEstadoWFResult.Location = new System.Drawing.Point(514, 320);
            this.lblEstadoWFResult.Name = "lblEstadoWFResult";
            this.lblEstadoWFResult.Size = new System.Drawing.Size(100, 20);
            this.lblEstadoWFResult.TabIndex = 26;
            this.lblEstadoWFResult.Text = "lblEstadoWF";
            // 
            // txtEstadoWF
            // 
            this.txtEstadoWF.Location = new System.Drawing.Point(165, 314);
            this.txtEstadoWF.Name = "txtEstadoWF";
            this.txtEstadoWF.ReadOnly = true;
            this.txtEstadoWF.Size = new System.Drawing.Size(339, 26);
            this.txtEstadoWF.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Estado WF";
            // 
            // txtTipoCredito
            // 
            this.txtTipoCredito.Location = new System.Drawing.Point(641, 215);
            this.txtTipoCredito.Name = "txtTipoCredito";
            this.txtTipoCredito.ReadOnly = true;
            this.txtTipoCredito.Size = new System.Drawing.Size(276, 26);
            this.txtTipoCredito.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tipo de crédito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nuevo Estado";
            // 
            // cmbEstados
            // 
            this.cmbEstados.Enabled = false;
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Location = new System.Drawing.Point(641, 269);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(276, 28);
            this.cmbEstados.TabIndex = 20;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(485, 497);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 38);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(364, 497);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 38);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Actualizar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(165, 364);
            this.txtComment.MaxLength = 1000;
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(752, 115);
            this.txtComment.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Comentario";
            // 
            // txtEstadoActual
            // 
            this.txtEstadoActual.Location = new System.Drawing.Point(165, 266);
            this.txtEstadoActual.Name = "txtEstadoActual";
            this.txtEstadoActual.ReadOnly = true;
            this.txtEstadoActual.Size = new System.Drawing.Size(339, 26);
            this.txtEstadoActual.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Estado actual";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(165, 215);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(339, 26);
            this.txtCliente.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cliente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 78);
            this.panel1.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(177, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(609, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "FORMULARIO PARA REALIZAR CAMBIOS DE ESTADOS TOPAZ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSolicitud
            // 
            this.txtSolicitud.Location = new System.Drawing.Point(165, 155);
            this.txtSolicitud.MaxLength = 15;
            this.txtSolicitud.Name = "txtSolicitud";
            this.txtSolicitud.Size = new System.Drawing.Size(276, 26);
            this.txtSolicitud.TabIndex = 2;
            this.txtSolicitud.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSolicitud_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Solicitud";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(462, 149);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 38);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.dtpFin);
            this.tabPage3.Controls.Add(this.dtpInicio);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.dgvReporte);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(948, 598);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consultas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "FECHA FIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "FECHA INICIO";
            // 
            // dtpFin
            // 
            this.dtpFin.CustomFormat = "";
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(163, 93);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 26);
            this.dtpFin.TabIndex = 3;
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(163, 37);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 26);
            this.dtpInicio.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvReporte
            // 
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Solicitud,
            this.EstadoAnterior,
            this.NuevoEstado,
            this.user,
            this.motivoCambio,
            this.objeto,
            this.fecha});
            this.dgvReporte.Location = new System.Drawing.Point(30, 153);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.RowTemplate.Height = 28;
            this.dgvReporte.Size = new System.Drawing.Size(887, 294);
            this.dgvReporte.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // Solicitud
            // 
            this.Solicitud.DataPropertyName = "Solicitud";
            this.Solicitud.HeaderText = "SOLICITUD";
            this.Solicitud.Name = "Solicitud";
            // 
            // EstadoAnterior
            // 
            this.EstadoAnterior.DataPropertyName = "EstadoAnterior";
            this.EstadoAnterior.HeaderText = "ESTADO ANTERIOR";
            this.EstadoAnterior.Name = "EstadoAnterior";
            this.EstadoAnterior.Width = 120;
            // 
            // NuevoEstado
            // 
            this.NuevoEstado.DataPropertyName = "NuevoEstado";
            this.NuevoEstado.HeaderText = "NUEVO ESTADO";
            this.NuevoEstado.Name = "NuevoEstado";
            this.NuevoEstado.Width = 120;
            // 
            // user
            // 
            this.user.DataPropertyName = "Usuario";
            this.user.HeaderText = "USUARIO";
            this.user.Name = "user";
            this.user.Width = 130;
            // 
            // motivoCambio
            // 
            this.motivoCambio.DataPropertyName = "motivoCambio";
            this.motivoCambio.HeaderText = "COMENTARIO";
            this.motivoCambio.Name = "motivoCambio";
            this.motivoCambio.Width = 150;
            // 
            // objeto
            // 
            this.objeto.DataPropertyName = "objeto";
            this.objeto.HeaderText = "TABLA";
            this.objeto.Name = "objeto";
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "FECHA";
            this.fecha.Name = "fecha";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(52, 103);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(70, 20);
            this.lblResult.TabIndex = 27;
            this.lblResult.Text = "lblResult";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 683);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAMBIOS ESTADO TOPAZ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtSolicitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEstados;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstadoActual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTipoCredito;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoAnterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn NuevoEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn objeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.TextBox txtEstadoWF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEstadoWFResult;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblResult;
    }
}

