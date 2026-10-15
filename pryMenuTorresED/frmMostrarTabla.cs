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
    public partial class frmMostrarTabla : Form
    {
        public frmMostrarTabla()
        {
            InitializeComponent();
        }

        clsConexionDos objMostrarTabla = new clsConexionDos();

        private void frmMostrarTabla_Load(object sender, EventArgs e)
        {
            cboTabla.Items.Add("Autor");
            cboTabla.Items.Add("Idioma");
            cboTabla.Items.Add("Libro");
            cboTabla.Items.Add("Pais");

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            objMostrarTabla.listar(dgvTabla, cboTabla.Text);
        }
    }
}
