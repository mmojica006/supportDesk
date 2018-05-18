using supportDesk.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace supportDesk
{


    public partial class Form1 : Form
    {
        private SL_SolicitudCredito modelSolicitud = new SL_SolicitudCredito();
        private tbl_logEstado modelLogEstado = new tbl_logEstado();

        public bool observada = false;
        public bool Anulada = false;
        public bool eliminarTop = false;
        public bool eliminarTopWf = false;
        DateTime Hoy = DateTime.Today;

        public string usuario;

        public Form1(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();    
        
        }
        public Form1()
        {
            InitializeComponent();
        }
      

        private void callProcedure2(int v)
        {

            int result = modelSolicitud.validaSolicitud(v);
           
        }

       

        private void callProcedure()
        {
          foreach(var a in modelSolicitud.listadoSol())
            {

         
            Console.WriteLine(
                string.Format(
                       "Solicitud {0}, estado {1}, cliente {2}" ,
                       a.idsolicitud,
                       a.estado,
                       a.nombre
                    )
                );

            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if ((rbtnObservada.Checked == true) || (rbtnAnulada.Checked == true))
            {
                if (rbtnObservada.Checked == true)
                {
                    observada = true;
                    Anulada = false;
                }


                if (rbtnAnulada.Checked == true)
                {
                    Anulada = true;
                    observada = false;
                }

                


                if (rbtnObservada.Checked == true)
                {                
            

                if (txtSolicitud.Text != string.Empty)
                {
                  
                  if (!modelSolicitud.esObservadaAnulada(Convert.ToInt64(txtSolicitud.Text), 98))
                        {

                            if (modelSolicitud.validaSolicitud(Convert.ToInt64(txtSolicitud.Text)) == 1)
                            {

                                    var dataSolicitud = modelSolicitud.getDataSolicitud(Convert.ToInt64(txtSolicitud.Text));

                                    txtEstadoActual.Text = Convert.ToString(dataSolicitud.estado);
                                    txtCliente.Text= Convert.ToString(dataSolicitud.nombre);
                                    txtTipoCredito.Text= Convert.ToString(dataSolicitud.tipoCredito);
                                    callStateNew();
                                    radioButtonBlock(false);

                                }
                            else
                            {
                                MessageBox.Show("SOLICITUD NO APLICA PARA CAMBIAR ESTADO", "Consultando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("LA SOLICITUD YA ESTA OBSERVADA", "Consultando", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }   

                }
          
        }
        else if(rbtnAnulada.Checked)
                {

                    if (!modelSolicitud.esObservadaAnulada(Convert.ToInt64(txtSolicitud.Text), 13))
                    {

                            int[] result;
                            result = modelSolicitud.validaSolicitudDEL(Convert.ToInt64(txtSolicitud.Text));

                            if ((result[0] == 1) || (result[1] == 1))
                            {                     
                                // Existe en topaz pero en workflow no existe
                      
                                if (result[0] == 1)
                                    eliminarTop = true; //Eliminar solamente en solicitudes

                                if (result[1] == 1)
                                    eliminarTopWf = true; //Eliminar en solicitudes y workflow


                                var dataSolicitud = modelSolicitud.getDataSolicitud(Convert.ToInt64(txtSolicitud.Text));

                                txtEstadoActual.Text = Convert.ToString(dataSolicitud.estado);
                                txtCliente.Text = Convert.ToString(dataSolicitud.nombre);
                                txtTipoCredito.Text = Convert.ToString(dataSolicitud.tipoCredito);
                                callStateNew();
                                radioButtonBlock(false);

                        }
                            else
                            {
                            MessageBox.Show("SOLICITUD NO APLICA PARA CAMBIAR ESTADO", "Consultando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("LA SOLICITUD YA ESTA ANULADA", "Consultando", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
            }
            else
            {
                MessageBox.Show("Favor Elegir la opción a realizar", "Consultando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void callStateNew()
        {
            cmbEstados.DataSource = modelSolicitud.EstadoSolicitud();
            cmbEstados.ValueMember = "CodEstado";
            cmbEstados.DisplayMember = "DescEstado";
            if (observada)
            {
                cmbEstados.SelectedIndex = 0;
            }
            else
            {
                cmbEstados.SelectedIndex = 1;
            }
        }

       

        private void BloquearControles()
        {
            txtSolicitud.Enabled = false;
            //txtEstado.Enabled = false;
        }

        private void dgvSolicitudes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

  

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void dgvSolicitudes_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
           // if (e.RowIndex == -1) return;
           // new frmDetalle( Convert.ToInt64( dgvSolicitudes.Rows[e.RowIndex].Cells[0].Value), this).ShowDialog();

        }

        private void txtSolicitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if ((txtSolicitud.Text != string.Empty) &&
               (txtEstadoActual.Text != string.Empty) &&
               (txtComment.Text != string.Empty)
               )
            {
                long idSolicitud = Convert.ToInt64(txtSolicitud.Text);

                if (observada)
                {
                    if (MessageBox.Show("SEGURO QUE DESEA CAMBIAR EL ESTADO A OBSERVADO?", "CAMBIO DE ESTADO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        //do something

                        if (modelSolicitud.Guardar(idSolicitud, Convert.ToInt16(cmbEstados.SelectedValue)))
                        {
                            var dataAlumno = new tbl_logEstado
                            {
                                solicitud = idSolicitud,
                                Objeto = "SL_SolicitudCredito",
                                MotivoCambio = txtComment.Text,
                                Parametro = "INSERT",
                                EstadoAnterior = txtEstadoActual.Text,
                                NuevoEstado = cmbEstados.GetItemText(cmbEstados.SelectedItem),
                                fecha = Hoy,
                                Usuario = usuario
                            };

                            modelLogEstado.Guardar(dataAlumno);

                            MessageBox.Show("SOLICITUD ACTUALIZADA!", "CAMBIO DE ESTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarData();
                            radioButtonBlock(true);
                        }
                        else
                        {
                            MessageBox.Show("ERROR EN LA ACTUALIZACION!", "CAMBIO DE ESTADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }


                }
                else if (Anulada)
                {
                    if (MessageBox.Show("SEGURO QUE DESEA EL ESTADO A ANULADO?", "CAMBIO DE ESTADO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        if (eliminarTop)
                        {
                            if (modelSolicitud.Guardar(idSolicitud, Convert.ToInt16(cmbEstados.SelectedValue)))
                            {
                                var dataAlumno = new tbl_logEstado
                                {
                                    solicitud = idSolicitud,
                                    Objeto = "SL_SolicitudCredito",
                                    MotivoCambio = txtComment.Text,
                                    Parametro = "DELETE",
                                    EstadoAnterior = txtEstadoActual.Text,
                                    NuevoEstado = cmbEstados.GetItemText(cmbEstados.SelectedItem),
                                    fecha = Hoy,
                                    Usuario = usuario
                                };

                                modelLogEstado.Guardar(dataAlumno);

                                MessageBox.Show("SOLICITUD ACTUALIZADA!", "CAMBIO DE ESTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiarData();
                                radioButtonBlock(true);
                            }
                            else
                            {
                                MessageBox.Show("ERROR EN LA ACTUALIZACION!", "CAMBIO DE ESTADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }
                        else if (eliminarTopWf)
                        {

                            var data = modelSolicitud.getProccesWF(idSolicitud);

                            decimal p0 = Convert.ToInt64(data.id_);
                            decimal p1 = Convert.ToInt64(data.PROCINST_);


                        
                             if (modelSolicitud.updateWF(p0, 0, p1))
                             {                         
                                if (modelSolicitud.Guardar(idSolicitud, Convert.ToInt16(cmbEstados.SelectedValue)))
                                {
                                    var dataAlumno = new tbl_logEstado
                                    {
                                        solicitud = idSolicitud,
                                        Objeto = "SL_SolicitudCredito || JBPM_TASKINSTANCE",
                                        MotivoCambio = txtComment.Text,
                                        Parametro = "DELETE",
                                        EstadoAnterior = txtEstadoActual.Text,
                                        NuevoEstado = cmbEstados.GetItemText(cmbEstados.SelectedItem),
                                        fecha = Hoy,
                                        Usuario = usuario
                                    };

                                    modelLogEstado.Guardar(dataAlumno);

                                    MessageBox.Show("SOLICITUD ACTUALIZADA!", "CAMBIO DE ESTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    limpiarData();
                                    radioButtonBlock(true);
                                }
                                else
                                {
                                    MessageBox.Show("ERROR EN LA ACTUALIZACION!", "CAMBIO DE ESTADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("ERROR EN LA ACTUALIZACION!\n FAVOR REPORTAR A TECNOLOGIA", "CAMBIO DE ESTADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }

                    }

                }

            }


        }

        private void limpiarData()
        {
            txtSolicitud.Text = string.Empty;
            cmbEstados.DataSource = null;
            txtEstadoActual.Text= string.Empty;
            txtComment.Text = string.Empty;
            txtTipoCredito.Text = string.Empty;
            txtCliente.Text = string.Empty;
        }
        private void radioButtonBlock(bool bloquear)
        {
            rbtnAnulada.Enabled = bloquear;
            rbtnObservada.Enabled = bloquear;
            txtSolicitud.Enabled = bloquear;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarData();
            radioButtonBlock(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpFin.Format = DateTimePickerFormat.Custom;

            string fechaInicio = dtpInicio.Value.ToShortDateString();
            string fechaFin = dtpFin.Value.ToShortDateString();            

            dgvReporte.DataSource = modelLogEstado.getReport(Convert.ToDateTime(fechaInicio).ToString("yyyyMMdd"), Convert.ToDateTime(fechaFin).ToString("yyyyMMdd"));
        }
    }
}
