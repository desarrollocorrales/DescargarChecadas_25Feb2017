using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DescargarChecadas.GUIs;
using System.IO;
using DescargarChecadas.Negocio;

namespace DescargarChecadas
{
    public partial class Form1 : Form
    {
        IConsultasNegocio _consultasNegocio;

        public Form1()
        {
            InitializeComponent();
        }

        //Create Standalone SDK class dynamicly.
        public zkemkeeper.CZKEM axCZKEM1 = new zkemkeeper.CZKEM();

        private bool _bIsConnected = false;//the boolean value identifies whether the device is connected
        private int iMachineNumber = 1;//the serial number of the device.After connecting the device ,this value will be changed.


        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmAcceso formA = new frmAcceso();

            var respuesta = formA.ShowDialog();

            if (respuesta == System.Windows.Forms.DialogResult.OK)
            {
                frmConfiguracion form = new frmConfiguracion();
                form.ShowDialog();

                this.Form1_Load(null, null);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // valida si ya tiene alguna clave guardada para el archivo
                string cveActual = Properties.Settings.Default.accesoConfig;

                if (string.IsNullOrEmpty(cveActual))
                {
                    string acceso = Modelos.Utilerias.Transform("p4ssw0rd");

                    Properties.Settings.Default.accesoConfig = acceso;
                    Properties.Settings.Default.Save();
                }

                string fileName = "config.dat";
                string pathConfigFile = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DescChec\";

                // si no existe el directorio, lo crea
                bool exists = System.IO.Directory.Exists(pathConfigFile);

                if (!exists) System.IO.Directory.CreateDirectory(pathConfigFile);

                // busca en el directorio si exite el archivo con el nombre dado
                var file = Directory.GetFiles(pathConfigFile, fileName, SearchOption.AllDirectories)
                        .FirstOrDefault();

                if (file == null)
                {
                    // no existe
                    // abrir el formulario para llenar la configuracion de conexion 
                    frmConfiguracion form = new frmConfiguracion();
                    form.ShowDialog();
                }
                else
                {
                    // si existe
                    // obtener la cadena de conexion del archivo
                    FEncrypt.Respuesta result = FEncrypt.EncryptDncrypt.DecryptFile(file, "milagros");

                    if (result.status == FEncrypt.Estatus.ERROR)
                        throw new Exception(result.error);

                    if (result.status == FEncrypt.Estatus.OK)
                    {
                        string[] list = result.resultado.Split(new string[] { "||" }, StringSplitOptions.None);

                        string ip = list[0].Substring(2);           // ip
                        string puerto = list[1].Substring(2);       // puerto
                        string servidor = list[2].Substring(2);     // servidor
                        string usuario = list[3].Substring(2);      // usuario
                        string contra = list[4].Substring(2);       // contraseña
                        string baseDatos = list[5].Substring(2);    // base de datos
                        string nomChecador = list[6].Substring(2);  // nombre checador

                        // si licencia pasa asigna cadena de conexion
                        Modelos.ConectionString.conn = string.Format(
                            "server={0};User Id={1};password={2};database={3}",
                            servidor, usuario, contra, baseDatos);

                        Modelos.ConectionString.ip = ip;
                        Modelos.ConectionString.puerto = puerto;

                        this.lbChecador.Text = "Checador: " + nomChecador;

                        this.lbChecador.Left = (this.ClientSize.Width - this.lbChecador.Width) / 2;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Descarga Checadores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDescargarChecadas_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Modelos.ConectionString.ip.Trim()) ||
                    string.IsNullOrEmpty(Modelos.ConectionString.puerto.Trim()))
                    throw new Exception("No se han definido los parámetros de conexión del Checador");

                if(string.IsNullOrEmpty(Modelos.ConectionString.conn.Trim()))
                    throw new Exception ("No se ha definido la cadena de conexión a la base de datos");

                string ip = Modelos.ConectionString.ip;
                int puerto = Convert.ToInt32(Modelos.ConectionString.puerto);

                // obteniendo los parametros de conexion del checador y de la base de datos
                this.agregarDetalle("Obteniendo los parametros de conexion del checador y de la base de datos");

                // conexion por ip y puerto al checador
                int idwErrorCode = 0;

                // estableciendo conexion con el checador
                this.agregarDetalle("Estableciendo conexión con el checador");

                Cursor = Cursors.WaitCursor;
                this._bIsConnected = axCZKEM1.Connect_Net(ip, puerto);
                if (this._bIsConnected)
                {
                    this.agregarDetalle("Conexión Exitosa!!!");

                    iMachineNumber = 1;//In fact,when you are using the tcp/ip communication,this parameter will be ignored,that is any integer will all right.Here we use 1.
                    axCZKEM1.RegEvent(iMachineNumber, 65535);//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
                }
                else
                {
                    axCZKEM1.GetLastError(ref idwErrorCode);
                    throw new Exception("No se puede conectar, ErrorCode=" + idwErrorCode.ToString());
                }

                // inicializa clase de conexion a la base de datos
                this._consultasNegocio = new ConsultasNegocio();

                // conectando con la base de datos
                this.agregarDetalle("Conectando con la base de datos");
                bool conectaBd = this._consultasNegocio.conectaBase();

                if (conectaBd)
                    this.agregarDetalle("Conexión Exitosa!!!");
                else
                    throw new Exception("Problemas al conectar con la base de datos");

                // obtener la ultmia checada
                this.agregarDetalle("Obteniendo la última fecha de registro");
                DateTime ultFecha = this._consultasNegocio.obtUltimaFecha();
                this.agregarDetalle("Fecha: " + ultFecha.ToString("yyyy-MM-dd HH:mm"));

                // obtiene checadas
                this.agregarDetalle("Obteniendo los registros del checador");
                List<Modelos.AttLogs> resultado = this.obtieneChecadas();
                List<Modelos.AttLogs> traspaso = resultado.FindAll(fl => fl.fecha >= ultFecha);

                foreach (Modelos.AttLogs res in traspaso)
                {
                    try
                    {                        
                        this._consultasNegocio.insertaRegistro(res);

                        // imprime mensajes en pantalla
                        this.agregarDetalle("Registro Agregado: IdInterno: " + res.enrolIdNumber + "\tFecha: " + res.fecha.ToString("yyyy-MM-dd HH:mm"));
                    }
                    catch (Exception EX)
                    {
                        if (EX.Message.ToLower().Contains("duplicate entry"))
                        {
                            this.agregarDetalle(string.Format("El registro con IdInteno: {0} y FechaHora: {1} ya existe.", res.enrolIdNumber, res.fecha.ToString("yyyy-MM-dd HH:mm")));
                            Application.DoEvents();
                            continue;
                        }

                       throw new Exception(EX.Message);
                    }

                }

                // proceso concluido
                this.agregarDetalle("Proceso Concluido");

                // desconectar checador
                this.agregarDetalle("Cerrando conexión con el checador");
                axCZKEM1.Disconnect();
                this._bIsConnected = false;

                Cursor = Cursors.Default;
            }
            catch (Exception Ex)
            {
                Cursor = Cursors.Default;
                this.agregarDetalle("Error:" + Ex.Message);
                MessageBox.Show(Ex.Message, "Descarga Checadores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private List<Modelos.AttLogs> obtieneChecadas()
        {
            List<Modelos.AttLogs> result = new List<Modelos.AttLogs>();
            Modelos.AttLogs ent;

            int idwEnrollNumber = 0;
            int idwVerifyMode = 0;
            int idwInOutMode = 0;
            string dwTimestr = string.Empty;

            int idwErrorCode = 0;

            Cursor = Cursors.WaitCursor;
            
            axCZKEM1.EnableDevice(iMachineNumber, false); // disable the device

            if (axCZKEM1.ReadGeneralLogData(iMachineNumber)) // read all the attendance records to the memory
            {
                while (axCZKEM1.GetGeneralLogDataStr(iMachineNumber, ref idwEnrollNumber, ref idwVerifyMode, ref idwInOutMode, ref dwTimestr)) // get records from the memory
                {
                    ent = new Modelos.AttLogs();

                    ent.enrolIdNumber = idwEnrollNumber;
                    ent.fecha = Convert.ToDateTime(dwTimestr);

                    result.Add(ent);
                }
            }
            else
            {
                Cursor = Cursors.Default;
                axCZKEM1.GetLastError(ref idwErrorCode);

                if (idwErrorCode != 0)
                {
                    this.agregarDetalle("Lectura de información del checador falló. ErrorCode: " + idwErrorCode.ToString());
                    throw new Exception("Lectura de información del checador falló. ErrorCode: " + idwErrorCode.ToString());
                }
                else
                {
                    this.agregarDetalle("No hay informacion en el Checador");
                    throw new Exception("No hay informacion en el Checador");
                }
            }

            axCZKEM1.EnableDevice(iMachineNumber, true);//enable the device
            Cursor = Cursors.Default;

            return result;
        }

        private void agregarDetalle(string mensaje)
        {
            try
            {
                this.tbResultados.Paste(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ": " + mensaje + Environment.NewLine);
            }
            catch
            {
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
