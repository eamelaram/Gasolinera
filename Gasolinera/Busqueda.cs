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
    public partial class Busqueda : Form
    {
        cass objCass = new cass();
        public Busqueda()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem .ToString() == "NOMBRE")
            {
                txtbusq.Visible = true;
                btnbuscar.Visible = true;
                chkacb.Visible = false;
            }
            if (comboBox1.SelectedItem.ToString() == "APELLIDO")
            {
                txtbusq.Visible = true;
                btnbuscar.Visible = true;
                chkacb.Visible = false;
            }
            if (comboBox1.SelectedItem.ToString() == "ACTIVOS / INACTIVOS")
            {
                txtbusq.Visible = false ;
                btnbuscar.Visible = true;
                chkacb.Visible = true ;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dtemple = null;

            Int16 activo;
            if (chkacb.Checked == true)
            {
                activo = 1;
            }
            else 
            {
                activo = 0;
            }

            try
            {
                if (comboBox1.SelectedItem.ToString() == "NOMBRE")
                {
                    dtemple = objCass.getDTfromSP("GetEmple",
                            new string[] { "tipo", "nombre", "activo" },
                            new object[] { 1, txtbusq.Text, 1 },
                            new DbType[] { DbType.Int16, DbType.String, DbType.Int16 });
                }
                if (comboBox1.SelectedItem.ToString() == "APELLIDO")
                {
                    dtemple = objCass.getDTfromSP("GetEmple",
                            new string[] { "tipo", "nombre", "activo" },
                            new object[] { 2, txtbusq.Text, 1 },
                            new DbType[] { DbType.Int16, DbType.String, DbType.Int16 });
                }
                if (comboBox1.SelectedItem.ToString() == "ACTIVOS / INACTIVOS")
                {
                    dtemple = objCass.getDTfromSP("GetEmple",
                             new string[] { "tipo", "nombre", "activo" },
                             new object[] { 3, null, activo },
                             new DbType[] { DbType.Int16, DbType.String, DbType.Int16 });
                }



                if (dtemple.Rows.Count > 0)
                {
                    grdemple.DataSource = dtemple;
                    grdemple.Refresh();

                    
                }


            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        private void grdemple_DoubleClick(object sender, EventArgs e)
        {
            Static.busqueda = grdemple.CurrentRow.Cells["nombre"].Value.ToString() + " " + grdemple.CurrentRow.Cells["apellido"].Value.ToString();
            Static.idemple = Convert.ToInt16(grdemple.CurrentRow.Cells["idempleado"].Value.ToString());
            this.Close();
        }
    }
}
