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

            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((txtSol.Text != string.Empty)&&
                (txtState.Text != string.Empty) &&
                (txtComment.Text != string.Empty)
                )
            {
                var dataAlumno = new tbl_logEstado
                {
                    solicitud = this.idSolicitud,
                    Objeto = "SL_SolicitudCredito",
                    MotivoCambio = txtComment.Text,
                    Parametro = "INSERT",
                    EstadoAnterior =Convert.ToInt16(this.estadoAnterior),
                    NuevoEstado = int.Parse(txtState.Text),
                    Usuario = "MMOJICA"
                };

                modelLogEstado.Guardar(dataAlumno);
                form.cleanGridView();
                form.cargarSolicitud(this.idSolicitud);
                this.Close();

                
            }
        }
    }
}
