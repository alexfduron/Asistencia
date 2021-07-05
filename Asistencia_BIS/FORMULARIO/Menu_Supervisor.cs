using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//importamos la clase Logica y Datos
using Asistencia_BIS.LOGICA;
using Asistencia_BIS.DATOS;

namespace Asistencia_BIS.FORMULARIO
{
    public partial class Menu_Supervisor : UserControl
    {
        public Menu_Supervisor()
        {
            InitializeComponent();
        }

        private void Menu_Supervisor_Load(object sender, EventArgs e)
        {

            this.TLP_Botones.Controls.Remove(this.btn_Modificar);

            Mostrar_Supervisor();

        }






        public event EventHandler Click_Menu_Personal;

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            if (this.Click_Menu_Personal != null)
            {
                this.Click_Menu_Personal(this, e);
            }
        }



        //Botones
        //Btn_Guardar
        private void btn_Guardar_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_Guardar.BackgroundImage = Asistencia_BIS.Properties.Resources.Btn_Gris2__transparentimage;
        }

        private void btn_Guardar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Guardar.BackgroundImage = Asistencia_BIS.Properties.Resources.Btn_Gris3__transparentimage;
        }

        //Btn_Modificar
        private void btn_Modificar_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_Modificar.BackgroundImage = Asistencia_BIS.Properties.Resources.Btn_Gris2__transparentimage;
        }

        private void btn_Modificar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Modificar.BackgroundImage = Asistencia_BIS.Properties.Resources.Btn_Gris3__transparentimage;
        }

        //Btn_Volver
        private void btn_Volver_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_Volver.BackgroundImage = Asistencia_BIS.Properties.Resources.Btn_Gris2__transparentimage;
        }

        private void btn_Volver_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Volver.BackgroundImage = Asistencia_BIS.Properties.Resources.Btn_Gris3__transparentimage;
        }




        //txt_Nombre
        private void txt_Nombre_MouseMove(object sender, MouseEventArgs e)
        {

            if (this.txt_Nombre.Focused == false)
            {

                this.pnl_Nombre.BackColor = Color.DimGray;

            }

        }

        private void txt_Nombre_MouseLeave(object sender, EventArgs e)
        {

            if (this.txt_Nombre.Focused == false)
            {

                this.pnl_Nombre.BackColor = Color.FromArgb(64, 64, 64);

            }

        }

        private void txt_Nombre_Enter(object sender, EventArgs e)
        {

            this.pnl_Nombre.BackColor = Color.Silver;

        }

        private void txt_Nombre_Leave(object sender, EventArgs e)
        {

            this.pnl_Nombre.BackColor = Color.FromArgb(64, 64, 64);

        }



        //txt_Apellido
        private void txt_Apellido_MouseMove(object sender, MouseEventArgs e)
        {

            if (this.txt_Apellido.Focused == false)
            {

                this.pnl_Apellido.BackColor = Color.DimGray;

            }

        }

        private void txt_Apellido_MouseLeave(object sender, EventArgs e)
        {

            if (this.txt_Apellido.Focused == false)
            {

                this.pnl_Apellido.BackColor = Color.FromArgb(64, 64, 64);

            }

        }

        private void txt_Apellido_Enter(object sender, EventArgs e)
        {

            this.pnl_Apellido.BackColor = Color.Silver;

        }

        private void txt_Apellido_Leave(object sender, EventArgs e)
        {

            this.pnl_Apellido.BackColor = Color.FromArgb(64, 64, 64);

        }





        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {

            Buscar_Supervisor();

        }

        private void txt_Apellido_TextChanged(object sender, EventArgs e)
        {

            Buscar_Supervisor();

        }


        private void Buscar_Supervisor()
        {

            DataTable Dt = new DataTable();

            Datos_Super Funcion = new Datos_Super();

            Funcion.Buscar_Supervisor(ref Dt, this.txt_Nombre.Text, this.txt_Apellido.Text);

            this.DGV_Supervisor.DataSource = Dt;

            Logica_DataTable.MultiLinea(ref this.DGV_Supervisor);

        }

        private void Mostrar_Supervisor()
        {

            DataTable Dt = new DataTable();

            Datos_Super Funcion = new Datos_Super();

            Funcion.Mostrar_Supervisor(ref Dt);

            this.DGV_Supervisor.DataSource = Dt;

            Logica_DataTable.MultiLinea(ref DGV_Supervisor);

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            Insertar_Supervisor();

        }

        private void Insertar_Supervisor()
        {

            if(string.IsNullOrEmpty(this.txt_Nombre.Text) == false)
            {

                if(string.IsNullOrEmpty(this.txt_Apellido.Text) == false)
                {

                    Logica_Super Parametros = new Logica_Super();

                    Datos_Super Funcion = new Datos_Super();

                    Parametros.Nombre = this.txt_Nombre.Text;
                    Parametros.Apellido = this.txt_Apellido.Text;

                    if(Funcion.Insertar_Supervisor(Parametros) == true)
                    {

                        this.btn_Volver_Click(this, null);

                    }

                }else
                {

                    MessageBox.Show("Agregar un Apellido", "Falta el Apellido...", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }else
            {

                MessageBox.Show("Agregar un Nombre", "Falta el Nombre...", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }





    }
}
