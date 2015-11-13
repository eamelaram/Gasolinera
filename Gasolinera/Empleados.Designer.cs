namespace Gasolinera
{
    partial class Empleados
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.dtnac = new System.Windows.Forms.DateTimePicker();
            this.rbnM = new System.Windows.Forms.RadioButton();
            this.rbnF = new System.Windows.Forms.RadioButton();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtelefono = new System.Windows.Forms.MaskedTextBox();
            this.fecingre = new System.Windows.Forms.DateTimePicker();
            this.txtdui = new System.Windows.Forms.MaskedTextBox();
            this.txtnit = new System.Windows.Forms.MaskedTextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnmuevo = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.cmbperfilb = new System.Windows.Forms.ComboBox();
            this.chkacb = new System.Windows.Forms.CheckBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbusq = new System.Windows.Forms.TextBox();
            this.cmbbuscarpor = new System.Windows.Forms.Label();
            this.cmbbuscar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(685, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(12, 58);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(163, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(181, 58);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(163, 20);
            this.txtapellido.TabIndex = 2;
            // 
            // dtnac
            // 
            this.dtnac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtnac.Location = new System.Drawing.Point(350, 58);
            this.dtnac.Name = "dtnac";
            this.dtnac.Size = new System.Drawing.Size(163, 20);
            this.dtnac.TabIndex = 3;
            // 
            // rbnM
            // 
            this.rbnM.AutoSize = true;
            this.rbnM.Location = new System.Drawing.Point(527, 59);
            this.rbnM.Name = "rbnM";
            this.rbnM.Size = new System.Drawing.Size(34, 17);
            this.rbnM.TabIndex = 4;
            this.rbnM.TabStop = true;
            this.rbnM.Text = "M\r\n";
            this.rbnM.UseVisualStyleBackColor = true;
            // 
            // rbnF
            // 
            this.rbnF.AutoSize = true;
            this.rbnF.Location = new System.Drawing.Point(568, 59);
            this.rbnF.Name = "rbnF";
            this.rbnF.Size = new System.Drawing.Size(31, 17);
            this.rbnF.TabIndex = 5;
            this.rbnF.TabStop = true;
            this.rbnF.Text = "F";
            this.rbnF.UseVisualStyleBackColor = true;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(10, 106);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(319, 20);
            this.txtdireccion.TabIndex = 6;
            // 
            // txtelefono
            // 
            this.txtelefono.Location = new System.Drawing.Point(335, 106);
            this.txtelefono.Mask = "0000-0000";
            this.txtelefono.Name = "txtelefono";
            this.txtelefono.Size = new System.Drawing.Size(100, 20);
            this.txtelefono.TabIndex = 7;
            // 
            // fecingre
            // 
            this.fecingre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecingre.Location = new System.Drawing.Point(441, 106);
            this.fecingre.Name = "fecingre";
            this.fecingre.Size = new System.Drawing.Size(163, 20);
            this.fecingre.TabIndex = 8;
            // 
            // txtdui
            // 
            this.txtdui.Location = new System.Drawing.Point(12, 154);
            this.txtdui.Mask = "00000000-0";
            this.txtdui.Name = "txtdui";
            this.txtdui.Size = new System.Drawing.Size(100, 20);
            this.txtdui.TabIndex = 9;
            // 
            // txtnit
            // 
            this.txtnit.Location = new System.Drawing.Point(118, 154);
            this.txtnit.Mask = "0000-000000-000-0";
            this.txtnit.Name = "txtnit";
            this.txtnit.Size = new System.Drawing.Size(100, 20);
            this.txtnit.TabIndex = 10;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(14, 42);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 11;
            this.lblnombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fecha de Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fecha de ingreso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "DUI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "NIT";
            // 
            // btnmuevo
            // 
            this.btnmuevo.Location = new System.Drawing.Point(12, 12);
            this.btnmuevo.Name = "btnmuevo";
            this.btnmuevo.Size = new System.Drawing.Size(75, 23);
            this.btnmuevo.TabIndex = 20;
            this.btnmuevo.Text = "NUEVO";
            this.btnmuevo.UseVisualStyleBackColor = true;
            this.btnmuevo.Click += new System.EventHandler(this.btnmuevo_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(529, 151);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 23;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(452, 180);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 22;
            this.btnmodificar.Text = "MODIFICAR";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(448, 151);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 21;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
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
            this.cmbperfilb.Location = new System.Drawing.Point(174, 256);
            this.cmbperfilb.Name = "cmbperfilb";
            this.cmbperfilb.Size = new System.Drawing.Size(233, 21);
            this.cmbperfilb.TabIndex = 30;
            this.cmbperfilb.Visible = false;
            // 
            // chkacb
            // 
            this.chkacb.AutoSize = true;
            this.chkacb.Location = new System.Drawing.Point(174, 260);
            this.chkacb.Name = "chkacb";
            this.chkacb.Size = new System.Drawing.Size(105, 17);
            this.chkacb.TabIndex = 29;
            this.chkacb.Text = "Activo / Inactivo";
            this.chkacb.UseVisualStyleBackColor = true;
            this.chkacb.Visible = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(417, 256);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 28;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Visible = false;
            // 
            // txtbusq
            // 
            this.txtbusq.Location = new System.Drawing.Point(174, 259);
            this.txtbusq.Name = "txtbusq";
            this.txtbusq.Size = new System.Drawing.Size(237, 20);
            this.txtbusq.TabIndex = 27;
            this.txtbusq.Visible = false;
            // 
            // cmbbuscarpor
            // 
            this.cmbbuscarpor.AutoSize = true;
            this.cmbbuscarpor.Location = new System.Drawing.Point(13, 237);
            this.cmbbuscarpor.Name = "cmbbuscarpor";
            this.cmbbuscarpor.Size = new System.Drawing.Size(61, 13);
            this.cmbbuscarpor.TabIndex = 26;
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
            this.cmbbuscar.Location = new System.Drawing.Point(12, 256);
            this.cmbbuscar.Name = "cmbbuscar";
            this.cmbbuscar.Size = new System.Drawing.Size(156, 21);
            this.cmbbuscar.TabIndex = 25;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 450);
            this.Controls.Add(this.cmbperfilb);
            this.Controls.Add(this.chkacb);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbusq);
            this.Controls.Add(this.cmbbuscarpor);
            this.Controls.Add(this.cmbbuscar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnmuevo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtnit);
            this.Controls.Add(this.txtdui);
            this.Controls.Add(this.fecingre);
            this.Controls.Add(this.txtelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.rbnF);
            this.Controls.Add(this.rbnM);
            this.Controls.Add(this.dtnac);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Empleados";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMPLEADOS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.DateTimePicker dtnac;
        private System.Windows.Forms.RadioButton rbnM;
        private System.Windows.Forms.RadioButton rbnF;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.MaskedTextBox txtelefono;
        private System.Windows.Forms.DateTimePicker fecingre;
        private System.Windows.Forms.MaskedTextBox txtdui;
        private System.Windows.Forms.MaskedTextBox txtnit;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnmuevo;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.ComboBox cmbperfilb;
        private System.Windows.Forms.CheckBox chkacb;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtbusq;
        private System.Windows.Forms.Label cmbbuscarpor;
        private System.Windows.Forms.ComboBox cmbbuscar;
    }
}