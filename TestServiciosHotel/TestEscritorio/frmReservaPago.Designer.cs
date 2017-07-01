namespace TestEscritorio
{
    partial class frmReservaPago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbBusqueda = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPagar = new System.Windows.Forms.Button();
            this.id_Reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_Habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Inicio_Reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Fin_Reserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNomCliente = new System.Windows.Forms.Label();
            this.grbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbBusqueda
            // 
            this.grbBusqueda.Controls.Add(this.label4);
            this.grbBusqueda.Controls.Add(this.btnBuscar);
            this.grbBusqueda.Controls.Add(this.txtNroDocumento);
            this.grbBusqueda.Location = new System.Drawing.Point(27, 12);
            this.grbBusqueda.Name = "grbBusqueda";
            this.grbBusqueda.Size = new System.Drawing.Size(407, 44);
            this.grbBusqueda.TabIndex = 29;
            this.grbBusqueda.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nro. Documento";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(243, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 23);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar Reserva";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(115, 13);
            this.txtNroDocumento.MaxLength = 11;
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtNroDocumento.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Reserva,
            this.id_Habitacion,
            this.Fecha_Registro,
            this.Fecha_Inicio_Reserva,
            this.Fecha_Fin_Reserva,
            this.Precio});
            this.dataGridView1.Location = new System.Drawing.Point(27, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(663, 207);
            this.dataGridView1.TabIndex = 30;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(615, 301);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(75, 23);
            this.btnPagar.TabIndex = 31;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // id_Reserva
            // 
            this.id_Reserva.HeaderText = "Código";
            this.id_Reserva.Name = "id_Reserva";
            this.id_Reserva.ReadOnly = true;
            // 
            // id_Habitacion
            // 
            this.id_Habitacion.HeaderText = "Habitación";
            this.id_Habitacion.Name = "id_Habitacion";
            this.id_Habitacion.ReadOnly = true;
            // 
            // Fecha_Registro
            // 
            dataGridViewCellStyle5.Format = "d";
            this.Fecha_Registro.DefaultCellStyle = dataGridViewCellStyle5;
            this.Fecha_Registro.HeaderText = "Fec. Reg";
            this.Fecha_Registro.Name = "Fecha_Registro";
            this.Fecha_Registro.ReadOnly = true;
            // 
            // Fecha_Inicio_Reserva
            // 
            dataGridViewCellStyle6.Format = "d";
            this.Fecha_Inicio_Reserva.DefaultCellStyle = dataGridViewCellStyle6;
            this.Fecha_Inicio_Reserva.HeaderText = "Fec.Inicio";
            this.Fecha_Inicio_Reserva.Name = "Fecha_Inicio_Reserva";
            this.Fecha_Inicio_Reserva.ReadOnly = true;
            // 
            // Fecha_Fin_Reserva
            // 
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.Fecha_Fin_Reserva.DefaultCellStyle = dataGridViewCellStyle7;
            this.Fecha_Fin_Reserva.HeaderText = "Fec.Fin";
            this.Fecha_Fin_Reserva.Name = "Fecha_Fin_Reserva";
            this.Fecha_Fin_Reserva.ReadOnly = true;
            // 
            // Precio
            // 
            dataGridViewCellStyle8.Format = "N2";
            this.Precio.DefaultCellStyle = dataGridViewCellStyle8;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(24, 59);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 32;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblNomCliente
            // 
            this.lblNomCliente.AutoSize = true;
            this.lblNomCliente.Location = new System.Drawing.Point(73, 59);
            this.lblNomCliente.Name = "lblNomCliente";
            this.lblNomCliente.Size = new System.Drawing.Size(0, 13);
            this.lblNomCliente.TabIndex = 33;
            // 
            // frmReservaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 334);
            this.Controls.Add(this.lblNomCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbBusqueda);
            this.Name = "frmReservaPago";
            this.Text = "frmReservaPago";
            this.grbBusqueda.ResumeLayout(false);
            this.grbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBusqueda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Reserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Inicio_Reserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Fin_Reserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNomCliente;
    }
}