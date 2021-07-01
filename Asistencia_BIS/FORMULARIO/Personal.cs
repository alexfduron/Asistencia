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

            this.Pnl_Paginado.Visible = false;

            this.Pnl_RegistroInf.Visible = true;

            this.Pnl_RegistroInf.Dock = DockStyle.Fill;

            Menu_Personal();

        }

        private void Menu_Personal()
        {
            
            Menu_Personal Control1 = new Menu_Personal();

            Control1.Button1_Click += new EventHandler(Control1_BtnClick);
            
            if (this.Pnl_RegistroInf.Contains(Control1) == false)
            {
                this.Pnl_RegistroInf.Controls.Add(Control1);
                Control1.Dock = DockStyle.Fill;
                Control1.BringToFront();
            }
            else
            {
                Control1.BringToFront();
            }

            this.lbl_Titulo.Text = "Agregar Personal";

        }

        private void Control1_BtnClick(object sender, EventArgs e)
        {
            
            Menu_Cargo();
            
        }

        public void Menu_Cargo()
        {
            
            Menu_Cargo Control2 = new Menu_Cargo();
            
            Control2.Button2_Click += new EventHandler(Control2_BtnClick);

            if (this.Pnl_RegistroInf.Contains(Control2) == false)
            {
                this.Pnl_RegistroInf.Controls.Add(Control2);
                Control2.Dock = DockStyle.Fill;
                Control2.BringToFront();
            }
            else
            {
                Control2.BringToFront();
            }

            this.lbl_Titulo.Text = "Agregar Cargo";
            
        }

        private void Control2_BtnClick(object sender, EventArgs e)
        {
            
            MessageBox.Show("OK");

        }







    }
}
