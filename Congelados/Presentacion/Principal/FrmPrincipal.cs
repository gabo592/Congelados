using Congelados.Presentacion.CapitalHumano;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
