namespace Congelados.Presentacion.Principal
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.LblIniciarSesion = new System.Windows.Forms.Label();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.TbPnlDatos = new System.Windows.Forms.TableLayoutPanel();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.PbUsuario = new System.Windows.Forms.PictureBox();
            this.PbClave = new System.Windows.Forms.PictureBox();
            this.PbRevelarClave = new System.Windows.Forms.PictureBox();
            this.FlwPnlBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.TbPnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRevelarClave)).BeginInit();
            this.FlwPnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblIniciarSesion
            // 
            this.LblIniciarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIniciarSesion.Location = new System.Drawing.Point(0, 0);
            this.LblIniciarSesion.Name = "LblIniciarSesion";
            this.LblIniciarSesion.Size = new System.Drawing.Size(395, 42);
            this.LblIniciarSesion.TabIndex = 1;
            this.LblIniciarSesion.Text = "Inicio de Sesión";
            this.LblIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PbLogo
            // 
            this.PbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PbLogo.Image = global::Congelados.Properties.Resources.chocolate;
            this.PbLogo.Location = new System.Drawing.Point(0, 42);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(395, 112);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 2;
            this.PbLogo.TabStop = false;
            // 
            // TbPnlDatos
            // 
            this.TbPnlDatos.ColumnCount = 5;
            this.TbPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TbPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TbPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TbPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TbPnlDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TbPnlDatos.Controls.Add(this.TxtUsuario, 2, 1);
            this.TbPnlDatos.Controls.Add(this.TxtClave, 2, 2);
            this.TbPnlDatos.Controls.Add(this.PbUsuario, 1, 1);
            this.TbPnlDatos.Controls.Add(this.PbClave, 1, 2);
            this.TbPnlDatos.Controls.Add(this.PbRevelarClave, 3, 2);
            this.TbPnlDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.TbPnlDatos.Location = new System.Drawing.Point(0, 154);
            this.TbPnlDatos.Name = "TbPnlDatos";
            this.TbPnlDatos.RowCount = 3;
            this.TbPnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.5F));
            this.TbPnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.5F));
            this.TbPnlDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.TbPnlDatos.Size = new System.Drawing.Size(395, 91);
            this.TbPnlDatos.TabIndex = 3;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(43, 21);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(309, 22);
            this.TxtUsuario.TabIndex = 0;
            // 
            // TxtClave
            // 
            this.TxtClave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClave.Location = new System.Drawing.Point(43, 59);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(309, 22);
            this.TxtClave.TabIndex = 1;
            this.TxtClave.UseSystemPasswordChar = true;
            // 
            // PbUsuario
            // 
            this.PbUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.PbUsuario.Image = global::Congelados.Properties.Resources.user;
            this.PbUsuario.Location = new System.Drawing.Point(18, 21);
            this.PbUsuario.Name = "PbUsuario";
            this.PbUsuario.Size = new System.Drawing.Size(19, 22);
            this.PbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbUsuario.TabIndex = 2;
            this.PbUsuario.TabStop = false;
            // 
            // PbClave
            // 
            this.PbClave.Dock = System.Windows.Forms.DockStyle.Top;
            this.PbClave.Image = global::Congelados.Properties.Resources._lock;
            this.PbClave.Location = new System.Drawing.Point(18, 59);
            this.PbClave.Name = "PbClave";
            this.PbClave.Size = new System.Drawing.Size(19, 22);
            this.PbClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbClave.TabIndex = 3;
            this.PbClave.TabStop = false;
            // 
            // PbRevelarClave
            // 
            this.PbRevelarClave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbRevelarClave.Dock = System.Windows.Forms.DockStyle.Top;
            this.PbRevelarClave.Image = global::Congelados.Properties.Resources.eye;
            this.PbRevelarClave.Location = new System.Drawing.Point(358, 59);
            this.PbRevelarClave.Name = "PbRevelarClave";
            this.PbRevelarClave.Size = new System.Drawing.Size(19, 22);
            this.PbRevelarClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbRevelarClave.TabIndex = 4;
            this.PbRevelarClave.TabStop = false;
            this.PbRevelarClave.Click += new System.EventHandler(this.PbRevelarClave_Click);
            // 
            // FlwPnlBotones
            // 
            this.FlwPnlBotones.Controls.Add(this.BtnIniciarSesion);
            this.FlwPnlBotones.Controls.Add(this.BtnCancelar);
            this.FlwPnlBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlwPnlBotones.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.FlwPnlBotones.Location = new System.Drawing.Point(0, 245);
            this.FlwPnlBotones.Name = "FlwPnlBotones";
            this.FlwPnlBotones.Size = new System.Drawing.Size(395, 35);
            this.FlwPnlBotones.TabIndex = 4;
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarSesion.Location = new System.Drawing.Point(292, 3);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(100, 30);
            this.BtnIniciarSesion.TabIndex = 0;
            this.BtnIniciarSesion.Text = "Entrar";
            this.BtnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(186, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Salir";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(395, 288);
            this.Controls.Add(this.FlwPnlBotones);
            this.Controls.Add(this.TbPnlDatos);
            this.Controls.Add(this.PbLogo);
            this.Controls.Add(this.LblIniciarSesion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.TbPnlDatos.ResumeLayout(false);
            this.TbPnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRevelarClave)).EndInit();
            this.FlwPnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LblIniciarSesion;
        private System.Windows.Forms.PictureBox PbLogo;
        private System.Windows.Forms.TableLayoutPanel TbPnlDatos;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.PictureBox PbUsuario;
        private System.Windows.Forms.PictureBox PbClave;
        private System.Windows.Forms.PictureBox PbRevelarClave;
        private System.Windows.Forms.FlowLayoutPanel FlwPnlBotones;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.Button BtnCancelar;
    }
}