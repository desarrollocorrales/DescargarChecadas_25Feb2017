using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace DescargarChecadas.Modelos
{
    public class Conexion: IConexion
    {
        private string _cademaConexion;

        public Conexion(string cademaConexion)
        {
            this._cademaConexion = cademaConexion;
        }

        public string getCadena()
        {
            return this._cademaConexion;
        }

        public MySqlConnection getConexion()
        {
            return new MySqlConnection(this._cademaConexion);
        }
    }
}
