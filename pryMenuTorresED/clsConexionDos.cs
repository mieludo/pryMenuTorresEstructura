using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMenuTorresED
{
    internal class clsConexionDos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        
        private string CadenaConexion = " Provider = Microsoft.JET.OLEDB.4.0; Data Source = Libreria.mdb";
       
        public void listar(DataGridView grilla, String Dato)
        {
            conexion.ConnectionString = CadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = Dato;

            DataSet ds = new DataSet();
            adaptador = new OleDbDataAdapter(comando);
            adaptador.Fill(ds, Dato);

            grilla.DataSource = null;
            grilla.DataSource = ds.Tables[Dato];


            conexion.Close();
        }

    }
}
