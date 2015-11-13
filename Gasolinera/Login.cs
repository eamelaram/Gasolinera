using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using Gasolinera.Classes;
using Carssi.Classes;

namespace Gasolinera
{
    public partial class Login : Form
    {
        cass objCass = new cass();
        Encryptor descriptar = new Encryptor();
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string sql;

            sql = "select e.nombre,u.usuario, p.idperfil as perfil";
            sql += " from usuario u inner join empleado e on u.idempleado = e.idempleado ";
            sql += " inner join perfil p on u.idperfil = p.idperfil";
            sql += " where u.estado = 1";
            sql += " and u.usuario = '" + this.txtuser.Text + "'";
            sql += " and u.pasword = '" + descriptar.Encrypt(this.txtpass.Text.Trim()) + "'";

            try
            {
                DataTable dtUser = objCass.getDTfromSQL(sql);

                if (dtUser.Rows.Count > 0)
                {

                    Static.nombre = dtUser.Rows[0]["nombre"].ToString();
                    Static.User = dtUser.Rows[0]["usuario"].ToString();
                    Static.idperfil = Convert.ToInt16 (dtUser.Rows[0]["perfil"].ToString());
                    //this.Response.Redirect("Default.aspx", false);
                    Principal MttoPlanes = new Principal();
                    MttoPlanes.Show();
                    this.Visible = false;
                }
                else
                {
                    this.lblerror.Visible = true;
                    this.txtuser.Text = "";
                    this.txtpass.Text = "";
                }



            }
            catch (Exception ex)
            {
            }



            
            
        }
    }
}
