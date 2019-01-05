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

namespace DocumentadorFO12
{
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }
        //MYSQL 

        MySqlCommand cmd;
        MySqlDataAdapter ad;

        // variables datos a extraer

        public static string id = "null", consecutivointerno, ultimamodificacionpor, fechaultimamodificacion, estado, fecha1ergestion, formacion, supervision, calidad, estado1ergestion, nombre, telefono, nit, correo, chatSpark, servicioSolicitud, subEstado, fallaReportada, cuentaEnlace, redAcceso, equipo, radicadoTicket, nombreEmpresa, direccion, ciudad, horarioAtencion, horarioAtencionFDS, reincidente, observaciones, tkInterno, nombreContactoSede, telefonoContactoSede, ClienteBW, puertosSW, PDSR, ValidacionSW, ValidacionRuta, ValidacionUM, ValidacionCPE, SenalizacionSER, CierreSintoma, CierreFInicio, CierreFSolucion, CierreDown, CierreFCausa, CierreSolDef, CierreSolFalla, CierreSolFalaRazon, CierraFallaAtribuible, PQRActiva, TkRed, MotivoTransferencia, TrasferenciaRecibidoPor, PermisosIngerso, ValidacionCapa2, ConfiguracionCPE, SeEnviaCorreo, InfoAtencion, PermisosActuales, HabilitarPermisos, tipoDeGestionSelect, plantillaCierre, uccid, seRecibeCorreo, SolicitudEcare, UsuarioEcare, ContrasenaEcare, ClienteEcare, LineaDeSoporte, LineaGestion, agenteasignado;

        private void txtbucar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.buscar();
            }
        }

        public void buscar()
        {
            if (radioFront.Checked == false & radioBacklinea.Checked == false)
            {

                MessageBox.Show("Por favor seleccione la liena que va a consultar", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);



            }

            if (radioFront.Checked | radioBacklinea.Checked == true)
            {

                /* if (txtbucar.Text.Trim() == "")
                 {
                     txtbucar.Text = "0";
                 }
                 */

                if (string.IsNullOrEmpty(txtbucar.Text.Trim()) == false)
                {



                    try
                    {



                        DataTable Registros = new DataTable();
                        ad = new MySqlDataAdapter("SELECT `id`, `consecutivointerno`, `ultimamodificacionpor`, `fechaultimamodificacion`, `estado`, `fecha1ergestion`, `formacion`, `supervision`, `calidad`, `estado1ergestion`, `nombre`, `telefono`, `nit`, `correo`, `chatSpark`, `servicioSolicitud`, `subEstado`, `fallaReportada`, `cuentaEnlace`, `redAcceso`, `equipo`, `radicadoTicket`, `nombreEmpresa`, `direccion`, `ciudad`, `horarioAtencion`, `horarioAtencionFDS`, `reincidente`, `observaciones`, `tkInterno`, `nombreContactoSede`, `telefonoContactoSede`, `ClienteBW`, `puertosSW`, `PDSR`, `ValidacionSW`, `ValidacionRuta`, `ValidacionUM`, `ValidacionCPE`, `SenalizacionSER`, `CierreSintoma`, `CierreFInicio`, `CierreFSolucion`, `CierreDown`, `CierreFCausa`, `CierreSolDef`, `CierreSolFalla`, `CierreSolFalaRazon`, `CierraFallaAtribuible`, `PQRActiva`, `TkRed`, `MotivoTransferencia`, `TrasferenciaRecibidoPor`, `PermisosIngerso`, `ValidacionCapa2`, `ConfiguracionCPE`, `SeEnviaCorreo`, `InfoAtencion`, `PermisosActuales`, `HabilitarPermisos`, `tipoDeGestionSelect`, `plantillaCierre`, `uccid`, `seRecibeCorreo`, `SolicitudEcare`, `UsuarioEcare`, `ContrasenaEcare`, `ClienteEcare`, `agenteasignado` FROM " + LineaDeSoporte + ".registros WHERE `radicadoTicket`  = " + txtbucar.Text + "", Conexion.ObtenerConexion()); ad.Fill(Registros);
                        dgvBuscar.DataSource = Registros;


                        this.dgvBuscar.Columns["id"].Visible = false;
                        this.dgvBuscar.Columns["fecha1ergestion"].Visible = false;
                        this.dgvBuscar.Columns["formacion"].Visible = false;
                        this.dgvBuscar.Columns["supervision"].Visible = false;
                        this.dgvBuscar.Columns["calidad"].Visible = false;
                        this.dgvBuscar.Columns["estado1ergestion"].Visible = false;
                        this.dgvBuscar.Columns["nombre"].Visible = false;
                        this.dgvBuscar.Columns["telefono"].Visible = false;
                        this.dgvBuscar.Columns["nit"].Visible = false;
                        this.dgvBuscar.Columns["correo"].Visible = false;
                        this.dgvBuscar.Columns["chatSpark"].Visible = false;
                        this.dgvBuscar.Columns["servicioSolicitud"].Visible = false;
                        this.dgvBuscar.Columns["subEstado"].Visible = false;
                        this.dgvBuscar.Columns["fallaReportada"].Visible = false;
                        this.dgvBuscar.Columns["cuentaEnlace"].Visible = false;
                        this.dgvBuscar.Columns["redAcceso"].Visible = false;
                        this.dgvBuscar.Columns["equipo"].Visible = false;
                        this.dgvBuscar.Columns["radicadoTicket"].Visible = false;
                        this.dgvBuscar.Columns["nombreEmpresa"].Visible = false;
                        this.dgvBuscar.Columns["direccion"].Visible = false;
                        this.dgvBuscar.Columns["ciudad"].Visible = false;
                        this.dgvBuscar.Columns["horarioAtencion"].Visible = false;
                        this.dgvBuscar.Columns["horarioAtencionFDS"].Visible = false;
                        this.dgvBuscar.Columns["reincidente"].Visible = false;
                        this.dgvBuscar.Columns["observaciones"].Visible = false;
                        this.dgvBuscar.Columns["tkInterno"].Visible = false;
                        this.dgvBuscar.Columns["nombreContactoSede"].Visible = false;
                        this.dgvBuscar.Columns["telefonoContactoSede"].Visible = false;
                        this.dgvBuscar.Columns["ClienteBW"].Visible = false;
                        this.dgvBuscar.Columns["puertosSW"].Visible = false;
                        this.dgvBuscar.Columns["PDSR"].Visible = false;
                        this.dgvBuscar.Columns["ValidacionSW"].Visible = false;
                        this.dgvBuscar.Columns["ValidacionRuta"].Visible = false;
                        this.dgvBuscar.Columns["ValidacionUM"].Visible = false;
                        this.dgvBuscar.Columns["ValidacionCPE"].Visible = false;
                        this.dgvBuscar.Columns["SenalizacionSER"].Visible = false;
                        this.dgvBuscar.Columns["CierreSintoma"].Visible = false;
                        this.dgvBuscar.Columns["CierreFInicio"].Visible = false;
                        this.dgvBuscar.Columns["CierreFSolucion"].Visible = false;
                        this.dgvBuscar.Columns["CierreDown"].Visible = false;
                        this.dgvBuscar.Columns["CierreFCausa"].Visible = false;
                        this.dgvBuscar.Columns["CierreSolDef"].Visible = false;
                        this.dgvBuscar.Columns["CierreSolFalla"].Visible = false;
                        this.dgvBuscar.Columns["CierreSolFalaRazon"].Visible = false;
                        this.dgvBuscar.Columns["CierraFallaAtribuible"].Visible = false;
                        this.dgvBuscar.Columns["PQRActiva"].Visible = false;
                        this.dgvBuscar.Columns["TkRed"].Visible = false;
                        this.dgvBuscar.Columns["MotivoTransferencia"].Visible = false;
                        this.dgvBuscar.Columns["TrasferenciaRecibidoPor"].Visible = false;
                        this.dgvBuscar.Columns["PermisosIngerso"].Visible = false;
                        this.dgvBuscar.Columns["ValidacionCapa2"].Visible = false;
                        this.dgvBuscar.Columns["ConfiguracionCPE"].Visible = false;
                        this.dgvBuscar.Columns["SeEnviaCorreo"].Visible = false;
                        this.dgvBuscar.Columns["InfoAtencion"].Visible = false;
                        this.dgvBuscar.Columns["PermisosActuales"].Visible = false;
                        this.dgvBuscar.Columns["HabilitarPermisos"].Visible = false;
                        this.dgvBuscar.Columns["tipoDeGestionSelect"].Visible = false;
                        this.dgvBuscar.Columns["plantillaCierre"].Visible = false;
                        this.dgvBuscar.Columns["uccid"].Visible = false;
                        this.dgvBuscar.Columns["seRecibeCorreo"].Visible = false;
                        this.dgvBuscar.Columns["SolicitudEcare"].Visible = false;
                        this.dgvBuscar.Columns["UsuarioEcare"].Visible = false;
                        this.dgvBuscar.Columns["ContrasenaEcare"].Visible = false;
                        this.dgvBuscar.Columns["agenteasignado"].Visible = false;
                        this.dgvBuscar.Columns["ClienteEcare"].Visible = false;

                        //Se cambia el nombre de la columna

                        dgvBuscar.Columns[1].HeaderText = "Consecutivo Interno";
                        dgvBuscar.Columns[2].HeaderText = "Ultima Modificacion";
                        dgvBuscar.Columns[3].HeaderText = "Fecha de Modificacion";
                        dgvBuscar.Columns[4].HeaderText = "Estado";

                        // this.dgvBuscar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;



                        // this.dgvBuscar.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        // this.dgvBuscar.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        //this.dgvBuscar.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                        //this.dgvBuscar.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


                    }

                    catch (Exception exx)
                    {
                        MessageBox.Show(exx.Message);
                    }
                }
            }

        }

        private void txtbucar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Buscar_Load(object sender, EventArgs e)
        {

        }

        private void radioBacklinea_CheckedChanged(object sender, EventArgs e)
        {
            LineaDeSoporte = "empresasNegociosBack";
            LineaGestion = "FO BACK";
        }

        private void radioFront_CheckedChanged(object sender, EventArgs e)
        {
            LineaDeSoporte = "empresasNegociosFront";
            LineaGestion = "FO FRONT";
        }

        private void dgvBuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //DocumentadorFO15.Soporte Soporte = new DocumentadorFO15.Soporte();
            this.Close();

        }

        private void dgvBuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Envia los datos al formulario de soporte

            try
            {
         
                if (dgvBuscar.SelectedRows.Count >0)
                {

                

                id = dgvBuscar.Rows[e.RowIndex].Cells["id"].Value.ToString();
                consecutivointerno = dgvBuscar.Rows[e.RowIndex].Cells["consecutivointerno"].Value.ToString();
                ultimamodificacionpor = dgvBuscar.Rows[e.RowIndex].Cells["ultimamodificacionpor"].Value.ToString();
                fechaultimamodificacion = dgvBuscar.Rows[e.RowIndex].Cells["fechaultimamodificacion"].Value.ToString();
                estado = dgvBuscar.Rows[e.RowIndex].Cells["estado"].Value.ToString();
                fecha1ergestion = dgvBuscar.Rows[e.RowIndex].Cells["fecha1ergestion"].Value.ToString();
                formacion = dgvBuscar.Rows[e.RowIndex].Cells["formacion"].Value.ToString();
                supervision = dgvBuscar.Rows[e.RowIndex].Cells["supervision"].Value.ToString();
                calidad = dgvBuscar.Rows[e.RowIndex].Cells["calidad"].Value.ToString();
                nombre = dgvBuscar.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                telefono = dgvBuscar.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
                nit = dgvBuscar.Rows[e.RowIndex].Cells["nit"].Value.ToString();
                correo = dgvBuscar.Rows[e.RowIndex].Cells["correo"].Value.ToString();
                chatSpark = dgvBuscar.Rows[e.RowIndex].Cells["chatSpark"].Value.ToString();
                servicioSolicitud = dgvBuscar.Rows[e.RowIndex].Cells["servicioSolicitud"].Value.ToString();
                subEstado = dgvBuscar.Rows[e.RowIndex].Cells["subEstado"].Value.ToString();
                fallaReportada = dgvBuscar.Rows[e.RowIndex].Cells["fallaReportada"].Value.ToString();
                cuentaEnlace = dgvBuscar.Rows[e.RowIndex].Cells["cuentaEnlace"].Value.ToString();
                redAcceso = dgvBuscar.Rows[e.RowIndex].Cells["redAcceso"].Value.ToString();
                equipo = dgvBuscar.Rows[e.RowIndex].Cells["equipo"].Value.ToString();
                radicadoTicket = dgvBuscar.Rows[e.RowIndex].Cells["radicadoTicket"].Value.ToString();
                nombreEmpresa = dgvBuscar.Rows[e.RowIndex].Cells["nombreEmpresa"].Value.ToString();
                direccion = dgvBuscar.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
                ciudad = dgvBuscar.Rows[e.RowIndex].Cells["ciudad"].Value.ToString();
                horarioAtencion = dgvBuscar.Rows[e.RowIndex].Cells["horarioAtencion"].Value.ToString();
                horarioAtencionFDS = dgvBuscar.Rows[e.RowIndex].Cells["horarioAtencionFDS"].Value.ToString();
                reincidente = dgvBuscar.Rows[e.RowIndex].Cells["reincidente"].Value.ToString();
                observaciones = dgvBuscar.Rows[e.RowIndex].Cells["observaciones"].Value.ToString();
                tkInterno = dgvBuscar.Rows[e.RowIndex].Cells["tkInterno"].Value.ToString();
                nombreContactoSede = dgvBuscar.Rows[e.RowIndex].Cells["nombreContactoSede"].Value.ToString();
                telefonoContactoSede = dgvBuscar.Rows[e.RowIndex].Cells["telefonoContactoSede"].Value.ToString();
                ClienteBW = dgvBuscar.Rows[e.RowIndex].Cells["ClienteBW"].Value.ToString();
                puertosSW = dgvBuscar.Rows[e.RowIndex].Cells["puertosSW"].Value.ToString();
                PDSR = dgvBuscar.Rows[e.RowIndex].Cells["PDSR"].Value.ToString();
                ValidacionSW = dgvBuscar.Rows[e.RowIndex].Cells["ValidacionSW"].Value.ToString();
                ValidacionRuta = dgvBuscar.Rows[e.RowIndex].Cells["ValidacionRuta"].Value.ToString();
                ValidacionUM = dgvBuscar.Rows[e.RowIndex].Cells["ValidacionUM"].Value.ToString();
                ValidacionCPE = dgvBuscar.Rows[e.RowIndex].Cells["ValidacionCPE"].Value.ToString();
                SenalizacionSER = dgvBuscar.Rows[e.RowIndex].Cells["SenalizacionSER"].Value.ToString();
                CierreSintoma = dgvBuscar.Rows[e.RowIndex].Cells["CierreSintoma"].Value.ToString();
                CierreFInicio = dgvBuscar.Rows[e.RowIndex].Cells["CierreFInicio"].Value.ToString();
                CierreFSolucion = dgvBuscar.Rows[e.RowIndex].Cells["CierreFSolucion"].Value.ToString();
                CierreDown = dgvBuscar.Rows[e.RowIndex].Cells["CierreDown"].Value.ToString();
                CierreFCausa = dgvBuscar.Rows[e.RowIndex].Cells["CierreFCausa"].Value.ToString();
                CierreSolDef = dgvBuscar.Rows[e.RowIndex].Cells["CierreSolDef"].Value.ToString();
                CierreSolFalla = dgvBuscar.Rows[e.RowIndex].Cells["CierreSolFalla"].Value.ToString();
                CierreSolFalaRazon = dgvBuscar.Rows[e.RowIndex].Cells["CierreSolFalaRazon"].Value.ToString();
                CierraFallaAtribuible = dgvBuscar.Rows[e.RowIndex].Cells["CierraFallaAtribuible"].Value.ToString();
                PQRActiva = dgvBuscar.Rows[e.RowIndex].Cells["PQRActiva"].Value.ToString();
                TkRed = dgvBuscar.Rows[e.RowIndex].Cells["TkRed"].Value.ToString();
                MotivoTransferencia = dgvBuscar.Rows[e.RowIndex].Cells["MotivoTransferencia"].Value.ToString();
                TrasferenciaRecibidoPor = dgvBuscar.Rows[e.RowIndex].Cells["TrasferenciaRecibidoPor"].Value.ToString();
                PermisosIngerso = dgvBuscar.Rows[e.RowIndex].Cells["PermisosIngerso"].Value.ToString();
                ValidacionCapa2 = dgvBuscar.Rows[e.RowIndex].Cells["ValidacionCapa2"].Value.ToString();
                ConfiguracionCPE = dgvBuscar.Rows[e.RowIndex].Cells["ConfiguracionCPE"].Value.ToString();
                SeEnviaCorreo = dgvBuscar.Rows[e.RowIndex].Cells["SeEnviaCorreo"].Value.ToString();
                InfoAtencion = dgvBuscar.Rows[e.RowIndex].Cells["InfoAtencion"].Value.ToString();
                PermisosActuales = dgvBuscar.Rows[e.RowIndex].Cells["PermisosActuales"].Value.ToString();
                HabilitarPermisos = dgvBuscar.Rows[e.RowIndex].Cells["HabilitarPermisos"].Value.ToString();
                tipoDeGestionSelect = dgvBuscar.Rows[e.RowIndex].Cells["tipoDeGestionSelect"].Value.ToString();
                plantillaCierre = dgvBuscar.Rows[e.RowIndex].Cells["plantillaCierre"].Value.ToString();
                uccid = dgvBuscar.Rows[e.RowIndex].Cells["uccid"].Value.ToString();
                seRecibeCorreo = dgvBuscar.Rows[e.RowIndex].Cells["seRecibeCorreo"].Value.ToString();
                SolicitudEcare = dgvBuscar.Rows[e.RowIndex].Cells["SolicitudEcare"].Value.ToString();
                UsuarioEcare = dgvBuscar.Rows[e.RowIndex].Cells["UsuarioEcare"].Value.ToString();
                ContrasenaEcare = dgvBuscar.Rows[e.RowIndex].Cells["ContrasenaEcare"].Value.ToString();
                ClienteEcare = dgvBuscar.Rows[e.RowIndex].Cells["ClienteEcare"].Value.ToString();
                agenteasignado = dgvBuscar.Rows[e.RowIndex].Cells["agenteasignado"].Value.ToString();
                }
            }

            catch (Exception exx)
            {
                MessageBox.Show("Seleccione un dato", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }




        }



        private void button5_Click(object sender, EventArgs e)
        {
            this.buscar();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (id == "null")
            {
                MessageBox.Show("Por favor seleccione un dato", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (id != "null")
            {
                this.Close();
            }
            
        }
    }
}
