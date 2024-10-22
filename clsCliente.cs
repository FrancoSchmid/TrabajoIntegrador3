using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryTrabajoIntegrador3
{
    public class clsCliente
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adapter = new OleDbDataAdapter();

        private String cadenaConexion = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=Clientes.mdb";
        private String tabla = "Cliente";

        private Int32 cantidad = 0;
        private Decimal deuda = 0;
        private Decimal promedio = 0;

        public Int32 Cantidad
        {
            get { return cantidad; }
        }

        public Decimal Deuda
        {
            get { return deuda; }
        }

        public Decimal Promedio
        {
            get { return promedio; }
        }

        public void LlamarDatos ()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = tabla;

            adapter = new OleDbDataAdapter(comando);
        }
        public void Buscar(Int32 IdCliente, DataGridView grilla)
        {
            try
            {
                LlamarDatos();

                adapter = new OleDbDataAdapter(comando);
                OleDbDataReader DR = comando.ExecuteReader();
                grilla.Rows.Clear();

                while (DR.Read())
                {
                    if (IdCliente == DR.GetInt32(0))
                    {
                        grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetDecimal(2), DR.GetDecimal(3), DR.GetInt32(4));

                    }
                }

                DR.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void Listar(DataGridView grilla)
        {
            try
            {
                LlamarDatos();

                DataSet DS = new DataSet();
                adapter.Fill(DS);

                grilla.DataSource = DS.Tables[0];
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ListarDeudores(DataGridView grilla)
        {
            try
            {
                LlamarDatos();

                OleDbDataReader DR = comando.ExecuteReader();
                grilla.Rows.Clear();

                while (DR.Read())
                {
                    grilla.Rows.Add(DR.GetInt32(0), DR.GetString(1), DR.GetDecimal(2));
                    cantidad++;
                    deuda = DR.GetDecimal(2) + deuda;
                }

                promedio = deuda / cantidad;
                DR.Close();
            }
            catch (Exception e)
            { 
                MessageBox.Show(e.ToString());
            }
        }
    }
}
