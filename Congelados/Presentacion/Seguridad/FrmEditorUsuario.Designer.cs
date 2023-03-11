namespace Congelados.Presentacion.Seguridad
{
    partial class FrmEditorUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditorUsuario));
            this.LblTitulo = new System.Windows.Forms.Label();
            this.TbPnlLayoutIdentificacion = new System.Windows.Forms.TableLayoutPanel();
            this.GbIdentificacion = new System.Windows.Forms.GroupBox();
            this.TbPnlIdentificacion = new System.Windows.Forms.TableLayoutPanel();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblClave = new System.Windows.Forms.Label();
            this.LblRol = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.CmbRoles = new System.Windows.Forms.ComboBox();
            this.TbPnlLayoutEmpleado = new System.Windows.Forms.TableLayoutPanel();
            this.GbEmpleado = new System.Windows.Forms.GroupBox();
            this.TbPnlEmpleados = new System.Windows.Forms.TableLayoutPanel();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DgvEmpleados = new System.Windows.Forms.DataGridView();
            this.TbPnlBotones = new System.Windows.Forms.TableLayoutPanel();
            this.FlwPnlBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TbPnlLayoutIdentificacion.SuspendLayout();
            this.GbIdentificacion.SuspendLayout();
            this.TbPnlIdentificacion.SuspendLayout();
            this.TbPnlLayoutEmpleado.SuspendLayout();
            this.GbEmpleado.SuspendLayout();
            this.TbPnlEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).BeginInit();
            this.TbPnlBotones.SuspendLayout();
            this.FlwPnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(0, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(800, 40);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Información del Usuario";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbPnlLayoutIdentificacion
            // 
            this.TbPnlLayoutIdentificacion.ColumnCount = 3;
            this.TbPnlLayoutIdentificacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlLayoutIdentificacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlLayoutIdentificacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlLayoutIdentificacion.Controls.Add(this.GbIdentificacion, 1, 0);
            this.TbPnlLayoutIdentificacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbPnlLayoutIdentificacion.Location = new System.Drawing.Point(0, 40);
            this.TbPnlLayoutIdentificacion.Name = "TbPnlLayoutIdentificacion";
            this.TbPnlLayoutIdentificacion.RowCount = 1;
            this.TbPnlLayoutIdentificacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbPnlLayoutIdentificacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbPnlLayoutIdentificacion.Size = new System.Drawing.Size(800, 140);
            this.TbPnlLayoutIdentificacion.TabIndex = 1;
            // 
            // GbIdentificacion
            // 
            this.GbIdentificacion.Controls.Add(this.TbPnlIdentificacion);
            this.GbIdentificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbIdentificacion.Location = new System.Drawing.Point(13, 3);
            this.GbIdentificacion.Name = "GbIdentificacion";
            this.GbIdentificacion.Size = new System.Drawing.Size(774, 134);
            this.GbIdentificacion.TabIndex = 0;
            this.GbIdentificacion.TabStop = false;
            this.GbIdentificacion.Text = "Indentificación";
            // 
            // TbPnlIdentificacion
            // 
            this.TbPnlIdentificacion.ColumnCount = 2;
            this.TbPnlIdentificacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.TbPnlIdentificacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlIdentificacion.Controls.Add(this.LblNombre, 0, 0);
            this.TbPnlIdentificacion.Controls.Add(this.LblClave, 0, 1);
            this.TbPnlIdentificacion.Controls.Add(this.LblRol, 0, 2);
            this.TbPnlIdentificacion.Controls.Add(this.TxtNombre, 1, 0);
            this.TbPnlIdentificacion.Controls.Add(this.TxtClave, 1, 1);
            this.TbPnlIdentificacion.Controls.Add(this.CmbRoles, 1, 2);
            this.TbPnlIdentificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPnlIdentificacion.Location = new System.Drawing.Point(3, 16);
            this.TbPnlIdentificacion.Name = "TbPnlIdentificacion";
            this.TbPnlIdentificacion.RowCount = 3;
            this.TbPnlIdentificacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TbPnlIdentificacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TbPnlIdentificacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TbPnlIdentificacion.Size = new System.Drawing.Size(768, 115);
            this.TbPnlIdentificacion.TabIndex = 0;
            // 
            // LblNombre
            // 
            this.LblNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(3, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(144, 23);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre:";
            this.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblClave
            // 
            this.LblClave.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClave.Location = new System.Drawing.Point(3, 38);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(144, 23);
            this.LblClave.TabIndex = 1;
            this.LblClave.Text = "Clave:";
            this.LblClave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblRol
            // 
            this.LblRol.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRol.Location = new System.Drawing.Point(3, 76);
            this.LblRol.Name = "LblRol";
            this.LblRol.Size = new System.Drawing.Size(144, 23);
            this.LblRol.TabIndex = 2;
            this.LblRol.Text = "Rol:";
            this.LblRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(153, 3);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(612, 22);
            this.TxtNombre.TabIndex = 3;
            // 
            // TxtClave
            // 
            this.TxtClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClave.Location = new System.Drawing.Point(153, 41);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(612, 22);
            this.TxtClave.TabIndex = 4;
            this.TxtClave.UseSystemPasswordChar = true;
            // 
            // CmbRoles
            // 
            this.CmbRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbRoles.FormattingEnabled = true;
            this.CmbRoles.Items.AddRange(new object[] {
            "Capital Humano",
            "Compras",
            "Inventario",
            "Seguridad",
            "Ventas"});
            this.CmbRoles.Location = new System.Drawing.Point(153, 79);
            this.CmbRoles.Name = "CmbRoles";
            this.CmbRoles.Size = new System.Drawing.Size(612, 24);
            this.CmbRoles.TabIndex = 5;
            // 
            // TbPnlLayoutEmpleado
            // 
            this.TbPnlLayoutEmpleado.ColumnCount = 3;
            this.TbPnlLayoutEmpleado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlLayoutEmpleado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlLayoutEmpleado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlLayoutEmpleado.Controls.Add(this.GbEmpleado, 1, 0);
            this.TbPnlLayoutEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbPnlLayoutEmpleado.Location = new System.Drawing.Point(0, 180);
            this.TbPnlLayoutEmpleado.Name = "TbPnlLayoutEmpleado";
            this.TbPnlLayoutEmpleado.RowCount = 1;
            this.TbPnlLayoutEmpleado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlLayoutEmpleado.Size = new System.Drawing.Size(800, 244);
            this.TbPnlLayoutEmpleado.TabIndex = 2;
            // 
            // GbEmpleado
            // 
            this.GbEmpleado.Controls.Add(this.TbPnlEmpleados);
            this.GbEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbEmpleado.Location = new System.Drawing.Point(13, 3);
            this.GbEmpleado.Name = "GbEmpleado";
            this.GbEmpleado.Size = new System.Drawing.Size(774, 238);
            this.GbEmpleado.TabIndex = 0;
            this.GbEmpleado.TabStop = false;
            this.GbEmpleado.Text = "Empleado";
            // 
            // TbPnlEmpleados
            // 
            this.TbPnlEmpleados.ColumnCount = 2;
            this.TbPnlEmpleados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TbPnlEmpleados.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlEmpleados.Controls.Add(this.LblBuscar, 0, 0);
            this.TbPnlEmpleados.Controls.Add(this.TxtBuscar, 1, 0);
            this.TbPnlEmpleados.Controls.Add(this.DgvEmpleados, 0, 1);
            this.TbPnlEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPnlEmpleados.Location = new System.Drawing.Point(3, 16);
            this.TbPnlEmpleados.Name = "TbPnlEmpleados";
            this.TbPnlEmpleados.RowCount = 2;
            this.TbPnlEmpleados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TbPnlEmpleados.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlEmpleados.Size = new System.Drawing.Size(768, 219);
            this.TbPnlEmpleados.TabIndex = 0;
            // 
            // LblBuscar
            // 
            this.LblBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscar.Location = new System.Drawing.Point(3, 0);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(94, 30);
            this.LblBuscar.TabIndex = 0;
            this.LblBuscar.Text = "Buscar:";
            this.LblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(103, 3);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(662, 22);
            this.TxtBuscar.TabIndex = 1;
            // 
            // DgvEmpleados
            // 
            this.DgvEmpleados.AllowUserToAddRows = false;
            this.DgvEmpleados.AllowUserToDeleteRows = false;
            this.DgvEmpleados.BackgroundColor = System.Drawing.Color.White;
            this.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TbPnlEmpleados.SetColumnSpan(this.DgvEmpleados, 2);
            this.DgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvEmpleados.Location = new System.Drawing.Point(3, 33);
            this.DgvEmpleados.Name = "DgvEmpleados";
            this.DgvEmpleados.ReadOnly = true;
            this.DgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEmpleados.Size = new System.Drawing.Size(762, 183);
            this.DgvEmpleados.TabIndex = 2;
            // 
            // TbPnlBotones
            // 
            this.TbPnlBotones.ColumnCount = 3;
            this.TbPnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlBotones.Controls.Add(this.FlwPnlBotones, 1, 0);
            this.TbPnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbPnlBotones.Location = new System.Drawing.Point(0, 424);
            this.TbPnlBotones.Name = "TbPnlBotones";
            this.TbPnlBotones.RowCount = 1;
            this.TbPnlBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlBotones.Size = new System.Drawing.Size(800, 42);
            this.TbPnlBotones.TabIndex = 3;
            // 
            // FlwPnlBotones
            // 
            this.FlwPnlBotones.Controls.Add(this.BtnGuardar);
            this.FlwPnlBotones.Controls.Add(this.BtnLimpiar);
            this.FlwPnlBotones.Controls.Add(this.BtnCancelar);
            this.FlwPnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlwPnlBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlwPnlBotones.Location = new System.Drawing.Point(13, 3);
            this.FlwPnlBotones.Name = "FlwPnlBotones";
            this.FlwPnlBotones.Size = new System.Drawing.Size(774, 36);
            this.FlwPnlBotones.TabIndex = 0;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(671, 3);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 30);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(565, 3);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.BtnLimpiar.TabIndex = 1;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(459, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmEditorUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.TbPnlBotones);
            this.Controls.Add(this.TbPnlLayoutEmpleado);
            this.Controls.Add(this.TbPnlLayoutIdentificacion);
            this.Controls.Add(this.LblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditorUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor Usuario";
            this.TbPnlLayoutIdentificacion.ResumeLayout(false);
            this.GbIdentificacion.ResumeLayout(false);
            this.TbPnlIdentificacion.ResumeLayout(false);
            this.TbPnlIdentificacion.PerformLayout();
            this.TbPnlLayoutEmpleado.ResumeLayout(false);
            this.GbEmpleado.ResumeLayout(false);
            this.TbPnlEmpleados.ResumeLayout(false);
            this.TbPnlEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).EndInit();
            this.TbPnlBotones.ResumeLayout(false);
            this.FlwPnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.TableLayoutPanel TbPnlLayoutIdentificacion;
        private System.Windows.Forms.GroupBox GbIdentificacion;
        private System.Windows.Forms.TableLayoutPanel TbPnlIdentificacion;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblClave;
        private System.Windows.Forms.Label LblRol;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.ComboBox CmbRoles;
        private System.Windows.Forms.TableLayoutPanel TbPnlLayoutEmpleado;
        private System.Windows.Forms.GroupBox GbEmpleado;
        private System.Windows.Forms.TableLayoutPanel TbPnlEmpleados;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DgvEmpleados;
        private System.Windows.Forms.TableLayoutPanel TbPnlBotones;
        private System.Windows.Forms.FlowLayoutPanel FlwPnlBotones;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}