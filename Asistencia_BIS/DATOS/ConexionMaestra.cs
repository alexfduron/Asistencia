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

        public static string Conexion = @"Data Source = BISW_PRODUC19\SQLEXPRESS; " +
                                        "Initial Catalog = PERSONAL_BIS; " +
                                        "Integrated Security = true";

        public static SqlConnection Conectar = new SqlConnection(Conexion);

        public static void Abrir()
        {

            if(Conectar.State == ConnectionState.Closed)
            {

                Conectar.Open();

            }

        }

        public static void Cerrar()
        {

            if(Conectar.State == ConnectionState.Open)
            {

                Conectar.Close();

            }

        }

    }
}
