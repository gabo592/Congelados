namespace Congelados.Presentacion.Principal
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PnlSideBar = new System.Windows.Forms.Panel();
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.BtnEmpleados = new System.Windows.Forms.Button();
            this.PnlSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlSideBar
            // 
            this.PnlSideBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PnlSideBar.Controls.Add(this.BtnEmpleados);
            this.PnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.PnlSideBar.Name = "PnlSideBar";
            this.PnlSideBar.Size = new System.Drawing.Size(146, 461);
            this.PnlSideBar.TabIndex = 1;
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPrincipal.Location = new System.Drawing.Point(146, 0);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(758, 461);
            this.PnlPrincipal.TabIndex = 2;
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnEmpleados.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpleados.Location = new System.Drawing.Point(0, 0);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Size = new System.Drawing.Size(146, 35);
            this.BtnEmpleados.TabIndex = 0;
            this.BtnEmpleados.Text = "Empleados";
            this.BtnEmpleados.UseVisualStyleBackColor = true;
            this.BtnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 461);
            this.Controls.Add(this.PnlPrincipal);
            this.Controls.Add(this.PnlSideBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.PnlSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlSideBar;
        private System.Windows.Forms.Panel PnlPrincipal;
        private System.Windows.Forms.Button BtnEmpleados;
    }
}