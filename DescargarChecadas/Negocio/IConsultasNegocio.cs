using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DescargarChecadas.Negocio
{
    public interface IConsultasNegocio
    {
        void pruebaConn();

        DateTime obtUltimaFecha();

        void insertaRegistro(Modelos.AttLogs res);

        bool conectaBase();
    }
}
