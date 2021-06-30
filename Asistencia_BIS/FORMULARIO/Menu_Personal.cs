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
    public partial class Menu_Personal : UserControl
    {


        /*
        private static Menu_Personal _instance;

        public static Menu_Personal Instance
        {
            get
            {
                if (Instance == null)
                {
                    _instance = new Menu_Personal();
                }
                return _instance;
            }
        }
        */
        /*
        public event EventHandler Button_Click;

        private void Button_Click(object sender, EventArgs e)
        {
            if(this.Button_Click != null)
            {
                this.Button_Click(this, e);
            }
        }
        */








        public Menu_Personal()
        {
            InitializeComponent();
        }

        private void Menu_Personal_Load(object sender, EventArgs e)
        {

            this.TLP_Botones.Controls.Remove(this.btn_Modificar);

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

            if (Funcion.Insertar_Cargo(Parametros) == true)
            {



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
        private void txt_Codigo_MouseMove(object sender, MouseEventArgs e)
        {

            if (this.txt_Codigo.Focused == false)
            {

                this.pnl_ID.BackColor = Color.DimGray;

            }

        }

        private void txt_Codigo_MouseLeave(object sender, EventArgs e)
        {

            if (this.txt_Codigo.Focused == false)
            {

                this.pnl_ID.BackColor = Color.FromArgb(64, 64, 64);

            }

        }

        private void txt_Codigo_Enter(object sender, EventArgs e)
        {

            this.pnl_ID.BackColor = Color.Silver;

        }

        private void txt_Codigo_Leave(object sender, EventArgs e)
        {

            this.pnl_ID.BackColor = Color.FromArgb(64, 64, 64);

        }


        //Texto Centro de Costo
        private void cbx_CC_MouseMove(object sender, MouseEventArgs e)
        {

            if (this.cbx_CC.Focused == false)
            {

                this.pnl_CC.BackColor = Color.DimGray;

            }

        }

        private void cbx_CC_MouseLeave(object sender, EventArgs e)
        {

            if (this.cbx_CC.Focused == false)
            {

                this.pnl_CC.BackColor = Color.FromArgb(64, 64, 64);

            }

        }

        private void cbx_CC_Enter(object sender, EventArgs e)
        {

            this.pnl_CC.BackColor = Color.Silver;

        }

        private void cbx_CC_Leave(object sender, EventArgs e)
        {

            this.pnl_CC.BackColor = Color.FromArgb(64, 64, 64);

        }


        //Texto cargo
        private void cbx_Cargo_MouseMove(object sender, MouseEventArgs e)
        {

            if (this.cbx_Cargo.Focused == false)
            {

                this.pnl_Cargo.BackColor = Color.DimGray;

            }

        }

        private void cbx_Cargo_MouseLeave(object sender, EventArgs e)
        {

            if (this.cbx_Cargo.Focused == false)
            {

                this.pnl_Cargo.BackColor = Color.FromArgb(64, 64, 64);

            }

        }

        private void cbx_Cargo_Enter(object sender, EventArgs e)
        {

            this.pnl_Cargo.BackColor = Color.Silver;

        }

        private void cbx_Cargo_Leave(object sender, EventArgs e)
        {

            this.pnl_Cargo.BackColor = Color.FromArgb(64, 64, 64);

        }


        //Texto Supervisor
        private void cbx_Supervisor_MouseMove(object sender, MouseEventArgs e)
        {

            if (this.cbx_Supervisor.Focused == false)
            {

                this.pnl_Supervisor.BackColor = Color.DimGray;

            }

        }

        private void cbx_Supervisor_MouseLeave(object sender, EventArgs e)
        {

            if (this.cbx_Supervisor.Focused == false)
            {

                this.pnl_Supervisor.BackColor = Color.FromArgb(64, 64, 64);

            }

        }

        private void cbx_Supervisor_Enter(object sender, EventArgs e)
        {

            this.pnl_Supervisor.BackColor = Color.Silver;

        }

        private void cbx_Supervisor_Leave(object sender, EventArgs e)
        {

            this.pnl_Supervisor.BackColor = Color.FromArgb(64, 64, 64);

        }

        public event EventHandler Button_Click;

        private void btn_Buscar_Cargo_Click(object sender, EventArgs e)
        {


            if(this.Button_Click != null)
            {
                this.Button_Click(this, e);
            }

            /*
            //Personal ABC = new Personal();

            //ABC.Menu_Cargo();

            Asistencia_BIS.FORMULARIO.Personal.Instance.GetTuUserControl();
            */

        }
    }
}
