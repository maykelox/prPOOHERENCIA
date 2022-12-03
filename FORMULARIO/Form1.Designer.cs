namespace FORMULARIO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Empleado = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipos = new System.Windows.Forms.ComboBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtDocumentos = new System.Windows.Forms.TextBox();
            this.cboTipoContratos = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvVendedores = new System.Windows.Forms.DataGridView();
            this.Tipos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // Empleado
            // 
            this.Empleado.Controls.Add(this.btnGuardar);
            this.Empleado.Controls.Add(this.cboTipoContratos);
            this.Empleado.Controls.Add(this.txtDocumentos);
            this.Empleado.Controls.Add(this.txtApellidos);
            this.Empleado.Controls.Add(this.txtNombres);
            this.Empleado.Controls.Add(this.cboTipos);
            this.Empleado.Controls.Add(this.label4);
            this.Empleado.Controls.Add(this.label3);
            this.Empleado.Controls.Add(this.label2);
            this.Empleado.Controls.Add(this.label1);
            this.Empleado.Location = new System.Drawing.Point(16, 19);
            this.Empleado.Name = "Empleado";
            this.Empleado.Size = new System.Drawing.Size(414, 360);
            this.Empleado.TabIndex = 0;
            this.Empleado.TabStop = false;
            this.Empleado.Text = "Empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Documentos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contratos:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cboTipos
            // 
            this.cboTipos.FormattingEnabled = true;
            this.cboTipos.Items.AddRange(new object[] {
            "Vendedor",
            "Empleado",
            "Gerente"});
            this.cboTipos.Location = new System.Drawing.Point(96, 40);
            this.cboTipos.Name = "cboTipos";
            this.cboTipos.Size = new System.Drawing.Size(121, 23);
            this.cboTipos.TabIndex = 4;
            this.cboTipos.Text = "Vendedor";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(96, 93);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(121, 23);
            this.txtNombres.TabIndex = 5;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(249, 93);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(115, 23);
            this.txtApellidos.TabIndex = 6;
            // 
            // txtDocumentos
            // 
            this.txtDocumentos.Location = new System.Drawing.Point(110, 143);
            this.txtDocumentos.Name = "txtDocumentos";
            this.txtDocumentos.Size = new System.Drawing.Size(107, 23);
            this.txtDocumentos.TabIndex = 7;
            // 
            // cboTipoContratos
            // 
            this.cboTipoContratos.FormattingEnabled = true;
            this.cboTipoContratos.Items.AddRange(new object[] {
            "C",
            "N"});
            this.cboTipoContratos.Location = new System.Drawing.Point(96, 189);
            this.cboTipoContratos.Name = "cboTipoContratos";
            this.cboTipoContratos.Size = new System.Drawing.Size(121, 23);
            this.cboTipoContratos.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(289, 280);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvVendedores
            // 
            this.dgvVendedores.AllowUserToAddRows = false;
            this.dgvVendedores.AllowUserToOrderColumns = true;
            this.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipos,
            this.Apellidos,
            this.Nombres,
            this.Documentos,
            this.Sueldo});
            this.dgvVendedores.Location = new System.Drawing.Point(436, 19);
            this.dgvVendedores.Name = "dgvVendedores";
            this.dgvVendedores.RowTemplate.Height = 25;
            this.dgvVendedores.Size = new System.Drawing.Size(623, 360);
            this.dgvVendedores.TabIndex = 1;
            this.dgvVendedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendedores_CellContentClick);
            // 
            // Tipos
            // 
            this.Tipos.HeaderText = "Tipos";
            this.Tipos.Name = "Tipos";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            // 
            // Documentos
            // 
            this.Documentos.HeaderText = "Documentos";
            this.Documentos.Name = "Documentos";
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.Name = "Sueldo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 391);
            this.Controls.Add(this.dgvVendedores);
            this.Controls.Add(this.Empleado);
            this.Name = "Form1";
            this.Text = "POO";
            this.Empleado.ResumeLayout(false);
            this.Empleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Empleado;
        private Button btnGuardar;
        private ComboBox cboTipoContratos;
        private TextBox txtDocumentos;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private ComboBox cboTipos;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvVendedores;
        private DataGridViewTextBoxColumn Tipos;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Documentos;
        private DataGridViewTextBoxColumn Sueldo;
    }
}