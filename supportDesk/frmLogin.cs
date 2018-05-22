using supportDesk.Model;
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
using System.Configuration;

namespace supportDesk
{
    public partial class frmLogin : Form
    {
        ServicioActiveDirectory ad = new ServicioActiveDirectory();
        responseResult response = new responseResult();
        private string domain = "crediexpress.local";
        public frmLogin()
        {
           InitializeComponent();            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtLogin.Text != string.Empty) && (txtPassword.Text != string.Empty))
            {

                if (ad.IsAuthenticated(txtLogin.Text, txtPassword.Text))                {
      
                    string nameGrupoSeguridad = ConfigurationManager.AppSettings["grupoSeguridad"];

                    ADHelper helper = new ADHelper(txtLogin.Text, txtPassword.Text, this.domain);

                    string groupDN = helper.GetGroupDN(nameGrupoSeguridad);
                    string userDN = helper.GetUserDN("GrupodeSeguridad\\"+ txtLogin.Text);

                    if (helper.isUserInGroup(userDN, groupDN))
                    {
                        Form1 fm = new Form1(txtLogin.Text);
                        this.Hide();
                        fm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("NO TIENE PERMISO PARA USAR ESTA APLICACION", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                   
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

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
               
            //    btnAceptar_Click(sender, e);
            //}

        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (this.ActiveControl != null)
                {
                    this.SelectNextControl(this.ActiveControl, true, true, true, true);
                }
                e.Handled = true; // Mark the event as handled
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (this.ActiveControl != null)
                {
                    this.SelectNextControl(this.ActiveControl, true, true, true, true);
                }
                e.Handled = true; // Mark the event as handled
            }
        }
    }
}
