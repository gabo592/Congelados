namespace Congelados.Presentacion.CapitalHumano
{
    partial class FrmEditorEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditorEmpleado));
            this.LblTitulo = new System.Windows.Forms.Label();
            this.TbPnlLayoutDatosPersonales = new System.Windows.Forms.TableLayoutPanel();
            this.GbDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.TbPnlDatosPersonales = new System.Windows.Forms.TableLayoutPanel();
            this.LblPrimerNombre = new System.Windows.Forms.Label();
            this.TxtPrimerNombre = new System.Windows.Forms.TextBox();
            this.TxtSegundoNombre = new System.Windows.Forms.TextBox();
            this.TxtPrimerApellido = new System.Windows.Forms.TextBox();
            this.TxtSegundoApellido = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.LblSegundoNombre = new System.Windows.Forms.Label();
            this.LblPrimerApellido = new System.Windows.Forms.Label();
            this.LblSegundoApellido = new System.Windows.Forms.Label();
            this.LblCedula = new System.Windows.Forms.Label();
            this.TbPnlLayoutContacto = new System.Windows.Forms.TableLayoutPanel();
            this.GbContacto = new System.Windows.Forms.GroupBox();
            this.TbPnlContacto = new System.Windows.Forms.TableLayoutPanel();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.TbPnlLayoutUbicacion = new System.Windows.Forms.TableLayoutPanel();
            this.GpUbicacion = new System.Windows.Forms.GroupBox();
            this.TbPnlUbicacion = new System.Windows.Forms.TableLayoutPanel();
            this.CmbDepartamentos = new System.Windows.Forms.ComboBox();
            this.CmbMunicipios = new System.Windows.Forms.ComboBox();
            this.LblDepartamento = new System.Windows.Forms.Label();
            this.LblMunicipio = new System.Windows.Forms.Label();
            this.TbPnlBotones = new System.Windows.Forms.TableLayoutPanel();
            this.FlwPnlBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TbPnlLayoutDatosPersonales.SuspendLayout();
            this.GbDatosEmpleado.SuspendLayout();
            this.TbPnlDatosPersonales.SuspendLayout();
            this.TbPnlLayoutContacto.SuspendLayout();
            this.GbContacto.SuspendLayout();
            this.TbPnlContacto.SuspendLayout();
            this.TbPnlLayoutUbicacion.SuspendLayout();
            this.GpUbicacion.SuspendLayout();
            this.TbPnlUbicacion.SuspendLayout();
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
            this.LblTitulo.Size = new System.Drawing.Size(783, 40);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Información del Empleado";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbPnlLayoutDatosPersonales
            // 
            this.TbPnlLayoutDatosPersonales.ColumnCount = 3;
            this.TbPnlLayoutDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlLayoutDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlLayoutDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlLayoutDatosPersonales.Controls.Add(this.GbDatosEmpleado, 1, 0);
            this.TbPnlLayoutDatosPersonales.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbPnlLayoutDatosPersonales.Location = new System.Drawing.Point(0, 40);
            this.TbPnlLayoutDatosPersonales.Name = "TbPnlLayoutDatosPersonales";
            this.TbPnlLayoutDatosPersonales.RowCount = 1;
            this.TbPnlLayoutDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlLayoutDatosPersonales.Size = new System.Drawing.Size(783, 201);
            this.TbPnlLayoutDatosPersonales.TabIndex = 1;
            // 
            // GbDatosEmpleado
            // 
            this.GbDatosEmpleado.Controls.Add(this.TbPnlDatosPersonales);
            this.GbDatosEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbDatosEmpleado.Location = new System.Drawing.Point(13, 3);
            this.GbDatosEmpleado.Name = "GbDatosEmpleado";
            this.GbDatosEmpleado.Size = new System.Drawing.Size(757, 195);
            this.GbDatosEmpleado.TabIndex = 0;
            this.GbDatosEmpleado.TabStop = false;
            this.GbDatosEmpleado.Text = "Datos Personales";
            // 
            // TbPnlDatosPersonales
            // 
            this.TbPnlDatosPersonales.ColumnCount = 2;
            this.TbPnlDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.TbPnlDatosPersonales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlDatosPersonales.Controls.Add(this.LblPrimerNombre, 0, 0);
            this.TbPnlDatosPersonales.Controls.Add(this.TxtPrimerNombre, 1, 0);
            this.TbPnlDatosPersonales.Controls.Add(this.TxtSegundoNombre, 1, 1);
            this.TbPnlDatosPersonales.Controls.Add(this.TxtPrimerApellido, 1, 2);
            this.TbPnlDatosPersonales.Controls.Add(this.TxtSegundoApellido, 1, 3);
            this.TbPnlDatosPersonales.Controls.Add(this.TxtCedula, 1, 4);
            this.TbPnlDatosPersonales.Controls.Add(this.LblSegundoNombre, 0, 1);
            this.TbPnlDatosPersonales.Controls.Add(this.LblPrimerApellido, 0, 2);
            this.TbPnlDatosPersonales.Controls.Add(this.LblSegundoApellido, 0, 3);
            this.TbPnlDatosPersonales.Controls.Add(this.LblCedula, 0, 4);
            this.TbPnlDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPnlDatosPersonales.Location = new System.Drawing.Point(3, 16);
            this.TbPnlDatosPersonales.Name = "TbPnlDatosPersonales";
            this.TbPnlDatosPersonales.RowCount = 5;
            this.TbPnlDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TbPnlDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TbPnlDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TbPnlDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TbPnlDatosPersonales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TbPnlDatosPersonales.Size = new System.Drawing.Size(751, 176);
            this.TbPnlDatosPersonales.TabIndex = 0;
            // 
            // LblPrimerNombre
            // 
            this.LblPrimerNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblPrimerNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrimerNombre.Location = new System.Drawing.Point(3, 0);
            this.LblPrimerNombre.Name = "LblPrimerNombre";
            this.LblPrimerNombre.Size = new System.Drawing.Size(194, 25);
            this.LblPrimerNombre.TabIndex = 0;
            this.LblPrimerNombre.Text = "Primer Nombre:";
            this.LblPrimerNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtPrimerNombre
            // 
            this.TxtPrimerNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtPrimerNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrimerNombre.Location = new System.Drawing.Point(203, 3);
            this.TxtPrimerNombre.Name = "TxtPrimerNombre";
            this.TxtPrimerNombre.Size = new System.Drawing.Size(545, 22);
            this.TxtPrimerNombre.TabIndex = 1;
            // 
            // TxtSegundoNombre
            // 
            this.TxtSegundoNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSegundoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSegundoNombre.Location = new System.Drawing.Point(203, 38);
            this.TxtSegundoNombre.Name = "TxtSegundoNombre";
            this.TxtSegundoNombre.Size = new System.Drawing.Size(545, 22);
            this.TxtSegundoNombre.TabIndex = 2;
            // 
            // TxtPrimerApellido
            // 
            this.TxtPrimerApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrimerApellido.Location = new System.Drawing.Point(203, 73);
            this.TxtPrimerApellido.Name = "TxtPrimerApellido";
            this.TxtPrimerApellido.Size = new System.Drawing.Size(545, 22);
            this.TxtPrimerApellido.TabIndex = 3;
            // 
            // TxtSegundoApellido
            // 
            this.TxtSegundoApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSegundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSegundoApellido.Location = new System.Drawing.Point(203, 108);
            this.TxtSegundoApellido.Name = "TxtSegundoApellido";
            this.TxtSegundoApellido.Size = new System.Drawing.Size(545, 22);
            this.TxtSegundoApellido.TabIndex = 4;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCedula.Location = new System.Drawing.Point(203, 143);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(545, 22);
            this.TxtCedula.TabIndex = 5;
            // 
            // LblSegundoNombre
            // 
            this.LblSegundoNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblSegundoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSegundoNombre.Location = new System.Drawing.Point(3, 35);
            this.LblSegundoNombre.Name = "LblSegundoNombre";
            this.LblSegundoNombre.Size = new System.Drawing.Size(194, 25);
            this.LblSegundoNombre.TabIndex = 6;
            this.LblSegundoNombre.Text = "Segundo Nombre:";
            this.LblSegundoNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblPrimerApellido
            // 
            this.LblPrimerApellido.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrimerApellido.Location = new System.Drawing.Point(3, 70);
            this.LblPrimerApellido.Name = "LblPrimerApellido";
            this.LblPrimerApellido.Size = new System.Drawing.Size(194, 23);
            this.LblPrimerApellido.TabIndex = 7;
            this.LblPrimerApellido.Text = "Primer Apellido:";
            this.LblPrimerApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblSegundoApellido
            // 
            this.LblSegundoApellido.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblSegundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSegundoApellido.Location = new System.Drawing.Point(3, 105);
            this.LblSegundoApellido.Name = "LblSegundoApellido";
            this.LblSegundoApellido.Size = new System.Drawing.Size(194, 23);
            this.LblSegundoApellido.TabIndex = 8;
            this.LblSegundoApellido.Text = "Segundo Apellido:";
            this.LblSegundoApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCedula
            // 
            this.LblCedula.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCedula.Location = new System.Drawing.Point(3, 140);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(194, 23);
            this.LblCedula.TabIndex = 9;
            this.LblCedula.Text = "Cédula:";
            this.LblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbPnlLayoutContacto
            // 
            this.TbPnlLayoutContacto.ColumnCount = 3;
            this.TbPnlLayoutContacto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlLayoutContacto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlLayoutContacto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlLayoutContacto.Controls.Add(this.GbContacto, 1, 1);
            this.TbPnlLayoutContacto.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbPnlLayoutContacto.Location = new System.Drawing.Point(0, 241);
            this.TbPnlLayoutContacto.Name = "TbPnlLayoutContacto";
            this.TbPnlLayoutContacto.RowCount = 2;
            this.TbPnlLayoutContacto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlLayoutContacto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlLayoutContacto.Size = new System.Drawing.Size(783, 130);
            this.TbPnlLayoutContacto.TabIndex = 2;
            // 
            // GbContacto
            // 
            this.GbContacto.Controls.Add(this.TbPnlContacto);
            this.GbContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbContacto.Location = new System.Drawing.Point(13, 13);
            this.GbContacto.Name = "GbContacto";
            this.GbContacto.Size = new System.Drawing.Size(757, 114);
            this.GbContacto.TabIndex = 0;
            this.GbContacto.TabStop = false;
            this.GbContacto.Text = "Información de contacto";
            // 
            // TbPnlContacto
            // 
            this.TbPnlContacto.ColumnCount = 2;
            this.TbPnlContacto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.TbPnlContacto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlContacto.Controls.Add(this.TxtTelefono, 1, 0);
            this.TbPnlContacto.Controls.Add(this.TxtDireccion, 1, 1);
            this.TbPnlContacto.Controls.Add(this.LblTelefono, 0, 0);
            this.TbPnlContacto.Controls.Add(this.LblDireccion, 0, 1);
            this.TbPnlContacto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPnlContacto.Location = new System.Drawing.Point(3, 16);
            this.TbPnlContacto.Name = "TbPnlContacto";
            this.TbPnlContacto.RowCount = 2;
            this.TbPnlContacto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TbPnlContacto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlContacto.Size = new System.Drawing.Size(751, 95);
            this.TbPnlContacto.TabIndex = 0;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(203, 3);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(545, 22);
            this.TxtTelefono.TabIndex = 0;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(203, 33);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDireccion.Size = new System.Drawing.Size(545, 59);
            this.TxtDireccion.TabIndex = 1;
            // 
            // LblTelefono
            // 
            this.LblTelefono.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTelefono.Location = new System.Drawing.Point(3, 0);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(194, 23);
            this.LblTelefono.TabIndex = 2;
            this.LblTelefono.Text = "Número de teléfono:";
            this.LblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblDireccion
            // 
            this.LblDireccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblDireccion.Location = new System.Drawing.Point(3, 30);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(194, 23);
            this.LblDireccion.TabIndex = 3;
            this.LblDireccion.Text = "Dirección";
            this.LblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbPnlLayoutUbicacion
            // 
            this.TbPnlLayoutUbicacion.ColumnCount = 3;
            this.TbPnlLayoutUbicacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlLayoutUbicacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlLayoutUbicacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlLayoutUbicacion.Controls.Add(this.GpUbicacion, 1, 1);
            this.TbPnlLayoutUbicacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbPnlLayoutUbicacion.Location = new System.Drawing.Point(0, 371);
            this.TbPnlLayoutUbicacion.Name = "TbPnlLayoutUbicacion";
            this.TbPnlLayoutUbicacion.RowCount = 2;
            this.TbPnlLayoutUbicacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlLayoutUbicacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlLayoutUbicacion.Size = new System.Drawing.Size(783, 100);
            this.TbPnlLayoutUbicacion.TabIndex = 3;
            // 
            // GpUbicacion
            // 
            this.GpUbicacion.Controls.Add(this.TbPnlUbicacion);
            this.GpUbicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GpUbicacion.Location = new System.Drawing.Point(13, 13);
            this.GpUbicacion.Name = "GpUbicacion";
            this.GpUbicacion.Size = new System.Drawing.Size(757, 84);
            this.GpUbicacion.TabIndex = 0;
            this.GpUbicacion.TabStop = false;
            this.GpUbicacion.Text = "Ubicación";
            // 
            // TbPnlUbicacion
            // 
            this.TbPnlUbicacion.ColumnCount = 2;
            this.TbPnlUbicacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.TbPnlUbicacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlUbicacion.Controls.Add(this.CmbDepartamentos, 1, 0);
            this.TbPnlUbicacion.Controls.Add(this.CmbMunicipios, 1, 1);
            this.TbPnlUbicacion.Controls.Add(this.LblDepartamento, 0, 0);
            this.TbPnlUbicacion.Controls.Add(this.LblMunicipio, 0, 1);
            this.TbPnlUbicacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPnlUbicacion.Location = new System.Drawing.Point(3, 16);
            this.TbPnlUbicacion.Name = "TbPnlUbicacion";
            this.TbPnlUbicacion.RowCount = 2;
            this.TbPnlUbicacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbPnlUbicacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbPnlUbicacion.Size = new System.Drawing.Size(751, 65);
            this.TbPnlUbicacion.TabIndex = 0;
            // 
            // CmbDepartamentos
            // 
            this.CmbDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDepartamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbDepartamentos.FormattingEnabled = true;
            this.CmbDepartamentos.Location = new System.Drawing.Point(203, 3);
            this.CmbDepartamentos.Name = "CmbDepartamentos";
            this.CmbDepartamentos.Size = new System.Drawing.Size(545, 24);
            this.CmbDepartamentos.TabIndex = 0;
            this.CmbDepartamentos.SelectedIndexChanged += new System.EventHandler(this.CmbDepartamentos_SelectedIndexChanged);
            // 
            // CmbMunicipios
            // 
            this.CmbMunicipios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbMunicipios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMunicipios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbMunicipios.FormattingEnabled = true;
            this.CmbMunicipios.Location = new System.Drawing.Point(203, 35);
            this.CmbMunicipios.Name = "CmbMunicipios";
            this.CmbMunicipios.Size = new System.Drawing.Size(545, 24);
            this.CmbMunicipios.TabIndex = 1;
            // 
            // LblDepartamento
            // 
            this.LblDepartamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblDepartamento.Location = new System.Drawing.Point(3, 0);
            this.LblDepartamento.Name = "LblDepartamento";
            this.LblDepartamento.Size = new System.Drawing.Size(194, 23);
            this.LblDepartamento.TabIndex = 2;
            this.LblDepartamento.Text = "Departamento:";
            this.LblDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblMunicipio
            // 
            this.LblMunicipio.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblMunicipio.Location = new System.Drawing.Point(3, 32);
            this.LblMunicipio.Name = "LblMunicipio";
            this.LblMunicipio.Size = new System.Drawing.Size(194, 23);
            this.LblMunicipio.TabIndex = 3;
            this.LblMunicipio.Text = "Municipio:";
            this.LblMunicipio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbPnlBotones
            // 
            this.TbPnlBotones.ColumnCount = 3;
            this.TbPnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlBotones.Controls.Add(this.FlwPnlBotones, 1, 1);
            this.TbPnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbPnlBotones.Location = new System.Drawing.Point(0, 471);
            this.TbPnlBotones.Name = "TbPnlBotones";
            this.TbPnlBotones.RowCount = 2;
            this.TbPnlBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlBotones.Size = new System.Drawing.Size(783, 54);
            this.TbPnlBotones.TabIndex = 4;
            // 
            // FlwPnlBotones
            // 
            this.FlwPnlBotones.Controls.Add(this.BtnGuardar);
            this.FlwPnlBotones.Controls.Add(this.BtnLimpiar);
            this.FlwPnlBotones.Controls.Add(this.BtnCancelar);
            this.FlwPnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlwPnlBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlwPnlBotones.Location = new System.Drawing.Point(13, 13);
            this.FlwPnlBotones.Name = "FlwPnlBotones";
            this.FlwPnlBotones.Size = new System.Drawing.Size(757, 38);
            this.FlwPnlBotones.TabIndex = 0;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(654, 3);
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
            this.BtnLimpiar.Location = new System.Drawing.Point(548, 3);
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
            this.BtnCancelar.Location = new System.Drawing.Point(442, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmEditorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbPnlBotones);
            this.Controls.Add(this.TbPnlLayoutUbicacion);
            this.Controls.Add(this.TbPnlLayoutContacto);
            this.Controls.Add(this.TbPnlLayoutDatosPersonales);
            this.Controls.Add(this.LblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditorEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor Empleado";
            this.TbPnlLayoutDatosPersonales.ResumeLayout(false);
            this.GbDatosEmpleado.ResumeLayout(false);
            this.TbPnlDatosPersonales.ResumeLayout(false);
            this.TbPnlDatosPersonales.PerformLayout();
            this.TbPnlLayoutContacto.ResumeLayout(false);
            this.GbContacto.ResumeLayout(false);
            this.TbPnlContacto.ResumeLayout(false);
            this.TbPnlContacto.PerformLayout();
            this.TbPnlLayoutUbicacion.ResumeLayout(false);
            this.GpUbicacion.ResumeLayout(false);
            this.TbPnlUbicacion.ResumeLayout(false);
            this.TbPnlBotones.ResumeLayout(false);
            this.FlwPnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.TableLayoutPanel TbPnlLayoutDatosPersonales;
        private System.Windows.Forms.GroupBox GbDatosEmpleado;
        private System.Windows.Forms.TableLayoutPanel TbPnlDatosPersonales;
        private System.Windows.Forms.Label LblPrimerNombre;
        private System.Windows.Forms.TextBox TxtPrimerNombre;
        private System.Windows.Forms.TextBox TxtSegundoNombre;
        private System.Windows.Forms.TextBox TxtPrimerApellido;
        private System.Windows.Forms.TextBox TxtSegundoApellido;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label LblSegundoNombre;
        private System.Windows.Forms.Label LblPrimerApellido;
        private System.Windows.Forms.Label LblSegundoApellido;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.TableLayoutPanel TbPnlLayoutContacto;
        private System.Windows.Forms.GroupBox GbContacto;
        private System.Windows.Forms.TableLayoutPanel TbPnlContacto;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.TableLayoutPanel TbPnlLayoutUbicacion;
        private System.Windows.Forms.GroupBox GpUbicacion;
        private System.Windows.Forms.TableLayoutPanel TbPnlUbicacion;
        private System.Windows.Forms.ComboBox CmbDepartamentos;
        private System.Windows.Forms.ComboBox CmbMunicipios;
        private System.Windows.Forms.Label LblDepartamento;
        private System.Windows.Forms.Label LblMunicipio;
        private System.Windows.Forms.TableLayoutPanel TbPnlBotones;
        private System.Windows.Forms.FlowLayoutPanel FlwPnlBotones;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}