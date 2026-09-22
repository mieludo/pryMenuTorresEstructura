using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMenuTorresED
{
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble ListaDoble = new clsListaDoble();
        private void frmListaDoble_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Int32 codigo;
            if (!Int32.TryParse(txtCodigo.Text, out codigo))
            {
                MessageBox.Show(
                    "Ingrese un código numérico válido.",
                    "Código inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtCodigo.Focus();
                return;
            }

            clsNodo Persona = new clsNodo();

            Persona.Codigo = codigo;
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            ListaDoble.Agregar(Persona);

            limpiarTodo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbxCodigo.SelectedItem != null)
            {
                if (ListaDoble.Eliminar(Convert.ToInt32(cbxCodigo.SelectedItem)))
                {
                    MessageBox.Show("Se eliminó correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el código indicado.");
                }

                limpiarTodo();
            }
            else
            {
                MessageBox.Show("No se seleccionó ningún valor para eliminar.");
            }
        }
        private void limpiarTodo()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

            LosRecorrer();
            cbxCodigo.SelectedIndex = -1;
            txtCodigo.Focus();
        }

        private void LosRecorrer()
        {
            ListaDoble.Recorrer(cbxCodigo);
            ListaDoble.Recorrer(dgvDatos);
            ListaDoble.RecorrerDes(lstListaDoble);
        }
    }
}
