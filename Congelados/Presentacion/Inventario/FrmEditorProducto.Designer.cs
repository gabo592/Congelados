namespace Congelados.Presentacion.Inventario
{
    partial class FrmEditorProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditorProducto));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.TbPnlLayoutDatosProducto = new System.Windows.Forms.TableLayoutPanel();
            this.GpDatosProducto = new System.Windows.Forms.GroupBox();
            this.TbPnlDatosProducto = new System.Windows.Forms.TableLayoutPanel();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.NumPrecio = new System.Windows.Forms.NumericUpDown();
            this.NumCantidad = new System.Windows.Forms.NumericUpDown();
            this.TbPnlLayoutCategoria = new System.Windows.Forms.TableLayoutPanel();
            this.GbCategoria = new System.Windows.Forms.GroupBox();
            this.TbPnlCategoria = new System.Windows.Forms.TableLayoutPanel();
            this.CmbCategoriaProducto = new System.Windows.Forms.ComboBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.TbPnlBotones = new System.Windows.Forms.TableLayoutPanel();
            this.FlwPnlBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            this.TbPnlLayoutDatosProducto.SuspendLayout();
            this.GpDatosProducto.SuspendLayout();
            this.TbPnlDatosProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidad)).BeginInit();
            this.TbPnlLayoutCategoria.SuspendLayout();
            this.GbCategoria.SuspendLayout();
            this.TbPnlCategoria.SuspendLayout();
            this.TbPnlBotones.SuspendLayout();
            this.FlwPnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(729, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoríasDeProductosToolStripMenuItem});
            this.inventarioToolStripMenuItem.Image = global::Congelados.Properties.Resources.box;
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // categoríasDeProductosToolStripMenuItem
            // 
            this.categoríasDeProductosToolStripMenuItem.Image = global::Congelados.Properties.Resources.categorias;
            this.categoríasDeProductosToolStripMenuItem.Name = "categoríasDeProductosToolStripMenuItem";
            this.categoríasDeProductosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.categoríasDeProductosToolStripMenuItem.Size = new System.Drawing.Size(291, 22);
            this.categoríasDeProductosToolStripMenuItem.Text = "Categorías de Productos";
            this.categoríasDeProductosToolStripMenuItem.Click += new System.EventHandler(this.CategoríasDeProductosToolStripMenuItem_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(0, 24);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(729, 40);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "Información del Producto";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbPnlLayoutDatosProducto
            // 
            this.TbPnlLayoutDatosProducto.ColumnCount = 3;
            this.TbPnlLayoutDatosProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlLayoutDatosProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlLayoutDatosProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlLayoutDatosProducto.Controls.Add(this.GpDatosProducto, 1, 0);
            this.TbPnlLayoutDatosProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbPnlLayoutDatosProducto.Location = new System.Drawing.Point(0, 64);
            this.TbPnlLayoutDatosProducto.Name = "TbPnlLayoutDatosProducto";
            this.TbPnlLayoutDatosProducto.RowCount = 1;
            this.TbPnlLayoutDatosProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbPnlLayoutDatosProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbPnlLayoutDatosProducto.Size = new System.Drawing.Size(729, 147);
            this.TbPnlLayoutDatosProducto.TabIndex = 2;
            // 
            // GpDatosProducto
            // 
            this.GpDatosProducto.Controls.Add(this.TbPnlDatosProducto);
            this.GpDatosProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GpDatosProducto.Location = new System.Drawing.Point(13, 3);
            this.GpDatosProducto.Name = "GpDatosProducto";
            this.GpDatosProducto.Size = new System.Drawing.Size(703, 141);
            this.GpDatosProducto.TabIndex = 0;
            this.GpDatosProducto.TabStop = false;
            this.GpDatosProducto.Text = "Datos del Producto";
            // 
            // TbPnlDatosProducto
            // 
            this.TbPnlDatosProducto.ColumnCount = 2;
            this.TbPnlDatosProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.TbPnlDatosProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlDatosProducto.Controls.Add(this.LblDescripcion, 0, 0);
            this.TbPnlDatosProducto.Controls.Add(this.LblPrecio, 0, 1);
            this.TbPnlDatosProducto.Controls.Add(this.LblCantidad, 0, 2);
            this.TbPnlDatosProducto.Controls.Add(this.TxtDescripcion, 1, 0);
            this.TbPnlDatosProducto.Controls.Add(this.NumPrecio, 1, 1);
            this.TbPnlDatosProducto.Controls.Add(this.NumCantidad, 1, 2);
            this.TbPnlDatosProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPnlDatosProducto.Location = new System.Drawing.Point(3, 16);
            this.TbPnlDatosProducto.Name = "TbPnlDatosProducto";
            this.TbPnlDatosProducto.RowCount = 3;
            this.TbPnlDatosProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TbPnlDatosProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbPnlDatosProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbPnlDatosProducto.Size = new System.Drawing.Size(697, 122);
            this.TbPnlDatosProducto.TabIndex = 0;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblDescripcion.Location = new System.Drawing.Point(3, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(174, 23);
            this.LblDescripcion.TabIndex = 0;
            this.LblDescripcion.Text = "Descripcion";
            this.LblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblPrecio
            // 
            this.LblPrecio.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblPrecio.Location = new System.Drawing.Point(3, 60);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(174, 23);
            this.LblPrecio.TabIndex = 1;
            this.LblPrecio.Text = "Precio C$:";
            this.LblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCantidad
            // 
            this.LblCantidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblCantidad.Location = new System.Drawing.Point(3, 91);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(174, 23);
            this.LblCantidad.TabIndex = 2;
            this.LblCantidad.Text = "Cantidad:";
            this.LblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescripcion.Location = new System.Drawing.Point(183, 3);
            this.TxtDescripcion.Multiline = true;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDescripcion.Size = new System.Drawing.Size(511, 54);
            this.TxtDescripcion.TabIndex = 3;
            // 
            // NumPrecio
            // 
            this.NumPrecio.DecimalPlaces = 2;
            this.NumPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumPrecio.Location = new System.Drawing.Point(183, 63);
            this.NumPrecio.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.NumPrecio.Name = "NumPrecio";
            this.NumPrecio.Size = new System.Drawing.Size(511, 22);
            this.NumPrecio.TabIndex = 4;
            this.NumPrecio.ThousandsSeparator = true;
            // 
            // NumCantidad
            // 
            this.NumCantidad.DecimalPlaces = 2;
            this.NumCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCantidad.Location = new System.Drawing.Point(183, 94);
            this.NumCantidad.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.NumCantidad.Name = "NumCantidad";
            this.NumCantidad.Size = new System.Drawing.Size(511, 22);
            this.NumCantidad.TabIndex = 5;
            this.NumCantidad.ThousandsSeparator = true;
            // 
            // TbPnlLayoutCategoria
            // 
            this.TbPnlLayoutCategoria.ColumnCount = 3;
            this.TbPnlLayoutCategoria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlLayoutCategoria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlLayoutCategoria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlLayoutCategoria.Controls.Add(this.GbCategoria, 1, 1);
            this.TbPnlLayoutCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbPnlLayoutCategoria.Location = new System.Drawing.Point(0, 211);
            this.TbPnlLayoutCategoria.Name = "TbPnlLayoutCategoria";
            this.TbPnlLayoutCategoria.RowCount = 2;
            this.TbPnlLayoutCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlLayoutCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlLayoutCategoria.Size = new System.Drawing.Size(729, 68);
            this.TbPnlLayoutCategoria.TabIndex = 3;
            // 
            // GbCategoria
            // 
            this.GbCategoria.Controls.Add(this.TbPnlCategoria);
            this.GbCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbCategoria.Location = new System.Drawing.Point(13, 13);
            this.GbCategoria.Name = "GbCategoria";
            this.GbCategoria.Size = new System.Drawing.Size(703, 52);
            this.GbCategoria.TabIndex = 0;
            this.GbCategoria.TabStop = false;
            this.GbCategoria.Text = "Clasificación";
            // 
            // TbPnlCategoria
            // 
            this.TbPnlCategoria.ColumnCount = 2;
            this.TbPnlCategoria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.TbPnlCategoria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlCategoria.Controls.Add(this.CmbCategoriaProducto, 1, 0);
            this.TbPnlCategoria.Controls.Add(this.LblCategoria, 0, 0);
            this.TbPnlCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPnlCategoria.Location = new System.Drawing.Point(3, 16);
            this.TbPnlCategoria.Name = "TbPnlCategoria";
            this.TbPnlCategoria.RowCount = 1;
            this.TbPnlCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbPnlCategoria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbPnlCategoria.Size = new System.Drawing.Size(697, 33);
            this.TbPnlCategoria.TabIndex = 0;
            // 
            // CmbCategoriaProducto
            // 
            this.CmbCategoriaProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbCategoriaProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategoriaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCategoriaProducto.FormattingEnabled = true;
            this.CmbCategoriaProducto.Location = new System.Drawing.Point(183, 3);
            this.CmbCategoriaProducto.Name = "CmbCategoriaProducto";
            this.CmbCategoriaProducto.Size = new System.Drawing.Size(511, 24);
            this.CmbCategoriaProducto.TabIndex = 0;
            // 
            // LblCategoria
            // 
            this.LblCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblCategoria.Location = new System.Drawing.Point(3, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(174, 23);
            this.LblCategoria.TabIndex = 1;
            this.LblCategoria.Text = "Categoría de Producto:";
            this.LblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbPnlBotones
            // 
            this.TbPnlBotones.ColumnCount = 3;
            this.TbPnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlBotones.Controls.Add(this.FlwPnlBotones, 1, 1);
            this.TbPnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbPnlBotones.Location = new System.Drawing.Point(0, 279);
            this.TbPnlBotones.Name = "TbPnlBotones";
            this.TbPnlBotones.RowCount = 2;
            this.TbPnlBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlBotones.Size = new System.Drawing.Size(729, 54);
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
            this.FlwPnlBotones.Size = new System.Drawing.Size(703, 38);
            this.FlwPnlBotones.TabIndex = 0;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(600, 3);
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
            this.BtnLimpiar.Location = new System.Drawing.Point(494, 3);
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
            this.BtnCancelar.Location = new System.Drawing.Point(388, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmEditorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(729, 337);
            this.Controls.Add(this.TbPnlBotones);
            this.Controls.Add(this.TbPnlLayoutCategoria);
            this.Controls.Add(this.TbPnlLayoutDatosProducto);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "FrmEditorProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor Productos";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.TbPnlLayoutDatosProducto.ResumeLayout(false);
            this.GpDatosProducto.ResumeLayout(false);
            this.TbPnlDatosProducto.ResumeLayout(false);
            this.TbPnlDatosProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidad)).EndInit();
            this.TbPnlLayoutCategoria.ResumeLayout(false);
            this.GbCategoria.ResumeLayout(false);
            this.TbPnlCategoria.ResumeLayout(false);
            this.TbPnlBotones.ResumeLayout(false);
            this.FlwPnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríasDeProductosToolStripMenuItem;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.TableLayoutPanel TbPnlLayoutDatosProducto;
        private System.Windows.Forms.GroupBox GpDatosProducto;
        private System.Windows.Forms.TableLayoutPanel TbPnlDatosProducto;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.NumericUpDown NumPrecio;
        private System.Windows.Forms.NumericUpDown NumCantidad;
        private System.Windows.Forms.TableLayoutPanel TbPnlLayoutCategoria;
        private System.Windows.Forms.GroupBox GbCategoria;
        private System.Windows.Forms.TableLayoutPanel TbPnlCategoria;
        private System.Windows.Forms.ComboBox CmbCategoriaProducto;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.TableLayoutPanel TbPnlBotones;
        private System.Windows.Forms.FlowLayoutPanel FlwPnlBotones;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}