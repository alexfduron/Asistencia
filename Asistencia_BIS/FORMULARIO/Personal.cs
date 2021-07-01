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

        private void Funcion_Menu_Personal(object sender, EventArgs e)
        {

            Menu_Personal();

        }

        private void Menu_Personal()
        {
            
            Menu_Personal Control_Menu_Personal = new Menu_Personal();

            Control_Menu_Personal.Click_Buscar_Cargo += new EventHandler(Funcion_Buscar_Cargo);
            Control_Menu_Personal.Click_Buscar_CC += new EventHandler(Funcion_Buscar_CC);
            Control_Menu_Personal.Click_Buscar_Supervisor += new EventHandler(Funcion_Buscar_Supervisor);
            
            if (this.Pnl_RegistroInf.Contains(Control_Menu_Personal) == false)
            {
                this.Pnl_RegistroInf.Controls.Add(Control_Menu_Personal);
                Control_Menu_Personal.Dock = DockStyle.Fill;
                Control_Menu_Personal.BringToFront();
            }
            else
            {
                Control_Menu_Personal.BringToFront();
            }

            this.lbl_Titulo.Text = "Agregar Personal";

        }





        private void Funcion_Buscar_Cargo(object sender, EventArgs e)
        {
            
            Menu_Cargo();
            
        }

        private void Menu_Cargo()
        {
            
            Menu_Cargo Control_Menu_Cargo = new Menu_Cargo();

            Control_Menu_Cargo.Click_Menu_Personal += new EventHandler(Funcion_Menu_Personal);

            if (this.Pnl_RegistroInf.Contains(Control_Menu_Cargo) == false)
            {
                this.Pnl_RegistroInf.Controls.Add(Control_Menu_Cargo);
                Control_Menu_Cargo.Dock = DockStyle.Fill;
                Control_Menu_Cargo.BringToFront();
            }
            else
            {
                Control_Menu_Cargo.BringToFront();
            }

            this.lbl_Titulo.Text = "Agregar Cargo";
            
        }




        private void Funcion_Buscar_CC(object sender, EventArgs e)
        {

            Menu_CC();

        }

        private void Menu_CC()
        {

            Menu_CC Control_Menu_CC = new Menu_CC();

            Control_Menu_CC.Click_Menu_Personal += new EventHandler(Funcion_Menu_Personal);

            if (this.Pnl_RegistroInf.Contains(Control_Menu_CC) == false)
            {
                this.Pnl_RegistroInf.Controls.Add(Control_Menu_CC);
                Control_Menu_CC.Dock = DockStyle.Fill;
                Control_Menu_CC.BringToFront();
            }
            else
            {
                Control_Menu_CC.BringToFront();
            }

            this.lbl_Titulo.Text = "Agregar Centro de Costo";

        }





        private void Funcion_Buscar_Supervisor(object sender, EventArgs e)
        {

            Menu_Supervisor();

        }

        private void Menu_Supervisor()
        {

            Menu_Supervisor Control_Menu_Supervisor = new Menu_Supervisor();

            Control_Menu_Supervisor.Click_Menu_Personal += new EventHandler(Funcion_Menu_Personal);

            if (this.Pnl_RegistroInf.Contains(Control_Menu_Supervisor) == false)
            {
                this.Pnl_RegistroInf.Controls.Add(Control_Menu_Supervisor);
                Control_Menu_Supervisor.Dock = DockStyle.Fill;
                Control_Menu_Supervisor.BringToFront();
            }
            else
            {
                Control_Menu_Supervisor.BringToFront();
            }

            this.lbl_Titulo.Text = "Agregar Supervisor";

        }




    }
}
