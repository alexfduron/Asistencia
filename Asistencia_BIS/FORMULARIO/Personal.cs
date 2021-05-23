using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        private void btn_Guardar_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_Guardar.BackgroundImage = Asistencia_BIS.Properties.Resources.Btn_Gris2__transparentimage;
        }

        private void btn_Guardar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Guardar.BackgroundImage = Asistencia_BIS.Properties.Resources.Btn_Gris3__transparentimage;
        }

        private void btn_Modificar_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_Modificar.BackgroundImage = Asistencia_BIS.Properties.Resources.Btn_Gris2__transparentimage;
        }

        private void btn_Modificar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Modificar.BackgroundImage = Asistencia_BIS.Properties.Resources.Btn_Gris3__transparentimage;
        }

        private void btn_Volver_MouseMove(object sender, MouseEventArgs e)
        {
            this.btn_Volver.BackgroundImage = Asistencia_BIS.Properties.Resources.Btn_Gris2__transparentimage;
        }

        private void btn_Volver_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Volver.BackgroundImage = Asistencia_BIS.Properties.Resources.Btn_Gris3__transparentimage;
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

            if (this.txt_ID.Focused == false)
            {

                this.pnl_ID.BackColor = Color.DimGray;

            }

        }

        private void txt_ID_MouseLeave(object sender, EventArgs e)
        {

            if (this.txt_ID.Focused == false)
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

            if (this.cb_CC.Focused == false)
            {

                this.pnl_CC.BackColor = Color.DimGray;

            }

        }

        private void cb_CC_MouseLeave(object sender, EventArgs e)
        {

            if (this.cb_CC.Focused == false)
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

            if (this.cb_Cargo.Focused == false)
            {

                this.pnl_Cargo.BackColor = Color.DimGray;

            }

        }

        private void cb_Cargo_MouseLeave(object sender, EventArgs e)
        {

            if (this.cb_Cargo.Focused == false)
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

            if (this.cb_Supervisor.Focused == false)
            {

                this.pnl_Supervisor.BackColor = Color.DimGray;

            }

        }

        private void cb_Supervisor_MouseLeave(object sender, EventArgs e)
        {

            if (this.cb_Supervisor.Focused == false)
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



    }
}
