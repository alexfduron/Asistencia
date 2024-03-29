﻿using System;
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
    public partial class Menu_Cargo : UserControl
    {
        public Menu_Cargo()
        {
            InitializeComponent();
        }

        int ID_Cargo_Local;

        string Estado_Local;

        private void Menu_Cargo_Load(object sender, EventArgs e)
        {

            this.TLP_Botones.Controls.Remove(this.btn_Modificar);

            Mostrar_Cargo();

            this.txt_Cargo.Focus();

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




        //txt_Cargo
        private void txt_Cargo_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.txt_Cargo.Focused == false)
            {

                this.pnl_Cargo.BackColor = Color.DimGray;

            }
        }

        private void txt_Cargo_MouseLeave(object sender, EventArgs e)
        {
            if (this.txt_Cargo.Focused == false)
            {

                this.pnl_Cargo.BackColor = Color.FromArgb(64, 64, 64);

            }
        }

        private void txt_Cargo_Enter(object sender, EventArgs e)
        {
            this.pnl_Cargo.BackColor = Color.Silver;
        }

        private void txt_Cargo_Leave(object sender, EventArgs e)
        {
            this.pnl_Cargo.BackColor = Color.FromArgb(64, 64, 64);
        }




        


        private void txt_Cargo_TextChanged(object sender, EventArgs e)
        {

            Buscar_Cargo();

        }
        
        private void Buscar_Cargo()
        {

            DataTable Dt = new DataTable();

            Datos_Cargo Funcion = new Datos_Cargo();

            Funcion.Buscar_Cargo(ref Dt, this.txt_Cargo.Text);

            this.DGV_Cargo.DataSource = Dt;

            Logica_DataTable.MultiLinea(ref this.DGV_Cargo);

        }

        private void Mostrar_Cargo()
        {

            DataTable Dt = new DataTable();

            Datos_Cargo Funcion = new Datos_Cargo();

            Funcion.Mostrar_Cargo(ref Dt);

            this.DGV_Cargo.DataSource = Dt;

            Logica_DataTable.MultiLinea(ref this.DGV_Cargo);

        }

        

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            Insertar_Cargo();

        }

        private void Insertar_Cargo()
        {

            if (string.IsNullOrEmpty(this.txt_Cargo.Text) == false) {

                Logica_Cargo Parametros = new Logica_Cargo();

                Datos_Cargo Funcion = new Datos_Cargo();

                Parametros.Cargo = this.txt_Cargo.Text;

                if (Funcion.Insertar_Cargo(Parametros) == true)
                {

                    this.btn_Volver_Click(this, null);

                }

            }else
            {

                MessageBox.Show("Agregar un Cargo", "Falta el Cargo...", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {

            Editar_Cargo();

        }

        private void Editar_Cargo()
        {

            if (string.IsNullOrEmpty(this.txt_Cargo.Text) == false)
            {

                Logica_Cargo Parametros = new Logica_Cargo();

                Datos_Cargo Funcion = new Datos_Cargo();

                Parametros.ID_Cargo = ID_Cargo_Local;
                Parametros.Cargo = this.txt_Cargo.Text;
                Parametros.Estado = Estado_Local;

                if (Funcion.Editar_Cargo(Parametros) == true)
                {

                    this.btn_Volver_Click(this, null);

                }

            }
            else
            {

                MessageBox.Show("Agregar un Cargo", "Falta el Cargo...", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void DGV_Cargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == this.DGV_Cargo.Columns["Editar_Col"].Index)
            {

                ID_Cargo_Local = Convert.ToInt32(this.DGV_Cargo.SelectedCells[2].Value);

                this.txt_Cargo.Text = Convert.ToString(this.DGV_Cargo.SelectedCells[3].Value);

                Estado_Local = Convert.ToString(this.DGV_Cargo.SelectedCells[4].Value);

                this.TLP_Botones.Controls.Remove(this.btn_Guardar);

                this.TLP_Botones.Controls.Add(this.btn_Modificar, 4, 0);

                this.txt_Cargo.Focus();

                this.txt_Cargo.SelectAll();

            }
            if (e.ColumnIndex == this.DGV_Cargo.Columns["Borrar_Col"].Index)
            {



            }
            if (e.ColumnIndex == this.DGV_Cargo.Columns["Cargo"].Index)
            {



            }



        }




    }
}
