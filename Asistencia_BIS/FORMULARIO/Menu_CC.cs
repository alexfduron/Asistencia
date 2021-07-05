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
    public partial class Menu_CC : UserControl
    {
        public Menu_CC()
        {
            InitializeComponent();
        }

        private void Menu_CC_Load(object sender, EventArgs e)
        {

            this.TLP_Botones.Controls.Remove(this.btn_Modificar);

            Mostrar_CC();

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





        //txt_CC
        private void txt_CC_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.txt_CC.Focused == false)
            {

                this.pnl_CC.BackColor = Color.DimGray;

            }
        }

        private void txt_CC_MouseLeave(object sender, EventArgs e)
        {
            if (this.txt_CC.Focused == false)
            {

                this.pnl_CC.BackColor = Color.FromArgb(64, 64, 64);

            }
        }

        private void txt_CC_Enter(object sender, EventArgs e)
        {
            this.pnl_CC.BackColor = Color.Silver;
        }

        private void txt_CC_Leave(object sender, EventArgs e)
        {
            this.pnl_CC.BackColor = Color.FromArgb(64, 64, 64);
        }




        private void txt_CC_TextChanged(object sender, EventArgs e)
        {

            Buscar_CC();

        }

        private void Buscar_CC()
        {

            DataTable Dt = new DataTable();

            Datos_CC Funcion = new Datos_CC();

            Funcion.Buscar_CC(ref Dt, this.txt_CC.Text);

            this.DGV_CC.DataSource = Dt;

            Logica_DataTable.MultiLinea(ref this.DGV_CC);

        }

        private void Mostrar_CC()
        {

            DataTable Dt = new DataTable();

            Datos_CC Funcion = new Datos_CC();

            Funcion.Mostrar_CC(ref Dt);

            this.DGV_CC.DataSource = Dt;

            Logica_DataTable.MultiLinea(ref this.DGV_CC);

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            Insertar_CC();

        }

        private void Insertar_CC()
        {

            if(string.IsNullOrEmpty(this.txt_CC.Text) == false)
            {

                Logica_CC Parametros = new Logica_CC();

                Datos_CC Funcion = new Datos_CC();

                Parametros.Centro_de_Costo = this.txt_CC.Text;

                if(Funcion.Insertar_CC(Parametros) == true)
                {

                    this.btn_Volver_Click(this, null);

                }

            }else
            {

                MessageBox.Show("Agregar un Centro de Costo", "Falta el Centro de Costo...", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



    }
}
