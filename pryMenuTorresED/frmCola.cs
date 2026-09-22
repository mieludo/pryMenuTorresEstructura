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
    public partial class frmCola : Form
    {
        clsCola Cola = new clsCola();
        public frmCola()
        {
            InitializeComponent();
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

            clsNodo objNodo = new clsNodo();

            objNodo.Codigo = codigo;
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            Cola.Agregar(objNodo);
            Cola.Recorrer(lbLista);
            Cola.Recorrer(dgvLista);

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();

            txtCodigo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Cola.Primero != null)
            {
                lblCodigoEliminar.Text = Cola.Primero.Codigo.ToString();
                lblNombreEliminar.Text = Cola.Primero.Nombre;
                lblTramiteEliminar.Text = Cola.Primero.Tramite;

                Cola.Eliminar();
                Cola.Recorrer(lbLista);
                Cola.Recorrer(dgvLista);
            }
            else
            {
                MessageBox.Show(
                    "La cola está vacía. No hay elementos para eliminar.",
                    "Cola vacía",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void frmCola_Load(object sender, EventArgs e)
        {

        }
    }
}
