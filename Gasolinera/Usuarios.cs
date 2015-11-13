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
    public partial class Usuarios : Form
    {
        cass objCass = new cass();
        Encryptor descriptar = new Encryptor();
        public Usuarios()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

            this.txtbusqueda.Text = "";
            Busqueda MttoPlanes = new Busqueda();
            MttoPlanes.ShowDialog();
            this.txtbusqueda.Text = Static.busqueda;
            this.txtidemple.Text = Convert.ToString (Static.idemple);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbuscar.SelectedItem .ToString() == "NOMBRE")
            {
                txtbusq.Visible = true;
                btnbuscar.Visible = true;
                cmbperfilb.Visible = false;
                chkacb.Visible = false;
            }
            if (cmbbuscar.SelectedItem.ToString() == "APELLIDO")
            {
                txtbusq.Visible = true;
                btnbuscar.Visible = true;
                cmbperfilb.Visible = false;
                chkacb.Visible = false;
            }
            if (cmbbuscar.SelectedItem.ToString() == "USUARIO")
            {
                txtbusq.Visible = true;
                btnbuscar.Visible = true;
                cmbperfilb.Visible = false;
                chkacb.Visible = false;
            }
            if (cmbbuscar.SelectedItem.ToString() == "PUESTO")
            {
                cmbperfilb.Visible = true;
                txtbusq.Visible = false;
                chkacb.Visible = false;
                btnbuscar.Visible = true;
            }
            if (cmbbuscar.SelectedItem.ToString() == "ACTIVOS / INACTIVOS")
            {
                chkacb.Visible = true;
                cmbperfilb.Visible = false ;
                txtbusq.Visible = false;
                btnbuscar.Visible = true; 
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Int16 activo;
            if (chkacb.Checked == true)
            {
                activo = 1;
            }
            else
            {
                activo = 2;
            }
        }

        private void btnmuevo_Click(object sender, EventArgs e)
        {
            this.txtbusqueda.Enabled = true;
            this.txtusuario.Enabled = true;
            this.txtContraseña.Enabled = true;
            this.chkact.Enabled = true;
            this.cmbperfil.Enabled = true;

            this.btnmuevo.Visible = false;
            this.btnguardar.Visible = true;
            this.btnmodificar.Visible = false;
            this.btncancelar.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtbusqueda.Enabled = true;
            this.txtusuario.Enabled = true;
            this.txtContraseña.Enabled = true;
            this.chkact.Enabled = true;
            this.cmbperfil.Enabled = true;

            this.btnmuevo.Visible = false;
            this.btnguardar.Visible = false ;
            this.btnmodificar.Visible = true ;
            this.btncancelar.Visible = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.txtbusqueda.Enabled = false;
            this.txtbusqueda.Text = "";
            this.txtusuario.Enabled = false ;
            this.txtusuario.Text = "";
            this.txtContraseña.Enabled = false;
            this.txtContraseña.Text = "";
            this.chkact.Enabled = false;
            this.chkact.Checked = false;
            this.cmbperfil.Enabled = false;
            this.cmbperfil.Text = "";

            this.btnmuevo.Visible = true ;
            this.btnguardar.Visible = false ;
            this.btnmodificar.Visible = false ;
            this.btncancelar.Visible = false ;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {





            this.txtbusqueda.Enabled = false;
            this.txtbusqueda.Text = "";
            this.txtusuario.Enabled = false;
            this.txtusuario.Text = "";
            this.txtContraseña.Enabled = false;
            this.txtContraseña.Text = "";
            this.chkact.Enabled = false;
            this.chkact.Checked = false;
            this.cmbperfil.Enabled = false;
            this.cmbperfil.Text = "";

            this.btnmuevo.Visible = true;
            this.btnguardar.Visible = false;
            this.btnmodificar.Visible = false;
            this.btncancelar.Visible = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            int activo;
            int perfil;

            if (chkact.Checked == true)
            {
                activo = 1;
            }
            else
            {
                activo = 0;
            }
            if (cmbperfil.SelectedItem.ToString() == "ADMINISTRADOR")
            {
                perfil = 1;
            }
            else
            {
                perfil = 0;
            }
            int id = Convert.ToInt16(txtidemple.Text);

            string pass = descriptar.Encrypt(this.txtContraseña.Text.Trim());


            objCass.ExecSP("InsertUser",
                        new string[] { "idempleado", "Userd", "Pasword", "perfil", "estado" },
                        new object[] { id, txtusuario.Text, pass, perfil, activo },
                        new DbType[] { DbType.Int16, DbType.String, DbType.String, DbType.Int16, DbType.Int16 });



           DataTable  dtemple = objCass.getDTfromSP("GetEmple",
                            new string[] { "tipo", "nombre", "activo" },
                            new object[] { 4, "a", 1 },
                            new DbType[] { DbType.Int16, DbType.String, DbType.Int16 });

           grduser.DataSource = dtemple;
           grduser.Refresh();


            this.txtbusqueda.Enabled = false;
            this.txtbusqueda.Text = "";
            this.txtusuario.Enabled = false;
            this.txtusuario.Text = "";
            this.txtContraseña.Enabled = false;
            this.txtContraseña.Text = "";
            this.chkact.Enabled = false;
            this.chkact.Checked = false;
            this.cmbperfil.Enabled = false;
            this.cmbperfil.Text = "";

            this.btnmuevo.Visible = true;
            this.btnguardar.Visible = false;
            this.btnmodificar.Visible = false;
            this.btncancelar.Visible = false;
        }

        private void grduser_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
