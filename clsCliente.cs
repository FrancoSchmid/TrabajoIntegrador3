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
            conexion.Close();
            conexion.Dispose();
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
            conexion.Close();
            conexion.Dispose();
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
            conexion.Close();
            conexion.Dispose();
        }

        public void Ordenar(DataGridView grilla, ComboBox opcion, ComboBox criterio)
        {
            LlamarDatos();

            // Crear un vector para almacenar las filas de la grilla
            int numFilas = grilla.Rows.Count - 1; // Excluimos la fila en blanco
            DataGridViewRow[] vectorFilas = new DataGridViewRow[numFilas];

            // Llenar el vector con las filas del DataGridView
            for (int i = 0; i < numFilas; i++)
            {
                vectorFilas[i] = grilla.Rows[i];
            }

            // Ordenar el vector usando un algoritmo de ordenamiento
            for (int i = 0; i < numFilas - 1; i++)
            {
                for (int j = i + 1; j < numFilas; j++)
                {
                    bool intercambio = false;

                    // Obtener los valores según el criterio seleccionado
                    object valorActual = vectorFilas[i].Cells[criterio.Text].Value;
                    object valorSiguiente = vectorFilas[j].Cells[criterio.Text].Value;

                    // Comparar los valores en función del tipo de dato y la ordenación seleccionada
                    if (criterio.Text == "IdCliente" || criterio.Text == "Deuda" || criterio.Text == "Limite" || criterio.Text == "IdCiudad")
                    {
                        // Convertir a decimal para los campos numéricos
                        decimal actual = Convert.ToDecimal(valorActual);
                        decimal siguiente = Convert.ToDecimal(valorSiguiente);

                        if (opcion.Text == "Ascendente" && actual > siguiente)
                        {
                            intercambio = true;
                        }
                        else if (opcion.Text == "Descendente" && actual < siguiente)
                        {
                            intercambio = true;
                        }
                    }
                    else if (criterio.Text == "Nombre")
                    {
                        // Convertir a string para los campos de texto
                        string actual = valorActual.ToString();
                        string siguiente = valorSiguiente.ToString();

                        if (opcion.Text == "Ascendente" && string.Compare(actual, siguiente) > 0)
                        {
                            intercambio = true;
                        }
                        else if (opcion.Text == "Descendente" && string.Compare(actual, siguiente) < 0)
                        {
                            intercambio = true;
                        }
                    }

                    // Realizar el intercambio si es necesario
                    if (intercambio)
                    {
                        DataGridViewRow temp = vectorFilas[i];
                        vectorFilas[i] = vectorFilas[j];
                        vectorFilas[j] = temp;
                    }
                }
            }

            // Limpiar la grilla y cargar las filas ordenadas
            grilla.Rows.Clear();
            foreach (DataGridViewRow fila in vectorFilas)
            {
                grilla.Rows.Add(fila.Cells[0].Value, fila.Cells[1].Value, fila.Cells[2].Value, fila.Cells[3].Value, fila.Cells[4].Value);
            }

            conexion.Close();
            conexion.Dispose();
        }

        public void AgregarCliente(TextBox nombre, TextBox deuda, TextBox limite, TextBox ciudad)
        {
            try
            {
                // Establecer la conexión a la base de datos
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();

                // Configurar el comando SQL para insertar un nuevo registro en la tabla Cliente
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO Cliente (Nombre, Deuda, Limite, Ciudad) VALUES (@Nombre, @Deuda, @Limite, @Ciudad)";

                // Agregar parámetros para evitar problemas de inyección SQL
                comando.Parameters.AddWithValue("@Nombre", nombre.Text);
                comando.Parameters.AddWithValue("@Deuda", Convert.ToDecimal(deuda.Text));
                comando.Parameters.AddWithValue("@Limite", Convert.ToDecimal(limite.Text));
                comando.Parameters.AddWithValue("@Ciudad", ciudad.Text);

                // Ejecutar el comando
                int rowsAffected = comando.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cliente agregado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo agregar el cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Asegurarse de cerrar la conexión
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }

                // Limpiar los parámetros del comando para evitar problemas en futuras consultas
                comando.Parameters.Clear();
            }
        }


    }
}
