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
    public partial class GenerarXML : Form
    {
        public GenerarXML()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Conexión
            string connString = @"server = (local)\sqlexpress;
                database = AdventureWorks2014; Integrated Security = true;";

            // Query
            string sql = @"SELECT ProductNumber, Name
                           FROM Production.Product";

            // Crear la conexión
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                // Crear el DataAdapter
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sql, conn);

                // Abrir la conexión
                conn.Open();

                // Crear y llenar el DataSet
                DataSet ds = new DataSet();
                da.Fill(ds, "Production.Product");

                // Extraer la información del DataSet y
                // enviarla a un archivo XML
                ds.WriteXml(@"d:\products.xml");
                MessageBox.Show("El archivo XML ha sido creado satisfactoriamente.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la conexión");
            }
            finally
            {
                // Cerrar la conexión
                conn.Close();
            }
        }
    }
}
