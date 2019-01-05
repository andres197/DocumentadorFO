using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace DocumentadorFO12
{
    public partial class Login : Form
    {

        //Llamar la libreria MYSQL 

        MySqlCommand cmd;
        MySqlDataAdapter ad;

        public Login()
        {
            InitializeComponent();
        }

        public void logeo(string Usuario, string Contrasena)
        {
            //CONSULTA MYSQL USUARIO Y CONTRASEÑA 

            try
            {

            

            MySqlCommand cmd = new MySqlCommand("SELECT usuario, pwd, nombre, documento_identidad, formacion, supervision,  calidad, id FROM usuario WHERE Usuario= @Usuario AND pwd = @Contrasena ", Conexion.ObtenerConexion()); //Realizamos una selecion de la tabla usuarios.
            cmd.Parameters.AddWithValue("Usuario", Usuario);
            cmd.Parameters.AddWithValue("Contrasena", Contrasena);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //Conidicional login OK

            if (dt.Rows.Count == 1 )
            {
                this.Hide();

                //dt.Rows[0][3].ToString() <-- Captura de datos, resultado 0 columna 3

             /*   string documento_identidad = dt.Rows[0][3].ToString();
                string Nombre = dt.Rows[0][2].ToString();

                DocumentadorFO15.Soporte Soporte = new DocumentadorFO15.Soporte();

                //Envia los datos al formulario de soporte y se inicia

                Soporte.txtNombre.Text = Nombre;
                Soporte.txtNit.Text = documento_identidad; 
                
                
                Soporte.ShowDialog();  <---- esto envia la consulta directamente al textbox sin parametros*/


                //Se envia consulta al formulario soporte y se guararda en variable que recibe soporte como parametro
                new DocumentadorFO15.Soporte(dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString()).Show();
               

            }
            else
            {
                MessageBox.Show("Usuario o contraseña errado, verifique la informacion", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
            catch (Exception ex)
               {
                MessageBox.Show(ex.Message);

               }

            }



            private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            //Conversion a MD5

            string login_pass = textBox2.Text;
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(login_pass);
            byte[] hash = md5.ComputeHash(inputBytes);
            login_pass = BitConverter.ToString(hash).Replace("-", "");

            // textBox2.Text = login_pass;

            logeo(this.textBox1.Text, login_pass);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                //Conversion a MD5

                string login_pass = textBox2.Text;
                MD5 md5 = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(login_pass);
                byte[] hash = md5.ComputeHash(inputBytes);
                login_pass = BitConverter.ToString(hash).Replace("-", "");

                // textBox2.Text = login_pass;

                logeo(this.textBox1.Text, login_pass);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                //Conversion a MD5

                string login_pass = textBox2.Text;
                MD5 md5 = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(login_pass);
                byte[] hash = md5.ComputeHash(inputBytes);
                login_pass = BitConverter.ToString(hash).Replace("-", "");

                // textBox2.Text = login_pass;

                logeo(this.textBox1.Text, login_pass);
            }
        }
    }
}
