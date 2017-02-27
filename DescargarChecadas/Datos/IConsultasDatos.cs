using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DescargarChecadas.Datos
{
    public interface IConsultasDatos
    {
        void pruebaConn();

        DateTime obtUltimaFecha();

        void insertaRegistro(Modelos.AttLogs res);

        bool conectaBase();
    }
}
