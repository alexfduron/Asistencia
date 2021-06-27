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



        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            this.lbl_Titulo.Text = "Agregar Personal";

            this.Pnl_Paginado.Visible = false;

            this.Pnl_RegistroInf.Visible = true;

            this.Pnl_RegistroInf.Dock = DockStyle.Fill;

            Menu_Personal Control1 = new Menu_Personal();

            this.Pnl_RegistroInf.Controls.Clear();

            Control1.Dock = DockStyle.Fill;

            this.Pnl_RegistroInf.Controls.Add(Control1);


            

        }

        

        private void btn_Guardar_Click(object sender, EventArgs e)
        {



        }

        

        

    }
}
