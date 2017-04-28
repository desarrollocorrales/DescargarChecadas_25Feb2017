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
        public DateTime obtUltimaFecha(int numChec)
        {
            DateTime result = new DateTime();

            string sql = "SELECT MAX(fecha_hora) AS fecha_hora FROM checadas where no_checador = @numC";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@numC", numChec);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            if (res.reader["fecha_hora"] == DBNull.Value)
                                result = new DateTime(1900, 1, 1, 0, 0, 0);
                            else
                                result = Convert.ToDateTime(res.reader["fecha_hora"]);
                        }
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
            string sql = "insert into checadas (id_interno, fecha_hora, no_checador) values (@idIn, @fecha, @noCh)";

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
                    cmd.Parameters.AddWithValue("@noCh", log.noChecador);

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

        // crea un nuevo usuario como pendiente
        public void insertaNuevo(int idInterno)
        {
            string sql = "INSERT INTO empleados(id_interno, id_depto, nombre, activado, variado) VALUES (@idInterno, 1, '<PENDIENTE>', 1, 1)";

            int rows = 0;

            using (var conn = this._conexion.getConexion())
            {
                conn.Open();
                string error = string.Empty;

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@idInterno", idInterno);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, ref rows, cmd);

                    if (!res.ok) throw new Exception(res.numErr + ": " + res.descErr);
                }

            }
        }

        // busca si ya esta dado de alta el registro
        public bool buscaIdInterno(int idInterno)
        {
            bool result = false;

            string sql = "SELECT id_interno FROM empleados WHERE id_interno = @idInterno";

            // define conexion con la cadena de conexion
            using (var conn = this._conexion.getConexion())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    cmd.Parameters.AddWithValue("@idInterno", idInterno);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        if (res.reader.HasRows)
                            result = true;
                        else
                            result = false;
                    }
                    else
                        throw new Exception(res.numErr + ": " + res.descErr);

                    // cerrar el reader
                    res.reader.Close();

                }
            }

            return result;
        }
    }
}
