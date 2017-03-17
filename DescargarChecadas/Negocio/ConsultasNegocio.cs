using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DescargarChecadas.Datos;

namespace DescargarChecadas.Negocio
{
    public class ConsultasNegocio : IConsultasNegocio
    {
        IConsultasDatos _consultadatos;

        public ConsultasNegocio()
        {
            this._consultadatos = new ConsultasDatos();
        }


        public void pruebaConn()
        {
            this._consultadatos.pruebaConn();
        }


        public DateTime obtUltimaFecha(int numChec)
        {
            return this._consultadatos.obtUltimaFecha(numChec);
        }


        public void insertaRegistro(Modelos.AttLogs res)
        {
            this._consultadatos.insertaRegistro(res);
        }


        public bool conectaBase()
        {
            return this._consultadatos.conectaBase();
        }


        public void insertaNuevo(int idInterno)
        {
            bool existe = this._consultadatos.buscaIdInterno(idInterno);

            if(!existe)
                this._consultadatos.insertaNuevo(idInterno);
        }
    }
}
