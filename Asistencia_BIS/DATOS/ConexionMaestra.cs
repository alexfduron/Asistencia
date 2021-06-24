using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//importamos librerias para SQL
using System.Data;
using System.Data.SqlClient;

namespace Asistencia_BIS.DATOS
{
    public class ConexionMaestra
    {

        public static string Conexion = "";

        public static SqlConnection Conectar = new SqlConnection(Conexion);

    }
}
