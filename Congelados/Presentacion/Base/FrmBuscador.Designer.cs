namespace Congelados.Presentacion.Base
{
    partial class FrmBuscador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscador));
            this.LblTitulo = new System.Windows.Forms.Label();
            this.TbPnlBuscar = new System.Windows.Forms.TableLayoutPanel();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.TbPnlDatos = new System.Windows.Forms.TableLayoutPanel();
            this.DgvCatalogo = new System.Windows.Forms.DataGridView();
            this.TbPnlBotones = new System.Windows.Forms.TableLayoutPanel();
            this.FlwPnlBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.TbPnlBuscar.SuspendLayout();
            this.TbPnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCatalogo)).BeginInit();
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
            this.LblTitulo.Size = new System.Drawing.Size(964, 40);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Título";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbPnlBuscar
            // 
            this.TbPnlBuscar.ColumnCount = 4;
            this.TbPnlBuscar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlBuscar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.TbPnlBuscar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlBuscar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlBuscar.Controls.Add(this.TxtBuscar, 2, 0);
            this.TbPnlBuscar.Controls.Add(this.LblBuscar, 1, 0);
            this.TbPnlBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbPnlBuscar.Location = new System.Drawing.Point(0, 40);
            this.TbPnlBuscar.Name = "TbPnlBuscar";
            this.TbPnlBuscar.RowCount = 1;
            this.TbPnlBuscar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbPnlBuscar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TbPnlBuscar.Size = new System.Drawing.Size(964, 35);
            this.TbPnlBuscar.TabIndex = 1;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(86, 3);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(865, 22);
            this.TxtBuscar.TabIndex = 0;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // LblBuscar
            // 
            this.LblBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscar.Location = new System.Drawing.Point(13, 0);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(67, 25);
            this.LblBuscar.TabIndex = 1;
            this.LblBuscar.Text = "Buscar:";
            this.LblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbPnlDatos
            // 
            this.TbPnlDatos.ColumnCount = 3;
            this.TbPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlDatos.Controls.Add(this.DgvCatalogo, 1, 0);
            this.TbPnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPnlDatos.Location = new System.Drawing.Point(0, 75);
            this.TbPnlDatos.Name = "TbPnlDatos";
            this.TbPnlDatos.RowCount = 2;
            this.TbPnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TbPnlDatos.Size = new System.Drawing.Size(964, 392);
            this.TbPnlDatos.TabIndex = 2;
            // 
            // DgvCatalogo
            // 
            this.DgvCatalogo.AllowUserToAddRows = false;
            this.DgvCatalogo.AllowUserToDeleteRows = false;
            this.DgvCatalogo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCatalogo.BackgroundColor = System.Drawing.Color.White;
            this.DgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCatalogo.Location = new System.Drawing.Point(13, 3);
            this.DgvCatalogo.MultiSelect = false;
            this.DgvCatalogo.Name = "DgvCatalogo";
            this.DgvCatalogo.ReadOnly = true;
            this.DgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCatalogo.Size = new System.Drawing.Size(938, 336);
            this.DgvCatalogo.TabIndex = 0;
            // 
            // TbPnlBotones
            // 
            this.TbPnlBotones.ColumnCount = 3;
            this.TbPnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TbPnlBotones.Controls.Add(this.FlwPnlBotones, 1, 0);
            this.TbPnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TbPnlBotones.Location = new System.Drawing.Point(0, 423);
            this.TbPnlBotones.Name = "TbPnlBotones";
            this.TbPnlBotones.RowCount = 1;
            this.TbPnlBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlBotones.Size = new System.Drawing.Size(964, 44);
            this.TbPnlBotones.TabIndex = 3;
            // 
            // FlwPnlBotones
            // 
            this.FlwPnlBotones.Controls.Add(this.BtnAgregar);
            this.FlwPnlBotones.Controls.Add(this.BtnModificar);
            this.FlwPnlBotones.Controls.Add(this.BtnEliminar);
            this.FlwPnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlwPnlBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlwPnlBotones.Location = new System.Drawing.Point(13, 3);
            this.FlwPnlBotones.Name = "FlwPnlBotones";
            this.FlwPnlBotones.Size = new System.Drawing.Size(938, 38);
            this.FlwPnlBotones.TabIndex = 0;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(835, 3);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(100, 30);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(729, 3);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(100, 30);
            this.BtnModificar.TabIndex = 1;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(623, 3);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 30);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // FrmBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 467);
            this.Controls.Add(this.TbPnlBotones);
            this.Controls.Add(this.TbPnlDatos);
            this.Controls.Add(this.TbPnlBuscar);
            this.Controls.Add(this.LblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBuscador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador";
            this.TbPnlBuscar.ResumeLayout(false);
            this.TbPnlBuscar.PerformLayout();
            this.TbPnlDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCatalogo)).EndInit();
            this.TbPnlBotones.ResumeLayout(false);
            this.FlwPnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.TableLayoutPanel TbPnlBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.TableLayoutPanel TbPnlDatos;
        private System.Windows.Forms.TableLayoutPanel TbPnlBotones;
        private System.Windows.Forms.FlowLayoutPanel FlwPnlBotones;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView DgvCatalogo;
        private System.Windows.Forms.Label LblBuscar;
    }
}