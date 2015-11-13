namespace Gasolinera
{
    partial class Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnmuevo = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.grduser = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.txtidemple = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.chkactive = new System.Windows.Forms.CheckBox();
            this.cmbperfil = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkact = new System.Windows.Forms.CheckBox();
            this.cmbbuscarpor = new System.Windows.Forms.Label();
            this.cmbbuscar = new System.Windows.Forms.ComboBox();
            this.txtbusq = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.chkacb = new System.Windows.Forms.CheckBox();
            this.cmbperfilb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grduser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmuevo
            // 
            this.btnmuevo.Location = new System.Drawing.Point(12, 12);
            this.btnmuevo.Name = "btnmuevo";
            this.btnmuevo.Size = new System.Drawing.Size(75, 23);
            this.btnmuevo.TabIndex = 0;
            this.btnmuevo.Text = "NUEVO";
            this.btnmuevo.UseVisualStyleBackColor = true;
            this.btnmuevo.Click += new System.EventHandler(this.btnmuevo_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(403, 134);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 1;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Visible = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(403, 115);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 2;
            this.btnmodificar.Text = "MODIFICAR";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Visible = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(484, 134);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Visible = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // grduser
            // 
            this.grduser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grduser.Location = new System.Drawing.Point(12, 218);
            this.grduser.Name = "grduser";
            this.grduser.Size = new System.Drawing.Size(640, 165);
            this.grduser.TabIndex = 4;
            this.grduser.DoubleClick += new System.EventHandler(this.grduser_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Empleado";
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Enabled = false;
            this.txtbusqueda.Location = new System.Drawing.Point(12, 79);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(237, 20);
            this.txtbusqueda.TabIndex = 7;
            this.txtbusqueda.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // txtidemple
            // 
            this.txtidemple.Location = new System.Drawing.Point(73, 56);
            this.txtidemple.Name = "txtidemple";
            this.txtidemple.Size = new System.Drawing.Size(56, 20);
            this.txtidemple.TabIndex = 8;
            this.txtidemple.Visible = false;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(254, 63);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(43, 13);
            this.lblusuario.TabIndex = 9;
            this.lblusuario.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contraseña";
            // 
            // txtusuario
            // 
            this.txtusuario.Enabled = false;
            this.txtusuario.Location = new System.Drawing.Point(257, 79);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(97, 20);
            this.txtusuario.TabIndex = 13;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Enabled = false;
            this.txtContraseña.Location = new System.Drawing.Point(360, 79);
            this.txtContraseña.MaxLength = 25;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(166, 20);
            this.txtContraseña.TabIndex = 14;
            // 
            // chkactive
            // 
            this.chkactive.AutoSize = true;
            this.chkactive.Location = new System.Drawing.Point(532, 79);
            this.chkactive.Name = "chkactive";
            this.chkactive.Size = new System.Drawing.Size(120, 17);
            this.chkactive.TabIndex = 15;
            this.chkactive.Text = "Cambiar contraseña";
            this.chkactive.UseVisualStyleBackColor = true;
            this.chkactive.Visible = false;
            // 
            // cmbperfil
            // 
            this.cmbperfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbperfil.Enabled = false;
            this.cmbperfil.FormattingEnabled = true;
            this.cmbperfil.Items.AddRange(new object[] {
            "",
            "ADMINISTRADOR"});
            this.cmbperfil.Location = new System.Drawing.Point(16, 136);
            this.cmbperfil.Name = "cmbperfil";
            this.cmbperfil.Size = new System.Drawing.Size(233, 21);
            this.cmbperfil.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Perfil";
            // 
            // chkact
            // 
            this.chkact.AutoSize = true;
            this.chkact.Enabled = false;
            this.chkact.Location = new System.Drawing.Point(257, 138);
            this.chkact.Name = "chkact";
            this.chkact.Size = new System.Drawing.Size(105, 17);
            this.chkact.TabIndex = 18;
            this.chkact.Text = "Activo / Inactivo";
            this.chkact.UseVisualStyleBackColor = true;
            // 
            // cmbbuscarpor
            // 
            this.cmbbuscarpor.AutoSize = true;
            this.cmbbuscarpor.Location = new System.Drawing.Point(13, 170);
            this.cmbbuscarpor.Name = "cmbbuscarpor";
            this.cmbbuscarpor.Size = new System.Drawing.Size(61, 13);
            this.cmbbuscarpor.TabIndex = 20;
            this.cmbbuscarpor.Text = "Buscar por:";
            // 
            // cmbbuscar
            // 
            this.cmbbuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbuscar.FormattingEnabled = true;
            this.cmbbuscar.Items.AddRange(new object[] {
            "",
            "NOMBRE",
            "APELLIDO",
            "USUARIO",
            "PUESTO",
            "ACTIVOS / INACTIVOS"});
            this.cmbbuscar.Location = new System.Drawing.Point(12, 189);
            this.cmbbuscar.Name = "cmbbuscar";
            this.cmbbuscar.Size = new System.Drawing.Size(167, 21);
            this.cmbbuscar.TabIndex = 19;
            this.cmbbuscar.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtbusq
            // 
            this.txtbusq.Location = new System.Drawing.Point(185, 192);
            this.txtbusq.Name = "txtbusq";
            this.txtbusq.Size = new System.Drawing.Size(237, 20);
            this.txtbusq.TabIndex = 21;
            this.txtbusq.Visible = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(428, 189);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 22;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Visible = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // chkacb
            // 
            this.chkacb.AutoSize = true;
            this.chkacb.Location = new System.Drawing.Point(185, 193);
            this.chkacb.Name = "chkacb";
            this.chkacb.Size = new System.Drawing.Size(105, 17);
            this.chkacb.TabIndex = 23;
            this.chkacb.Text = "Activo / Inactivo";
            this.chkacb.UseVisualStyleBackColor = true;
            this.chkacb.Visible = false;
            // 
            // cmbperfilb
            // 
            this.cmbperfilb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbperfilb.FormattingEnabled = true;
            this.cmbperfilb.Items.AddRange(new object[] {
            "",
            "NOMBRE",
            "APELLIDO",
            "USUARIO",
            "PUESTO",
            "ACTIVOS / INACTIVOS"});
            this.cmbperfilb.Location = new System.Drawing.Point(185, 189);
            this.cmbperfilb.Name = "cmbperfilb";
            this.cmbperfilb.Size = new System.Drawing.Size(233, 21);
            this.cmbperfilb.TabIndex = 24;
            this.cmbperfilb.Visible = false;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 395);
            this.Controls.Add(this.cmbperfilb);
            this.Controls.Add(this.chkacb);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbusq);
            this.Controls.Add(this.cmbbuscarpor);
            this.Controls.Add(this.cmbbuscar);
            this.Controls.Add(this.chkact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbperfil);
            this.Controls.Add(this.chkactive);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.txtidemple);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grduser);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnmuevo);
            this.MaximizeBox = false;
            this.Name = "Usuarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USUARIOS";
            ((System.ComponentModel.ISupportInitialize)(this.grduser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmuevo;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.DataGridView grduser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.TextBox txtidemple;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusuario;
        internal System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.CheckBox chkactive;
        private System.Windows.Forms.ComboBox cmbperfil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkact;
        private System.Windows.Forms.Label cmbbuscarpor;
        private System.Windows.Forms.ComboBox cmbbuscar;
        private System.Windows.Forms.TextBox txtbusq;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.CheckBox chkacb;
        private System.Windows.Forms.ComboBox cmbperfilb;

    }
}