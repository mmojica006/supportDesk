using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using supportDesk.Model;

namespace supportDesk
{
    public partial class frmDetalle : Form
    {

        public long idSolicitud = 0;
        public decimal estadoAnterior = 0;
        public Form1 form;
        private SL_SolicitudCredito modelSolicitud = new SL_SolicitudCredito();
        private tbl_logEstado modelLogEstado = new tbl_logEstado();
        

        public frmDetalle(long idSolicitud, Form1 frm1)
        {
            this.idSolicitud = idSolicitud;
            this.form = frm1;



            var dataSolicitud = modelSolicitud.Obtener(this.idSolicitud);
            this.estadoAnterior = Convert.ToDecimal(dataSolicitud.C5063);



            InitializeComponent();

        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {

            txtSol.Text = this.idSolicitud.ToString();

            if (this.idSolicitud > 0)
            {


                btnSave.Visible = true;
                var dataSolicitud = modelSolicitud.Obtener(this.idSolicitud);

                txtState.Text = dataSolicitud.C5063.ToString();


                cmbEstados.DataSource = modelSolicitud.EstadoSolicitud();
                cmbEstados.ValueMember = "CodEstado";
                cmbEstados.DisplayMember = "DescEstado";
                if (form.observada)
                {
                    cmbEstados.SelectedIndex = 0;
                }
                else
                {
                    cmbEstados.SelectedIndex = 1;
                }

            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((txtSol.Text != string.Empty) &&
                (txtState.Text != string.Empty) &&
                (txtComment.Text != string.Empty)
                )
            {

                if (form.observada)
                {
                    if (modelSolicitud.Guardar(this.idSolicitud, Convert.ToInt16(cmbEstados.SelectedValue)))
                    {
                        var dataAlumno = new tbl_logEstado
                        {
                            solicitud = this.idSolicitud,
                            Objeto = "SL_SolicitudCredito",
                            MotivoCambio = txtComment.Text,
                            Parametro = "INSERT",
                            EstadoAnterior = int.Parse(txtState.Text),
                            NuevoEstado = Convert.ToInt16(cmbEstados.SelectedValue) ,
                            Usuario = form.usuario
                        };

                        modelLogEstado.Guardar(dataAlumno);

                        MessageBox.Show("SOLICITUD ACTUALIZADA!", "CAMBIO DE ESTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        form.cleanGridView();
                        form.cargarSolicitud(this.idSolicitud);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("ERROR EN LA ACTUALIZACION!", "CAMBIO DE ESTADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (form.Anulada)
                {

                    if (form.eliminarTop)
                    {
                        if (modelSolicitud.Guardar(this.idSolicitud, Convert.ToInt16(cmbEstados.SelectedValue)))
                        {
                            var dataAlumno = new tbl_logEstado
                            {
                                solicitud = this.idSolicitud,
                                Objeto = "SL_SolicitudCredito",
                                MotivoCambio = txtComment.Text,
                                Parametro = "DELETE",
                                EstadoAnterior = int.Parse(txtState.Text),
                                NuevoEstado = Convert.ToInt16(cmbEstados.SelectedValue),
                                Usuario = form.usuario
                            };

                            modelLogEstado.Guardar(dataAlumno);

                            MessageBox.Show("SOLICITUD ACTUALIZADA!", "CAMBIO DE ESTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            form.cleanGridView();
                            form.cargarSolicitud(this.idSolicitud);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("ERROR EN LA ACTUALIZACION!", "CAMBIO DE ESTADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }else if(form.eliminarTopWf){                   

                       var data  = modelSolicitud.getProccesWF(this.idSolicitud);

                        decimal p0 =  Convert.ToInt64( data.id_);
                        decimal p1 = Convert.ToInt64(data.PROCINST_);
                      

                        bool response = modelSolicitud.updateWF(p0, 0, p1);

                        if (modelSolicitud.Guardar(this.idSolicitud, Convert.ToInt16(cmbEstados.SelectedValue)))
                        {
                            var dataAlumno = new tbl_logEstado
                            {
                                solicitud = this.idSolicitud,
                                Objeto = "SL_SolicitudCredito || JBPM_TASKINSTANCE",
                                MotivoCambio = txtComment.Text,
                                Parametro = "DELETE",
                                EstadoAnterior = int.Parse(txtState.Text),
                                NuevoEstado = Convert.ToInt16(cmbEstados.SelectedValue),
                                Usuario = form.usuario
                            };

                            modelLogEstado.Guardar(dataAlumno);

                            MessageBox.Show("SOLICITUD ACTUALIZADA!", "CAMBIO DE ESTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            form.cleanGridView();
                            form.cargarSolicitud(this.idSolicitud);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("ERROR EN LA ACTUALIZACION!", "CAMBIO DE ESTADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }






                    }


                }






            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
