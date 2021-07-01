using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Asistencia_BIS.FORMULARIO
{
    public partial class Menu_Cargo : UserControl
    {
        public Menu_Cargo()
        {
            InitializeComponent();
        }

        private void Menu_Cargo_Load(object sender, EventArgs e)
        {

        }

        


        public event EventHandler Button2_Click;

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            if (this.Button2_Click != null)
            {
                this.Button2_Click(this, e);
            }
        }




    }
}
