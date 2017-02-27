using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DescargarChecadas.Modelos;
using MySql.Data.MySqlClient;

namespace DescargarChecadas.Datos
{
    public class ConsultasDatos : IConsultasDatos
    {
        // Variable que almacena el estado de la conexión a la base de datos
        IConexion _conexion;

        public ConsultasDatos()
        {
            // Establece la cadena de conexión
            _conexion = new Conexion(Modelos.ConectionString.conn);
        }

        // realiza prueba de conexion
        public void pruebaConn()
        {
            string sql =
                "select * from checadas limit 1";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (!res.ok) throw new Exception(res.numErr + ": " + res.descErr);

                    // cerrar el reader
                    res.reader.Close();

                }
            }

        }

        // obtiene la ultima fecha
        public DateTime obtUltimaFecha()
        {
            DateTime result = new DateTime();

            string sql = "SELECT MAX(fecha_hora) AS fecha_hora FROM checadas";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        if (res.reader.HasRows)
                            while (res.reader.Read())
                            {
                                result = Convert.ToDateTime(res.reader["fecha_hora"]);
                            }
                        else
                            result = new DateTime();
                    }
                    else
                        throw new Exception(res.numErr + ": " + res.descErr);

                    // cerrar el reader
                    res.reader.Close();

                }
            }

            return result;
        }

        // inserta el registro
        public void insertaRegistro(AttLogs log)
        {
            string sql = "insert into checadas (id_interno, fecha_hora, no_checador) values (@idIn, @fecha, 1)";

            int rows = 0;

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();
                string error = string.Empty;

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@idIn", log.enrolIdNumber);

                    string fechaFormato = "yyyy-MM-dd HH:mm";

                    cmd.Parameters.AddWithValue("@fecha", log.fecha.ToString(fechaFormato));
                    string s = log.fecha.ToString(fechaFormato);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, ref rows, cmd);

                    if (!res.ok) throw new Exception (res.numErr + ": " + res.descErr);
                }

            }
        }

        // prueba de conexion con la base de datos
        public bool conectaBase()
        {
            using (var conn = this._conexion.getConexion())
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch (MySqlException)
                {
                    return false;
                }
                
            }
        }
    }
}
