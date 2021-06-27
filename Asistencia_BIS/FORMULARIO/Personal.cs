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

//<div>Iconos diseñados por <a href="https://www.flaticon.es/autores/smashicons" title="Smashicons">Smashicons</a> from <a href="https://www.flaticon.es/" title="Flaticon">www.flaticon.es</a></div>

namespace Asistencia_BIS.FORMULARIO
{
    public partial class Personal : UserControl
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void Personal_Load(object sender, EventArgs e)
        {

            this.TLP_Botones.Controls.Remove(this.btn_Modificar);

        }

        private void cb_Supervisor_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        //Btn_Pag_Ant
        private void btn_Pag_Ant_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_Pag_Ant.BackgroundImage = Asistencia_BIS.Properties.Resources.Btn_L1_transparent;
        }

        private void btn_Pag_Ant_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Pag_Ant.BackgroundImage = Asistencia_BIS.Properties.Resources.Btn_L2_transparent;
        }

        //Btn_Pag_Sig
        private void btn_Pag_Sig_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_Pag_Sig.BackgroundImage = Asistencia_BIS.Properties.Resources.Btn_R1_transparent;
        }

        private void btn_Pag_Sig_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Pag_Sig.BackgroundImage = Asistencia_BIS.Properties.Resources.Btn_R2_transparent;
        }

        //Btn_Pri_Pag
        private void btn_Pri_Pag_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_Pri_Pag.BackgroundImage = Asistencia_BIS.Properties.Resources.Btn_LL1_transparent;
        }

        private void btn_Pri_Pag_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Pri_Pag.BackgroundImage = Asistencia_BIS.Properties.Resources.Btn_LL2_transparent;
        }

        //Btn_Ult_Pag
        private void btn_Ult_Pag_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_Ult_Pag.BackgroundImage = Asistencia_BIS.Properties.Resources.Btn_RR1_transparent;
        }

        private void btn_Ult_Pag_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Ult_Pag.BackgroundImage = Asistencia_BIS.Properties.Resources.Btn_RR2_transparent;
        }




        //Texto Buscar
        private void txt_Buscar_MouseMove(object sender, MouseEventArgs e)
        {

            if (this.txt_Buscar.Focused == false)
            {

                this.pnl_Buscar.BackColor = Color.DimGray;

            }

        }

        private void txt_Buscar_MouseLeave(object sender, EventArgs e)
        {

            if (this.txt_Buscar.Focused == false)
            {

                this.pnl_Buscar.BackColor = Color.FromArgb(64, 64, 64);

            }

        }

        private void txt_Buscar_Enter(object sender, EventArgs e)
        {

            this.pnl_Buscar.BackColor = Color.Silver;

        }

        private void txt_Buscar_Leave(object sender, EventArgs e)
        {

            this.pnl_Buscar.BackColor = Color.FromArgb(64, 64, 64);

        }


        //Texto Nombre
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

        //Texto Apellido
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


        //Texto Codigo
        private void txt_ID_MouseMove(object sender, MouseEventArgs e)
        {

            if (this.txt_Codigo.Focused == false)
            {

                this.pnl_ID.BackColor = Color.DimGray;

            }

        }

        private void txt_ID_MouseLeave(object sender, EventArgs e)
        {

            if (this.txt_Codigo.Focused == false)
            {

                this.pnl_ID.BackColor = Color.FromArgb(64, 64, 64);

            }

        }

        private void txt_ID_Enter(object sender, EventArgs e)
        {

            this.pnl_ID.BackColor = Color.Silver;

        }

        private void txt_ID_Leave(object sender, EventArgs e)
        {

            this.pnl_ID.BackColor = Color.FromArgb(64, 64, 64);

        }


        //Texto Centro de Costo
        private void cb_CC_MouseMove(object sender, MouseEventArgs e)
        {

            if (this.cbx_CC.Focused == false)
            {

                this.pnl_CC.BackColor = Color.DimGray;

            }

        }

        private void cb_CC_MouseLeave(object sender, EventArgs e)
        {

            if (this.cbx_CC.Focused == false)
            {

                this.pnl_CC.BackColor = Color.FromArgb(64, 64, 64);

            }

        }

        private void cb_CC_Enter(object sender, EventArgs e)
        {

            this.pnl_CC.BackColor = Color.Silver;

        }

        private void cb_CC_Leave(object sender, EventArgs e)
        {

            this.pnl_CC.BackColor = Color.FromArgb(64, 64, 64);

        }


        //Texto cargo
        private void cb_Cargo_MouseMove(object sender, MouseEventArgs e)
        {

            if (this.cbx_Cargo.Focused == false)
            {

                this.pnl_Cargo.BackColor = Color.DimGray;

            }

        }

        private void cb_Cargo_MouseLeave(object sender, EventArgs e)
        {

            if (this.cbx_Cargo.Focused == false)
            {

                this.pnl_Cargo.BackColor = Color.FromArgb(64, 64, 64);

            }

        }

        private void cb_Cargo_Enter(object sender, EventArgs e)
        {

            this.pnl_Cargo.BackColor = Color.Silver;

        }

        private void cb_Cargo_Leave(object sender, EventArgs e)
        {

            this.pnl_Cargo.BackColor = Color.FromArgb(64, 64, 64);

        }


        //Texto Supervisor
        private void cb_Supervisor_MouseMove(object sender, MouseEventArgs e)
        {

            if (this.cbx_Supervisor.Focused == false)
            {

                this.pnl_Supervisor.BackColor = Color.DimGray;

            }

        }

        private void cb_Supervisor_MouseLeave(object sender, EventArgs e)
        {

            if (this.cbx_Supervisor.Focused == false)
            {

                this.pnl_Supervisor.BackColor = Color.FromArgb(64, 64, 64);

            }

        }

        private void cb_Supervisor_Enter(object sender, EventArgs e)
        {

            this.pnl_Supervisor.BackColor = Color.Silver;

        }

        private void cb_Supervisor_Leave(object sender, EventArgs e)
        {

            this.pnl_Supervisor.BackColor = Color.FromArgb(64, 64, 64);

        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            this.lbl_Titulo.Text = "Agregar Personal";

            this.Pnl_Paginado.Visible = false;

            this.Pnl_RegistroInf.Visible = true;

            this.Pnl_RegistroInf.Dock = DockStyle.Fill;

            this.Pnl_RegistroSup.Visible = true;

            this.TLP_Botones.Controls.Remove(this.btn_Modificar);

            TAM_DT Centrado = new TAM_DT();

            Centrado.CentrarControl(this.Pnl_RegistroSup);

            Limpiar();

        }

        private void Limpiar()
        {

            this.txt_Codigo.Clear();

            this.txt_Nombre.Clear();

            this.txt_Apellido.Clear();

            this.cbx_CC.Text = "";

            this.cbx_Cargo.Text = "";

            this.cbx_Supervisor.Text = "";

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {



        }

        private void Insertar_Personal()
        {

            Logica_Personal Parametros = new Logica_Personal();

            Datos_Personal Funcion = new Datos_Personal();

            Parametros.Codigo = this.txt_Codigo.Text;

            Parametros.Nombre = this.txt_Nombre.Text;

            Parametros.Apellido = this.txt_Apellido.Text;



        }

        private void Insertar_Cargo()
        {

            Logica_Cargo Parametros = new Logica_Cargo();

            Datos_Cargo Funcion = new Datos_Cargo();

            Parametros.Cargo = cbx_Cargo.Text;

            if(Funcion.Insertar_Cargo(Parametros) == true)
            {



            }

        }

    }
}
