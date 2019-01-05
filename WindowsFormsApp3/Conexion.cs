using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentadorFO12
{
    public class Conexion
    {
        public static MySqlConnection ObtenerConexion()
        {
            //MySqlConnection conectar = new MySqlConnection("server=10.110.64.225; port=3306; database=planillas; Uid=intranet; pwd=Latcom2018*+-*;");
            MySqlConnection conectar = new MySqlConnection("server=localhost; port=3306; database=planillas; Uid=root; pwd=;");


            try
            {

                conectar.Open();

                //MySqlDataAdapter adapter = new MySqlDataAdapter("Query", conectar);

                // conectar.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar " + ex.Message);
            }
            return conectar;
        }

    }
}
