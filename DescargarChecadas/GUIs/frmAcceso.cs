using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DescargarChecadas.GUIs
{
    public partial class frmAcceso : Form
    {
        public frmAcceso()
        {
            InitializeComponent();
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {

            this.Size = new Size(304, 193);

            this.ActiveControl = this.tbAccess;
        }

        private void btnCambCve_Click(object sender, EventArgs e)
        {
            // mostrar el panel del cambio de clave
            this.Size = new Size(304, 542);

            // se habilita el panel
            this.panel1.Enabled = true;

            // se deshabilita el acceso
            this.label1.Enabled = false;
            this.tbAccess.Enabled = false;
            this.btnAceptar.Enabled = false;
            this.btnCancelar.Enabled = false;
            this.btnCambCve.Enabled = false;
            this.tbAccess.Text = string.Empty;

            // habilita el panel
            this.tbPCveAnt.Text = string.Empty;
            this.tbPCveNueva.Text = string.Empty;
            this.tbPConfirmCve.Text = string.Empty;
            this.ActiveControl = this.tbPCveAnt;
        }

        private void btnPCancelar_Click(object sender, EventArgs e)
        {
            // regresa el tamaño del formulario
            this.Size = new Size(304, 193);

            // habilita el acces
            this.label1.Enabled = true;
            this.tbAccess.Enabled = true;
            this.btnAceptar.Enabled = true;
            this.btnCancelar.Enabled = true;
            this.btnCambCve.Enabled = true;

            // deshabilita el panel
            this.panel1.Enabled = false;

            this.ActiveControl = this.tbAccess;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // validacion
                if (string.IsNullOrEmpty(this.tbAccess.Text))
                    throw new Exception("Ingrese la clave de acceso");

                string claveAcceso = Modelos.Utilerias.Transform(this.tbAccess.Text);

                string acceso = Properties.Settings.Default.accesoConfig;

                if (Modelos.Utilerias.Transform(acceso).Equals(Modelos.Utilerias.Transform(claveAcceso)))
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                else
                {
                    this.ActiveControl = this.tbAccess;
                    this.tbAccess.SelectAll();
                    throw new Exception("Clave incorrecta");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // validacion
                if (string.IsNullOrEmpty(this.tbPCveAnt.Text))
                    throw new Exception("Ingrese la clave anterior");

                if (string.IsNullOrEmpty(this.tbPCveNueva.Text))
                    throw new Exception("Ingrese la clave nueva");

                if (string.IsNullOrEmpty(this.tbPConfirmCve.Text))
                    throw new Exception("Ingrese la clave a confirmar");

                // valida si la clave anterior es correcta
                string claveAcceso = Modelos.Utilerias.Transform(this.tbPCveAnt.Text);

                string acceso = Properties.Settings.Default.accesoConfig;

                if (!Modelos.Utilerias.Transform(acceso).Equals(Modelos.Utilerias.Transform(claveAcceso)))
                {
                    this.ActiveControl = this.tbPCveAnt;
                    this.tbPCveAnt.SelectAll();
                    throw new Exception("Clave anterior incorrecta");
                }

                string claveNueva = this.tbPCveNueva.Text;
                string claveConfirm = this.tbPConfirmCve.Text;

                if (!claveNueva.Equals(claveConfirm))
                {
                    this.ActiveControl = this.tbPCveNueva;
                    this.tbPConfirmCve.Text = string.Empty;
                    this.tbPCveNueva.SelectAll();
                    throw new Exception("La claves no coinciden");
                }

                string cveNAcceso = Modelos.Utilerias.Transform(this.tbPCveNueva.Text);

                Properties.Settings.Default.accesoConfig = cveNAcceso;

                Properties.Settings.Default.Save();

                MessageBox.Show("Clave Modificada!!!", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.btnPCancelar_Click(null, null);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbAccess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnAceptar_Click(null, null);
            }
        }
    }
}
