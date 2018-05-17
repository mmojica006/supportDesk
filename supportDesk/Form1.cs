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

        
        public string usuario;

        public Form1(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
         
            dgvSolicitudes.AutoGenerateColumns = false;

            // callProcedure();
            //callProc(2000057);
            //callProcedure2(2000057); 

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
                if (rbtnObservada.Checked == true) observada = true;

                if (rbtnAnulada.Checked == true) Anulada = true;


                if (rbtnObservada.Checked == true)
                {                
            

                if (txtSolicitud.Text != string.Empty)
                {
                    if (modelSolicitud.validaSolicitud(Convert.ToInt64(txtSolicitud.Text)) == 1)
                    {
                        long str = Convert.ToInt64(txtSolicitud.Text);
                        cleanGridView();
                        cargarSolicitud(str);
                    }
                    else
                    {
                        MessageBox.Show("SOLICITUD NO APLICA PARA CAMBIAR ESTADO", "Consultando", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }      

                }
          
        }
        else if(rbtnAnulada.Checked)
                {

                    int[] result;
                    result = modelSolicitud.validaSolicitudDEL(Convert.ToInt64(txtSolicitud.Text));
                   

              

                    if ((result[0] == 1) || (result[1] == 1))
                    {
                      
                       
                        // Existe en topaz pero en workflow no existe
                        cargarSolicitud((Convert.ToInt64(txtSolicitud.Text)));
                        if (result[0] == 1)
                            eliminarTop = true; //Eliminar solamente en solicitudes

                        if (result[1] == 1)
                            eliminarTopWf = true; //Eliminar en solicitudes y workflow


                    }
                    




          }
            }
            else
            {
                MessageBox.Show("Favor Elegir la opción a realizar", "Consultando", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvSolicitudes_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            new frmDetalle( Convert.ToInt64( dgvSolicitudes.Rows[e.RowIndex].Cells[0].Value), this).ShowDialog();

        }

        private void txtSolicitud_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    
    }
}
