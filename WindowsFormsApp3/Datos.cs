using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentadorFO15
{
    public partial class Datos : Form
    {
        public Datos()
        {
            InitializeComponent();
        }

        public void DatosInfo()
        {
            richComentario.Text = "-------------------------------------------------" + "\r\n" + "\r\n" + "DESPLAZAMIENTO_DATOS" + "\r\n" + "\r\n" + "-------------------------------------------------" + "\r\n" + "\r\n" +
            lblContacto.Text + " " + txtContacto.Text + "\r\n" + "\r\n" +
            lblDir.Text + " " + txtDir.Text + "\r\n" + "\r\n" +
            lblCiudad.Text + " " + txtCiudad.Text + "\r\n" + "\r\n" +
            "Horario atención (Lunes / Viernes):" + " " + txtHorario.Text + "\r\n" + "\r\n" +
            "Horario atención ( Fin de semana ): " + texthorarioFDS.Text + "\r\n" + "\r\n" +
            lblTServicio.Text + " " + cmbTipoServicio.Text + "\r\n" + "\r\n" +
            lblPermisos.Text + " " + txtPermisos.Text + "\r\n" + "\r\n" +
            lblEnlace.Text + " " + txtEnlace.Text + "\r\n" + "\r\n" +
            "Gestion: Inmediata" + "\r\n" + "\r\n" +
            "-------------------------------------------------" + "\r\n" + "\r\n" + lblEquipos.Text + " " + richEquipos.Text + "\r\n" + "\r\n" + 
            "-------------------------------------------------" + "\r\n" + "\r\n" + lblPotencia.Text + " " + txtPotencia.Text + "\r\n" + "\r\n" + 
            "-------------------------------------------------" + "\r\n" + "\r\n" + groupBox4.Text + " " + richObservaciones.Text + "\r\n" + "\r\n" + 
            "-------------------------------------------------" + "\r\n" + "\r\n" + "CONTACTO GESTIÓN INMEDIATA PYME" + "\r\n" + "\r\n" + 
            "-------------------------------------------------" + "\r\n" + "\r\n" + "7448595 Opción 4, Clave 3695." + "\r\n" + "\r\n" + 
            "-------------------------------------------------" + "\r\n" + "\r\n" + lblReporta.Text + " " + txtReporta.Text + "\r\n" + lblRecibe.Text + " " + txtRecibe.Text + "\r\n";








        }

            private void lblReincidente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void lblReporta_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DatosInfo();
            txtTkCRM.Text = "SIN SERVICIO // INMEDIATO // " + txtCiudad.Text;
        }

        private void Datos_Load(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtTkCRM_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCiudad_TextChanged(object sender, EventArgs e)
        {
            txtTkCRM.Text = "SIN SERVICIO // INMEDIATO // " + txtCiudad.Text;
        }

        private void txtCiudad_TextChanged_1(object sender, EventArgs e)
        {
            txtTkCRM.Text = "SIN SERVICIO // INMEDIATO // " + txtCiudad.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
