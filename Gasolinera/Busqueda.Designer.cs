namespace Gasolinera
{
    partial class Busqueda
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
            this.grdemple = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.cmbbuscarpor = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chkacb = new System.Windows.Forms.CheckBox();
            this.txtbusq = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdemple)).BeginInit();
            this.SuspendLayout();
            // 
            // grdemple
            // 
            this.grdemple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdemple.Location = new System.Drawing.Point(12, 93);
            this.grdemple.Name = "grdemple";
            this.grdemple.Size = new System.Drawing.Size(418, 150);
            this.grdemple.TabIndex = 0;
            //this.grdemple.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.grdemple.DoubleClick += new System.EventHandler(this.grdemple_DoubleClick);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(255, 62);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbbuscarpor
            // 
            this.cmbbuscarpor.AutoSize = true;
            this.cmbbuscarpor.Location = new System.Drawing.Point(13, 18);
            this.cmbbuscarpor.Name = "cmbbuscarpor";
            this.cmbbuscarpor.Size = new System.Drawing.Size(61, 13);
            this.cmbbuscarpor.TabIndex = 7;
            this.cmbbuscarpor.Text = "Buscar por:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "NOMBRE",
            "APELLIDO",
            "ACTIVOS / INACTIVOS"});
            this.comboBox1.Location = new System.Drawing.Point(12, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chkacb
            // 
            this.chkacb.AutoSize = true;
            this.chkacb.Location = new System.Drawing.Point(12, 66);
            this.chkacb.Name = "chkacb";
            this.chkacb.Size = new System.Drawing.Size(105, 17);
            this.chkacb.TabIndex = 26;
            this.chkacb.Text = "Activo / Inactivo";
            this.chkacb.UseVisualStyleBackColor = true;
            this.chkacb.Visible = false;
            // 
            // txtbusq
            // 
            this.txtbusq.Location = new System.Drawing.Point(12, 67);
            this.txtbusq.Name = "txtbusq";
            this.txtbusq.Size = new System.Drawing.Size(237, 20);
            this.txtbusq.TabIndex = 25;
            this.txtbusq.Visible = false;
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 257);
            this.Controls.Add(this.chkacb);
            this.Controls.Add(this.txtbusq);
            this.Controls.Add(this.cmbbuscarpor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.grdemple);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Busqueda";
            this.ShowIcon = false;
            this.Text = "BUSQUEDA";
            ((System.ComponentModel.ISupportInitialize)(this.grdemple)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdemple;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label cmbbuscarpor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chkacb;
        private System.Windows.Forms.TextBox txtbusq;
    }
}