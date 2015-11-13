using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gasolinera
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void eMPLEADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados MttoPlanes = new Empleados();
            MttoPlanes.MdiParent  = this;
            MttoPlanes.Show();
        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios MttoPlanes = new Usuarios();
            MttoPlanes.MdiParent = this;
            MttoPlanes.Show();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes MttoPlanes = new Clientes();
            MttoPlanes.MdiParent = this;
            MttoPlanes.Show();
        }

        private void pROVEEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bodegas MttoPlanes = new Bodegas();
            MttoPlanes.MdiParent = this;
            MttoPlanes.Show();
        }

        private void gASOLINAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gasolina MttoPlanes = new Gasolina();
            MttoPlanes.MdiParent = this;
            MttoPlanes.Show();
        }

       
  
    }
}
