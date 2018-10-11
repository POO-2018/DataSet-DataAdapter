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
    public partial class DataViewForm : Form
    {
        public DataViewForm()
        {
            InitializeComponent();
        }

        private void DataViewForm_Load(object sender, EventArgs e)
        {
            // Conexión
            string connString = @"server = (local)\sqlexpress;
                database = AdventureWorks2014; Integrated Security = true;";

            // Query
            string sql = @"SELECT FirstName, MiddleName, LastName
                           FROM Person.Person";

            // Crear la conexión
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                // Crear el Data Adapter
                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = new SqlCommand(sql, conn);

                // Crear y popular el DataSet
                DataSet ds = new DataSet();

                da.Fill(ds, "Person.Person");

                // Obtener los datos de la tabla de referencia
                DataTable dt = ds.Tables["Person.Person"];

                // Crear el DataView
                DataView dv = new DataView(dt,
                    "MiddleName = 'J.'",
                    "MiddleName",
                    DataViewRowState.Unchanged);

                // Desplegar los contactos del DataView en el DataGrid
                gvContactos.DataSource = dv;
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
