using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DescargarChecadas.Negocio;
using System.IO;

namespace DescargarChecadas.GUIs
{
    public partial class frmConfiguracion : Form
    {
        IConsultasNegocio _consultasNegocio;
        private string _path = string.Empty;

        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void btnTestConn_Click(object sender, EventArgs e)
        {
            try
            {
                Modelos.ConectionString.conn = string.Format(
                            "server={0};User Id={1};password={2};database={3}",
                            this.tbServidor.Text,
                            this.tbUsuario.Text,
                            this.tbContrasenia.Text,
                            this.tbBaseDeDatos.Text);

                this._consultasNegocio = new ConsultasNegocio();

                this._consultasNegocio.pruebaConn();

                MessageBox.Show("Conexión Exitosa!!!", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Falló la conexión a la base de datos", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // validaciones
                foreach (Control x in this.groupBox1.Controls)
                {
                    if (x is TextBox)
                    {
                        if (string.IsNullOrEmpty(((TextBox)x).Text))
                            throw new Exception("Campos incompletos, Por favor verifique");
                    }
                }

                // validaciones
                foreach (Control x in this.groupBox2.Controls)
                {
                    if (x is TextBox)
                    {
                        if (string.IsNullOrEmpty(((TextBox)x).Text))
                            throw new Exception("Campos incompletos, Por favor verifique");
                    }
                }

                // define texto del archivo
                string cadena = string.Empty;

                cadena += "I_" + this.tbIP.Text + "||";
                cadena += "P_" + this.tbPuerto.Text + "||";
                cadena += "S_" + this.tbServidor.Text + "||";
                cadena += "U_" + this.tbUsuario.Text + "||";
                cadena += "C_" + this.tbContrasenia.Text + "||";
                cadena += "B_" + this.tbBaseDeDatos.Text + "||";
                cadena += "N_" + this.tbNomChecador.Text + "||";


                // prosigue con la creación del archivo
                FEncrypt.Respuesta result = FEncrypt.EncryptDncrypt.EncryptFile("milagros", cadena, this._path);

                if (result.status == FEncrypt.Estatus.ERROR)
                    throw new Exception(result.error);

                if (result.status == FEncrypt.Estatus.OK)
                {
                    Modelos.ConectionString.conn = string.Format(
                        "server={0};User Id={1};password={2};database={3}",
                        this.tbServidor.Text,
                        this.tbUsuario.Text,
                        this.tbContrasenia.Text,
                        this.tbBaseDeDatos.Text);

                    Modelos.ConectionString.ip = this.tbIP.Text;
                    Modelos.ConectionString.puerto = this.tbPuerto.Text;

                    MessageBox.Show("Se cargó correctamente la información", "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            try
            {
                string fileName = "config.dat";
                string pathConfigFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DescChec\";

                // si no existe el directorio, lo crea
                bool exists = System.IO.Directory.Exists(pathConfigFile);

                if (!exists) System.IO.Directory.CreateDirectory(pathConfigFile);

                // busca en el directorio si exite el archivo con el nombre dado
                var file = Directory.GetFiles(pathConfigFile, fileName, SearchOption.AllDirectories)
                        .FirstOrDefault();

                this._path = pathConfigFile + fileName;

                if (file != null)
                {
                    // si existe
                    // cargar los datos en los campos
                    FEncrypt.Respuesta result = FEncrypt.EncryptDncrypt.DecryptFile(this._path, "milagros");

                    if (result.status == FEncrypt.Estatus.ERROR)
                        throw new Exception(result.error);

                    if (result.status == FEncrypt.Estatus.OK)
                    {
                        string[] list = result.resultado.Split(new string[] { "||" }, StringSplitOptions.None);

                        this.tbIP.Text = list[0].Substring(2);          // IP
                        this.tbPuerto.Text = list[1].Substring(2);      // PUERTO
                        this.tbServidor.Text = list[2].Substring(2);    // servidor
                        this.tbUsuario.Text = list[3].Substring(2);     // usuario
                        this.tbContrasenia.Text = list[4].Substring(2); // contraseña
                        this.tbBaseDeDatos.Text = list[5].Substring(2); // base de datos
                        this.tbNomChecador.Text = list[6].Substring(2); // base de datos
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Configuración", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
