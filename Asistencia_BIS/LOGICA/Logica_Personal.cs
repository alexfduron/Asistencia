using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//importamos la libreria para el DataGridView y los Controles
using System.Windows.Forms;

//importamos la libreria para el Color y las Fuentes
using System.Drawing;

namespace Asistencia_BIS.LOGICA
{
    public class Logica_Personal
    {

        public int ID_Personal
        {
            get;set;
        }

        public string Codigo
        {
            get;set;
        }

        public string Nombre
        {
            get;set;
        }

        public string Apellido
        {
            get;set;
        }

        public int ID_Centro_de_Costo
        {
            get;set;
        }

        public int ID_Cargo
        {
            get;set;
        }

        public int ID_Supervisor
        {
            get;set;
        }

        public string Estado
        {
            get;set;
        }

        public byte[] Foto
        {
            get;set;
        }

    }

    class TAM_DT
    {

        public void MultiLinea(DataGridView Lista)
        {

            Lista.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Lista.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            Lista.DefaultCellStyle.BackColor = Color.Black;

            Lista.DefaultCellStyle.Font = new Font("Consolas", 20, FontStyle.Regular);

            Lista.DefaultCellStyle.ForeColor = Color.White;

            for (int k = 0; k < Lista.Rows.Count; k++)
            {
                Lista.Rows[k].Height = 50;
            }

            for (int j = 0; j < Lista.Columns.Count; j++)
            {
                if (Lista.Columns[j] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)Lista.Columns[j]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    continue;
                }
            }


            Lista.RowHeadersVisible = false;


            Lista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            Lista.ColumnHeadersHeight = 50;

            Lista.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Lista.EnableHeadersVisualStyles = false;

            DataGridViewCellStyle Estilo_Cabecera = new DataGridViewCellStyle();

            Estilo_Cabecera.BackColor = Color.Black;

            Estilo_Cabecera.ForeColor = Color.White;

            Estilo_Cabecera.Font = new Font("Consolas", 20, FontStyle.Bold);

            Lista.ColumnHeadersDefaultCellStyle = Estilo_Cabecera;



            Lista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            Lista.BackgroundColor = Color.Black;

            Lista.BorderStyle = BorderStyle.Fixed3D;

            Lista.Dock = DockStyle.Fill;

            Lista.MultiSelect = false;

        }

        public void CentrarControl(object xControl)
        {

            Control yControl = xControl as Control;

            yControl.Top = (yControl.Parent.ClientSize.Height - yControl.Height) / 2;

            yControl.Left = (yControl.Parent.ClientSize.Width - yControl.Width) / 2;

        }

        public void CentrarTopControl(object xControl)
        {

            Control yControl = xControl as Control;

            yControl.Top = 0;

            yControl.Left = (yControl.Parent.ClientSize.Width - yControl.Width) / 2;

        }

        public void CentrarBottomControl(object xControl)
        {

            Control yControl = xControl as Control;

            yControl.Top = yControl.Parent.ClientSize.Height - yControl.Height;

            yControl.Left = (yControl.Parent.ClientSize.Width - yControl.Width) / 2;

        }

        public void CentrarLeftControl(object xControl)
        {

            Control yControl = xControl as Control;

            yControl.Top = (yControl.Parent.ClientSize.Height - yControl.Height) / 2;

            yControl.Left = 0;

        }

        public void CentrarRightControl(object xControl)
        {

            Control yControl = xControl as Control;

            yControl.Top = (yControl.Parent.ClientSize.Height - yControl.Height) / 2;

            yControl.Left = yControl.Parent.ClientSize.Width - yControl.Width;

        }

    }

}
