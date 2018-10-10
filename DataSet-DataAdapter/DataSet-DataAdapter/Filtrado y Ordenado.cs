using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace DataSet_DataAdapter
{
    public partial class FiltradoOrdenado : Form
    {
        public FiltradoOrdenado()
        {
            InitializeComponent();
        }

        private void FiltradoOrdenado_Load(object sender, EventArgs e)
        {
            // Cadena de conexión
            string connString = @"server = (local)\sqlexpress; 
                database = AdventureWorks2014; integrated security = true;";

            // Query
            string sql1 = @"SELECT *
                            FROM Production.Product
                            WHERE Name LIKE 'Mountain%'";
            string sql2 = @"SELECT *
                            FROM Production.Product
                            WHERE StandardCost > 10.0";

            // Combinar los querys
            string sql = sql1 + sql2;

            // Crear la conexión
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                // Crear el DataAdapter
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sql, conn);

                // Crear y llenar el DataSet
                DataSet ds = new DataSet();
                da.Fill(ds, "Production.Product");

                // Crear una colección de tablas
                DataTableCollection dtc = ds.Tables;

                // Desplegar los datos de la primera consulta
                txtOrdenar.AppendText("Resultados de la tabla Product:\n");
                txtOrdenar.AppendText("*******************************\n");
                txtOrdenar.AppendText("Nombre\t\t\t\tCódigo Producto\n");
                txtOrdenar.AppendText("________________________________________\n");

                // Establecer un filtro
                string filtro = "Color = 'Black'";

                // Establecer el orden
                string orden = "ProductNumber asc";

                // Desplegar los datos filtrados y ordenados
                foreach (DataRow row in dtc["Production.Product"].Select(filtro, orden))
                {
                    txtOrdenar.AppendText(row["Name"].ToString().PadRight(25));
                    txtOrdenar.AppendText("\t\t");
                    txtOrdenar.AppendText(row["Name"].ToString());
                    txtOrdenar.AppendText(Environment.NewLine);
                }

                txtOrdenar.AppendText("==================================================");

                // Desplegar los datos de la segunda consulta
                txtOrdenar.AppendText("Resultados de la tabla Product:\n");
                txtOrdenar.AppendText("*******************************\n");
                txtOrdenar.AppendText("Nombre\t\t\t\tCódigo Producto\n");
                txtOrdenar.AppendText("________________________________________\n");

                // Desplegar los datos
                foreach (DataRow row in dtc[1].Rows)
                {
                    txtOrdenar.AppendText(row["Name"].ToString().PadRight(25));
                    txtOrdenar.AppendText("\t\t");
                    txtOrdenar.AppendText(row["StandardCost"].ToString());
                    txtOrdenar.AppendText(Environment.NewLine);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la excepción");
            }
            finally
            {
                // Cerrar la conexión
                conn.Close();
            }
        }
    }
}





