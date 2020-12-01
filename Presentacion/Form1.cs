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
using System.Windows;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\valen\source\repos\ConeccionBD\Presentacion\Prueba.mdf;Integrated Security = True

        public void Coneccion() {
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\valen\\source\\repos\\ConeccionBD\\Presentacion\\Prueba.mdf;Integrated Security = True";
            SqlConnection connection = new SqlConnection(connectionString);
            Mensaje(connection);
        }

        public void Mensaje(SqlConnection connection) {
            try
            {
                connection.Open();
                MessageBox.Show(" CONECTADO A LA BASE DE DATOS");
            }
            catch (Exception e )
            {
                MessageBox.Show(" ERROR" + e.Message);
                throw;
            }
            finally {
                connection.Close();
                MessageBox.Show("DESCONECTADO DE LA BASE DE DATOS");

            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coneccion();
        }
    }

}
