using Congelados.Presentacion.CapitalHumano;
using Congelados.Presentacion.Compras;
using Congelados.Presentacion.Inventario;
using Congelados.Presentacion.Seguridad;
using Congelados.Presentacion.Ventas;
using System;
using System.Windows.Forms;

namespace Congelados.Presentacion.Principal
{
    public partial class FrmPrincipal : Form
    {
        /// <summary>
        /// Formulario a agregar en el panel principal.
        /// </summary>
        private Form ChildForm;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Agrega un formulario al panel principal.
        /// </summary>
        /// <param name="form">Formulario a agregar.</param>
        private void AddForm(Form form)
        {
            ChildForm?.Close();

            ChildForm = form;

            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;

            PnlPrincipal.Controls.Add(ChildForm);
            PnlPrincipal.Tag = ChildForm;

            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "¿Desea cerrar el programa? Los cambios no guardados pueden perderse.", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            e.Cancel = result == DialogResult.No;
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            AddForm(new FrmBuscadorEmpleados());
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            AddForm(new FrmBuscadorProveedores());
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            AddForm(new FrmBuscadorProductos());
        }

        private void BtnMateriasPrimas_Click(object sender, EventArgs e)
        {
            AddForm(new FrmBuscadorMateriasPrimas());
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            AddForm(new FrmBuscadorClientes());
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AddForm(new FrmBuscadorUsuarios());
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            AddForm(new FrmCajaCompras());
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            AddForm(new FrmCajaVentas());
        }
    }
}
