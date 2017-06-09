namespace TestEscritorio
{
    partial class frmReserva
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDIreccion = new System.Windows.Forms.Label();
            this.btnBuscarBusqueda = new System.Windows.Forms.Button();
            this.grbBusqueda = new System.Windows.Forms.GroupBox();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.dgvDisponible = new System.Windows.Forms.DataGridView();
            this.idHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEspecial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Piso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbBusqueda.SuspendLayout();
            this.grbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponible)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Inicio";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(77, 18);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(79, 20);
            this.dtpInicio.TabIndex = 1;
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(253, 18);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(88, 20);
            this.dtpFin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Fin";
            // 
            // cboSucursal
            // 
            this.cboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(77, 47);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(121, 21);
            this.cboSucursal.TabIndex = 4;
            this.cboSucursal.SelectionChangeCommitted += new System.EventHandler(this.cboSucursal_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sucursal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Direción";
            // 
            // lblDIreccion
            // 
            this.lblDIreccion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDIreccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDIreccion.Location = new System.Drawing.Point(77, 77);
            this.lblDIreccion.Name = "lblDIreccion";
            this.lblDIreccion.Size = new System.Drawing.Size(264, 21);
            this.lblDIreccion.TabIndex = 7;
            this.lblDIreccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBuscarBusqueda
            // 
            this.btnBuscarBusqueda.Location = new System.Drawing.Point(418, 17);
            this.btnBuscarBusqueda.Name = "btnBuscarBusqueda";
            this.btnBuscarBusqueda.Size = new System.Drawing.Size(55, 23);
            this.btnBuscarBusqueda.TabIndex = 8;
            this.btnBuscarBusqueda.Text = "Buscar";
            this.btnBuscarBusqueda.UseVisualStyleBackColor = true;
            this.btnBuscarBusqueda.Click += new System.EventHandler(this.btnBuscarBusqueda_Click);
            // 
            // grbBusqueda
            // 
            this.grbBusqueda.Controls.Add(this.label1);
            this.grbBusqueda.Controls.Add(this.btnBuscarBusqueda);
            this.grbBusqueda.Controls.Add(this.dtpInicio);
            this.grbBusqueda.Controls.Add(this.lblDIreccion);
            this.grbBusqueda.Controls.Add(this.label2);
            this.grbBusqueda.Controls.Add(this.label4);
            this.grbBusqueda.Controls.Add(this.dtpFin);
            this.grbBusqueda.Controls.Add(this.label3);
            this.grbBusqueda.Controls.Add(this.cboSucursal);
            this.grbBusqueda.Location = new System.Drawing.Point(12, 12);
            this.grbBusqueda.Name = "grbBusqueda";
            this.grbBusqueda.Size = new System.Drawing.Size(479, 112);
            this.grbBusqueda.TabIndex = 9;
            this.grbBusqueda.TabStop = false;
            this.grbBusqueda.Text = "Busqueda";
            // 
            // grbCliente
            // 
            this.grbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grbCliente.Controls.Add(this.btnBuscarCliente);
            this.grbCliente.Controls.Add(this.lblDocumento);
            this.grbCliente.Controls.Add(this.lblNombres);
            this.grbCliente.Controls.Add(this.label12);
            this.grbCliente.Controls.Add(this.label11);
            this.grbCliente.Location = new System.Drawing.Point(12, 368);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(487, 100);
            this.grbCliente.TabIndex = 13;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Cliente";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(423, 54);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(50, 23);
            this.btnBuscarCliente.TabIndex = 15;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblDocumento
            // 
            this.lblDocumento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDocumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDocumento.Location = new System.Drawing.Point(81, 50);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(117, 21);
            this.lblDocumento.TabIndex = 14;
            this.lblDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNombres
            // 
            this.lblNombres.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombres.Location = new System.Drawing.Point(81, 23);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(319, 21);
            this.lblNombres.TabIndex = 13;
            this.lblNombres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Documento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nombres:";
            // 
            // btnReservar
            // 
            this.btnReservar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Location = new System.Drawing.Point(506, 433);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(150, 35);
            this.btnReservar.TabIndex = 14;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // dgvDisponible
            // 
            this.dgvDisponible.AllowUserToAddRows = false;
            this.dgvDisponible.AllowUserToDeleteRows = false;
            this.dgvDisponible.AllowUserToResizeColumns = false;
            this.dgvDisponible.AllowUserToResizeRows = false;
            this.dgvDisponible.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisponible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisponible.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHabitacion,
            this.Descripcion,
            this.DescripcionEstado,
            this.DescripcionTipo,
            this.FechaEspecial,
            this.idEstado,
            this.idSede,
            this.IdTipo,
            this.Piso,
            this.Precio});
            this.dgvDisponible.Location = new System.Drawing.Point(12, 146);
            this.dgvDisponible.MultiSelect = false;
            this.dgvDisponible.Name = "dgvDisponible";
            this.dgvDisponible.RowHeadersVisible = false;
            this.dgvDisponible.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisponible.Size = new System.Drawing.Size(644, 207);
            this.dgvDisponible.TabIndex = 15;
            // 
            // idHabitacion
            // 
            this.idHabitacion.DataPropertyName = "idHabitacion";
            this.idHabitacion.HeaderText = "Nro.";
            this.idHabitacion.Name = "idHabitacion";
            this.idHabitacion.ReadOnly = true;
            this.idHabitacion.Width = 40;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 280;
            // 
            // DescripcionEstado
            // 
            this.DescripcionEstado.DataPropertyName = "DescripcionEstado";
            this.DescripcionEstado.HeaderText = "DescripcionEstado";
            this.DescripcionEstado.Name = "DescripcionEstado";
            this.DescripcionEstado.ReadOnly = true;
            this.DescripcionEstado.Visible = false;
            // 
            // DescripcionTipo
            // 
            this.DescripcionTipo.DataPropertyName = "DescripcionTipo";
            this.DescripcionTipo.HeaderText = "Tipo";
            this.DescripcionTipo.Name = "DescripcionTipo";
            this.DescripcionTipo.ReadOnly = true;
            this.DescripcionTipo.Width = 200;
            // 
            // FechaEspecial
            // 
            this.FechaEspecial.DataPropertyName = "FechaEspecial";
            this.FechaEspecial.HeaderText = "FechaEspecial";
            this.FechaEspecial.Name = "FechaEspecial";
            this.FechaEspecial.ReadOnly = true;
            this.FechaEspecial.Visible = false;
            // 
            // idEstado
            // 
            this.idEstado.DataPropertyName = "idEstado";
            this.idEstado.HeaderText = "idEstado";
            this.idEstado.Name = "idEstado";
            this.idEstado.ReadOnly = true;
            this.idEstado.Visible = false;
            // 
            // idSede
            // 
            this.idSede.DataPropertyName = "idSede";
            this.idSede.HeaderText = "idSede";
            this.idSede.Name = "idSede";
            this.idSede.ReadOnly = true;
            this.idSede.Visible = false;
            // 
            // IdTipo
            // 
            this.IdTipo.DataPropertyName = "IdTipo";
            this.IdTipo.HeaderText = "IdTipo";
            this.IdTipo.Name = "IdTipo";
            this.IdTipo.ReadOnly = true;
            this.IdTipo.Visible = false;
            // 
            // Piso
            // 
            this.Piso.DataPropertyName = "Piso";
            this.Piso.HeaderText = "Piso";
            this.Piso.Name = "Piso";
            this.Piso.ReadOnly = true;
            this.Piso.Width = 35;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "0";
            this.Precio.DefaultCellStyle = dataGridViewCellStyle5;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 70;
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 480);
            this.Controls.Add(this.dgvDisponible);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.grbCliente);
            this.Controls.Add(this.grbBusqueda);
            this.Name = "frmReserva";
            this.Text = "frmReserva";
            this.Load += new System.EventHandler(this.frmReserva_Load);
            this.grbBusqueda.ResumeLayout(false);
            this.grbBusqueda.PerformLayout();
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponible)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDIreccion;
        private System.Windows.Forms.Button btnBuscarBusqueda;
        private System.Windows.Forms.GroupBox grbBusqueda;
        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.DataGridView dgvDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEspecial;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSede;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Piso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}