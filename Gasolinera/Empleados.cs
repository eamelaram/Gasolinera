using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gasolinera.Classes;
using Carssi.Classes;

namespace Gasolinera
{
    public partial class Empleados : Form
    {
        cass objCass = new cass();
        public Empleados()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            //objCass.ExecSP("InsertEmple",
            //            new string[] { "nombre", "apellido", "fechnac", "genero", "direccion", "telefono", "fecingre", "dui", "nit","estado" },
            //            new object[] { id, txtusuario.Text, pass, perfil, activo },
            //            new DbType[] { DbType.Int16, DbType.String, DbType.String, DbType.Int16, DbType.Int16 });


            this.txtnombre.Enabled = false;
            this.txtnombre.Text = "";
            this.txtapellido.Enabled = false;
            this.dtnac.Enabled = false;
            this.txtdireccion.Enabled = false;
            this.txtdireccion.Text = "";
            this.txtelefono.Enabled = false;
            this.txtelefono.Text = "";
            this.fecingre.Enabled = false;
            this.txtdui.Enabled = false;
            this.txtdui.Text ="";
            this.txtnit.Enabled = false;
            this.txtnit.Text = "";

            this.btnmuevo.Visible = true;
            this.btnguardar.Visible = false;
            this.btnmodificar.Visible = false;
            this.btncancelar.Visible = false;
            
        }

        private void btnmuevo_Click(object sender, EventArgs e)
        {
            this.txtnombre.Enabled = true ;
            this.txtnombre.Text = "";
            this.txtapellido.Enabled = true ;
            this.dtnac.Enabled = true ;
            this.txtdireccion.Enabled = true ;
            this.txtdireccion.Text = "";
            this.txtelefono.Enabled = true ;
            this.txtelefono.Text = "";
            this.fecingre.Enabled = true ;
            this.txtdui.Enabled = true ;
            this.txtdui.Text = "";
            this.txtnit.Enabled = true ;
            this.txtnit.Text = "";

            this.btnmuevo.Visible = false;
            this.btnguardar.Visible = true ;
            this.btnmodificar.Visible = false;
            this.btncancelar.Visible = true ;
        }
    }
}
