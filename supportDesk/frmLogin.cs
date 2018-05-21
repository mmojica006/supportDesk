using suppportDesk;
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
    public partial class frmLogin : Form
    {
        ServicioActiveDirectory ad = new ServicioActiveDirectory();
        public frmLogin()
        {
          

            InitializeComponent();


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtLogin.Text != string.Empty) && (txtPassword.Text != string.Empty))
            {

                if (ad.IsAuthenticated(txtLogin.Text, txtPassword.Text))
                { 
                    Form1 fm = new Form1(txtLogin.Text);
                    this.Hide();
                    fm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("FAVOR VERIFICAR SU USUARIO O CONTRASEÑA", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
