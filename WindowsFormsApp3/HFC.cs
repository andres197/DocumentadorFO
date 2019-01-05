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
    public partial class HFC : Form
    {
        public HFC()
        {
            InitializeComponent();
        }

        private void InitializeComponentnmn()
        {
            throw new NotImplementedException();
        }


        //Plantillas F7

        public void NotasF7()
        {
            richnotasf7.Text =
           "NOMBRE EMPRESA: " + txtNombreEmpresa.Text + "\r\n" +
           "DIRECCION:" + txtDir.Text + "\r\n" +
           "HORARIOS DE ATENCION:" + txtHora.Text + "\r\n" +
           "NOMBRE CONTACTO: " + txtNombreCliente.Text + "\r\n" +
           "TELEFONOS DE CONTACTO " + txtTelcliente.Text + "\r\n" +
           "CARGO: " + txtCargo.Text + "\r\n" +
           "CORREO: " + txtCorreoelectronico.Text + "\r\n" +
           "AUTORIZA COMUNICACIÓN VIA CORREO? " + cCorreo.Text + "\r\n" +
           "CEDULA " + txtCedulaCliente.Text + "\r\n" +
           "REPORTE DE FALLA: " + txtServicioAfectado.Text + "\r\n" +
           "DIAGNOSTICO DE REPORTE: " + txtdiagnosticofalla.Text + "\r\n" +
           "PROCESO EFECTUADO: " + txtObservaciones.Text + "\r\n" + "\r\n" +
           "LLS: " + txtlls.Text + "\r\n" +
           "AVISO: " + txtaviso.Text + "\r\n" +
           "Vecinos: " + txtvecinos.Text + "\r\n" +
           "ES REINCIDENTE: " + Creincidente.Text + "\r\n" +
           "REPORTE SOLO POR UN SERVICIO: " + Creportasoloun.Text + "\r\n" +
           "PQR EN CURSO POR ESTA CAUSA: " + cPQR.Text + "\r\n" +
           "CM / DECODIFICADOR / MTA ENGANCHADO: " + Cmodemenganchado.Text + "\r\n" +
           "SUBE CON REINICIO: " + cSubeConReinicio.Text + "\r\n" +
           "PROVISION CORRECTA(RR-MODULO - VISOR - CM - INTRAWAY): " + cSerepara.Text + "\r\n" +
           "VECINOS (incluyendo cuentas no matrices): " + txtvecinos.Text + "\r\n" +
           "HAY UN AVISO POR FALLA ENCONTRADA: " + cavisos.Text + "\r\n" +
           "MARCA MODEM " + txtRefEquipo.Text;
        }

        public void LLS()
        {
            

        }




            private void lblplantillacierre_Click(object sender, EventArgs e)
        {

        }

        private void plantilla_si_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void plantilla_no_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HFC_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.NotasF7();
        }

        private void HFC_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Al cerrar el programa toda la informacion se perdera ¿Desea cerrar el programa?",
               "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtPQR.Enabled = true;
            txtMarcacion.Enabled = true;
            txtlls.Enabled = true;
            txtaviso.Enabled = true;
            Creincidente.Enabled = true;
            Creportasoloun.Enabled = true;
            cPQR.Enabled = true;
            Cmodemenganchado.Enabled = true;
            cSubeConReinicio.Enabled = true;
            cSerepara.Enabled = true;
            cSubeConReinicio.Enabled = true;
            cvecinosafectados.Enabled = true;
            cavisos.Enabled = true;
            txtTitulonotas7.Enabled = true;
            richnotasf7.Enabled = true;




        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtPQR.Enabled = false;
            txtMarcacion.Enabled = false;
            txtlls.Enabled = false;
            txtaviso.Enabled = false;
            Creincidente.Enabled = false;
            Creportasoloun.Enabled = false;
            cPQR.Enabled = false;
            Cmodemenganchado.Enabled = false;
            cSubeConReinicio.Enabled = false;
            cSerepara.Enabled = false;
            cSubeConReinicio.Enabled = false;
            cvecinosafectados.Enabled = false;
            cavisos.Enabled = false;
            txtTitulonotas7.Enabled = false;
            richnotasf7.Enabled = false;
        }
    }
    }

