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

namespace Asistencia_BIS.DATOS
{
    public class Datos_Super
    {

        public bool Insertar_Supervisor(Logica_Super Parametros)
        {

            try
            {

                Asistencia_BIS.DATOS.ConexionMaestra.Abrir();

                SqlCommand Cmd = new SqlCommand("Insertar_Super", Asistencia_BIS.DATOS.ConexionMaestra.Conectar);

                Cmd.CommandType = CommandType.StoredProcedure;
                
                Cmd.Parameters.AddWithValue("@Nombre", Parametros.Nombre.Trim());
                Cmd.Parameters.AddWithValue("@Apellido", Parametros.Apellido.Trim());
                
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

        public bool Editar_Supervisor(Logica_Super Parametros)
        {

            try
            {

                Asistencia_BIS.DATOS.ConexionMaestra.Abrir();

                SqlCommand Cmd = new SqlCommand("Editar_Super", Asistencia_BIS.DATOS.ConexionMaestra.Conectar);

                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@ID_Supervisor", Parametros.ID_Supervisor);
                Cmd.Parameters.AddWithValue("@Nombre", Parametros.Nombre);
                Cmd.Parameters.AddWithValue("@Apellido", Parametros.Apellido);
                Cmd.Parameters.AddWithValue("@Estado", Parametros.Estado);

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

        public bool Eliminar_Supervisor(Logica_Super Parametros)
        {

            try
            {

                Asistencia_BIS.DATOS.ConexionMaestra.Abrir();

                SqlCommand Cmd = new SqlCommand("Eliminar_Super", Asistencia_BIS.DATOS.ConexionMaestra.Conectar);

                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@ID_Supervisor", Parametros.ID_Supervisor);

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

        public void Mostrar_Supervisor(ref DataTable Dt)
        {

            try
            {

                Asistencia_BIS.DATOS.ConexionMaestra.Abrir();

                SqlDataAdapter Da = new SqlDataAdapter("Mostrar_Super", Asistencia_BIS.DATOS.ConexionMaestra.Conectar);

                Da.SelectCommand.CommandType = CommandType.StoredProcedure;

                Da.Fill(Dt);

            }
            catch (Exception ex)
            {

                //ex.Message muestra el resumen del error (se usa para mostrar el mensaje del SQL)
                //ex.StackTrace muestra el mensaje completo (numero de linea, clase, form, folder, no muestra error SQL)
                MessageBox.Show(ex.StackTrace);

            }

            finally
            {

                Asistencia_BIS.DATOS.ConexionMaestra.Cerrar();

            }

        }

        public void Buscar_Supervisor(ref DataTable Dt, string Buscador_Nombre, string Buscador_Apellido)
        {

            try
            {

                Asistencia_BIS.DATOS.ConexionMaestra.Abrir();

                SqlDataAdapter Da = new SqlDataAdapter("Buscar_Super", Asistencia_BIS.DATOS.ConexionMaestra.Conectar);

                Da.SelectCommand.CommandType = CommandType.StoredProcedure;

                Da.SelectCommand.Parameters.AddWithValue("@Buscador_Nombre", Buscador_Nombre);

                Da.SelectCommand.Parameters.AddWithValue("@Buscador_Apellido", Buscador_Apellido);

                Da.Fill(Dt);

            }
            catch (Exception ex)
            {

                //ex.Message muestra el resumen del error (se usa para mostrar el mensaje del SQL)
                //ex.StackTrace muestra el mensaje completo (numero de linea, clase, form, folder, no muestra error SQL)
                MessageBox.Show(ex.StackTrace);

            }

            finally
            {

                Asistencia_BIS.DATOS.ConexionMaestra.Cerrar();

            }

        }

    }
}
