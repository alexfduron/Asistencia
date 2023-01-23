using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Asistencia_BIS.FORMULARIO
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.pnl_Bienvenido.Dock = DockStyle.Fill;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Personal_Click(object sender, EventArgs e)
        {

            Personal Control1 = new Personal();

            this.pnl_Bienvenido.Controls.Clear();

            Control1.Dock = DockStyle.Fill;

            this.pnl_Bienvenido.Controls.Add(Control1);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
