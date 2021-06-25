using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//importamos librerias para SQL
using System.Data;
using System.Data.SqlClient;

//importamos la clase Logica
using Asistencia_BIS.LOGICA;

//importamos la libreria para MsgBox
using System.Windows.Forms;

namespace Asistencia_BIS.DATO
{
    class Datos_Personal
    {

        public bool Insertar_Personal(LogicaPersonal Parametros)
        {

            try
            {

                Asistencia_BIS.DATOS.ConexionMaestra.Abrir();

                SqlCommand Cmd = new SqlCommand("Insertar_Personal", Asistencia_BIS.DATOS.ConexionMaestra.Conectar);

                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@Codigo", Parametros.Codigo);
                Cmd.Parameters.AddWithValue("@Nombre", Parametros.Nombre);
                Cmd.Parameters.AddWithValue("@Apellido", Parametros.Apellido);
                Cmd.Parameters.AddWithValue("@ID_Centro_de_Costo", Parametros.ID_Centro_de_Costo);
                Cmd.Parameters.AddWithValue("@ID_Cargo", Parametros.ID_Cargo);
                Cmd.Parameters.AddWithValue("@ID_Supervisor", Parametros.ID_Supervisor);

                Cmd.Parameters.AddWithValue("@Foto", Parametros.Foto);

                Cmd.ExecuteNonQuery();

                return true;



            }
            catch (Exception ex)
            {

                //ex.Message muestra el resumen del error (se usa para mostrar el mensaje del SQL)
                //ex.StackTrace muestra el mensaje completo (numero de linea, clase, form, folder, no muestra error SQL)
                MessageBox.Show(ex.Message);

                return false;

            }

            finally
            {

                Asistencia_BIS.DATOS.ConexionMaestra.Cerrar();

            }

        }

    }
}
