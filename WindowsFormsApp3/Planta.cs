using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentadorFO
{
    public partial class Planta : Form
    {
        public Planta()
        {
            InitializeComponent();
        }

        private void Planta_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            richComentario.Text = "\r\n" + "------------------------------------------------" + "\r\n" +
               "DESPLAZAMIENTO PLANTA EXTERNA" + "\r\n" +
               "------------------------------------------------" + "\r\n" +
               "Segmento: " + CmbSegmento.Text + "\r\n" +
               "Subsegmento: " + txtSubsegmento.Text + "\r\n" +
               "Contacto de quien reporta: " + txtSereportacon.Text + "\r\n" +
               "Dirección fisíca del cliente: " + txtDireccion.Text + "\r\n" +
               "Ciudad: " + txtCiudad.Text + "\r\n" +
               "SDS: " + txtSW.Text + "\r\n" +
               "Puerto: " + txtPuerto.Text + "\r\n" +
               "OT instalacion " + txtOTinstalacion.Text + "\r\n" +
               "Contacto del cliente: " + txtContactoDelCliente.Text + "\r\n" +
               "Fecha y hora de la ventana: " + txtFechayhoraventana.Text + "\r\n" +
               "Descripción de la actividad: " + richObservaciones.Text + "\r\n"
               ;

            TabPE.SelectedIndex = 1;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Gvalidaciones_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
