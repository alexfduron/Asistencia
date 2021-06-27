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
    public class Datos_CC
    {

        public bool Insertar_CC(Logica_CC Parametros)
        {

            try
            {

                Asistencia_BIS.DATOS.ConexionMaestra.Abrir();

                SqlCommand Cmd = new SqlCommand("Insertar_CC", Asistencia_BIS.DATOS.ConexionMaestra.Conectar);

                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@Centro_de_Costo", Parametros.Centro_de_Costo);

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

        public bool Editar_CC(Logica_CC Parametros)
        {

            try
            {

                Asistencia_BIS.DATOS.ConexionMaestra.Abrir();

                SqlCommand Cmd = new SqlCommand("Editar_CC", Asistencia_BIS.DATOS.ConexionMaestra.Conectar);

                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@ID_Centro_de_Costo", Parametros.ID_Centro_de_Costo);
                Cmd.Parameters.AddWithValue("@Centro_de_Costo", Parametros.Centro_de_Costo);
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

        public bool Eliminar_CC(Logica_CC Parametros)
        {

            try
            {

                Asistencia_BIS.DATOS.ConexionMaestra.Abrir();

                SqlCommand Cmd = new SqlCommand("Eliminar_CC", Asistencia_BIS.DATOS.ConexionMaestra.Conectar);

                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@ID_Centro_de_Costo", Parametros.ID_Centro_de_Costo);

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

        public void Mostrar_CC(ref DataTable Dt)
        {

            try
            {

                Asistencia_BIS.DATOS.ConexionMaestra.Abrir();

                SqlDataAdapter Da = new SqlDataAdapter("Mostrar_CC", Asistencia_BIS.DATOS.ConexionMaestra.Conectar);

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

        public void Buscar_CC(ref DataTable Dt, string Buscador)
        {

            try
            {

                Asistencia_BIS.DATOS.ConexionMaestra.Abrir();

                SqlDataAdapter Da = new SqlDataAdapter("Buscar_CC", Asistencia_BIS.DATOS.ConexionMaestra.Conectar);

                Da.SelectCommand.CommandType = CommandType.StoredProcedure;

                Da.SelectCommand.Parameters.AddWithValue("@Buscador", Buscador);

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
