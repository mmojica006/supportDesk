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

     public Form1()
        {
            InitializeComponent();
         
            dgvSolicitudes.AutoGenerateColumns = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtSolicitud.Text != string.Empty)
            {
                long str = Convert.ToInt64(txtSolicitud.Text);
                cargarSolicitud(str);


              

                //var DataSolicitud = modelSolicitud.Obtener(str);
                //if (DataSolicitud.C5000 > 0)
                //{
                //    txtEstado.Text = Convert.ToString(DataSolicitud.C5063).ToString();
                //    BloquearControles();

                //}          
                            
            }
        }

        public void cargarSolicitud(long idSolicitud)
        {
            this.dgvSolicitudes.DataSource = null;
            var DataSolicitud = modelSolicitud.Obtener(idSolicitud);
            if ((DataSolicitud != null) && (DataSolicitud.C5000 > 0)){

           
                DataTable dt = new DataTable();
                dt.Columns.Add(DataSolicitud.C5000.ToString());
                dt.Columns.Add(DataSolicitud.C5063.ToString());


                //dgvSolicitudes.Columns.Add("Solicitud", "Solicitud");
                //dgvSolicitudes.Columns.Add("Estado", "Estado");
                //dgvSolicitudes.Columns.Add("Cliente", "Cliente");

                dgvSolicitudes.Rows.Add(DataSolicitud.C5000.ToString(), 
                    DataSolicitud.C5063.ToString(), 
                    DataSolicitud.C5033.ToString(), 
                    DataSolicitud.C5062.ToString());

            }
            else
            {
                MessageBox.Show("Solicitud no encontrada", "Consultando", MessageBoxButtons.OK,MessageBoxIcon.Warning);
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

        public void cleanGridView()
        {
            this.dgvSolicitudes.DataSource = null;
            this.dgvSolicitudes.Rows.Clear();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
