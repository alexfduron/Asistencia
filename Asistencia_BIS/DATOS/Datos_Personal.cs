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
    class Datos_Personal
    {

        public bool Insertar_Personal(Logica_Personal Parametros)
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

        public bool Editar_Personal(Logica_Personal Parametros)
        {

            try
            {

                Asistencia_BIS.DATOS.ConexionMaestra.Abrir();

                SqlCommand Cmd = new SqlCommand("Editar_Personal", Asistencia_BIS.DATOS.ConexionMaestra.Conectar);

                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@ID_Personal", Parametros.ID_Personal);
                Cmd.Parameters.AddWithValue("@Codigo", Parametros.Codigo);
                Cmd.Parameters.AddWithValue("@Nombre", Parametros.Nombre);
                Cmd.Parameters.AddWithValue("@Apellido", Parametros.Apellido);
                Cmd.Parameters.AddWithValue("@ID_Centro_de_Costo", Parametros.ID_Centro_de_Costo);
                Cmd.Parameters.AddWithValue("@ID_Cargo", Parametros.ID_Cargo);
                Cmd.Parameters.AddWithValue("@ID_Supervisor", Parametros.ID_Supervisor);
                Cmd.Parameters.AddWithValue("@Estado", Parametros.Estado);
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

        public bool Eliminar_Personal(Logica_Personal Parametros)
        {

            try
            {

                Asistencia_BIS.DATOS.ConexionMaestra.Abrir();

                SqlCommand Cmd = new SqlCommand("Eliminar_Personal", Asistencia_BIS.DATOS.ConexionMaestra.Conectar);

                Cmd.CommandType = CommandType.StoredProcedure;

                Cmd.Parameters.AddWithValue("@ID_Personal", Parametros.ID_Personal);

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

        public void Mostrar_Personal(ref DataTable Dt, int Desde, int Hasta)
        {

            try
            {

                Asistencia_BIS.DATOS.ConexionMaestra.Abrir();

                SqlDataAdapter Da = new SqlDataAdapter("Mostrar_Personal", Asistencia_BIS.DATOS.ConexionMaestra.Conectar);

                Da.SelectCommand.CommandType = CommandType.StoredProcedure;

                Da.SelectCommand.Parameters.AddWithValue("@Desde", Desde);

                Da.SelectCommand.Parameters.AddWithValue("@Hasta", Hasta);

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

        public void Buscar_Personal(ref DataTable Dt, int Desde, int Hasta, string Buscador)
        {

            try
            {

                Asistencia_BIS.DATOS.ConexionMaestra.Abrir();

                SqlDataAdapter Da = new SqlDataAdapter("Buscar_Personal", Asistencia_BIS.DATOS.ConexionMaestra.Conectar);

                Da.SelectCommand.CommandType = CommandType.StoredProcedure;

                Da.SelectCommand.Parameters.AddWithValue("@Desde", Desde);

                Da.SelectCommand.Parameters.AddWithValue("@Hasta", Hasta);

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
