using DocumentadorFO;
using DocumentadorFO12;
using MySql.Data.MySqlClient;
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
    public partial class Soporte : Form
    {

        //MYSQL  <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        MySqlCommand cmd;
        MySqlDataAdapter ad;

        //Variables  <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        String nombresoporte, Documentosoporte, formacionsoporte, supervisionsoporte, calidadsoporte, idusuariosoporte, idhistorial, comentariohistorial, idconsulta = "null", LineaDeSoporte, LineaGestion, PrefijoSoporte, agenteasignado;

        //Variable hisotiral de modificaciones  <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        string historialestado;
        string historialnombre;
        string historialtelefono;
        string historialnit;
        string historialcorreo;
        string historialsubEstado;
        string historialservicioSolicitud;
        string historialfallaReportada;
        string historialcuentaEnlace;
        string historialredAcceso;
        string historialequipo;
        string historialradicadoTicket;
        string historialnombreEmpresa;
        string historialdireccion;
        string historialciudad;
        string historialhorarioAtencion;
        string historialhorarioAtencionFDS;
        string historialreincidente;
        string historialobservaciones;
        string historialtkInterno;
        string historialnombreContactoSede;
        string historialtelefonoContactoSede;
        string historialClienteBW;
        string historialpuertosSW;
        string historialPDSR;
        string historialValidacionSW;
        string historialValidacionRuta;
        string historialValidacionUM;
        string historialValidacionCPE;
        string historialSenalizacionSER;
        string historialCierreSintoma;
        string historialCierreFInicio;
        string historialCierreFSolucion;
        string historialCierreDown;
        string historialCierreFCausa;
        string historialCierreSolDef;
        string historialCierreSolFalaRazon;
        string historialCierraFallaAtribuible;
        string historialPQRActiva;
        string historialTkRed;
        string historialMotivoTransferencia;
        string historialTrasferenciaRecibidoPor;
        string historialPermisosIngerso;
        string historialValidacionCapa2;
        string historialConfiguracionCPE;
        string historialSeEnviaCorreo;
        string historialInfoAtencion;
        string historialPermisosActuales;
        string historialHabilitarPermisos;
        string historialuccid;
        string historialseRecibeCorreo;
        string historialCierreSolFalla;
        string historialSolicitudEcare;
        string historialUsuarioEcare;
        string historialContrasenaEcare;


        // |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||



        // Recibe parametro de la consulta realizada en login <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        public Soporte(string nombre, string documento_identidad, string formacion, string supervision, string calidad, string idusuario)
        {

            InitializeComponent();
            //txtNombre.Text = nombre;
            //txtNit.Text = documento_identidad;

            nombresoporte = nombre;
            Documentosoporte = documento_identidad;
            formacionsoporte = formacion;
            supervisionsoporte = supervision;
            calidadsoporte = calidad;
            idusuariosoporte = idusuario;




        }

        public Soporte()
        {
            InitializeComponent();


        }




        public void Tgestion() // <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        {
            if (radioConsulta.Checked == true & plantilla_si.Checked == true)
            {
                TabValidaciones.TabPages.Clear();

                DATOS.Parent = TabValidaciones;
                PDSR.Parent = TabValidaciones;
                SW.Parent = TabValidaciones;
                RUTA.Parent = TabValidaciones;
                PINGUM.Parent = TabValidaciones;
                CPE.Parent = TabValidaciones;
                TABTOPOLOGIA.Parent = TabValidaciones;
                TABCIERRE.Parent = TabValidaciones;
                COMENTARIOCRM.Parent = TabValidaciones;


            }


            if (radioback.Checked == true & plantilla_si.Checked == true)
            {
                TabValidaciones.TabPages.Clear();

                // PDSR.Parent = TabValidaciones;
                SW.Parent = TabValidaciones;
                RUTA.Parent = TabValidaciones;
                PINGUM.Parent = TabValidaciones;
                CPE.Parent = TabValidaciones;
                //TABTOPOLOGIA.Parent = TabValidaciones;
                TABCIERRE.Parent = TabValidaciones;
                COMENTARIOCRM.Parent = TabValidaciones;

            }
        }

        public void Tgestionno() // <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        {
            if (radioConsulta.Checked == true & plantilla_no.Checked == true)
            {
                TabValidaciones.TabPages.Clear();

                DATOS.Parent = TabValidaciones;
                PDSR.Parent = TabValidaciones;
                SW.Parent = TabValidaciones;
                RUTA.Parent = TabValidaciones;
                PINGUM.Parent = TabValidaciones;
                CPE.Parent = TabValidaciones;
                TABTOPOLOGIA.Parent = TabValidaciones;
                //TABCIERRE.Parent = TabValidaciones;
                COMENTARIOCRM.Parent = TabValidaciones;
            }


            if (radioback.Checked == true & plantilla_no.Checked == true)
            {
                TabValidaciones.TabPages.Clear();

                // PDSR.Parent = TabValidaciones;
                SW.Parent = TabValidaciones;
                RUTA.Parent = TabValidaciones;
                PINGUM.Parent = TabValidaciones;
                CPE.Parent = TabValidaciones;
                //TABTOPOLOGIA.Parent = TabValidaciones;
                //TABCIERRE.Parent = TabValidaciones;
                COMENTARIOCRM.Parent = TabValidaciones;

            }
        }

        //Plantilla de Ecare  <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        public void Ecare()
        {
            richComentario.Text = "======================" + "\r\n" + "DATOS DE CONTACTO" + "\r\n" + "======================" + "\r\n" +
                     "\r\n" + lblNombre.Text + " " + txtNombre.Text + "\r\n" +
                     lblTelefono.Text + " " + txtTelefono.Text + "\r\n" +
                     lblCorreo.Text + " " + txtCorreo.Text + "\r\n" +
                     lblNit.Text + " " + txtNit.Text + "\r\n" +
                     lblDireccion.Text + " " + txtDireccion.Text + "\r\n" +
                     lblCiudad.Text + " " + txtCiudad.Text + "\r\n" +
                     lblEnlace.Text + " " + txtEnlace.Text + "\r\n" +
                     lblHorario.Text + " " + txtHorario.Text + "\r\n" +
                     lblhoraiofds.Text + " " + txtHorariofds.Text + "\r\n" +
                     lblTk.Text + " " + txtTk.Text + "\r\n" + "\r\n" +
                     lblContactosede.Text + " " + txtContactoSede.Text + "\r\n" +
                     lblTelsede.Text + " " + txtTelefonoSede.Text + "\r\n" + "\r\n" + "-----------------------------------------" + "\r\n" + "FALLA REPORTADA" + ": " + txtFALLA.Text + "\r\n" + "-----------------------------------------" + "\r\n" +
                     "====================" + "\r\n" + "OBSERVACIONES" + "\r\n" + "====================" + "\r\n" + "\r\n" + richObservaciones.Text + "\r\n" +
                     "--------------------------------------------------" + "\r\n" + "--------------------------------------------------" + "\r\n" + "PLANTILLA DE CIERRE" + "\r\n" +
                     lblenombre.Text + " " + txtenombre.Text + "\r\n" +
                     lblesintoma.Text + " " + txtesintoma.Text + "\r\n" +
                     lblefechainicio.Text + " " + txtefinicio.Text + "\r\n" +
                     lblefsolucion.Text + " " + txtefsolucion.Text + "\r\n" +
                     lbledown.Text + " " + txtedown.Text + "\r\n" +
                     lblecfalla.Text + " " + txtecfalla.Text + "\r\n" +
                     lblesolucion.Text + " " + txtesolucion.Text + "\r\n" +
                     lblesfalla.Text + " " + txtesfalla.Text + "\r\n" +
                     lblecfalla.Text + " " + txtecfalla.Text + "\r\n" +
                     lblepqr.Text + " " + txtepqr.Text + "\r\n" +
                     lbletk.Text + " " + txtetk.Text + "\r\n";

        }






        //Plantilla reporte tecnico  <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        public void Datosusuario()
        {

            if (radioConsulta.Checked == true)

            {

                if (plantilla_si.Checked == true)

                {

                    richComentario.Text = "======================" + "\r\n" + "DATOS DE CONTACTO" + "\r\n" + "======================" + "\r\n" +
                             "\r\n" + lblNombre.Text + " " + txtNombre.Text + "\r\n" +
                             lblTelefono.Text + " " + txtTelefono.Text + "\r\n" +
                             lblCorreo.Text + " " + txtCorreo.Text + "\r\n" +
                             lblNit.Text + " " + txtNit.Text + "\r\n" +
                             lblDireccion.Text + " " + txtDireccion.Text + "\r\n" +
                             lblCiudad.Text + " " + txtCiudad.Text + "\r\n" +
                             lblEnlace.Text + " " + txtEnlace.Text + "\r\n" +
                             lblHorario.Text + " " + txtHorario.Text + "\r\n" +
                             lblhoraiofds.Text + " " + txtHorariofds.Text + "\r\n" +
                             lblTk.Text + " " + txtTk.Text + "\r\n" + "\r\n" +
                             lblContactosede.Text + " " + txtContactoSede.Text + "\r\n" +
                             lblTelsede.Text + " " + txtTelefonoSede.Text + "\r\n" + "\r\n" + "-----------------------------------------" + "\r\n" + "FALLA REPORTADA" + ": " + txtFALLA.Text + "\r\n" + "-----------------------------------------" + "\r\n" + "-----------------------------------------" + "\r\n" +
                             "Es una falla Reincidente: " + cmbReincidente.Text + "\r\n" + "\r\n" + "-----------------------------------------" + "\r\n" + "====================" + "\r\n" + "PDSR" + "\r\n" + "====================" + "\r\n" + "\r\n" + richPDSR.Text + "\r\n" + "\r\n" + "====================" + "\r\n" + "VALIDACIÓN DE SW" + "\r\n" + "====================" + "\r\n" + "\r\n" + richSW.Text + "\r\n" + "\r\n" +
                             "--------------------------------------------------" + "\r\n" + "Ruta del servicio." + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richRUTA.Text + "\r\n" + "\r\n" +
                             "--------------------------------------------------" + "\r\n" + "Conectividad de UM." + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richUM.Text + "\r\n" + "\r\n" +
                             "--------------------------------------------------" + "\r\n" + "Ingreso al CPE" + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richCPE.Text + "\r\n" + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" +
                             "====================" + "\r\n" + "TOPOLOGIA" + "\r\n" + "====================" + "\r\n" + "\r\n" + lblCPE.Text + " " + txtCPE.Text + "\r\n" + lblFGaoke.Text + " " + txtFGaoke.Text + "\r\n" + lblPuertosGaoke.Text + " " + txtPurertosGaoke.Text + "\r\n" + lblTopologiaRED.Text + " " + txtTopologiaRED.Text + "\r\n" + lblPC.Text + " " + cmbPC.Text + "\r\n" + lblWIFI.Text + " " + cmbWIFI.Text + "\r\n" + lblVPN.Text + " " + cmbVPN.Text + "\r\n" + lblServidores.Text + " " + cmbServidores.Text + "\r\n" + lblVOZIP.Text + " " + cmbVOZIP.Text + "\r\n" + lblDVR.Text + " " + cmbDVR.Text + "\r\n" + lblCAMARAS.Text + " " + cmbCAMARAS.Text + "\r\n" + lblTELIP.Text + " " + cmbTELIP.Text + "\r\n" + "\r\n" +
                             "====================" + "\r\n" + "SEÑALIZACIÓN" + "\r\n" + "====================" + "\r\n" + "\r\n" + richSEÑALIZACION.Text + "\r\n" + "\r\n" +
                             "====================" + "\r\n" + "OBSERVACIONES" + "\r\n" + "====================" + "\r\n" + "\r\n" + richObservaciones.Text + "\r\n" + "\r\n" +
                             "--------------------------------------------------" + "\r\n" + "--------------------------------------------------" + "\r\n" + "PLANTILLA DE CIERRE" + "\r\n" + "\r\n" +
                             lblCNombre.Text + " " + txtCNombre.Text + "\r\n" +
                             lblCSintoma.Text + " " + txtCSintoma.Text + "\r\n" +
                             lblCFInicio.Text + " " + txtCFInicio.Text + "\r\n" +
                             lblCFSolucion.Text + " " + txtCFSolucion.Text + "\r\n" +
                             lblCDown.Text + " " + txtCDown.Text + "\r\n" +
                             lblCCausa.Text + " " + txtCCausa.Text + "\r\n" +
                             lblCSolucion.Text + " " + cmbCSolucion.Text + "\r\n" +
                             lblCSFalla.Text + " " + txtCSFalla.Text + "\r\n" +
                             lblCFalla.Text + " " + txtCFalla.Text + "\r\n" +
                             lblCPQR.Text + " " + cmbCPQR.Text + "\r\n" +
                             lblCTK.Text + " " + txtCTK.Text + "\r\n";
                    TabValidaciones.SelectedIndex = 8;
                }

                else if (plantilla_no.Checked == true)
                {
                    richComentario.Text = "======================" + "\r\n" + "DATOS DE CONTACTO" + "\r\n" + "======================" + "\r\n" +
                             "\r\n" + lblNombre.Text + " " + txtNombre.Text + "\r\n" +
                             lblTelefono.Text + " " + txtTelefono.Text + "\r\n" +
                             lblCorreo.Text + " " + txtCorreo.Text + "\r\n" +
                             lblNit.Text + " " + txtNit.Text + "\r\n" +
                             lblDireccion.Text + " " + txtDireccion.Text + "\r\n" +
                             lblCiudad.Text + " " + txtCiudad.Text + "\r\n" +
                             lblEnlace.Text + " " + txtEnlace.Text + "\r\n" +
                             lblHorario.Text + " " + txtHorario.Text + "\r\n" +
                             lblhoraiofds.Text + " " + txtHorariofds.Text + "\r\n" +
                             lblTk.Text + " " + txtTk.Text + "\r\n" + "\r\n" +
                             lblContactosede.Text + " " + txtContactoSede.Text + "\r\n" +
                             lblTelsede.Text + " " + txtTelefonoSede.Text + "\r\n" + "\r\n" + "-----------------------------------------" + "\r\n" + "FALLA REPORTADA" + ": " + txtFALLA.Text + "\r\n" + "-----------------------------------------" + "\r\n" + "-----------------------------------------" + "\r\n" +
                             "Es una falla Reincidente: " + cmbReincidente.Text + "\r\n" + "\r\n" + "-----------------------------------------" + "\r\n" + "====================" + "\r\n" + "PDSR" + "\r\n" + "====================" + "\r\n" + "\r\n" + richPDSR.Text + "\r\n" + "\r\n" + "====================" + "\r\n" + "VALIDACIÓN DE SW" + "\r\n" + "====================" + "\r\n" + "\r\n" + richSW.Text + "\r\n" + "\r\n" +
                             "--------------------------------------------------" + "\r\n" + "Ruta del servicio." + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richRUTA.Text + "\r\n" + "\r\n" +
                             "--------------------------------------------------" + "\r\n" + "Conectividad de UM." + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richUM.Text + "\r\n" + "\r\n" +
                             "--------------------------------------------------" + "\r\n" + "Ingreso al CPE" + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richCPE.Text + "\r\n" + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" +
                             "====================" + "\r\n" + "TOPOLOGIA" + "\r\n" + "====================" + "\r\n" + "\r\n" + lblCPE.Text + " " + txtCPE.Text + "\r\n" + lblFGaoke.Text + " " + txtFGaoke.Text + "\r\n" + lblPuertosGaoke.Text + " " + txtPurertosGaoke.Text + "\r\n" + lblTopologiaRED.Text + " " + txtTopologiaRED.Text + "\r\n" + lblPC.Text + " " + cmbPC.Text + "\r\n" + lblWIFI.Text + " " + cmbWIFI.Text + "\r\n" + lblVPN.Text + " " + cmbVPN.Text + "\r\n" + lblServidores.Text + " " + cmbServidores.Text + "\r\n" + lblVOZIP.Text + " " + cmbVOZIP.Text + "\r\n" + lblDVR.Text + " " + cmbDVR.Text + "\r\n" + lblCAMARAS.Text + " " + cmbCAMARAS.Text + "\r\n" + lblTELIP.Text + " " + cmbTELIP.Text + "\r\n" + "\r\n" +
                             "====================" + "\r\n" + "SEÑALIZACIÓN" + "\r\n" + "====================" + "\r\n" + "\r\n" + richSEÑALIZACION.Text + "\r\n" + "\r\n" +
                             "====================" + "\r\n" + "OBSERVACIONES" + "\r\n" + "====================" + "\r\n" + "\r\n" + richObservaciones.Text + "\r\n" + "\r\n";
                    TabValidaciones.SelectedIndex = 7;
                }


            }


            else if (RadioECare.Checked == true)
            {



                if (txtSolicitude.Text == "Cambio de contraseña")
                {
                    if (radioseñor.Checked == true)

                    {
                        richObservaciones.Text = "Se comunica el señor " + txtNombre.Text + " solicita realizar el cambio de contraseña del usuario (" + txteusuario.Text + ") registrado en el portal e-care, se realiza el restablecimiento de la contraseña y se le asigna la contraseña (" + txtecontraseña.Text + ") se le recomienda hacer el cambio de la contraseña ya que es una contraseña generica, cliente confirma el usuario operativo y autoriza cierre del tk";

                        this.Ecare();
                        TabValidaciones.SelectedIndex = 2;
                    }

                    else if (radioseñora.Checked == true)
                    {
                        richObservaciones.Text = "Se comunica la señora " + txtNombre.Text + " solicita realizar el cambio de contraseña del usuario (" + txteusuario.Text + ") registrado en el portal e-care, se realiza el restablecimiento de la contraseña y se le asigna la contraseña (" + txtecontraseña.Text + ") se le recomienda hacer el cambio de la contraseña ya que es una contraseña generica, cliente confirma el usuario operativo y autoriza cierre del tk";
                        this.Ecare();
                        TabValidaciones.SelectedIndex = 2;
                    }
                }

                if (txtSolicitude.Text == "Creacion de usuario")
                {
                    if (radioseñor.Checked == true)

                    {
                        richObservaciones.Text = "Se comunica el señor (" + txtNombre.Text + ") solicita la creacion de un nuevo usuario en el portal de gestion E-care, se realiza la creacion del usuario (" + txteusuario.Text + ") y se le asigna la contraseña (" + txtecontraseña.Text + ") se le recomienda hacer el cambio de la contraseña ya que es una contraseña generica, cliente confirma el usuario operativo y autoriza cierre del tk";
                        this.Ecare();
                        TabValidaciones.SelectedIndex = 2;
                    }

                    else if (radioseñora.Checked == true)
                    {
                        richObservaciones.Text = "Se comunica la señora (" + txtNombre.Text + ") solicita la creacion de un nuevo usuario en el portal de gestion E-care, se realiza la creacion del usuario (" + txteusuario.Text + ") y se le asigna la contraseña (" + txtecontraseña.Text + ") se le recomienda hacer el cambio de la contraseña ya que es una contraseña generica, cliente confirma el usuario operativo y autoriza cierre del tk";
                        this.Ecare();
                        TabValidaciones.SelectedIndex = 2;
                    }
                }
                if (txtSolicitude.Text == "Desbloqueo de usuario")
                {
                    if (radioseñor.Checked == true)

                    {
                        richObservaciones.Text = "Se comunica el señor " + txtNombre.Text + " indica que se bloqueo el usuario (" + txteusuario.Text + ") en el portal de gestion E-care, se realiza el desbloqueo del usuario y se asigna una nueva contraseña (" + txtecontraseña.Text + ") se le recomienda hacer el cambio de la contraseña ya que es una contraseña generica, cliente confirma el usuario operativo y autoriza cierre del tk";
                        this.Ecare();
                        TabValidaciones.SelectedIndex = 2;
                    }

                    else if (radioseñora.Checked == true)
                    {
                        richObservaciones.Text = "Se comunica la señora " + txtNombre.Text + " indica que se bloqueo el usuario (" + txteusuario.Text + ") en el portal de gestion E-care, se realiza el desbloqueo del usuario y se asigna una nueva contraseña (" + txtecontraseña.Text + ") se le recomienda hacer el cambio de la contraseña ya que es una contraseña generica, cliente confirma el usuario operativo y autoriza cierre del tk";
                        this.Ecare();
                        TabValidaciones.SelectedIndex = 2;
                    }
                }

            }

            //Plantilla consulta clientes

            if (radioconsultacliente.Checked == true)
            {
                richComentario.Text = "======================" + "\r\n" + "DATOS DE CONTACTO" + "\r\n" + "======================" + "\r\n" +
                             "\r\n" + lblNombre.Text + " " + txtNombre.Text + "\r\n" +
                             lblTelefono.Text + " " + txtTelefono.Text + "\r\n" +
                             lblCorreo.Text + " " + txtCorreo.Text + "\r\n" +
                             lblNit.Text + " " + txtNit.Text + "\r\n" +
                             lblDireccion.Text + " " + txtDireccion.Text + "\r\n" +
                             lblCiudad.Text + " " + txtCiudad.Text + "\r\n" +
                             lblEnlace.Text + " " + txtEnlace.Text + "\r\n" +
                             lblHorario.Text + " " + txtHorario.Text + "\r\n" +
                             lblhoraiofds.Text + " " + txtHorariofds.Text + "\r\n" +
                             lblTk.Text + " " + txtTk.Text + "\r\n" + "\r\n" +
                             lblContactosede.Text + " " + txtContactoSede.Text + "\r\n" +
                             lblTelsede.Text + " " + txtTelefonoSede.Text + "\r\n" + "\r\n" + "-----------------------------------------" + "\r\n" + "FALLA REPORTADA" + ": " + txtFALLA.Text + "\r\n" + "-----------------------------------------" + "\r\n" + "-----------------------------------------" + "\r\n" +
                             "Es una falla Reincidente: " + cmbReincidente.Text + "\r\n" + "\r\n" + "-----------------------------------------" + "\r\n" + "====================" + "\r\n" + "PDSR" + "\r\n" + "====================" + "\r\n" + "\r\n" + richPDSR.Text + "\r\n" + "\r\n" + "====================" + "\r\n" + "VALIDACIÓN DE SW" + "\r\n" + "====================" + "\r\n" + "\r\n" + richSW.Text + "\r\n" + "\r\n" +
                             "--------------------------------------------------" + "\r\n" + "Ruta del servicio." + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richRUTA.Text + "\r\n" + "\r\n" +
                             "--------------------------------------------------" + "\r\n" + "Conectividad de UM." + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richUM.Text + "\r\n" + "\r\n" +
                             "--------------------------------------------------" + "\r\n" + "Ingreso al CPE" + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richCPE.Text + "\r\n" + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" +
                             "====================" + "\r\n" + "TOPOLOGIA" + "\r\n" + "====================" + "\r\n" + "\r\n" + lblCPE.Text + " " + txtCPE.Text + "\r\n" + lblFGaoke.Text + " " + txtFGaoke.Text + "\r\n" + lblPuertosGaoke.Text + " " + txtPurertosGaoke.Text + "\r\n" + lblTopologiaRED.Text + " " + txtTopologiaRED.Text + "\r\n" + lblPC.Text + " " + cmbPC.Text + "\r\n" + lblWIFI.Text + " " + cmbWIFI.Text + "\r\n" + lblVPN.Text + " " + cmbVPN.Text + "\r\n" + lblServidores.Text + " " + cmbServidores.Text + "\r\n" + lblVOZIP.Text + " " + cmbVOZIP.Text + "\r\n" + lblDVR.Text + " " + cmbDVR.Text + "\r\n" + lblCAMARAS.Text + " " + cmbCAMARAS.Text + "\r\n" + lblTELIP.Text + " " + cmbTELIP.Text + "\r\n" + "\r\n" +
                             "====================" + "\r\n" + "SEÑALIZACIÓN" + "\r\n" + "====================" + "\r\n" + "\r\n" + richSEÑALIZACION.Text + "\r\n" + "\r\n" +
                             "====================" + "\r\n" + "OBSERVACIONES" + "\r\n" + "====================" + "\r\n" + "\r\n" + richObservaciones.Text + "\r\n" + "\r\n";
                TabValidaciones.SelectedIndex = 7;
            }





            // Plantilla transferencia
            else if (rTransferencia.Checked == true)
            {
                richComentario.Text = "======================" + "\r\n" + "DATOS DE CONTACTO" + "\r\n" + "======================" + "\r\n" +
                             "\r\n" + lblNombre.Text + " " + txtNombre.Text + "\r\n" +
                             lblTelefono.Text + " " + txtTelefono.Text + "\r\n" +
                             lblCorreo.Text + " " + txtCorreo.Text + "\r\n" +
                             lblNit.Text + " " + txtNit.Text + "\r\n" +
                             lblDireccion.Text + " " + txtDireccion.Text + "\r\n" +
                             lblCiudad.Text + " " + txtCiudad.Text + "\r\n" +
                             lblEnlace.Text + " " + txtEnlace.Text + "\r\n" +
                             lblHorario.Text + " " + txtHorario.Text + "\r\n" +
                             lblhoraiofds.Text + " " + txtHorariofds.Text + "\r\n" +
                             lblTransferencia.Text + " " + txtTransferencia.Text + "\r\n" +
                             lblMotivo.Text + " " + txtMotivo.Text + "\r\n" +
                             lblRecibidopor.Text + " " + txtRecibidopor.Text + "\r\n" + "\r\n" +
                              "====================" + "\r\n" + "OBSERVACIONES" + "\r\n" + "====================" + "\r\n" + "\r\n" + richObservaciones.Text + "\r\n" + "\r\n";
                TabValidaciones.SelectedIndex = 2;
            }
            //Plantilla Falla masiva
            else if (radioFalla.Checked == true)
            {
                richComentario.Text = "#### " + "DATOS DE CONTACTO" + " ####" + "\r\n" +
                      "\r\n" + lblNombreEmpresa.Text + " " + txtNombreEmpresa.Text + "\r\n" +
                              lblNit.Text + " " + txtNit.Text + "\r\n" +
                              lblNombre.Text + " " + txtNombre.Text + "\r\n" +
                              lblTelefono.Text + " " + txtTelefono.Text + "\r\n" +
                              lblCorreo.Text + " " + txtCorreo.Text + "\r\n" +
                              lblDireccion.Text + " " + txtDireccion.Text + "\r\n" +
                              lblCiudad.Text + " " + txtCiudad.Text + "\r\n" +
                              lblHorario.Text + " " + txtHorario.Text + "\r\n" +
                              lblhoraiofds.Text + " " + txtHorariofds.Text + "\r\n" +
                              lblEnlace.Text + " " + txtEnlace.Text + "\r\n" +
                              lblpermisossede.Text + " " + txtIngresopermisos.Text + "\r\n" +
                              lblFallar.Text + " " + txtFALLA.Text + "\r\n" + "\r\n" +
                              "#### " + "DATOS RED" + " ####" + "\r\n" + "\r\n" +
                              lblSWW.Text + " " + txtSWW.Text + "\r\n" +
                              lblPuerto.Text + " " + txtSWPuerto.Text + "\r\n" + "\r\n" +
                              "#### " + "DATOS NODO" + " ####" + "\r\n" + "\r\n" +
                              "ENRUTAMIENTO: " + "\r\n" + "\r\n" + richRUTA.Text + "\r\n" + "\r\n" +
                              "PING UM" + "\r\n" + "\r\n" + richUM.Text + "\r\n";

                TabValidaciones.SelectedIndex = 4;



            }

            //Plantilla Back
            else if (radioback.Checked == true)
            {

                if (plantilla_si.Checked == true)

                {

                    richComentario.Text = "====================" + "\r\n" + "VALIDACIÓN DE SW" + "\r\n" + "====================" + "\r\n" + "\r\n" + richSW.Text + "\r\n" + "\r\n" +
                             "--------------------------------------------------" + "\r\n" + "Ruta del servicio." + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richRUTA.Text + "\r\n" + "\r\n" +
                             "--------------------------------------------------" + "\r\n" + "Conectividad de UM." + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richUM.Text + "\r\n" + "\r\n" +
                             "--------------------------------------------------" + "\r\n" + "Ingreso al CPE" + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richCPE.Text + "\r\n" + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" +
                             "====================" + "\r\n" + "OBSERVACIONES" + "\r\n" + "====================" + "\r\n" + "\r\n" + richObservaciones.Text + "\r\n" + "\r\n" +
                             "--------------------------------------------------" + "\r\n" + "--------------------------------------------------" + "\r\n" + "PLANTILLA DE CIERRE" + "\r\n" + "\r\n" +
                             lblCNombre.Text + " " + txtCNombre.Text + "\r\n" +
                             lblCSintoma.Text + " " + txtCSintoma.Text + "\r\n" +
                             lblCFInicio.Text + " " + txtCFInicio.Text + "\r\n" +
                             lblCFSolucion.Text + " " + txtCFSolucion.Text + "\r\n" +
                             lblCDown.Text + " " + txtCDown.Text + "\r\n" +
                             lblCCausa.Text + " " + txtCCausa.Text + "\r\n" +
                             lblCSolucion.Text + " " + cmbCSolucion.Text + "\r\n" +
                             lblCSFalla.Text + " " + txtCSFalla.Text + "\r\n" +
                             lblCFalla.Text + " " + txtCFalla.Text + "\r\n" +
                             lblCPQR.Text + " " + cmbCPQR.Text + "\r\n" +
                             lblCTK.Text + " " + txtCTK.Text + "\r\n";

                    TabValidaciones.SelectedIndex = 5;
                }

                else if (plantilla_no.Checked == true)
                {
                    richComentario.Text = "====================" + "\r\n" + "VALIDACIÓN DE SW" + "\r\n" + "====================" + "\r\n" + "\r\n" + richSW.Text + "\r\n" + "\r\n" +
                             "--------------------------------------------------" + "\r\n" + "Ruta del servicio." + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richRUTA.Text + "\r\n" + "\r\n" +
                             "--------------------------------------------------" + "\r\n" + "Conectividad de UM." + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richUM.Text + "\r\n" + "\r\n" +
                             "--------------------------------------------------" + "\r\n" + "Ingreso al CPE" + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richCPE.Text + "\r\n" + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" +
                             "====================" + "\r\n" + "OBSERVACIONES" + "\r\n" + "====================" + "\r\n" + "\r\n" + richObservaciones.Text + "\r\n" + "\r\n";
                    TabValidaciones.SelectedIndex = 4;
                }


            }

            //Plantilla configuracion cpe

            else if (RadioConfiguracionCPE.Checked == true)
            {
                richComentario.Text = "--------------------------------------------------" + "\r\n" + "SE RECIBE CORREO" + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richSeRecibeCorreo.Text + "\r\n" + "\r\n" +
                                      "--------------------------------------------------" + "\r\n" + "PDSR" + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richPDSR.Text + "\r\n" + "\r\n" +
                                      "--------------------------------------------------" + "\r\n" + "RUTA" + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richRUTA.Text + "\r\n" + "\r\n" +
                                      "--------------------------------------------------" + "\r\n" + "CAPA DOS" + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richCapa2.Text + "\r\n" + "\r\n" +
                                      "--------------------------------------------------" + "\r\n" + "VALIDO ESTADO DEL SERVICIO " + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richUM.Text + "\r\n" + "\r\n" +
                                      "--------------------------------------------------" + "\r\n" + "INGRESO AL CPE" + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richCPE.Text + "\r\n" + "\r\n" +
                                      "--------------------------------------------------" + "\r\n" + "SE REALIZA CAMBIOS A SOLICITUD DEL CLIENTE" + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richConfiguracionRealizada.Text + "\r\n" + "\r\n" +
                                      "--------------------------------------------------" + "\r\n" + "SE ENVIA CORREO AL CLIENTE" + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richSeEnviaCorreo.Text + "\r\n" + "\r\n";
                TabValidaciones.SelectedIndex = 8;

            }


            // Plantilla Configuracion Telefonia
            else if (RadioConfiguracionTelefonia.Checked == true)
            {
                richComentario.Text = "--------------------------------------------------" + "\r\n" + "INFORMACION COMPLETA DE LA ATENCION" + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richInformacionDeLaAtencion.Text + "\r\n" + "\r\n" +
                                      "--------------------------------------------------" + "\r\n" + "VALIDACION DE PERMISOS ACTUALES SOBRE LAS LINEAS" + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richValidarPermisosActuales.Text + "\r\n" + "\r\n" +
                                      "--------------------------------------------------" + "\r\n" + "HABILITAR PERMISOS SOLICITADOS" + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richHabilitarPermisos.Text + "\r\n" + "\r\n" +
                                      "--------------------------------------------------" + "\r\n" + "SE ENVIA CORREO AL CLIENTE" + "\r\n" + "--------------------------------------------------" + "\r\n" + "\r\n" + richSeEnviaCorreo.Text + "\r\n" + "\r\n";
                TabValidaciones.SelectedIndex = 4;
            }

        }

        //Descripcion tk CRM <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        public void CRM()
        {

            if (radioConsulta.Checked == true)
            {
                txtCRM.Text = txtEnlace.Text + " | " + txtSWW.Text + " | " + txtSWPuerto.Text + " | " + txtCPEE.Text + " | " + txtBW.Text + " | " + txtFALLA.Text + " | " + txtCiudad.Text;
            }
            if (radioconsultacliente.Checked == true)
            {
                txtCRM.Text = txtEnlace.Text + " | " + txtSWW.Text + " | " + txtSWPuerto.Text + " | " + txtCPEE.Text + " | " + txtBW.Text + " | " + txtFALLA.Text + " | " + txtCiudad.Text;
            }

            else if (RadioECare.Checked == true)
            {
                txtCRM.Text = txtEnlace.Text + " | " + txtFALLA.Text + " | " + txtCiudad.Text;
            }
            else if (rTransferencia.Checked == true)
            {
                txtCRM.Text = txtEnlace.Text + " | " + txtFALLA.Text + " | " + txtCiudad.Text;
            }
            else if (radioFalla.Checked == true)
            {
                txtCRM.Text = txtEnlace.Text + " | " + txtSWW.Text + " | " + txtSWPuerto.Text + " | " + txtCPEE.Text + " | " + txtBW.Text + " | " + txtFALLA.Text + " | " + txtCiudad.Text;
            }

            /* if (cmbestado.Text != "")
              {
                  cmbestado.Enabled = true;
              }
              if (cmbservicio.Text != "")
              {
                  cmbservicio.Enabled = true;
              }
              if (txtFALLA.Text != "")
              {
                  cmbservicio.Enabled = true;
              }*/


        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {



        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtCNombre.Text = txtNombre.Text;
            txtenombre.Text = txtNombre.Text;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            txtenumero.Text = txtTelefono.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            // Validacion datos de contacto
            if (radioConsulta.Checked | radioconsultacliente.Checked | RadioECare.Checked | radioFalla.Checked | rTransferencia.Checked)
            {

                string error = "";

                if (txtCorreo.Text.Trim() == "" | txtHorario.Text.Trim() == "" | txtHorariofds.Text.Trim() == "")
                {
                    error += "Datos de Contacto \n \n";
                }


                if (txtCorreo.Text.Trim() == "")
                {
                    error += "El campo Correo electronico no puede estar vacio \n";
                }


                if (txtHorario.Text.Trim() == "")
                {
                    error += "El campo de Horario atención (Lunes / Viernes) no puede estar vacio \n";
                }

                if (txtHorariofds.Text.Trim() == "")
                {
                    error += "El campo de Horario atención ( Fin de semana ) no puede estar vacio \n";
                }

                if (error != "")
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                else
                {
                    this.Datosusuario();
                    this.CRM();

                    if (idconsulta != "null")
                    {
                        if (Buscar.estado == "SOLUCIÓN EN PRIMER CONTACTO" | Buscar.estado == "CERRADO")
                        {
                            btnGuardar.Visible = false;

                        }



                    }
                    else
                    {
                        btnGuardar.Visible = true;
                    }

                    // btnGuardar.Visible = true;
                    //btnmod.Visible = true;
                }




                // Validacion casilla pestaña de cierre

            }
            if (radioConsulta.Checked | radioback.Checked == true)
            {



                if (plantilla_si.Checked == false & plantilla_no.Checked == false)
                {
                    MessageBox.Show("El campo \"Adjuntar plantilla de cierre\" no puede estar vacio", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnGuardar.Visible = false;
                }
                else
                {
                    /* if (idconsulta != "null")
                     {
                         if (Buscar.estado == "SOLUCIÓN EN PRIMER CONTACTO" | Buscar.estado == "CERRADO")
                         {
                             btnGuardar.Visible = false;

                         }



                     }*/

                }

            }

            // validacion soporte Ecare
            if (RadioECare.Checked == true)
            {



                if (radioseñor.Checked == false & radioseñora.Checked == false)
                {
                    MessageBox.Show("Cierre \n \n El campo \"Cliente\" no puede estar vacio", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (txtSolicitude.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("Cierre \n \n El campo \"Solicitud\" no puede estar vacio", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }


            //Condicional Seleccione Tipo de Gestion

            if (radioConsulta.Checked == false & RadioECare.Checked == false & rTransferencia.Checked == false & radioFalla.Checked == false & radioback.Checked == false & RadioConfiguracionCPE.Checked == false & RadioConfiguracionTelefonia.Checked == false & radioconsultacliente.Checked == false)
            {


                MessageBox.Show("Por favor seleccione el tipo de gestion", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }

            //Validaciones



            if (radioback.Checked == true | RadioConfiguracionCPE.Checked == true | RadioConfiguracionTelefonia.Checked == true)
            {
                this.Datosusuario();
                this.CRM();

                if (idconsulta != "null")
                {
                    if (Buscar.estado == "SOLUCIÓN EN PRIMER CONTACTO" | Buscar.estado == "CERRADO")
                    {
                        btnGuardar.Visible = false;

                    }



                }
                else
                {
                    btnGuardar.Visible = true;
                }
            }



        }

        public void borrar()
        {
            foreach (Control control in TABTOPOLOGIA.Controls)
            {
                TextBox text = control as TextBox;
                if (text != null)
                {
                    text.Text = "";
                }

            }

            foreach (Control Combo in TABTOPOLOGIA.Controls)
            {
                ComboBox text = Combo as ComboBox;
                if (text != null)
                {
                    text.Text = "";
                }

            }
            foreach (Control control in TABCIERRE.Controls)
            {
                TextBox text = control as TextBox;
                if (text != null)
                {
                    text.Text = "";
                }

            }

            foreach (Control Combo in TABCIERRE.Controls)
            {
                ComboBox text = Combo as ComboBox;
                if (text != null)
                {
                    text.Text = "";
                }

            }


            foreach (Control control in TRANSFERENCIA.Controls)
            {
                TextBox text = control as TextBox;
                if (text != null)
                {
                    text.Text = "";
                }

            }

            foreach (Control Combo in TRANSFERENCIA.Controls)
            {
                ComboBox text = Combo as ComboBox;
                if (text != null)
                {
                    text.Text = "";
                }

            }

            foreach (Control control in MASIVA.Controls)
            {
                TextBox text = control as TextBox;
                if (text != null)
                {
                    text.Text = "";
                }

            }

            foreach (Control Combo in MASIVA.Controls)
            {
                ComboBox text = Combo as ComboBox;
                if (text != null)
                {
                    text.Text = "";
                }

            }

            foreach (Control control in CIERRE.Controls)
            {
                TextBox text = control as TextBox;
                if (text != null)
                {
                    text.Text = "";
                }

            }

            foreach (Control Combo in CIERRE.Controls)
            {
                ComboBox text = Combo as ComboBox;
                if (text != null)
                {
                    text.Text = "";
                }

            }

            Limpiar limpiar = new Limpiar();
            limpiar.Borrar(this, groupBox1, gFalla, groupBox4, groupBox5, TabValidaciones, groupBox6);
            richPDSR.Clear();
            richSW.Clear();
            richRUTA.Clear();
            richUM.Clear();
            richCPE.Clear();
            richSEÑALIZACION.Clear();
            richInformacionDeLaAtencion.Clear();
            richValidarPermisosActuales.Clear();
            richHabilitarPermisos.Clear();
            richSeEnviaCorreo.Clear();
            richSeRecibeCorreo.Clear();
            richCapa2.Clear();
            richConfiguracionRealizada.Clear();

            idconsulta = "null";

            radioBacklinea.Checked = false;
            radioFront.Checked = false;
            cmbsubestado.Enabled = false;
            cmbestado.Enabled = false;
            cmbservicio.Enabled = false;


            radioBacklinea.Enabled = true;
            radioFront.Enabled = true;



            radioConsulta.Checked = false;
            radioconsultacliente.Checked = false;

            RadioECare.Checked = false;
            rTransferencia.Checked = false;
            radioFalla.Checked = false;
            plantilla_no.Checked = false;
            plantilla_si.Checked = false;
            radioback.Checked = false;
            RadioConfiguracionCPE.Checked = false;
            RadioConfiguracionTelefonia.Checked = false;

            TabValidaciones.TabPages.Clear();
            DATOS.Parent = TabValidaciones;

            // habilitar edicion mysql
            btnGuardar.Visible = false;
            btnmod.Visible = false;
            // PDSR.Parent = TabValidaciones;
            // SW.Parent = TabValidaciones;
            // RUTA.Parent = TabValidaciones;
            // PINGUM.Parent = TabValidaciones;
            // CPE.Parent = TabValidaciones;
            // TABTOPOLOGIA.Parent = TabValidaciones;
            // TABCIERRE.Parent = TabValidaciones;
            // TRANSFERENCIA.Parent = TabValidaciones;
            // MASIVA.Parent = TabValidaciones;


            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            txtNit.Enabled = true;
            txtDireccion.Enabled = true;
            txtCiudad.Enabled = true;
            txtEnlace.Enabled = true;
            txtTelefonoSede.Enabled = true;


            txtHorario.Enabled = true;
            txtTk.Enabled = true;
            txtContactoSede.Enabled = true;
            txtTelefonoSede.Enabled = true;
            txtFALLA.Enabled = false;
            cmbReincidente.Enabled = true;
            txtSWW.Enabled = true;
            txtSWPuerto.Enabled = true;
            txtBW.Enabled = true;
            txtCPE.Enabled = true;
            txtCPEE.Enabled = true;
            richObservaciones.Enabled = true;
            txtCRM.Enabled = true;
            lblplantillacierre.Enabled = false;
            plantilla_no.Enabled = false;
            plantilla_si.Enabled = false;

            richComentario.Text = "Para generar el comentario de CRM seleccione el boton GENERAR";

            txtCiudad.Text = "";
            this.ValidarBontonGuardar();

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Datos Datos = new Datos();
            Datos.txtContacto.Text = txtNombre.Text + " / " + txtTelefono.Text;
            Datos.txtDir.Text = txtDireccion.Text;
            Datos.txtCiudad.Text = txtCiudad.Text;
            Datos.txtHorario.Text = txtHorario.Text;
            Datos.txtEnlace.Text = txtEnlace.Text;
            Datos.texthorarioFDS.Text = txtHorariofds.Text;
            Datos.richObservaciones.Text = richObservaciones.Text;
            Datos.ShowDialog();







        }

        //Validacion tipificacion <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

        public void ValidacionTipificacion()
        {

            if (cmbestado.Items.Count >= 1)
            {
                //int puta = cmbsubestado.SelectedIndex = 0;



                cmbestado.Enabled = true;



            }
            if (cmbsubestado.Items.Count >= 1)
            {
                cmbsubestado.Enabled = true;

                cmbsubestado.SelectedItem = 1;
            }
            if (cmbservicio.Items.Count >= 1)
            {
                cmbservicio.Enabled = true;
            }
            if (txtFALLA.Items.Count >= 1)
            {
                txtFALLA.Enabled = true;
            }

        }


        //Se envia y se retorna el radiobutton seleccionado desde la base de datos <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        //radioConsulta.Checked =true;

        string TipoDeGestion, PlantillaCierre, EstadoRadiobutonBD, usuarioecare;

        public void RetornoTipoDeGestion()
        {

            if (radioConsulta.Checked == true)
            {
                TipoDeGestion = radioConsulta.Text;


            }
            if (radioconsultacliente.Checked == true)
            {
                TipoDeGestion = radioconsultacliente.Text;



            }
            if (RadioECare.Checked == true)
            {
                TipoDeGestion = RadioECare.Text;


            }
            if (rTransferencia.Checked == true)
            {
                TipoDeGestion = rTransferencia.Text;


            }
            if (radioFalla.Checked == true)
            {
                TipoDeGestion = radioFalla.Text;


            }
            if (radioback.Checked == true)
            {
                TipoDeGestion = radioback.Text;


            }
            if (RadioConfiguracionCPE.Checked == true)
            {
                TipoDeGestion = RadioConfiguracionCPE.Text;


            }
            if (RadioConfiguracionTelefonia.Checked == true)
            {
                TipoDeGestion = RadioConfiguracionTelefonia.Text;


            }
            if (plantilla_si.Checked == true)
            {
                PlantillaCierre = plantilla_si.Text;
            }

            if (plantilla_no.Checked == true)
            {
                PlantillaCierre = plantilla_no.Text;
            }
            if (radioseñor.Checked == true)
            {
                usuarioecare = radioseñor.Text;
            }
            if (radioseñora.Checked == true)
            {
                usuarioecare = radioseñora.Text;
            }



            EstadoRadiobutonBD = TipoDeGestion;
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEnlace_TextChanged(object sender, EventArgs e)
        {
            this.CRM();
        }

        private void txtSWW_TextChanged(object sender, EventArgs e)
        {
            this.CRM();
        }

        private void txtSWPuerto_TextChanged(object sender, EventArgs e)
        {
            this.CRM();
        }

        private void txtBW_TextChanged(object sender, EventArgs e)
        {
            this.CRM();
        }

        private void txtFALLA_TextChanged(object sender, EventArgs e)
        {
            this.CRM();
        }

        private void txtCiudad_TextChanged(object sender, EventArgs e)
        {
            this.CRM();

        }

        private void txtCPEE_TextChanged(object sender, EventArgs e)
        {
            this.CRM();
            txtCPE.Text = txtCPEE.Text;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Todos los datos se van a eliminar ¿Desea continuar?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.borrar();
                this.ValidarBontonGuardar();


            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Planta Planta = new Planta();
            Planta.txtDireccion.Text = txtDireccion.Text;
            Planta.txtCiudad.Text = txtCiudad.Text;
            Planta.txtSW.Text = txtSWW.Text;
            Planta.txtPuerto.Text = txtSWPuerto.Text;
            Planta.txtContactoDelCliente.Text = txtNombre.Text + " / " + txtTelefono.Text;

            Planta.ShowDialog();

        }

        private void radioConsulta_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            txtNit.Enabled = true;
            txtDireccion.Enabled = true;
            txtCiudad.Enabled = true;
            txtEnlace.Enabled = true;
            txtTelefonoSede.Enabled = true;



            txtHorario.Enabled = true;
            txtTk.Enabled = true;
            txtContactoSede.Enabled = true;
            txtTelefonoSede.Enabled = true;
            //txtFALLA.Enabled = true;
            cmbReincidente.Enabled = true;
            txtSWW.Enabled = true;
            txtSWPuerto.Enabled = true;
            txtBW.Enabled = true;
            txtCPE.Enabled = true;
            txtCPEE.Enabled = true;
            richObservaciones.Enabled = true;
            txtCRM.Enabled = true;
            lblplantillacierre.Enabled = true;
            plantilla_no.Enabled = true;
            plantilla_si.Enabled = true;
            richObservaciones.Enabled = true;


            TabValidaciones.TabPages.Clear();

            DATOS.Parent = TabValidaciones;
            PDSR.Parent = TabValidaciones;
            SW.Parent = TabValidaciones;
            RUTA.Parent = TabValidaciones;
            PINGUM.Parent = TabValidaciones;
            CPE.Parent = TabValidaciones;
            TABTOPOLOGIA.Parent = TabValidaciones;
            COMENTARIOCRM.Parent = TabValidaciones;

            /* cmbsubestado.Enabled = false;
             cmbservicio.Enabled = false;
             txtFALLA.Enabled = false;*/

            this.CRM();
            this.Tgestion();
            this.Tgestionno();
            this.RetornoTipoDeGestion();







        }



        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            txtNit.Enabled = true;
            txtDireccion.Enabled = true;
            txtCiudad.Enabled = true;
            txtEnlace.Enabled = true;
            txtTelefonoSede.Enabled = true;


            cmbReincidente.Enabled = false;
            txtSWW.Enabled = false;
            txtSWPuerto.Enabled = false;
            txtBW.Enabled = false;
            txtCPE.Enabled = false;
            txtCPEE.Enabled = false;
            txtHorario.Enabled = true;
            txtTk.Enabled = true;
            txtContactoSede.Enabled = true;
            txtTelefonoSede.Enabled = true;
            //txtFALLA.Enabled = true;
            richObservaciones.Enabled = true;
            txtCRM.Enabled = true;
            lblplantillacierre.Enabled = false;
            plantilla_no.Enabled = false;
            plantilla_si.Enabled = false;
            richObservaciones.Enabled = false;

            /*cmbsubestado.Enabled = false;
            cmbservicio.Enabled = false;
            txtFALLA.Enabled = false;*/


            TabValidaciones.TabPages.Clear();
            DATOS.Parent = TabValidaciones;
            CIERRE.Parent = TabValidaciones;
            COMENTARIOCRM.Parent = TabValidaciones;

            this.CRM();
            this.RetornoTipoDeGestion();



        }

        private void richPDSR_TextChanged(object sender, EventArgs e)
        {

        }

        private void rTransferencia_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            txtNit.Enabled = true;
            txtDireccion.Enabled = true;
            txtCiudad.Enabled = true;
            txtEnlace.Enabled = true;
            txtTelefonoSede.Enabled = true;
            txtHorario.Enabled = true;
            txtHorariofds.Enabled = true;


            txtTk.Enabled = false;
            txtContactoSede.Enabled = false;
            txtTelefonoSede.Enabled = false;
            //txtFALLA.Enabled = true;
            cmbReincidente.Enabled = false;
            txtSWW.Enabled = false;
            txtSWPuerto.Enabled = false;
            txtBW.Enabled = false;
            txtCPE.Enabled = false;
            txtCPEE.Enabled = false;
            richObservaciones.Enabled = false;
            txtCRM.Enabled = true;
            lblplantillacierre.Enabled = false;
            plantilla_no.Enabled = false;
            plantilla_si.Enabled = false;
            richObservaciones.Enabled = true;

            /* cmbsubestado.Enabled = false;
             cmbservicio.Enabled = false;
             txtFALLA.Enabled = false;*/



            TabValidaciones.TabPages.Clear();
            DATOS.Parent = TabValidaciones;
            TRANSFERENCIA.Parent = TabValidaciones;
            COMENTARIOCRM.Parent = TabValidaciones;
            this.CRM();
            this.RetornoTipoDeGestion();
        }

        private void radioFalla_CheckedChanged(object sender, EventArgs e)
        {

            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            txtNit.Enabled = true;
            txtDireccion.Enabled = true;
            txtCiudad.Enabled = true;
            txtEnlace.Enabled = true;
            txtTelefonoSede.Enabled = true;

            cmbReincidente.Enabled = false;
            txtContactoSede.Enabled = false;
            txtTelefonoSede.Enabled = false;


            txtSWW.Enabled = true;
            txtSWPuerto.Enabled = true;
            txtBW.Enabled = false;
            txtCPE.Enabled = false;
            txtCPEE.Enabled = false;
            txtHorario.Enabled = true;
            txtTk.Enabled = false;
            txtCPEE.Enabled = false;
            txtBW.Enabled = false;
            txtCRM.Enabled = false;
            // txtFALLA.Enabled = true;
            richObservaciones.Enabled = true;
            lblplantillacierre.Enabled = false;
            plantilla_no.Enabled = false;
            plantilla_si.Enabled = false;
            richObservaciones.Enabled = false;


            /* cmbsubestado.Enabled = false;
             cmbservicio.Enabled = false;
             txtFALLA.Enabled = false;*/


            TabValidaciones.TabPages.Clear();
            DATOS.Parent = TabValidaciones;
            MASIVA.Parent = TabValidaciones;
            RUTA.Parent = TabValidaciones;
            PINGUM.Parent = TabValidaciones;
            COMENTARIOCRM.Parent = TabValidaciones;
            this.CRM();
            this.RetornoTipoDeGestion();

        }

        private void txtTelefonoSede_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIngresopermisos_TextChanged(object sender, EventArgs e)
        {

        }

        private void Soporte_Load(object sender, EventArgs e)
        {



            TabValidaciones.TabPages.Clear();
            DATOS.Parent = TabValidaciones;

            lblplantillacierre.Enabled = false;
            plantilla_no.Enabled = false;
            plantilla_si.Enabled = false;
            cmbsubestado.Enabled = false;
            cmbestado.Enabled = false;
            cmbservicio.Enabled = false;
            txtFALLA.Enabled = false;



            radioConsulta.Enabled = false;
            radioconsultacliente.Enabled = false;
            RadioECare.Enabled = false;
            rTransferencia.Enabled = false;
            radioFalla.Enabled = false;
            radioback.Enabled = false;
            RadioConfiguracionCPE.Enabled = false;
            RadioConfiguracionTelefonia.Enabled = false;

            btnGuardar.Visible = false;
            btnmod.Visible = false;

            /*cmbestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbsubestado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbservicio.DropDownStyle = ComboBoxStyle.DropDownList;
            txtFALLA.DropDownStyle = ComboBoxStyle.DropDownList;*/
            // txtCiudad.DropDownStyle = ComboBoxStyle.DropDownList;


            /*  txtCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
              txtCiudad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
              txtCiudad.AutoCompleteSource = AutoCompleteSource.ListItems;  */
        }



        private void richObservaciones_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtenombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void plantilla_si_CheckedChanged(object sender, EventArgs e)
        {
            this.Tgestion();
            this.RetornoTipoDeGestion();




        }

        private void plantilla_no_CheckedChanged(object sender, EventArgs e)
        {
            this.Tgestionno();
            this.RetornoTipoDeGestion();


        }

        private void Soporte_FormClosing(object sender, FormClosingEventArgs e)
        {


            DialogResult dialogo = MessageBox.Show("Al cerrar el programa toda la informacion se perdera ¿Desea cerrar el programa?",
               "Cerrar el programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogo == DialogResult.No)
            {
                e.Cancel = true;


            }
            else
            {

                Login Login = new Login();
                Login.Show();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
            txtNit.Enabled = false;
            txtDireccion.Enabled = false;
            txtCiudad.Enabled = false;
            txtEnlace.Enabled = false;



            txtHorario.Enabled = false;
            txtTk.Enabled = false;
            txtContactoSede.Enabled = false;
            txtTelefonoSede.Enabled = false;
            //txtFALLA.Enabled = false;
            cmbReincidente.Enabled = false;
            txtSWW.Enabled = false;
            txtSWPuerto.Enabled = false;
            txtBW.Enabled = false;
            txtCPE.Enabled = false;
            txtCPEE.Enabled = false;
            richObservaciones.Enabled = true;
            txtCRM.Enabled = true;
            lblplantillacierre.Enabled = true;
            plantilla_no.Enabled = true;
            plantilla_si.Enabled = true;
            richObservaciones.Enabled = true;

            /*  cmbsubestado.Enabled = false;
              cmbservicio.Enabled = false;
              txtFALLA.Enabled = false;*/

            TabValidaciones.TabPages.Clear();

            //PDSR.Parent = TabValidaciones;

            SW.Parent = TabValidaciones;
            RUTA.Parent = TabValidaciones;
            PINGUM.Parent = TabValidaciones;
            CPE.Parent = TabValidaciones;
            //TABTOPOLOGIA.Parent = TabValidaciones;
            COMENTARIOCRM.Parent = TabValidaciones;

            this.CRM();
            this.Tgestion();
            this.Tgestionno();
            this.RetornoTipoDeGestion();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void gGestion_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }




        private void BarraTitulo_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

        }

        private void btnRestaurar_Click_3(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadioConfiguracionCPE_CheckedChanged(object sender, EventArgs e)
        {

            TabValidaciones.TabPages.Clear();

            CORREO.Parent = TabValidaciones;
            PDSR.Parent = TabValidaciones;
            RUTA.Parent = TabValidaciones;
            CAPA2.Parent = TabValidaciones;
            PINGUM.Parent = TabValidaciones;
            CPE.Parent = TabValidaciones;
            CONFIGURACIONREALIZADA.Parent = TabValidaciones;
            SEENVIACORREO.Parent = TabValidaciones;
            COMENTARIOCRM.Parent = TabValidaciones;
            plantilla_no.Enabled = false;
            plantilla_si.Enabled = false;
            richObservaciones.Enabled = false;

            this.RetornoTipoDeGestion();

            /*cmbsubestado.Enabled = false;
            cmbservicio.Enabled = false;
            txtFALLA.Enabled = false;*/

        }

        private void RadioConfiguracionTelefonia_CheckedChanged(object sender, EventArgs e)
        {
            TabValidaciones.TabPages.Clear();

            INFORMACIONDELAATENCION.Parent = TabValidaciones;
            VALIDARPERMISOSACTUALES.Parent = TabValidaciones;
            HABILITARPERMISOS.Parent = TabValidaciones;
            SEENVIACORREO.Parent = TabValidaciones;
            COMENTARIOCRM.Parent = TabValidaciones;
            plantilla_no.Enabled = false;
            plantilla_si.Enabled = false;

            this.RetornoTipoDeGestion();

            /*cmbsubestado.Enabled = false;
            cmbservicio.Enabled = false;
            txtFALLA.Enabled = false;*/
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Conexion.ObtenerConexion();
            MessageBox.Show("Conectado");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Buscar Buscar = new Buscar();
            Buscar.ShowDialog();
        }



        private void button6_Click_1(object sender, EventArgs e)
        {
            txtNombre.Text = nombresoporte;
            txtNit.Text = Documentosoporte;
            txtDireccion.Text = formacionsoporte;
            txtContactoSede.Text = supervisionsoporte;
            txtHorario.Text = calidadsoporte;
        }

        private void radioconsultacliente_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            txtNit.Enabled = true;
            txtDireccion.Enabled = true;
            txtCiudad.Enabled = true;
            txtEnlace.Enabled = true;
            txtTelefonoSede.Enabled = true;



            txtHorario.Enabled = true;
            txtTk.Enabled = true;
            txtContactoSede.Enabled = true;
            txtTelefonoSede.Enabled = true;
            //txtFALLA.Enabled = true;
            cmbReincidente.Enabled = true;
            txtSWW.Enabled = true;
            txtSWPuerto.Enabled = true;
            txtBW.Enabled = true;
            txtCPE.Enabled = true;
            txtCPEE.Enabled = true;
            richObservaciones.Enabled = true;
            txtCRM.Enabled = true;
            lblplantillacierre.Enabled = false;
            plantilla_no.Enabled = false;
            plantilla_si.Enabled = false;
            richObservaciones.Enabled = true;


            /*  cmbsubestado.Enabled = false;
              cmbservicio.Enabled = false;
              txtFALLA.Enabled = false;*/


            TabValidaciones.TabPages.Clear();

            DATOS.Parent = TabValidaciones;
            PDSR.Parent = TabValidaciones;
            SW.Parent = TabValidaciones;
            RUTA.Parent = TabValidaciones;
            PINGUM.Parent = TabValidaciones;
            CPE.Parent = TabValidaciones;
            TABTOPOLOGIA.Parent = TabValidaciones;
            COMENTARIOCRM.Parent = TabValidaciones;
            this.CRM();
            this.RetornoTipoDeGestion();


        }



        public string UpdateTimeTabla = "", fechasolucioncerrado, TransferenciaPendiente = "";

        //metodo para guardar datos en mysql    <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        public void DatosMysql()
        {


            string SolPrimerContacto = "", Escalado = "", Transferencia = "", Seguimiento = "", cierretxtCSintoma, cierretxtCFInicio, cierretxtCFSolucion, cierretxtCDown, cierretxtCCausa, cierrecmbCSolucion, cierretxtCSFalla, cierretxtCFalla, cierrecmbCPQR, cierretxtCTK, cierretxtMotivo, UpdateTimeTablaback;

            cierretxtCSintoma = txtCSintoma.Text.Trim();
            cierretxtCFInicio = txtCFInicio.Text.Trim();
            cierretxtCFSolucion = txtCFSolucion.Text.Trim();
            cierretxtCDown = txtCDown.Text.Trim();
            cierretxtCCausa = txtCCausa.Text.Trim();
            cierrecmbCSolucion = cmbCSolucion.Text.Trim();
            cierretxtCSFalla = txtCSFalla.Text.Trim();
            cierretxtCFalla = txtCFalla.Text.Trim();
            cierrecmbCPQR = cmbCPQR.Text.Trim();
            cierretxtCTK = txtCTK.Text.Trim();
            cierretxtMotivo = txtMotivo.Text.Trim();

            //SE cambian plantilal de cierre cuando se lecciona  ecare

            if (RadioECare.Checked == true)
            {
                cierretxtCSintoma = txtesintoma.Text.Trim();
                cierretxtCFInicio = txtefinicio.Text.Trim();
                cierretxtCFSolucion = txtefsolucion.Text.Trim();
                cierretxtCDown = txtedown.Text.Trim();
                cierretxtCCausa = txtecfalla.Text;
                cierrecmbCSolucion = txtesolucion.Text.Trim();
                cierretxtCSFalla = txtesfalla.Text.Trim();
                cierretxtCFalla = txtefallede.Text.Trim();
                cierrecmbCPQR = txtepqr.Text.Trim();
                cierretxtCTK = txtetk.Text.Trim();
                cierretxtMotivo = txtMotivo.Text.Trim();
            }

            //Se selecicona la fecha de solucion segun linea de soporte, front o back 

            if (radioFront.Checked == true)
            {
                fechasolucioncerrado = "fechasolucionenprimercontacto";

            }
            if (radioBacklinea.Checked == true)
            {
                fechasolucioncerrado = "fechacerrado";
            }


            //SOLUCION PRIMER CONTACTO 

            if (cmbestado.Text == "SOLUCIÓN EN PRIMER CONTACTO" | cmbestado.Text == "CERRADO")
            {
                SolPrimerContacto = "now()";
                Escalado = "NULL";
                Transferencia = "NULL";
                Seguimiento = "NULL";

                if (radioFront.Checked == true)
                {
                    UpdateTimeTabla = "fechasolucionenprimercontacto";
                }
                if (radioBacklinea.Checked == true)
                {
                    UpdateTimeTabla = "fechacerrado";
                }



            }

            if (cmbestado.Text == "TRANSFERENCIA")
            {
                SolPrimerContacto = "NULL";
                Escalado = "NULL";
                Transferencia = "now()";
                Seguimiento = "NULL";
                UpdateTimeTabla = "fechatransferencia";
                TransferenciaPendiente = "fechatransferencia";

            }

            if (cmbestado.Text == "SEGUIMIENTO")
            {
                SolPrimerContacto = "NULL";
                Escalado = "NULL";
                Transferencia = "NULL";
                Seguimiento = "now()";
                UpdateTimeTabla = "fechaseguimiento";
                TransferenciaPendiente = "fechapendiente";


            }
            if (cmbestado.Text == "ESCALADO")
            {

                SolPrimerContacto = "NULL";
                Escalado = "now()";
                Transferencia = "NULL";
                Seguimiento = "NULL";
                UpdateTimeTabla = "fechaescalado";



                if (cmbestado.Text == "ESCALADO" & radioFront.Checked == true)
                {

                    try
                    {

                        // Se guardan datos en la BD back registros <<<<<<<<<<<<<<<<
                        string QueryBDregistros = "INSERT INTO empresasNegociosBack.registros (`id`, `consecutivointerno`, `ultimamodificacionpor`, `fechaultimamodificacion`, `creadopor`, `fechacreacion`, `documento_identidad`, `ultimamodificacionmasivapor`, `fechaultimamodificacionmasiva`, `agenteasignado`, `añorecibidolatcom`, `diarecibidolatcom`, `estado`, `fecha1ergestion`, `mesrecibidolatcom`, `formacion`, `supervision`, `calidad`, `estado1ergestion`, `nombre`, `cargo`, `telefono`, `nit`, `correo`, `uccid`, `chatSpark`, `linea`, `servicioSolicitud`, `subEstado`, `fallaReportada`, `cuentaEnlace`, `redAcceso`, `equipo`, `radicadoTicket`, `plantilla`, `nombreEmpresa`, `direccion`, `ciudad`, `horarioAtencion`, `horarioAtencionFDS`, `clienteAutorizaEnvioCorreo`, `LLSOTAVISO`, `tituloAviso`, `reincidente`, `observaciones`, `equipoEnganchado`, `pqrPorEstaCausa`, `provisionCorrecta`, `subeConReinicio`, `cuentasVecinas`, `reparoActualizo`, `ssid`, `cuentaMatrizCaida`, `ip`, `pe`, `pass`, `mascara`, `dns2`, `dns1`, `numeroNuevo`, `numeroAntiguo`, `tipologia`, `marcacion`, `equipoRR`, `cuantosEquiposFallan`, `estructuraMarcacionRR`, `cedula`, `fechacerrado`, `fechaescalado`, `fechapendiente`, `fechaseguimiento`, `tkInterno`, `nombreContactoSede`, `telefonoContactoSede`, `ClienteBW`, `puertosSW`, `PDSR`, `ValidacionSW`, `ValidacionRuta`, `ValidacionUM`, `ValidacionCPE`, `SenalizacionSER`, `CierreSintoma`, `CierreFInicio`, `CierreFSolucion`, `CierreDown`, `CierreFCausa`, `CierreSolDef`, `CierreSolFalla`, `CierreSolFalaRazon`, `CierraFallaAtribuible`, `PQRActiva`, `TkRed`, `MotivoTransferencia`, `TrasferenciaRecibidoPor`, `PermisosIngerso`, `ValidacionCapa2`, `ConfiguracionCPE`, `SeEnviaCorreo`, `InfoAtencion`, `PermisosActuales`, `HabilitarPermisos`, `tipoDeGestionSelect`, `plantillaCierre`, `seRecibeCorreo`, `SolicitudEcare`, `UsuarioEcare`, `ContrasenaEcare`, `ClienteEcare`, `franjaVisita`,`skill`,`nombreSkill`,`estructuraLLS`,`codigoServicio`,areaResponsable) VALUES " + " (@id,@consecutivointerno,@ultimamodificacionpor,now(),@creadopor,now(),@documento_identidad,@ultimamodificacionmasivapor,@fechaultimamodificacionmasiva,@agenteasignado,@añorecibidolatcom,@diarecibidolatcom,@estado,now(),@mesrecibidolatcom,@formacion,@supervision,@calidad,@estado1ergestion,@nombre,@cargo,@telefono,@nit,@correo,@uccid,@chatSpark,@linea,@servicioSolicitud,@subEstado,@fallaReportada,@cuentaEnlace,@redAcceso,@equipo,@radicadoTicket,@plantilla,@nombreEmpresa,@direccion,@ciudad,@horarioAtencion,@horarioAtencionFDS,@clienteAutorizaEnvioCorreo,@LLSOTAVISO,@tituloAviso,@reincidente,@observaciones,@equipoEnganchado,@pqrPorEstaCausa,@provisionCorrecta,@subeConReinicio,@cuentasVecinas,@reparoActualizo,@ssid,@cuentaMatrizCaida,@ip,@pe,@pass,@mascara,@dns2,@dns1,@numeroNuevo,@numeroAntiguo,@tipologia,@marcacion,@equipoRR,@cuantosEquiposFallan,@estructuraMarcacionRR,@cedula," + SolPrimerContacto + ", " + Escalado + ", " + Transferencia + ", " + Seguimiento + ",@tkInterno,@nombreContactoSede,@telefonoContactoSede,@ClienteBW,@puertosSW,@PDSR,@ValidacionSW,@ValidacionRuta,@ValidacionUM,@ValidacionCPE,@SenalizacionSER,@CierreSintoma,@CierreFInicio,@CierreFSolucion,@CierreDown,@CierreFCausa,@CierreSolDef,@CierreSolFalla,@CierreSolFalaRazon,@CierraFallaAtribuible,@PQRActiva,@TkRed,@MotivoTransferencia,@TrasferenciaRecibidoPor,@PermisosIngerso,@ValidacionCapa2,@ConfiguracionCPE,@SeEnviaCorreo,@InfoAtencion,@PermisosActuales,@HabilitarPermisos,@tipoDeGestionSelect,'" + PlantillaCierre + "',@seRecibeCorreo,@SolicitudEcare,@UsuarioEcare,@ContrasenaEcare,'" + usuarioecare + "',@franjaVisita,@skill,@nombreSkill,@estructuraLLS,@codigoServicio,@areaResponsable); SELECT LAST_INSERT_ID() as lastid;";
                        cmd = new MySqlCommand(QueryBDregistros, Conexion.ObtenerConexion());

                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@id", null);
                        cmd.Parameters.AddWithValue("@consecutivointerno", "");
                        cmd.Parameters.AddWithValue("@ultimamodificacionpor", nombresoporte);
                        //cmd.Parameters.AddWithValue("@fechaultimamodificacion", DateTime.Now);
                        cmd.Parameters.AddWithValue("@creadopor", nombresoporte);
                        //cmd.Parameters.AddWithValue("@fechacreacion", "now()");
                        cmd.Parameters.AddWithValue("@documento_identidad", Documentosoporte);
                        cmd.Parameters.AddWithValue("@ultimamodificacionmasivapor", "");
                        cmd.Parameters.AddWithValue("@fechaultimamodificacionmasiva", null);
                        cmd.Parameters.AddWithValue("@agenteasignado", nombresoporte);
                        cmd.Parameters.AddWithValue("@añorecibidolatcom", "");
                        cmd.Parameters.AddWithValue("@diarecibidolatcom", "");
                        cmd.Parameters.AddWithValue("@estado", cmbestado.Text.Trim());
                        //cmd.Parameters.AddWithValue("@fecha1ergestion", "now()");
                        cmd.Parameters.AddWithValue("@mesrecibidolatcom", "");
                        cmd.Parameters.AddWithValue("@formacion", formacionsoporte);
                        cmd.Parameters.AddWithValue("@supervision", supervisionsoporte);
                        cmd.Parameters.AddWithValue("@calidad", calidadsoporte);
                        cmd.Parameters.AddWithValue("@estado1ergestion", cmbestado.Text.Trim());
                        cmd.Parameters.AddWithValue("@nombre", this.txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@cargo", "");
                        cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());
                        cmd.Parameters.AddWithValue("@nit", txtNit.Text.Trim());
                        cmd.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());
                        cmd.Parameters.AddWithValue("@uccid", txtUCCID.Text.Trim());
                        cmd.Parameters.AddWithValue("@chatSpark", chSpark.Checked);
                        cmd.Parameters.AddWithValue("@linea", LineaGestion);
                        cmd.Parameters.AddWithValue("@servicioSolicitud", cmbservicio.Text.Trim());
                        cmd.Parameters.AddWithValue("@subEstado", cmbsubestado.Text.Trim());
                        cmd.Parameters.AddWithValue("@fallaReportada", txtFALLA.Text.Trim());
                        cmd.Parameters.AddWithValue("@cuentaEnlace", txtEnlace.Text.Trim());
                        cmd.Parameters.AddWithValue("@redAcceso", txtSWW.Text.Trim());
                        cmd.Parameters.AddWithValue("@equipo", txtCPEE.Text.Trim());
                        cmd.Parameters.AddWithValue("@radicadoTicket", txtTicket.Text.Trim());
                        cmd.Parameters.AddWithValue("@plantilla", "");
                        cmd.Parameters.AddWithValue("@nombreEmpresa", txtNombreEmpresa.Text.Trim());
                        cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text.Trim());
                        cmd.Parameters.AddWithValue("@ciudad", txtCiudad.Text.Trim());
                        cmd.Parameters.AddWithValue("@horarioAtencion", txtHorario.Text.Trim());
                        cmd.Parameters.AddWithValue("@horarioAtencionFDS", txtHorariofds.Text.Trim());
                        cmd.Parameters.AddWithValue("@clienteAutorizaEnvioCorreo", "");
                        cmd.Parameters.AddWithValue("@LLSOTAVISO", "");
                        cmd.Parameters.AddWithValue("@tituloAviso", "");
                        cmd.Parameters.AddWithValue("@reincidente", cmbReincidente.Text.Trim());
                        cmd.Parameters.AddWithValue("@observaciones", richObservaciones.Text.Trim());
                        cmd.Parameters.AddWithValue("@equipoEnganchado", "");
                        cmd.Parameters.AddWithValue("@pqrPorEstaCausa", "");
                        cmd.Parameters.AddWithValue("@provisionCorrecta", "");
                        cmd.Parameters.AddWithValue("@subeConReinicio", "");
                        cmd.Parameters.AddWithValue("@cuentasVecinas", "");
                        cmd.Parameters.AddWithValue("@reparoActualizo", "");
                        cmd.Parameters.AddWithValue("@ssid", "");
                        cmd.Parameters.AddWithValue("@cuentaMatrizCaida", "");
                        cmd.Parameters.AddWithValue("@ip", "");
                        cmd.Parameters.AddWithValue("@pe", "");
                        cmd.Parameters.AddWithValue("@pass", "");
                        cmd.Parameters.AddWithValue("@mascara", "");
                        cmd.Parameters.AddWithValue("@dns2", "");
                        cmd.Parameters.AddWithValue("@dns1", "");
                        cmd.Parameters.AddWithValue("@numeroNuevo", "");
                        cmd.Parameters.AddWithValue("@numeroAntiguo", "");
                        cmd.Parameters.AddWithValue("@tipologia", "");
                        cmd.Parameters.AddWithValue("@marcacion", "");
                        cmd.Parameters.AddWithValue("@equipoRR", "");
                        cmd.Parameters.AddWithValue("@cuantosEquiposFallan", "");
                        cmd.Parameters.AddWithValue("@estructuraMarcacionRR", "");
                        cmd.Parameters.AddWithValue("@cedula", "");
                        /*cmd.Parameters.AddWithValue("@fechasolucionenprimercontacto", SolPrimerContacto);
                        cmd.Parameters.AddWithValue("@fechaescalado", Escalado);
                        cmd.Parameters.AddWithValue("@fechatransferencia", Transferencia);
                        cmd.Parameters.AddWithValue("@fechaseguimiento", Seguimiento);*/
                        cmd.Parameters.AddWithValue("@tkInterno", txtTk.Text.Trim());
                        cmd.Parameters.AddWithValue("@nombreContactoSede", txtContactoSede.Text.Trim());
                        cmd.Parameters.AddWithValue("@telefonoContactoSede", txtTelefonoSede.Text.Trim());
                        cmd.Parameters.AddWithValue("@ClienteBW", txtBW.Text.Trim());
                        cmd.Parameters.AddWithValue("@puertosSW", txtSWPuerto.Text.Trim());
                        cmd.Parameters.AddWithValue("@PDSR", richPDSR.Text.Trim());
                        cmd.Parameters.AddWithValue("@ValidacionSW", richSW.Text.Trim());
                        cmd.Parameters.AddWithValue("@ValidacionRuta", richRUTA.Text.Trim());
                        cmd.Parameters.AddWithValue("@ValidacionUM", richUM.Text.Trim());
                        cmd.Parameters.AddWithValue("@ValidacionCPE", richCPE.Text.Trim());
                        cmd.Parameters.AddWithValue("@SenalizacionSER", richSEÑALIZACION.Text.Trim());
                        cmd.Parameters.AddWithValue("@CierreSintoma", cierretxtCSintoma);
                        cmd.Parameters.AddWithValue("@CierreFInicio", cierretxtCFInicio);
                        cmd.Parameters.AddWithValue("@CierreFSolucion", cierretxtCFSolucion);
                        cmd.Parameters.AddWithValue("@CierreDown", cierretxtCDown);
                        cmd.Parameters.AddWithValue("@CierreFCausa", cierretxtCCausa);
                        cmd.Parameters.AddWithValue("@CierreSolDef", cierrecmbCSolucion);
                        cmd.Parameters.AddWithValue("@CierreSolFalla", cierretxtCSFalla);
                        cmd.Parameters.AddWithValue("@CierreSolFalaRazon", "");
                        cmd.Parameters.AddWithValue("@CierraFallaAtribuible", cierretxtCFalla);
                        cmd.Parameters.AddWithValue("@PQRActiva", cierrecmbCPQR);
                        cmd.Parameters.AddWithValue("@TkRed", cierretxtCTK);
                        cmd.Parameters.AddWithValue("@MotivoTransferencia", cierretxtMotivo);
                        cmd.Parameters.AddWithValue("@TrasferenciaRecibidoPor", txtRecibidopor.Text.Trim());
                        cmd.Parameters.AddWithValue("@PermisosIngerso", txtIngresopermisos.Text.Trim());
                        cmd.Parameters.AddWithValue("@ValidacionCapa2", richCapa2.Text.Trim());
                        cmd.Parameters.AddWithValue("@ConfiguracionCPE", richConfiguracionRealizada.Text.Trim());
                        cmd.Parameters.AddWithValue("@SeEnviaCorreo", richSeEnviaCorreo.Text.Trim());
                        cmd.Parameters.AddWithValue("@InfoAtencion", richInformacionDeLaAtencion.Text.Trim());
                        cmd.Parameters.AddWithValue("@PermisosActuales", richValidarPermisosActuales.Text.Trim());
                        cmd.Parameters.AddWithValue("@HabilitarPermisos", richHabilitarPermisos.Text.Trim());
                        cmd.Parameters.AddWithValue("@tipoDeGestionSelect", EstadoRadiobutonBD);
                        //cmd.Parameters.AddWithValue("@plantillaCierre", PlantillaCierre);
                        cmd.Parameters.AddWithValue("@seRecibeCorreo", richSeRecibeCorreo.Text.Trim());
                        cmd.Parameters.AddWithValue("@SolicitudEcare", txtSolicitude.Text.Trim());
                        cmd.Parameters.AddWithValue("@UsuarioEcare", txteusuario.Text.Trim());
                        cmd.Parameters.AddWithValue("@ContrasenaEcare", txtecontraseña.Text.Trim());
                        cmd.Parameters.AddWithValue("@ClienteEcare", usuarioecare);
                        cmd.Parameters.AddWithValue("@franjaVisita", "");
                        cmd.Parameters.AddWithValue("@skill", "");
                        cmd.Parameters.AddWithValue("@nombreSkill", "");
                        cmd.Parameters.AddWithValue("@estructuraLLS", "");
                        cmd.Parameters.AddWithValue("@codigoServicio", txtEnlace.Text.Trim());
                        cmd.Parameters.AddWithValue("@areaResponsable", txtEnlace.Text.Trim());

                        //se obtiene ID para generar consecutivo interno (Se actualiza informacion en registro back)
                        MySqlDataAdapter sdaa = new MySqlDataAdapter(cmd);
                        DataTable dtr = new DataTable();
                        sdaa.Fill(dtr);
                        string IDconsecutivointernoback = dtr.Rows[0][0].ToString();
                        cmd = new MySqlCommand("UPDATE empresasNegociosBack.registros SET `consecutivointerno` = 'FIBB-" + IDconsecutivointernoback + "' WHERE `registros`.`id` = " + IDconsecutivointernoback + ";", Conexion.ObtenerConexion());
                        cmd.ExecuteNonQuery();


                        //Se insertan datos en historial_actividades
                        string QueryHistorialActividades = "INSERT INTO empresasNegociosBack.historial_actividades (`id`, `fechacreacion`, `agenteasignado`, `comentario`, `fechahoraeliminacion`, `usuarioeliminacion`, `codigo`) VALUES (NULL, now(), '" + nombresoporte + "',@Comentario, NULL, '', '" + IDconsecutivointernoback + "');"; cmd = new MySqlCommand(QueryHistorialActividades, Conexion.ObtenerConexion());
                        cmd.Parameters.AddWithValue("@Comentario", richComentario.Text);
                        cmd.ExecuteNonQuery();



                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show("Error al insertar" + exx.Message);
                    }
                }

            }



            //SE ingresan datos para registro nuevo

            if (idconsulta == "null")
            {

                try
                {
                    //Se guardan datos en la BD registros
                    cmd = new MySqlCommand("INSERT INTO " + LineaDeSoporte + ".registros (`id`, `consecutivointerno`, `ultimamodificacionpor`, `fechaultimamodificacion`, `creadopor`, `fechacreacion`, `documento_identidad`, `ultimamodificacionmasivapor`, `fechaultimamodificacionmasiva`, `agenteasignado`, `añorecibidolatcom`, `diarecibidolatcom`, `estado`, `fecha1ergestion`, `mesrecibidolatcom`, `formacion`, `supervision`, `calidad`, `estado1ergestion`, `nombre`, `cargo`, `telefono`, `nit`, `correo`, `uccid`, `chatSpark`, `linea`, `servicioSolicitud`, `subEstado`, `fallaReportada`, `cuentaEnlace`, `redAcceso`, `equipo`, `radicadoTicket`, `plantilla`, `nombreEmpresa`, `direccion`, `ciudad`, `horarioAtencion`, `horarioAtencionFDS`, `clienteAutorizaEnvioCorreo`, `LLSOTAVISO`, `tituloAviso`, `reincidente`, `observaciones`, `equipoEnganchado`, `pqrPorEstaCausa`, `provisionCorrecta`, `subeConReinicio`, `cuentasVecinas`, `reparoActualizo`, `ssid`, `cuentaMatrizCaida`, `ip`, `pe`, `pass`, `mascara`, `dns2`, `dns1`, `numeroNuevo`, `numeroAntiguo`, `tipologia`, `marcacion`, `equipoRR`, `cuantosEquiposFallan`, `estructuraMarcacionRR`, `cedula`, `fechasolucionenprimercontacto`, `fechaescalado`, `fechatransferencia`, `fechaseguimiento`, `tkInterno`, `nombreContactoSede`, `telefonoContactoSede`, `ClienteBW`, `puertosSW`, `PDSR`, `ValidacionSW`, `ValidacionRuta`, `ValidacionUM`, `ValidacionCPE`, `SenalizacionSER`, `CierreSintoma`, `CierreFInicio`, `CierreFSolucion`, `CierreDown`, `CierreFCausa`, `CierreSolDef`, `CierreSolFalla`, `CierreSolFalaRazon`, `CierraFallaAtribuible`, `PQRActiva`, `TkRed`, `MotivoTransferencia`, `TrasferenciaRecibidoPor`, `PermisosIngerso`, `ValidacionCapa2`, `ConfiguracionCPE`, `SeEnviaCorreo`, `InfoAtencion`, `PermisosActuales`, `HabilitarPermisos`, `tipoDeGestionSelect`, `plantillaCierre`, `seRecibeCorreo`, `SolicitudEcare`, `UsuarioEcare`, `ContrasenaEcare`, `ClienteEcare`) VALUES (NULL, '', '" + nombresoporte + "', now(), '" + nombresoporte + "', now(), '" + Documentosoporte + "', '', NULL, '" + nombresoporte + "', '', '', '" + cmbestado.Text + "', now(), '', '" + formacionsoporte + "', '" + supervisionsoporte + "', '" + calidadsoporte + "', '" + cmbestado.Text + "', '" + txtNombre.Text + "', '', '" + txtTelefono.Text + "', '" + txtNit.Text + "', '" + txtCorreo.Text + "', '" + txtUCCID.Text + "', '" + chSpark.Checked + "', '" + LineaGestion + "', '" + cmbservicio.Text + "', '" + cmbsubestado.Text + "', '" + txtFALLA.Text + "', '" + txtEnlace.Text + "', '" + txtSWW.Text + "', '" + txtCPEE.Text + "', '" + txtTicket.Text + "', '', '" + txtNombreEmpresa.Text + "', '" + txtDireccion.Text + "', '" + txtCiudad.Text + "', '" + txtHorario.Text + "', '" + txtHorariofds.Text + "', '', '', '', '" + cmbReincidente.Text + "', '" + richObservaciones.Text + "', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', " + SolPrimerContacto + ", " + Escalado + ", " + Transferencia + ", " + Seguimiento + ", '" + txtTk.Text + "', '" + txtContactoSede.Text + "', '" + txtTelefonoSede.Text + "', '" + txtBW.Text + "', '" + txtSWPuerto.Text + "', '" + richPDSR.Text + "', '" + richSW.Text + "', '" + richRUTA.Text + "', '" + richUM.Text + "', '" + richCPE.Text + "', '" + richSEÑALIZACION.Text + "', '" + cierretxtCSintoma + "', '" + cierretxtCFInicio + "', '" + cierretxtCFSolucion + "', '" + cierretxtCDown + "', '" + cierretxtCCausa + "', '" + cierrecmbCSolucion + "', '" + cierretxtCSFalla + "', '', '" + cierretxtCFalla + "', '" + cierrecmbCPQR + "', '" + cierretxtCTK + "', '" + cierretxtMotivo + "', '" + txtRecibidopor.Text + "', '" + txtIngresopermisos.Text + "', '" + richCapa2.Text + "', '" + richConfiguracionRealizada.Text + "', '" + richSeEnviaCorreo.Text + "', '" + richInformacionDeLaAtencion.Text + "', '" + richValidarPermisosActuales.Text + "', '" + richHabilitarPermisos.Text + "','" + EstadoRadiobutonBD + "','" + PlantillaCierre + "', '" + richSeRecibeCorreo.Text + "', '" + txtSolicitude.Text + "', '" + txteusuario.Text + "', '" + txtecontraseña.Text + "', '" + usuarioecare + "'); SELECT LAST_INSERT_ID() as lastid;", Conexion.ObtenerConexion());

                    string QueryBDregistros = "";

                    if (radioFront.Checked == true)
                    {
                        QueryBDregistros = "INSERT INTO " + LineaDeSoporte + ".registros (`id`, `consecutivointerno`, `ultimamodificacionpor`, `fechaultimamodificacion`, `creadopor`, `fechacreacion`, `documento_identidad`, `ultimamodificacionmasivapor`, `fechaultimamodificacionmasiva`, `agenteasignado`, `añorecibidolatcom`, `diarecibidolatcom`, `estado`, `fecha1ergestion`, `mesrecibidolatcom`, `formacion`, `supervision`, `calidad`, `estado1ergestion`, `nombre`, `cargo`, `telefono`, `nit`, `correo`, `uccid`, `chatSpark`, `linea`, `servicioSolicitud`, `subEstado`, `fallaReportada`, `cuentaEnlace`, `redAcceso`, `equipo`, `radicadoTicket`, `plantilla`, `nombreEmpresa`, `direccion`, `ciudad`, `horarioAtencion`, `horarioAtencionFDS`, `clienteAutorizaEnvioCorreo`, `LLSOTAVISO`, `tituloAviso`, `reincidente`, `observaciones`, `equipoEnganchado`, `pqrPorEstaCausa`, `provisionCorrecta`, `subeConReinicio`, `cuentasVecinas`, `reparoActualizo`, `ssid`, `cuentaMatrizCaida`, `ip`, `pe`, `pass`, `mascara`, `dns2`, `dns1`, `numeroNuevo`, `numeroAntiguo`, `tipologia`, `marcacion`, `equipoRR`, `cuantosEquiposFallan`, `estructuraMarcacionRR`, `cedula`, `" + fechasolucioncerrado + "`, `fechaescalado`, `fechatransferencia`, `fechaseguimiento`, `tkInterno`, `nombreContactoSede`, `telefonoContactoSede`, `ClienteBW`, `puertosSW`, `PDSR`, `ValidacionSW`, `ValidacionRuta`, `ValidacionUM`, `ValidacionCPE`, `SenalizacionSER`, `CierreSintoma`, `CierreFInicio`, `CierreFSolucion`, `CierreDown`, `CierreFCausa`, `CierreSolDef`, `CierreSolFalla`, `CierreSolFalaRazon`, `CierraFallaAtribuible`, `PQRActiva`, `TkRed`, `MotivoTransferencia`, `TrasferenciaRecibidoPor`, `PermisosIngerso`, `ValidacionCapa2`, `ConfiguracionCPE`, `SeEnviaCorreo`, `InfoAtencion`, `PermisosActuales`, `HabilitarPermisos`, `tipoDeGestionSelect`, `plantillaCierre`, `seRecibeCorreo`, `SolicitudEcare`, `UsuarioEcare`, `ContrasenaEcare`, `ClienteEcare`, `franjaVisita`,`skill`,`nombreSkill`,`estructuraLLS`) VALUES " + " (@id,@consecutivointerno,@ultimamodificacionpor,now(),@creadopor,now(),@documento_identidad,@ultimamodificacionmasivapor,@fechaultimamodificacionmasiva,@agenteasignado,@añorecibidolatcom,@diarecibidolatcom,@estado,now(),@mesrecibidolatcom,@formacion,@supervision,@calidad,@estado1ergestion,@nombre,@cargo,@telefono,@nit,@correo,@uccid,@chatSpark,@linea,@servicioSolicitud,@subEstado,@fallaReportada,@cuentaEnlace,@redAcceso,@equipo,@radicadoTicket,@plantilla,@nombreEmpresa,@direccion,@ciudad,@horarioAtencion,@horarioAtencionFDS,@clienteAutorizaEnvioCorreo,@LLSOTAVISO,@tituloAviso,@reincidente,@observaciones,@equipoEnganchado,@pqrPorEstaCausa,@provisionCorrecta,@subeConReinicio,@cuentasVecinas,@reparoActualizo,@ssid,@cuentaMatrizCaida,@ip,@pe,@pass,@mascara,@dns2,@dns1,@numeroNuevo,@numeroAntiguo,@tipologia,@marcacion,@equipoRR,@cuantosEquiposFallan,@estructuraMarcacionRR,@cedula," + SolPrimerContacto + ", " + Escalado + ", " + Transferencia + ", " + Seguimiento + ",@tkInterno,@nombreContactoSede,@telefonoContactoSede,@ClienteBW,@puertosSW,@PDSR,@ValidacionSW,@ValidacionRuta,@ValidacionUM,@ValidacionCPE,@SenalizacionSER,@CierreSintoma,@CierreFInicio,@CierreFSolucion,@CierreDown,@CierreFCausa,@CierreSolDef,@CierreSolFalla,@CierreSolFalaRazon,@CierraFallaAtribuible,@PQRActiva,@TkRed,@MotivoTransferencia,@TrasferenciaRecibidoPor,@PermisosIngerso,@ValidacionCapa2,@ConfiguracionCPE,@SeEnviaCorreo,@InfoAtencion,@PermisosActuales,@HabilitarPermisos,@tipoDeGestionSelect,'" + PlantillaCierre + "',@seRecibeCorreo,@SolicitudEcare,@UsuarioEcare,@ContrasenaEcare,'" + usuarioecare + "',@franjaVisita,@skill,@nombreSkill,@estructuraLLS); SELECT LAST_INSERT_ID() as lastid;";

                    }
                    if (radioBacklinea.Checked == true)
                    {
                        QueryBDregistros = "INSERT INTO " + LineaDeSoporte + ".registros (`id`, `consecutivointerno`, `ultimamodificacionpor`, `fechaultimamodificacion`, `creadopor`, `fechacreacion`, `documento_identidad`, `ultimamodificacionmasivapor`, `fechaultimamodificacionmasiva`, `agenteasignado`, `añorecibidolatcom`, `diarecibidolatcom`, `estado`, `fecha1ergestion`, `mesrecibidolatcom`, `formacion`, `supervision`, `calidad`, `estado1ergestion`, `nombre`, `cargo`, `telefono`, `nit`, `correo`, `uccid`, `chatSpark`, `linea`, `servicioSolicitud`, `subEstado`, `fallaReportada`, `cuentaEnlace`, `redAcceso`, `equipo`, `radicadoTicket`, `plantilla`, `nombreEmpresa`, `direccion`, `ciudad`, `horarioAtencion`, `horarioAtencionFDS`, `clienteAutorizaEnvioCorreo`, `LLSOTAVISO`, `tituloAviso`, `reincidente`, `observaciones`, `equipoEnganchado`, `pqrPorEstaCausa`, `provisionCorrecta`, `subeConReinicio`, `cuentasVecinas`, `reparoActualizo`, `ssid`, `cuentaMatrizCaida`, `ip`, `pe`, `pass`, `mascara`, `dns2`, `dns1`, `numeroNuevo`, `numeroAntiguo`, `tipologia`, `marcacion`, `equipoRR`, `cuantosEquiposFallan`, `estructuraMarcacionRR`, `cedula`, `" + fechasolucioncerrado + "`, `fechaescalado`, `fechapendiente`, `fechaseguimiento`, `tkInterno`, `nombreContactoSede`, `telefonoContactoSede`, `ClienteBW`, `puertosSW`, `PDSR`, `ValidacionSW`, `ValidacionRuta`, `ValidacionUM`, `ValidacionCPE`, `SenalizacionSER`, `CierreSintoma`, `CierreFInicio`, `CierreFSolucion`, `CierreDown`, `CierreFCausa`, `CierreSolDef`, `CierreSolFalla`, `CierreSolFalaRazon`, `CierraFallaAtribuible`, `PQRActiva`, `TkRed`, `MotivoTransferencia`, `TrasferenciaRecibidoPor`, `PermisosIngerso`, `ValidacionCapa2`, `ConfiguracionCPE`, `SeEnviaCorreo`, `InfoAtencion`, `PermisosActuales`, `HabilitarPermisos`, `tipoDeGestionSelect`, `plantillaCierre`, `seRecibeCorreo`, `SolicitudEcare`, `UsuarioEcare`, `ContrasenaEcare`, `ClienteEcare`, `franjaVisita`,`skill`,`nombreSkill`,`estructuraLLS`,`codigoServicio`,areaResponsable) VALUES " + " (@id,@consecutivointerno,@ultimamodificacionpor,now(),@creadopor,now(),@documento_identidad,@ultimamodificacionmasivapor,@fechaultimamodificacionmasiva,@agenteasignado,@añorecibidolatcom,@diarecibidolatcom,@estado,now(),@mesrecibidolatcom,@formacion,@supervision,@calidad,@estado1ergestion,@nombre,@cargo,@telefono,@nit,@correo,@uccid,@chatSpark,@linea,@servicioSolicitud,@subEstado,@fallaReportada,@cuentaEnlace,@redAcceso,@equipo,@radicadoTicket,@plantilla,@nombreEmpresa,@direccion,@ciudad,@horarioAtencion,@horarioAtencionFDS,@clienteAutorizaEnvioCorreo,@LLSOTAVISO,@tituloAviso,@reincidente,@observaciones,@equipoEnganchado,@pqrPorEstaCausa,@provisionCorrecta,@subeConReinicio,@cuentasVecinas,@reparoActualizo,@ssid,@cuentaMatrizCaida,@ip,@pe,@pass,@mascara,@dns2,@dns1,@numeroNuevo,@numeroAntiguo,@tipologia,@marcacion,@equipoRR,@cuantosEquiposFallan,@estructuraMarcacionRR,@cedula," + SolPrimerContacto + ", " + Escalado + ", " + Transferencia + ", " + Seguimiento + ",@tkInterno,@nombreContactoSede,@telefonoContactoSede,@ClienteBW,@puertosSW,@PDSR,@ValidacionSW,@ValidacionRuta,@ValidacionUM,@ValidacionCPE,@SenalizacionSER,@CierreSintoma,@CierreFInicio,@CierreFSolucion,@CierreDown,@CierreFCausa,@CierreSolDef,@CierreSolFalla,@CierreSolFalaRazon,@CierraFallaAtribuible,@PQRActiva,@TkRed,@MotivoTransferencia,@TrasferenciaRecibidoPor,@PermisosIngerso,@ValidacionCapa2,@ConfiguracionCPE,@SeEnviaCorreo,@InfoAtencion,@PermisosActuales,@HabilitarPermisos,@tipoDeGestionSelect,'" + PlantillaCierre + "',@seRecibeCorreo,@SolicitudEcare,@UsuarioEcare,@ContrasenaEcare,'" + usuarioecare + "',@franjaVisita,@skill,@nombreSkill,@estructuraLLS,@codigoServicio,@areaResponsable); SELECT LAST_INSERT_ID() as lastid;";

                    }

                    cmd = new MySqlCommand(QueryBDregistros, Conexion.ObtenerConexion());



                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", null);
                    cmd.Parameters.AddWithValue("@consecutivointerno", "");
                    cmd.Parameters.AddWithValue("@ultimamodificacionpor", nombresoporte);
                    //cmd.Parameters.AddWithValue("@fechaultimamodificacion", DateTime.Now);
                    cmd.Parameters.AddWithValue("@creadopor", nombresoporte);
                    //cmd.Parameters.AddWithValue("@fechacreacion", "now()");
                    cmd.Parameters.AddWithValue("@documento_identidad", Documentosoporte);
                    cmd.Parameters.AddWithValue("@ultimamodificacionmasivapor", "");
                    cmd.Parameters.AddWithValue("@fechaultimamodificacionmasiva", null);
                    cmd.Parameters.AddWithValue("@agenteasignado", nombresoporte);
                    cmd.Parameters.AddWithValue("@añorecibidolatcom", "");
                    cmd.Parameters.AddWithValue("@diarecibidolatcom", "");
                    cmd.Parameters.AddWithValue("@estado", cmbestado.Text.Trim());
                    //cmd.Parameters.AddWithValue("@fecha1ergestion", "now()");
                    cmd.Parameters.AddWithValue("@mesrecibidolatcom", "");
                    cmd.Parameters.AddWithValue("@formacion", formacionsoporte);
                    cmd.Parameters.AddWithValue("@supervision", supervisionsoporte);
                    cmd.Parameters.AddWithValue("@calidad", calidadsoporte);
                    cmd.Parameters.AddWithValue("@estado1ergestion", cmbestado.Text.Trim());
                    cmd.Parameters.AddWithValue("@nombre", this.txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@cargo", "");
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@nit", txtNit.Text.Trim());
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());
                    cmd.Parameters.AddWithValue("@uccid", txtUCCID.Text.Trim());
                    cmd.Parameters.AddWithValue("@chatSpark", chSpark.Checked);
                    cmd.Parameters.AddWithValue("@linea", LineaGestion);
                    cmd.Parameters.AddWithValue("@servicioSolicitud", cmbservicio.Text.Trim());
                    cmd.Parameters.AddWithValue("@subEstado", cmbsubestado.Text.Trim());
                    cmd.Parameters.AddWithValue("@fallaReportada", txtFALLA.Text.Trim());
                    cmd.Parameters.AddWithValue("@cuentaEnlace", txtEnlace.Text.Trim());
                    cmd.Parameters.AddWithValue("@redAcceso", txtSWW.Text.Trim());
                    cmd.Parameters.AddWithValue("@equipo", txtCPEE.Text.Trim());
                    cmd.Parameters.AddWithValue("@radicadoTicket", txtTicket.Text.Trim());
                    cmd.Parameters.AddWithValue("@plantilla", "");
                    cmd.Parameters.AddWithValue("@nombreEmpresa", txtNombreEmpresa.Text.Trim());
                    cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text.Trim());
                    cmd.Parameters.AddWithValue("@ciudad", txtCiudad.Text.Trim());
                    cmd.Parameters.AddWithValue("@horarioAtencion", txtHorario.Text.Trim());
                    cmd.Parameters.AddWithValue("@horarioAtencionFDS", txtHorariofds.Text.Trim());
                    cmd.Parameters.AddWithValue("@clienteAutorizaEnvioCorreo", "");
                    cmd.Parameters.AddWithValue("@LLSOTAVISO", "");
                    cmd.Parameters.AddWithValue("@tituloAviso", "");
                    cmd.Parameters.AddWithValue("@reincidente", cmbReincidente.Text.Trim());
                    cmd.Parameters.AddWithValue("@observaciones", richObservaciones.Text.Trim());
                    cmd.Parameters.AddWithValue("@equipoEnganchado", "");
                    cmd.Parameters.AddWithValue("@pqrPorEstaCausa", "");
                    cmd.Parameters.AddWithValue("@provisionCorrecta", "");
                    cmd.Parameters.AddWithValue("@subeConReinicio", "");
                    cmd.Parameters.AddWithValue("@cuentasVecinas", "");
                    cmd.Parameters.AddWithValue("@reparoActualizo", "");
                    cmd.Parameters.AddWithValue("@ssid", "");
                    cmd.Parameters.AddWithValue("@cuentaMatrizCaida", "");
                    cmd.Parameters.AddWithValue("@ip", "");
                    cmd.Parameters.AddWithValue("@pe", "");
                    cmd.Parameters.AddWithValue("@pass", "");
                    cmd.Parameters.AddWithValue("@mascara", "");
                    cmd.Parameters.AddWithValue("@dns2", "");
                    cmd.Parameters.AddWithValue("@dns1", "");
                    cmd.Parameters.AddWithValue("@numeroNuevo", "");
                    cmd.Parameters.AddWithValue("@numeroAntiguo", "");
                    cmd.Parameters.AddWithValue("@tipologia", "");
                    cmd.Parameters.AddWithValue("@marcacion", "");
                    cmd.Parameters.AddWithValue("@equipoRR", "");
                    cmd.Parameters.AddWithValue("@cuantosEquiposFallan", "");
                    cmd.Parameters.AddWithValue("@estructuraMarcacionRR", "");
                    cmd.Parameters.AddWithValue("@cedula", "");
                    /*cmd.Parameters.AddWithValue("@fechasolucionenprimercontacto", SolPrimerContacto);
                    cmd.Parameters.AddWithValue("@fechaescalado", Escalado);
                    cmd.Parameters.AddWithValue("@fechatransferencia", Transferencia);
                    cmd.Parameters.AddWithValue("@fechaseguimiento", Seguimiento);*/
                    cmd.Parameters.AddWithValue("@tkInterno", txtTk.Text.Trim());
                    cmd.Parameters.AddWithValue("@nombreContactoSede", txtContactoSede.Text.Trim());
                    cmd.Parameters.AddWithValue("@telefonoContactoSede", txtTelefonoSede.Text.Trim());
                    cmd.Parameters.AddWithValue("@ClienteBW", txtBW.Text.Trim());
                    cmd.Parameters.AddWithValue("@puertosSW", txtSWPuerto.Text.Trim());
                    cmd.Parameters.AddWithValue("@PDSR", richPDSR.Text.Trim());
                    cmd.Parameters.AddWithValue("@ValidacionSW", richSW.Text.Trim());
                    cmd.Parameters.AddWithValue("@ValidacionRuta", richRUTA.Text.Trim());
                    cmd.Parameters.AddWithValue("@ValidacionUM", richUM.Text.Trim());
                    cmd.Parameters.AddWithValue("@ValidacionCPE", richCPE.Text.Trim());
                    cmd.Parameters.AddWithValue("@SenalizacionSER", richSEÑALIZACION.Text.Trim());
                    cmd.Parameters.AddWithValue("@CierreSintoma", cierretxtCSintoma);
                    cmd.Parameters.AddWithValue("@CierreFInicio", cierretxtCFInicio);
                    cmd.Parameters.AddWithValue("@CierreFSolucion", cierretxtCFSolucion);
                    cmd.Parameters.AddWithValue("@CierreDown", cierretxtCDown);
                    cmd.Parameters.AddWithValue("@CierreFCausa", cierretxtCCausa);
                    cmd.Parameters.AddWithValue("@CierreSolDef", cierrecmbCSolucion);
                    cmd.Parameters.AddWithValue("@CierreSolFalla", cierretxtCSFalla);
                    cmd.Parameters.AddWithValue("@CierreSolFalaRazon", "");
                    cmd.Parameters.AddWithValue("@CierraFallaAtribuible", cierretxtCFalla);
                    cmd.Parameters.AddWithValue("@PQRActiva", cierrecmbCPQR);
                    cmd.Parameters.AddWithValue("@TkRed", cierretxtCTK);
                    cmd.Parameters.AddWithValue("@MotivoTransferencia", cierretxtMotivo);
                    cmd.Parameters.AddWithValue("@TrasferenciaRecibidoPor", txtRecibidopor.Text.Trim());
                    cmd.Parameters.AddWithValue("@PermisosIngerso", txtIngresopermisos.Text.Trim());
                    cmd.Parameters.AddWithValue("@ValidacionCapa2", richCapa2.Text.Trim());
                    cmd.Parameters.AddWithValue("@ConfiguracionCPE", richConfiguracionRealizada.Text.Trim());
                    cmd.Parameters.AddWithValue("@SeEnviaCorreo", richSeEnviaCorreo.Text.Trim());
                    cmd.Parameters.AddWithValue("@InfoAtencion", richInformacionDeLaAtencion.Text.Trim());
                    cmd.Parameters.AddWithValue("@PermisosActuales", richValidarPermisosActuales.Text.Trim());
                    cmd.Parameters.AddWithValue("@HabilitarPermisos", richHabilitarPermisos.Text.Trim());
                    cmd.Parameters.AddWithValue("@tipoDeGestionSelect", EstadoRadiobutonBD);
                    //cmd.Parameters.AddWithValue("@plantillaCierre", PlantillaCierre);
                    cmd.Parameters.AddWithValue("@seRecibeCorreo", richSeRecibeCorreo.Text.Trim());
                    cmd.Parameters.AddWithValue("@SolicitudEcare", txtSolicitude.Text.Trim());
                    cmd.Parameters.AddWithValue("@UsuarioEcare", txteusuario.Text.Trim());
                    cmd.Parameters.AddWithValue("@ContrasenaEcare", txtecontraseña.Text.Trim());
                    cmd.Parameters.AddWithValue("@ClienteEcare", usuarioecare);
                    cmd.Parameters.AddWithValue("@franjaVisita", "");
                    cmd.Parameters.AddWithValue("@skill", "");
                    cmd.Parameters.AddWithValue("@nombreSkill", "");
                    cmd.Parameters.AddWithValue("@estructuraLLS", "");
                    cmd.Parameters.AddWithValue("@codigoServicio", txtEnlace.Text.Trim());
                    cmd.Parameters.AddWithValue("@areaResponsable", txtEnlace.Text.Trim());

                    //se obtiene ID para generar consecutivo interno (Se actualiza informacion en registros)
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    string IDconsecutivointerno = dt.Rows[0][0].ToString();
                    string QueryUpdateConsecutivoInterno = "UPDATE " + LineaDeSoporte + ".registros SET `consecutivointerno` = '" + PrefijoSoporte + IDconsecutivointerno + "' WHERE `registros`.`id` = " + IDconsecutivointerno + ";";
                    cmd = new MySqlCommand(QueryUpdateConsecutivoInterno, Conexion.ObtenerConexion());
                    cmd.ExecuteNonQuery();

                    //Se insertan datos en historial_actividades
                    string QueryHistorialActividades = "INSERT INTO " + LineaDeSoporte + ".historial_actividades (`id`, `fechacreacion`, `agenteasignado`, `comentario`, `fechahoraeliminacion`, `usuarioeliminacion`, `codigo`) VALUES (NULL, now(), '" + nombresoporte + "',@Comentario, NULL, '', '" + IDconsecutivointerno + "');"; cmd = new MySqlCommand(QueryHistorialActividades, Conexion.ObtenerConexion());
                    cmd.Parameters.AddWithValue("@Comentario", richComentario.Text);
                    cmd.ExecuteNonQuery();

                    //Se insertan datos en productividad
                    cmd = new MySqlCommand("INSERT INTO " + LineaDeSoporte + ".productividad (`id`, `registro`, `estado`, `subestado`, `consecutivointerno`, `codigo`, `agenteasignado`, `diarecibidolatcom`, `fechaultimamodificacion`, `documento_identidad`, `formacion`, `supervision`, `calidad`, `minfalla`) VALUES (NULL, '" + IDconsecutivointerno + "', '" + cmbestado.Text.Trim() + "', '" + cmbsubestado.Text.Trim() + "', '" + PrefijoSoporte + IDconsecutivointerno + "', '" + idusuariosoporte + "', '" + nombresoporte + "', '', now(), '" + Documentosoporte + "', '" + formacionsoporte + "', '" + supervisionsoporte + "', '" + calidadsoporte + "', NULL);", Conexion.ObtenerConexion());
                    cmd.ExecuteNonQuery();

                    /////////////////////////////////////////////Se guardan los datos en el hitorial de modificaiones  ///////////////////////////////////////////////////////////////////////////<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

                    if (radioConsulta.Checked == true)
                    {

                        if (plantilla_si.Checked == true)
                        {
                            // Se guardan cambios en el histial de modificaciones
                            string query = "INSERT INTO " + LineaDeSoporte + ".historialModificaciones (`id`, `registro`, `accion`, `tipo`, `alteradoDe`, `alteradoA`, `accionPor`, `codigoAccionPor`, `fecha`) VALUES ((NULL, '" + IDconsecutivointerno + "', 'Creó', ' estado con Interfaz de Gestión', '',@cmbestado , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' subEstado con Interfaz de Gestión', '',@cmbsubestado , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' servicioSolicitud con Interfaz de Gestión', '',@cmbservicio , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' fallaReportada con Interfaz de Gestión', '',@txtFALLA , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' nombre con Interfaz de Gestión', '',@txtNombre , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' telefono con Interfaz de Gestión', '',@txtTelefono , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' correo con Interfaz de Gestión', '',@txtCorreo , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' nit con Interfaz de Gestión', '',@txtNit , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' direccion con Interfaz de Gestión', '',@txtDireccion , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ciudad con Interfaz de Gestión', '',@txtCiudad , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' cuentaEnlace con Interfaz de Gestión', '',@txtEnlace , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' horarioAtencion con Interfaz de Gestión', '',@txtHorario , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' horarioAtencionFDS con Interfaz de Gestión', '',@txtHorariofds , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' tkInterno con Interfaz de Gestión', '',@txtTk , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' nombreContactoSede con Interfaz de Gestión', '',@txtContactoSede , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' telefonoContactoSede con Interfaz de Gestión', '',@txtTelefonoSede , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' reincidente con Interfaz de Gestión', '',@cmbReincidente , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' redAcceso con Interfaz de Gestión', '',@txtSWW , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' puertosSW con Interfaz de Gestión', '',@txtSWPuerto , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ClienteBW con Interfaz de Gestión', '',@txtBW , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' equipo con Interfaz de Gestión', '',@txtCPEE , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' observaciones con Interfaz de Gestión', '',@richObservaciones , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' radicadoTicket con Interfaz de Gestión', '',@txtTicket , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' uccid con Interfaz de Gestión', '',@txtUCCID , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' PDSR con Interfaz de Gestión', '',@richPDSR , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ValidacionSW con Interfaz de Gestión', '',@richSW , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ValidacionRuta con Interfaz de Gestión', '',@richRUTA , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ValidacionUM con Interfaz de Gestión', '',@richUM , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ValidacionCPE con Interfaz de Gestión', '',@richCPE , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' SenalizacionSER con Interfaz de Gestión', '',@richSEÑALIZACION , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'agenteasignado con Interfaz de Gestión', '',@nombresoporte, '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' CierreSintoma con Interfaz de Gestión', '',@txtCSintoma , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' CierreFInicio con Interfaz de Gestión', '',@txtCFInicio , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' CierreFSolucion con Interfaz de Gestión', '',@txtCFSolucion , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' CierreDown con Interfaz de Gestión', '',@txtCDown , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' CierreFCausa con Interfaz de Gestión', '',@txtCCausa , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' CierreSolDef con Interfaz de Gestión', '',@cmbCSolucion , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' CierreSolFalaRazon con Interfaz de Gestión', '',@txtCSFalla , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' CierraFallaAtribuible con Interfaz de Gestión', '',@txtCFalla , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' PQRActiva con Interfaz de Gestión', '',@cmbCPQR , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' TkRed con Interfaz de Gestión', '',@txtCTK , '" + nombresoporte + "', '" + idusuariosoporte + "', now())";
                            cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

                            cmd.Parameters.AddWithValue("@cmbestado", cmbestado.Text);
                            cmd.Parameters.AddWithValue("@cmbsubestado", cmbsubestado.Text);
                            cmd.Parameters.AddWithValue("@cmbservicio", cmbservicio.Text);
                            cmd.Parameters.AddWithValue("@txtFALLA", txtFALLA.Text);
                            cmd.Parameters.AddWithValue("@txtNombre", txtNombre.Text);
                            cmd.Parameters.AddWithValue("@txtTelefono", txtTelefono.Text);
                            cmd.Parameters.AddWithValue("@txtCorreo", txtCorreo.Text);
                            cmd.Parameters.AddWithValue("@txtNit", txtNit.Text);
                            cmd.Parameters.AddWithValue("@txtDireccion", txtDireccion.Text);
                            cmd.Parameters.AddWithValue("@txtCiudad", txtCiudad.Text);
                            cmd.Parameters.AddWithValue("@txtEnlace", txtEnlace.Text);
                            cmd.Parameters.AddWithValue("@txtHorario", txtHorario.Text);
                            cmd.Parameters.AddWithValue("@txtHorariofds", txtHorariofds.Text);
                            cmd.Parameters.AddWithValue("@txtTk", txtTk.Text);
                            cmd.Parameters.AddWithValue("@txtContactoSede", txtContactoSede.Text);
                            cmd.Parameters.AddWithValue("@txtTelefonoSede", txtTelefonoSede.Text);
                            cmd.Parameters.AddWithValue("@cmbReincidente", cmbReincidente.Text);
                            cmd.Parameters.AddWithValue("@txtSWW", txtSWW.Text);
                            cmd.Parameters.AddWithValue("@txtSWPuerto", txtSWPuerto.Text);
                            cmd.Parameters.AddWithValue("@txtBW", txtBW.Text);
                            cmd.Parameters.AddWithValue("@txtCPEE", txtCPEE.Text);
                            cmd.Parameters.AddWithValue("@richObservaciones", richObservaciones.Text);
                            cmd.Parameters.AddWithValue("@txtTicket", txtTicket.Text);
                            cmd.Parameters.AddWithValue("@txtUCCID", txtUCCID.Text);
                            cmd.Parameters.AddWithValue("@richPDSR", richPDSR.Text);
                            cmd.Parameters.AddWithValue("@richSW", richSW.Text);
                            cmd.Parameters.AddWithValue("@richRUTA", richRUTA.Text);
                            cmd.Parameters.AddWithValue("@richUM", richUM.Text);
                            cmd.Parameters.AddWithValue("@richCPE", richCPE.Text);
                            cmd.Parameters.AddWithValue("@richSEÑALIZACION", richSEÑALIZACION.Text);
                            cmd.Parameters.AddWithValue("@nombresoporte", nombresoporte);
                            cmd.Parameters.AddWithValue("@txtCSintoma", txtCSintoma.Text);
                            cmd.Parameters.AddWithValue("@txtCFInicio", txtCFInicio.Text);
                            cmd.Parameters.AddWithValue("@txtCFSolucion", txtCFSolucion.Text);
                            cmd.Parameters.AddWithValue("@txtCDown", txtCDown.Text);
                            cmd.Parameters.AddWithValue("@txtCCausa", txtCCausa.Text);
                            cmd.Parameters.AddWithValue("@cmbCSolucion", cmbCSolucion.Text);
                            cmd.Parameters.AddWithValue("@txtCSFalla", txtCSFalla.Text);
                            cmd.Parameters.AddWithValue("@txtCFalla", txtCFalla.Text);
                            cmd.Parameters.AddWithValue("@cmbCPQR", cmbCPQR.Text);
                            cmd.Parameters.AddWithValue("@txtCTK", txtCTK.Text);



                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Se guardaron los datos correctamente " + PrefijoSoporte + IDconsecutivointerno, " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        if (plantilla_no.Checked == true)
                        {
                            // Se guardan cambios en el histial de modificaciones

                            string query = "INSERT INTO " + LineaDeSoporte + ".historialModificaciones (`id`, `registro`, `accion`, `tipo`, `alteradoDe`, `alteradoA`, `accionPor`, `codigoAccionPor`, `fecha`) VALUES (NULL, '" + IDconsecutivointerno + "', 'Creó', ' estado con Interfaz de Gestión', '',@cmbestado , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' subEstado con Interfaz de Gestión', '',@cmbsubestado , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' servicioSolicitud con Interfaz de Gestión', '',@cmbservicio , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' fallaReportada con Interfaz de Gestión', '',@txtFALLA , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' nombre con Interfaz de Gestión', '',@txtNombre , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' telefono con Interfaz de Gestión', '',@txtTelefono , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' correo con Interfaz de Gestión', '',@txtCorreo , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' nit con Interfaz de Gestión', '',@txtNit , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' direccion con Interfaz de Gestión', '',@txtDireccion , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ciudad con Interfaz de Gestión', '',@txtCiudad , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' cuentaEnlace con Interfaz de Gestión', '',@txtEnlace , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' horarioAtencion con Interfaz de Gestión', '',@txtHorario , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' horarioAtencionFDS con Interfaz de Gestión', '',@txtHorariofds , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' tkInterno con Interfaz de Gestión', '',@txtTk , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' nombreContactoSede con Interfaz de Gestión', '',@txtContactoSede , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' telefonoContactoSede con Interfaz de Gestión', '',@txtTelefonoSede , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' reincidente con Interfaz de Gestión', '',@cmbReincidente , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' redAcceso con Interfaz de Gestión', '',@txtSWW , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' puertosSW con Interfaz de Gestión', '',@txtSWPuerto , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ClienteBW con Interfaz de Gestión', '',@txtBW , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' equipo con Interfaz de Gestión', '',@txtCPEE , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' observaciones con Interfaz de Gestión', '',@richObservaciones , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' radicadoTicket con Interfaz de Gestión', '',@txtTicket , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' uccid con Interfaz de Gestión', '',@txtUCCID , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' PDSR con Interfaz de Gestión', '',@richPDSR , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ValidacionSW con Interfaz de Gestión', '',@richSW , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ValidacionRuta con Interfaz de Gestión', '',@richRUTA , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ValidacionUM con Interfaz de Gestión', '',@richUM , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ValidacionCPE con Interfaz de Gestión', '',@richCPE , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' SenalizacionSER con Interfaz de Gestión', '',@richSEÑALIZACION , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'agenteasignado con Interfaz de Gestión', '',@nombresoporte, '" + nombresoporte + "', '" + idusuariosoporte + "', now())";
                            cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

                            cmd.Parameters.AddWithValue("@cmbestado", cmbestado.Text);
                            cmd.Parameters.AddWithValue("@cmbsubestado", cmbsubestado.Text);
                            cmd.Parameters.AddWithValue("@cmbservicio", cmbservicio.Text);
                            cmd.Parameters.AddWithValue("@txtFALLA", txtFALLA.Text);
                            cmd.Parameters.AddWithValue("@txtNombre", txtNombre.Text);
                            cmd.Parameters.AddWithValue("@txtTelefono", txtTelefono.Text);
                            cmd.Parameters.AddWithValue("@txtCorreo", txtCorreo.Text);
                            cmd.Parameters.AddWithValue("@txtNit", txtNit.Text);
                            cmd.Parameters.AddWithValue("@txtDireccion", txtDireccion.Text);
                            cmd.Parameters.AddWithValue("@txtCiudad", txtCiudad.Text);
                            cmd.Parameters.AddWithValue("@txtEnlace", txtEnlace.Text);
                            cmd.Parameters.AddWithValue("@txtHorario", txtHorario.Text);
                            cmd.Parameters.AddWithValue("@txtHorariofds", txtHorariofds.Text);
                            cmd.Parameters.AddWithValue("@txtTk", txtTk.Text);
                            cmd.Parameters.AddWithValue("@txtContactoSede", txtContactoSede.Text);
                            cmd.Parameters.AddWithValue("@txtTelefonoSede", txtTelefonoSede.Text);
                            cmd.Parameters.AddWithValue("@cmbReincidente", cmbReincidente.Text);
                            cmd.Parameters.AddWithValue("@txtSWW", txtSWW.Text);
                            cmd.Parameters.AddWithValue("@txtSWPuerto", txtSWPuerto.Text);
                            cmd.Parameters.AddWithValue("@txtBW", txtBW.Text);
                            cmd.Parameters.AddWithValue("@txtCPEE", txtCPEE.Text);
                            cmd.Parameters.AddWithValue("@richObservaciones", richObservaciones.Text);
                            cmd.Parameters.AddWithValue("@txtTicket", txtTicket.Text);
                            cmd.Parameters.AddWithValue("@txtUCCID", txtUCCID.Text);
                            cmd.Parameters.AddWithValue("@richPDSR", richPDSR.Text);
                            cmd.Parameters.AddWithValue("@richSW", richSW.Text);
                            cmd.Parameters.AddWithValue("@richRUTA", richRUTA.Text);
                            cmd.Parameters.AddWithValue("@richUM", richUM.Text);
                            cmd.Parameters.AddWithValue("@richCPE", richCPE.Text);
                            cmd.Parameters.AddWithValue("@richSEÑALIZACION", richSEÑALIZACION.Text);
                            cmd.Parameters.AddWithValue("@nombresoporte", nombresoporte);


                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Se guardaron los datos correctamente " + PrefijoSoporte + IDconsecutivointerno, " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }


                    }



                    if (radioconsultacliente.Checked == true)
                    {
                        // Se guardan cambios en el histial de modificaciones
                        string query = "INSERT INTO " + LineaDeSoporte + ".historialModificaciones (`id`, `registro`, `accion`, `tipo`, `alteradoDe`, `alteradoA`, `accionPor`, `codigoAccionPor`, `fecha`) VALUES (NULL, '" + IDconsecutivointerno + "', 'Creó', ' estado con Interfaz de Gestión', '',@cmbestado , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' subEstado con Interfaz de Gestión', '',@cmbsubestado , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' servicioSolicitud con Interfaz de Gestión', '',@cmbservicio , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' fallaReportada con Interfaz de Gestión', '',@txtFALLA , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' nombre con Interfaz de Gestión', '',@txtNombre , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' telefono con Interfaz de Gestión', '',@txtTelefono , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' correo con Interfaz de Gestión', '',@txtCorreo , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' nit con Interfaz de Gestión', '',@txtNit , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' direccion con Interfaz de Gestión', '',@txtDireccion , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ciudad con Interfaz de Gestión', '',@txtCiudad , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' cuentaEnlace con Interfaz de Gestión', '',@txtEnlace , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' horarioAtencion con Interfaz de Gestión', '',@txtHorario , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' horarioAtencionFDS con Interfaz de Gestión', '',@txtHorariofds , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' tkInterno con Interfaz de Gestión', '',@txtTk , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' nombreContactoSede con Interfaz de Gestión', '',@txtContactoSede , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' telefonoContactoSede con Interfaz de Gestión', '',@txtTelefonoSede , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' reincidente con Interfaz de Gestión', '',@cmbReincidente , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' redAcceso con Interfaz de Gestión', '',@txtSWW , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' puertosSW con Interfaz de Gestión', '',@txtSWPuerto , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ClienteBW con Interfaz de Gestión', '',@txtBW , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' equipo con Interfaz de Gestión', '',@txtCPEE , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' observaciones con Interfaz de Gestión', '',@richObservaciones , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' radicadoTicket con Interfaz de Gestión', '',@txtTicket , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' uccid con Interfaz de Gestión', '',@txtUCCID , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' PDSR con Interfaz de Gestión', '',@richPDSR , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ValidacionSW con Interfaz de Gestión', '',@richSW , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ValidacionRuta con Interfaz de Gestión', '',@richRUTA , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ValidacionUM con Interfaz de Gestión', '',@richUM , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ValidacionCPE con Interfaz de Gestión', '',@richCPE , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' SenalizacionSER con Interfaz de Gestión', '',@richSEÑALIZACION , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'agenteasignado con Interfaz de Gestión', '',@nombresoporte, '" + nombresoporte + "', '" + idusuariosoporte + "', now())";
                        cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

                        cmd.Parameters.AddWithValue("@cmbestado", cmbestado.Text);
                        cmd.Parameters.AddWithValue("@cmbsubestado", cmbsubestado.Text);
                        cmd.Parameters.AddWithValue("@cmbservicio", cmbservicio.Text);
                        cmd.Parameters.AddWithValue("@txtFALLA", txtFALLA.Text);
                        cmd.Parameters.AddWithValue("@txtNombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@txtTelefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@txtCorreo", txtCorreo.Text);
                        cmd.Parameters.AddWithValue("@txtNit", txtNit.Text);
                        cmd.Parameters.AddWithValue("@txtDireccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("@txtCiudad", txtCiudad.Text);
                        cmd.Parameters.AddWithValue("@txtEnlace", txtEnlace.Text);
                        cmd.Parameters.AddWithValue("@txtHorario", txtHorario.Text);
                        cmd.Parameters.AddWithValue("@txtHorariofds", txtHorariofds.Text);
                        cmd.Parameters.AddWithValue("@txtTk", txtTk.Text);
                        cmd.Parameters.AddWithValue("@txtContactoSede", txtContactoSede.Text);
                        cmd.Parameters.AddWithValue("@txtTelefonoSede", txtTelefonoSede.Text);
                        cmd.Parameters.AddWithValue("@cmbReincidente", cmbReincidente.Text);
                        cmd.Parameters.AddWithValue("@txtSWW", txtSWW.Text);
                        cmd.Parameters.AddWithValue("@txtSWPuerto", txtSWPuerto.Text);
                        cmd.Parameters.AddWithValue("@txtBW", txtBW.Text);
                        cmd.Parameters.AddWithValue("@txtCPEE", txtCPEE.Text);
                        cmd.Parameters.AddWithValue("@richObservaciones", richObservaciones.Text);
                        cmd.Parameters.AddWithValue("@txtTicket", txtTicket.Text);
                        cmd.Parameters.AddWithValue("@txtUCCID", txtUCCID.Text);
                        cmd.Parameters.AddWithValue("@richPDSR", richPDSR.Text);
                        cmd.Parameters.AddWithValue("@richSW", richSW.Text);
                        cmd.Parameters.AddWithValue("@richRUTA", richRUTA.Text);
                        cmd.Parameters.AddWithValue("@richUM", richUM.Text);
                        cmd.Parameters.AddWithValue("@richCPE", richCPE.Text);
                        cmd.Parameters.AddWithValue("@richSEÑALIZACION", richSEÑALIZACION.Text);
                        cmd.Parameters.AddWithValue("@nombresoporte", nombresoporte);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se guardaron los datos correctamente " + PrefijoSoporte + IDconsecutivointerno, " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                    if (RadioECare.Checked == true)
                    {
                        // Se guardan cambios en el histial de modificaciones
                        string query = "INSERT INTO " + LineaDeSoporte + ".historialModificaciones (`id`, `registro`, `accion`, `tipo`, `alteradoDe`, `alteradoA`, `accionPor`, `codigoAccionPor`, `fecha`) VALUES (NULL, '" + IDconsecutivointerno + "', 'Creó', ' estado con Interfaz de Gestión', '',@cmbestado , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' subEstado con Interfaz de Gestión', '',@cmbsubestado , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' servicioSolicitud con Interfaz de Gestión', '',@cmbservicio , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' fallaReportada con Interfaz de Gestión', '',@txtFALLA , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' nombre con Interfaz de Gestión', '',@txtNombre , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' telefono con Interfaz de Gestión', '',@txtTelefono , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' correo con Interfaz de Gestión', '',@txtCorreo , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' nit con Interfaz de Gestión', '',@txtNit , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' direccion con Interfaz de Gestión', '',@txtDireccion , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ciudad con Interfaz de Gestión', '',@txtCiudad , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' cuentaEnlace con Interfaz de Gestión', '',@txtEnlace , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' horarioAtencion con Interfaz de Gestión', '',@txtHorario , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' horarioAtencionFDS con Interfaz de Gestión', '',@txtHorariofds , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' tkInterno con Interfaz de Gestión', '',@txtTk , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' nombreContactoSede con Interfaz de Gestión', '',@txtContactoSede , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' telefonoContactoSede con Interfaz de Gestión', '',@txtTelefonoSede , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' observaciones con Interfaz de Gestión', '',@richObservaciones , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' radicadoTicket con Interfaz de Gestión', '',@txtTicket , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' uccid con Interfaz de Gestión', '',@txtUCCID , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' SolicitudEcare con Interfaz de Gestión', '',@txtSolicitude , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' UsuarioEcare con Interfaz de Gestión', '',@txteusuario , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ContrasenaEcare con Interfaz de Gestión', '',@txtecontraseña , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' CierreSintoma con Interfaz de Gestión', '',@txtesintoma , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' CierreFInicio con Interfaz de Gestión', '',@txtefinicio , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' CierreFSolucion con Interfaz de Gestión', '',@txtefsolucion , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' CierreDown con Interfaz de Gestión', '',@txtedown , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' CierreFCausa con Interfaz de Gestión', '',@txtecfalla , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' CierreSolDef con Interfaz de Gestión', '',@txtesolucion , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' CierreSolFalla con Interfaz de Gestión', '',@txtesfalla , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' CierraFallaAtribuible con Interfaz de Gestión', '',@txtefallede , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' PQRActiva con Interfaz de Gestión', '',@txtepqr , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' TkRed con Interfaz de Gestión', '',@txtetk , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'agenteasignado con Interfaz de Gestión', '',@nombresoporte, '" + nombresoporte + "', '" + idusuariosoporte + "', now())";

                        cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

                        cmd.Parameters.AddWithValue("@cmbestado", cmbestado.Text);
                        cmd.Parameters.AddWithValue("@cmbsubestado", cmbsubestado.Text);
                        cmd.Parameters.AddWithValue("@cmbservicio", cmbservicio.Text);
                        cmd.Parameters.AddWithValue("@txtFALLA", txtFALLA.Text);
                        cmd.Parameters.AddWithValue("@txtNombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@txtTelefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@txtCorreo", txtCorreo.Text);
                        cmd.Parameters.AddWithValue("@txtNit", txtNit.Text);
                        cmd.Parameters.AddWithValue("@txtDireccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("@txtCiudad", txtCiudad.Text);
                        cmd.Parameters.AddWithValue("@txtEnlace", txtEnlace.Text);
                        cmd.Parameters.AddWithValue("@txtHorario", txtHorario.Text);
                        cmd.Parameters.AddWithValue("@txtHorariofds", txtHorariofds.Text);
                        cmd.Parameters.AddWithValue("@txtTk", txtTk.Text);
                        cmd.Parameters.AddWithValue("@txtContactoSede", txtContactoSede.Text);
                        cmd.Parameters.AddWithValue("@txtTelefonoSede", txtTelefonoSede.Text);
                        cmd.Parameters.AddWithValue("@richObservaciones", richObservaciones.Text);
                        cmd.Parameters.AddWithValue("@txtTicket", txtTicket.Text);
                        cmd.Parameters.AddWithValue("@txtUCCID", txtUCCID.Text);
                        cmd.Parameters.AddWithValue("@txtSolicitude", txtSolicitude.Text);
                        cmd.Parameters.AddWithValue("@txteusuario", txteusuario.Text);
                        cmd.Parameters.AddWithValue("@txtecontraseña", txtecontraseña.Text);
                        cmd.Parameters.AddWithValue("@txtesintoma", txtesintoma.Text);
                        cmd.Parameters.AddWithValue("@txtefinicio", txtefinicio.Text);
                        cmd.Parameters.AddWithValue("@txtefsolucion", txtefsolucion.Text);
                        cmd.Parameters.AddWithValue("@txtedown", txtedown.Text);
                        cmd.Parameters.AddWithValue("@txtecfalla", txtecfalla.Text);
                        cmd.Parameters.AddWithValue("@txtesolucion", txtesolucion.Text);
                        cmd.Parameters.AddWithValue("@txtesfalla", txtesfalla.Text);
                        cmd.Parameters.AddWithValue("@txtefallede", txtefallede.Text);
                        cmd.Parameters.AddWithValue("@txtepqr", txtepqr.Text);
                        cmd.Parameters.AddWithValue("@txtetk", txtetk.Text);
                        cmd.Parameters.AddWithValue("@nombresoporte", nombresoporte);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se guardaron los datos correctamente " + PrefijoSoporte + IDconsecutivointerno, " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                    if (rTransferencia.Checked == true)
                    {
                        // Se guardan cambios en el histial de modificaciones

                        string query = "INSERT INTO " + LineaDeSoporte + ".historialModificaciones (`id`, `registro`, `accion`, `tipo`, `alteradoDe`, `alteradoA`, `accionPor`, `codigoAccionPor`, `fecha`) VALUES (NULL, '" + IDconsecutivointerno + "', 'Creó', 'estadocon Interfaz de Gestión', '',@cmbestado , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'subEstadocon Interfaz de Gestión', '',@cmbsubestado , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'servicioSolicitudcon Interfaz de Gestión', '',@cmbservicio , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'fallaReportadacon Interfaz de Gestión', '',@txtFALLA , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'nombrecon Interfaz de Gestión', '',@txtNombre , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'telefonocon Interfaz de Gestión', '',@txtTelefono , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'correocon Interfaz de Gestión', '',@txtCorreo , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'nitcon Interfaz de Gestión', '',@txtNit , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'direccioncon Interfaz de Gestión', '',@txtDireccion , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'ciudadcon Interfaz de Gestión', '',@txtCiudad , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'cuentaEnlacecon Interfaz de Gestión', '',@txtEnlace , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'horarioAtencioncon Interfaz de Gestión', '',@txtHorario , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'horarioAtencionFDScon Interfaz de Gestión', '',@txtHorariofds , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'observacionescon Interfaz de Gestión', '',@richObservaciones , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'radicadoTicketcon Interfaz de Gestión', '',@txtTicket , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'uccidcon Interfaz de Gestión', '',@txtUCCID , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'MotivoTransferenciacon Interfaz de Gestión', '',@txtMotivo , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'TrasferenciaRecibidoPorcon Interfaz de Gestión', '',@txtRecibidopor , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'agenteasignadocon Interfaz de Gestión', '',@nombresoporte, '" + nombresoporte + "', '" + idusuariosoporte + "', now())";
                        cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

                        cmd.Parameters.AddWithValue("@cmbestado", cmbestado.Text);
                        cmd.Parameters.AddWithValue("@cmbsubestado", cmbsubestado.Text);
                        cmd.Parameters.AddWithValue("@cmbservicio", cmbservicio.Text);
                        cmd.Parameters.AddWithValue("@txtFALLA", txtFALLA.Text);
                        cmd.Parameters.AddWithValue("@txtNombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@txtTelefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@txtCorreo", txtCorreo.Text);
                        cmd.Parameters.AddWithValue("@txtNit", txtNit.Text);
                        cmd.Parameters.AddWithValue("@txtDireccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("@txtCiudad", txtCiudad.Text);
                        cmd.Parameters.AddWithValue("@txtEnlace", txtEnlace.Text);
                        cmd.Parameters.AddWithValue("@txtHorario", txtHorario.Text);
                        cmd.Parameters.AddWithValue("@txtHorariofds", txtHorariofds.Text);
                        cmd.Parameters.AddWithValue("@richObservaciones", richObservaciones.Text);
                        cmd.Parameters.AddWithValue("@txtTicket", txtTicket.Text);
                        cmd.Parameters.AddWithValue("@txtUCCID", txtUCCID.Text);
                        cmd.Parameters.AddWithValue("@txtMotivo", txtMotivo.Text);
                        cmd.Parameters.AddWithValue("@txtRecibidopor", txtRecibidopor.Text);
                        cmd.Parameters.AddWithValue("@nombresoporte", nombresoporte);



                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se guardaron los datos correctamente " + PrefijoSoporte + IDconsecutivointerno, " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                    if (radioFalla.Checked == true)
                    {
                        // Se guardan cambios en el histial de modificaciones
                        string query = "INSERT INTO " + LineaDeSoporte + ".historialModificaciones (`id`, `registro`, `accion`, `tipo`, `alteradoDe`, `alteradoA`, `accionPor`, `codigoAccionPor`, `fecha`) VALUES (NULL, '" + IDconsecutivointerno + "', 'Creó', 'estadocon Interfaz de Gestión', '',	@	cmbestado 	, '" + nombresoporte + "', '" + idusuariosoporte + "', now())	,(NULL, '" + IDconsecutivointerno + "', 'Creó', 'subEstadocon Interfaz de Gestión', '',	@	cmbsubestado 	, '" + nombresoporte + "', '" + idusuariosoporte + "', now())	,(NULL, '" + IDconsecutivointerno + "', 'Creó', 'servicioSolicitudcon Interfaz de Gestión', '',	@	cmbservicio 	, '" + nombresoporte + "', '" + idusuariosoporte + "', now())	,(NULL, '" + IDconsecutivointerno + "', 'Creó', 'fallaReportadacon Interfaz de Gestión', '',	@	txtFALLA 	, '" + nombresoporte + "', '" + idusuariosoporte + "', now())	,(NULL, '" + IDconsecutivointerno + "', 'Creó', 'nombrecon Interfaz de Gestión', '',	@	txtNombre 	, '" + nombresoporte + "', '" + idusuariosoporte + "', now())	,(NULL, '" + IDconsecutivointerno + "', 'Creó', 'telefonocon Interfaz de Gestión', '',	@	txtTelefono 	, '" + nombresoporte + "', '" + idusuariosoporte + "', now())	,(NULL, '" + IDconsecutivointerno + "', 'Creó', 'correocon Interfaz de Gestión', '',	@	txtCorreo 	, '" + nombresoporte + "', '" + idusuariosoporte + "', now())	,(NULL, '" + IDconsecutivointerno + "', 'Creó', 'nitcon Interfaz de Gestión', '',	@	txtNit 	, '" + nombresoporte + "', '" + idusuariosoporte + "', now())	,(NULL, '" + IDconsecutivointerno + "', 'Creó', 'direccioncon Interfaz de Gestión', '',	@	txtDireccion 	, '" + nombresoporte + "', '" + idusuariosoporte + "', now())	,(NULL, '" + IDconsecutivointerno + "', 'Creó', 'ciudadcon Interfaz de Gestión', '',	@	txtCiudad 	, '" + nombresoporte + "', '" + idusuariosoporte + "', now())	,(NULL, '" + IDconsecutivointerno + "', 'Creó', 'cuentaEnlacecon Interfaz de Gestión', '',	@	txtEnlace 	, '" + nombresoporte + "', '" + idusuariosoporte + "', now())	,(NULL, '" + IDconsecutivointerno + "', 'Creó', 'horarioAtencioncon Interfaz de Gestión', '',	@	txtHorario 	, '" + nombresoporte + "', '" + idusuariosoporte + "', now())	,(NULL, '" + IDconsecutivointerno + "', 'Creó', 'horarioAtencionFDScon Interfaz de Gestión', '',	@	txtHorariofds 	, '" + nombresoporte + "', '" + idusuariosoporte + "', now())	,(NULL, '" + IDconsecutivointerno + "', 'Creó', 'radicadoTicketcon Interfaz de Gestión', '',	@	txtTicket 	, '" + nombresoporte + "', '" + idusuariosoporte + "', now())	,(NULL, '" + IDconsecutivointerno + "', 'Creó', 'uccidcon Interfaz de Gestión', '',	@	txtUCCID 	, '" + nombresoporte + "', '" + idusuariosoporte + "', now())	,(NULL, '" + IDconsecutivointerno + "', 'Creó', 'redAccesocon Interfaz de Gestión', '',	@	txtSWW 	, '" + nombresoporte + "', '" + idusuariosoporte + "', now())	,(NULL, '" + IDconsecutivointerno + "', 'Creó', 'puertosSWcon Interfaz de Gestión', '',	@	txtSWPuerto 	, '" + nombresoporte + "', '" + idusuariosoporte + "', now())	,(NULL, '" + IDconsecutivointerno + "', 'Creó', 'nombreEmpresacon Interfaz de Gestión', '',	@	txtNombreEmpresa 	, '" + nombresoporte + "', '" + idusuariosoporte + "', now())	,(NULL, '" + IDconsecutivointerno + "', 'Creó', 'PermisosIngersocon Interfaz de Gestión', '',	@	txtIngresopermisos 	, '" + nombresoporte + "', '" + idusuariosoporte + "', now())	,(NULL, '" + IDconsecutivointerno + "', 'Creó', 'ValidacionRutacon Interfaz de Gestión', '',	@	richRUTA 	, '" + nombresoporte + "', '" + idusuariosoporte + "', now())	,(NULL, '" + IDconsecutivointerno + "', 'Creó', 'ValidacionUMcon Interfaz de Gestión', '',	@	richUM 	, '" + nombresoporte + "', '" + idusuariosoporte + "', now())	,(NULL, '" + IDconsecutivointerno + "', 'Creó', '	agenteasignadocon Interfaz de Gestión', '',	@	nombresoporte	, '" + nombresoporte + "', '" + idusuariosoporte + "', now())";
                        cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

                        cmd.Parameters.AddWithValue("@cmbestado", cmbestado.Text);
                        cmd.Parameters.AddWithValue("@cmbsubestado", cmbsubestado.Text);
                        cmd.Parameters.AddWithValue("@cmbservicio", cmbservicio.Text);
                        cmd.Parameters.AddWithValue("@txtFALLA", txtFALLA.Text);
                        cmd.Parameters.AddWithValue("@txtNombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@txtTelefono", txtTelefono.Text);
                        cmd.Parameters.AddWithValue("@txtCorreo", txtCorreo.Text);
                        cmd.Parameters.AddWithValue("@txtNit", txtNit.Text);
                        cmd.Parameters.AddWithValue("@txtDireccion", txtDireccion.Text);
                        cmd.Parameters.AddWithValue("@txtCiudad", txtCiudad.Text);
                        cmd.Parameters.AddWithValue("@txtEnlace", txtEnlace.Text);
                        cmd.Parameters.AddWithValue("@txtHorario", txtHorario.Text);
                        cmd.Parameters.AddWithValue("@txtHorariofds", txtHorariofds.Text);
                        cmd.Parameters.AddWithValue("@txtTicket", txtTicket.Text);
                        cmd.Parameters.AddWithValue("@txtUCCID", txtUCCID.Text);
                        cmd.Parameters.AddWithValue("@txtSWW", txtSWW.Text);
                        cmd.Parameters.AddWithValue("@txtSWPuerto", txtSWPuerto.Text);
                        cmd.Parameters.AddWithValue("@txtNombreEmpresa", txtNombreEmpresa.Text);
                        cmd.Parameters.AddWithValue("@txtIngresopermisos", txtIngresopermisos.Text);
                        cmd.Parameters.AddWithValue("@richRUTA", richRUTA.Text);
                        cmd.Parameters.AddWithValue("@richUM", richUM.Text);
                        cmd.Parameters.AddWithValue("@nombresoporte", nombresoporte);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se guardaron los datos correctamente " + PrefijoSoporte + IDconsecutivointerno, " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                    if (radioback.Checked == true)
                    {
                        // Se guardan cambios en el histial de modificaciones

                        string query = "INSERT INTO " + LineaDeSoporte + ".historialModificaciones (`id`, `registro`, `accion`, `tipo`, `alteradoDe`, `alteradoA`, `accionPor`, `codigoAccionPor`, `fecha`) VALUES (NULL, '" + IDconsecutivointerno + "', 'Creó', 'estadocon Interfaz de Gestión', '',@cmbestado , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'subEstadocon Interfaz de Gestión', '',@cmbsubestado , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'servicioSolicitudcon Interfaz de Gestión', '',@cmbservicio , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'fallaReportadacon Interfaz de Gestión', '',@txtFALLA , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'ValidacionSWcon Interfaz de Gestión', '',@richSW , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'ValidacionRutacon Interfaz de Gestión', '',@richRUTA , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'ValidacionUMcon Interfaz de Gestión', '',@richUM , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'ValidacionCPEcon Interfaz de Gestión', '',@richCPE , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'observacionescon Interfaz de Gestión', '',@richObservaciones , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'radicadoTicketcon Interfaz de Gestión', '',@txtTicket , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'uccidcon Interfaz de Gestión', '',@txtUCCID , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'agenteasignadocon Interfaz de Gestión', '',@nombresoporte, '" + nombresoporte + "', '" + idusuariosoporte + "', now())";
                        cmd = new MySqlCommand("INSERT INTO " + LineaDeSoporte + ".historialModificaciones (`id`, `registro`, `accion`, `tipo`, `alteradoDe`, `alteradoA`, `accionPor`, `codigoAccionPor`, `fecha`) VALUES (NULL, '" + IDconsecutivointerno + "', 'Creó', ' estado con Interfaz de Gestión', '', '" + cmbestado.Text.Trim() + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' subEstado con Interfaz de Gestión', '', '" + cmbsubestado.Text.Trim() + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' servicioSolicitud con Interfaz de Gestión', '', '" + cmbservicio.Text.Trim() + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' fallaReportada con Interfaz de Gestión', '', '" + txtFALLA.Text.Trim() + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ValidacionSW con Interfaz de Gestión', '', '" + richSW.Text.Trim() + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ValidacionRuta con Interfaz de Gestión', '', '" + richRUTA.Text.Trim() + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ValidacionUM con Interfaz de Gestión', '', '" + richUM.Text.Trim() + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' ValidacionCPE con Interfaz de Gestión', '', '" + richCPE.Text.Trim() + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' observaciones con Interfaz de Gestión', '', '" + richObservaciones.Text.Trim() + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' radicadoTicket con Interfaz de Gestión', '', '" + txtTicket.Text.Trim() + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', ' uccid con Interfaz de Gestión', '', '" + txtUCCID.Text.Trim() + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now())", Conexion.ObtenerConexion());

                        cmd.Parameters.AddWithValue("@cmbestado", cmbestado.Text);
                        cmd.Parameters.AddWithValue("@cmbsubestado", cmbsubestado.Text);
                        cmd.Parameters.AddWithValue("@cmbservicio", cmbservicio.Text);
                        cmd.Parameters.AddWithValue("@txtFALLA", txtFALLA.Text);
                        cmd.Parameters.AddWithValue("@richSW", richSW.Text);
                        cmd.Parameters.AddWithValue("@richRUTA", richRUTA.Text);
                        cmd.Parameters.AddWithValue("@richUM", richUM.Text);
                        cmd.Parameters.AddWithValue("@richCPE", richCPE.Text);
                        cmd.Parameters.AddWithValue("@richObservaciones", richObservaciones.Text);
                        cmd.Parameters.AddWithValue("@txtTicket", txtTicket.Text);
                        cmd.Parameters.AddWithValue("@txtUCCID", txtUCCID.Text);
                        cmd.Parameters.AddWithValue("@nombresoporte", nombresoporte);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se guardaron los datos correctamente " + PrefijoSoporte + IDconsecutivointerno, " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                    if (RadioConfiguracionCPE.Checked == true)
                    {
                        // Se guardan cambios en el histial de modificaciones
                        string query = "INSERT INTO " + LineaDeSoporte + ".historialModificaciones (`id`, `registro`, `accion`, `tipo`, `alteradoDe`, `alteradoA`, `accionPor`, `codigoAccionPor`, `fecha`) VALUES (NULL, '" + IDconsecutivointerno + "', 'Creó', 'estadocon Interfaz de Gestión', '',@cmbestado , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'subEstadocon Interfaz de Gestión', '',@cmbsubestado , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'servicioSolicitudcon Interfaz de Gestión', '',@cmbservicio , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'fallaReportadacon Interfaz de Gestión', '',@txtFALLA , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'seRecibeCorreocon Interfaz de Gestión', '',@richSeRecibeCorreo , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'PDSRcon Interfaz de Gestión', '',@richPDSR , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'ValidacionRutacon Interfaz de Gestión', '',@richRUTA , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'ValidacionCapa2con Interfaz de Gestión', '',@richCapa2 , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'ValidacionUMcon Interfaz de Gestión', '',@richUM , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'ValidacionCPEcon Interfaz de Gestión', '',@richCPE , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'ConfiguracionCPEcon Interfaz de Gestión', '',@richConfiguracionRealizada , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'SeEnviaCorreocon Interfaz de Gestión', '',@richSeEnviaCorreo , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'radicadoTicketcon Interfaz de Gestión', '',@txtTicket , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'uccidcon Interfaz de Gestión', '',@txtUCCID , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'agenteasignadocon Interfaz de Gestión', '',@nombresoporte, '" + nombresoporte + "', '" + idusuariosoporte + "', now())";
                        cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

                        cmd.Parameters.AddWithValue("@cmbestado", cmbestado.Text);
                        cmd.Parameters.AddWithValue("@cmbsubestado", cmbsubestado.Text);
                        cmd.Parameters.AddWithValue("@cmbservicio", cmbservicio.Text);
                        cmd.Parameters.AddWithValue("@txtFALLA", txtFALLA.Text);
                        cmd.Parameters.AddWithValue("@richSeRecibeCorreo", richSeRecibeCorreo.Text);
                        cmd.Parameters.AddWithValue("@richPDSR", richPDSR.Text);
                        cmd.Parameters.AddWithValue("@richRUTA", richRUTA.Text);
                        cmd.Parameters.AddWithValue("@richCapa2", richCapa2.Text);
                        cmd.Parameters.AddWithValue("@richUM", richUM.Text);
                        cmd.Parameters.AddWithValue("@richCPE", richCPE.Text);
                        cmd.Parameters.AddWithValue("@richConfiguracionRealizada", richConfiguracionRealizada.Text);
                        cmd.Parameters.AddWithValue("@richSeEnviaCorreo", richSeEnviaCorreo.Text);
                        cmd.Parameters.AddWithValue("@txtTicket", txtTicket.Text);
                        cmd.Parameters.AddWithValue("@txtUCCID", txtUCCID.Text);
                        cmd.Parameters.AddWithValue("@nombresoporte", nombresoporte);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se guardaron los datos correctamente " + PrefijoSoporte + IDconsecutivointerno, " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                    if (RadioConfiguracionTelefonia.Checked == true)
                    {
                        // Se guardan cambios en el histial de modificaciones
                        string query = "INSERT INTO " + LineaDeSoporte + ".historialModificaciones (`id`, `registro`, `accion`, `tipo`, `alteradoDe`, `alteradoA`, `accionPor`, `codigoAccionPor`, `fecha`) VALUES ((NULL, '" + IDconsecutivointerno + "', 'Creó', 'estadocon Interfaz de Gestión', '',@cmbestado , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'subEstadocon Interfaz de Gestión', '',@cmbsubestado , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'servicioSolicitudcon Interfaz de Gestión', '',@cmbservicio , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'fallaReportadacon Interfaz de Gestión', '',@txtFALLA , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'InfoAtencioncon Interfaz de Gestión', '',@richInformacionDeLaAtencion , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'PermisosActualescon Interfaz de Gestión', '',@richValidarPermisosActuales , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'HabilitarPermisoscon Interfaz de Gestión', '',@richHabilitarPermisos , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'SeEnviaCorreocon Interfaz de Gestión', '',@richSeEnviaCorreo , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'radicadoTicketcon Interfaz de Gestión', '',@txtTicket , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'uccidcon Interfaz de Gestión', '',@txtUCCID , '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', 'agenteasignadocon Interfaz de Gestión', '',@nombresoporte, '" + nombresoporte + "', '" + idusuariosoporte + "', now())";
                        cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

                        cmd.Parameters.AddWithValue("@cmbestado", cmbestado.Text);
                        cmd.Parameters.AddWithValue("@cmbsubestado", cmbsubestado.Text);
                        cmd.Parameters.AddWithValue("@cmbservicio", cmbservicio.Text);
                        cmd.Parameters.AddWithValue("@txtFALLA", txtFALLA.Text);
                        cmd.Parameters.AddWithValue("@richInformacionDeLaAtencion", richInformacionDeLaAtencion.Text);
                        cmd.Parameters.AddWithValue("@richValidarPermisosActuales", richValidarPermisosActuales.Text);
                        cmd.Parameters.AddWithValue("@richHabilitarPermisos", richHabilitarPermisos.Text);
                        cmd.Parameters.AddWithValue("@richSeEnviaCorreo", richSeEnviaCorreo.Text);
                        cmd.Parameters.AddWithValue("@txtTicket", txtTicket.Text);
                        cmd.Parameters.AddWithValue("@txtUCCID", txtUCCID.Text);
                        cmd.Parameters.AddWithValue("@nombresoporte", nombresoporte);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se guardaron los datos correctamente " + PrefijoSoporte + IDconsecutivointerno, " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                        /*
                          // Se guardan cambios en el histial de modificaciones
                        cmd = new MySqlCommand("INSERT INTO " + LineaDeSoporte + ".historialModificaciones (`id`, `registro`, `accion`, `tipo`, `alteradoDe`, `alteradoA`, `accionPor`, `codigoAccionPor`, `fecha`) VALUES ", Conexion.ObtenerConexion());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Se registraron los datos correctamente");
                        */
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar" + ex.Message);
                }
            }

            //////////////////////////////////////////////// Se guardan datos para modificar el registro  <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

            if (idconsulta != "null")
            {


                try
                {




                    //Se actualzia tabla registros

                    string query = "UPDATE " + LineaDeSoporte + ".registros SET ultimamodificacionpor = @nombresoporte, fechaultimamodificacion = now(), agenteasignado =@nombresoporte, formacion = @formacionsoporte, supervision = @supervisionsoporte, calidad = @calidadsoporte, estado = @cmbestado, nombre = @txtNombre, telefono = @txtTelefono, nit = @txtNit, correo = @txtCorreo, subEstado = @cmbsubestado, servicioSolicitud = @cmbservicio, fallaReportada = @txtFALLA, cuentaEnlace = @txtEnlace, redAcceso = @txtSWW, equipo = @txtCPEE, radicadoTicket = @txtTicket, nombreEmpresa = @txtNombreEmpresa, direccion = @txtDireccion, ciudad = @txtCiudad, horarioAtencion = @txtHorario, horarioAtencionFDS = @txtHorariofds, reincidente = @cmbReincidente, observaciones = @richObservaciones, tkInterno = @txtTk, nombreContactoSede = @txtContactoSede, telefonoContactoSede = @txtTelefonoSede, ClienteBW = @txtBW, puertosSW = @txtSWPuerto, PDSR = @richPDSR, ValidacionSW = @richSW, ValidacionRuta = @richRUTA, ValidacionUM = @richUM, ValidacionCPE = @richCPE, SenalizacionSER = @richSEÑALIZACION, CierreSintoma = @txtCSintoma, CierreFInicio = @txtCFInicio, CierreFSolucion = @txtCFSolucion, CierreDown = @txtCDown, CierreFCausa = @txtCCausa, CierreSolDef = @cmbCSolucion, CierreSolFalaRazon =@txtCSFalla, CierraFallaAtribuible = @txtCFalla, PQRActiva = @cmbCPQR, TkRed = @txtCTK, MotivoTransferencia = @txtMotivo, TrasferenciaRecibidoPor = @txtRecibidopor, PermisosIngerso = @txtIngresopermisos, ValidacionCapa2 = @richCapa2, ConfiguracionCPE = @richConfiguracionRealizada, SeEnviaCorreo = @richSeEnviaCorreo, InfoAtencion = @richInformacionDeLaAtencion, PermisosActuales = @richValidarPermisosActuales, HabilitarPermisos = @richHabilitarPermisos, uccid = @txtUCCID, seRecibeCorreo = @richSeRecibeCorreo, CierreSolFalla = @txtCSFalla, SolicitudEcare = @txtSolicitude, UsuarioEcare = @txteusuario, ContrasenaEcare = @txtecontraseña, CierreSintoma = @txtesintoma, CierreFInicio = @txtefinicio, CierreFSolucion = @txtefsolucion, CierreDown = @txtedown, CierreFCausa = @txtecfalla, CierreSolDef = @txtesolucion, CierreSolFalla = @txtesfalla, CierraFallaAtribuible = @txtefallede, PQRActiva = @txtepqr, TkRed = @txtetk, " + UpdateTimeTabla + " = now(), documento_identidad =" + Documentosoporte + " WHERE " + LineaDeSoporte + ".registros.id = '" + idconsulta + "';";
                    cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

                    cmd.Parameters.AddWithValue("@nombresoporte", nombresoporte);
                    //cmd.Parameters.AddWithValue("now()", now());
                    //cmd.Parameters.AddWithValue("@nombresoporte", nombresoporte);
                    cmd.Parameters.AddWithValue("@formacionsoporte", formacionsoporte);
                    cmd.Parameters.AddWithValue("@supervisionsoporte", supervisionsoporte);
                    cmd.Parameters.AddWithValue("@calidadsoporte", calidadsoporte);
                    cmd.Parameters.AddWithValue("@cmbestado", cmbestado.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtNombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtTelefono", txtTelefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtNit", txtNit.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtCorreo", txtCorreo.Text.Trim());
                    cmd.Parameters.AddWithValue("@cmbsubestado", cmbsubestado.Text.Trim());
                    cmd.Parameters.AddWithValue("@cmbservicio", cmbservicio.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtFALLA", txtFALLA.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtEnlace", txtEnlace.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtSWW", txtSWW.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtCPEE", txtCPEE.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtTicket", txtTicket.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtNombreEmpresa", txtNombreEmpresa.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtDireccion", txtDireccion.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtCiudad", txtCiudad.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtHorario", txtHorario.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtHorariofds", txtHorariofds.Text.Trim());
                    cmd.Parameters.AddWithValue("@cmbReincidente", cmbReincidente.Text.Trim());
                    cmd.Parameters.AddWithValue("@richObservaciones", richObservaciones.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtTk", txtTk.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtContactoSede", txtContactoSede.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtTelefonoSede", txtTelefonoSede.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtBW", txtBW.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtSWPuerto", txtSWPuerto.Text.Trim());
                    cmd.Parameters.AddWithValue("@richPDSR", richPDSR.Text.Trim());
                    cmd.Parameters.AddWithValue("@richSW", richSW.Text.Trim());
                    cmd.Parameters.AddWithValue("@richRUTA", richRUTA.Text.Trim());
                    cmd.Parameters.AddWithValue("@richUM", richUM.Text.Trim());
                    cmd.Parameters.AddWithValue("@richCPE", richCPE.Text.Trim());
                    cmd.Parameters.AddWithValue("@richSEÑALIZACION", richSEÑALIZACION.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtCSintoma", txtCSintoma.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtCFInicio", txtCFInicio.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtCFSolucion", txtCFSolucion.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtCDown", txtCDown.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtCCausa", txtCCausa.Text.Trim());
                    cmd.Parameters.AddWithValue("@cmbCSolucion", cmbCSolucion.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtCSFalla", txtCSFalla.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtCFalla", txtCFalla.Text.Trim());
                    cmd.Parameters.AddWithValue("@cmbCPQR", cmbCPQR.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtCTK", txtCTK.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtMotivo", txtMotivo.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtRecibidopor", txtRecibidopor.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtIngresopermisos", txtIngresopermisos.Text.Trim());
                    cmd.Parameters.AddWithValue("@richCapa2", richCapa2.Text.Trim());
                    cmd.Parameters.AddWithValue("@richConfiguracionRealizada", richConfiguracionRealizada.Text.Trim());
                    cmd.Parameters.AddWithValue("@richSeEnviaCorreo", richSeEnviaCorreo.Text.Trim());
                    cmd.Parameters.AddWithValue("@richInformacionDeLaAtencion", richInformacionDeLaAtencion.Text.Trim());
                    cmd.Parameters.AddWithValue("@richValidarPermisosActuales", richValidarPermisosActuales.Text.Trim());
                    cmd.Parameters.AddWithValue("@richHabilitarPermisos", richHabilitarPermisos.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtUCCID", txtUCCID.Text.Trim());
                    cmd.Parameters.AddWithValue("@richSeRecibeCorreo", richSeRecibeCorreo.Text.Trim());
                    // cmd.Parameters.AddWithValue("@txtCSFalla", txtCSFalla.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtSolicitude", txtSolicitude.Text.Trim());
                    cmd.Parameters.AddWithValue("@txteusuario", txteusuario.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtecontraseña", txtecontraseña.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtesintoma", txtesintoma.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtefinicio", txtefinicio.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtefsolucion", txtefsolucion.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtedown", txtedown.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtecfalla", txtecfalla.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtesolucion", txtesolucion.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtesfalla", txtesfalla.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtefallede", txtefallede.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtepqr", txtepqr.Text.Trim());
                    cmd.Parameters.AddWithValue("@txtetk", txtetk.Text.Trim());


                    cmd.ExecuteNonQuery();
                    //Se insertan datos en historial_actividades
                    cmd = new MySqlCommand("INSERT INTO " + LineaDeSoporte + ".historial_actividades (`id`, `fechacreacion`, `agenteasignado`, `comentario`, `fechahoraeliminacion`, `usuarioeliminacion`, `codigo`) VALUES (NULL, now(), '" + nombresoporte + "', '" + richComentario.Text.Trim() + "', NULL, '', '" + idconsulta + "');", Conexion.ObtenerConexion());
                    cmd.ExecuteNonQuery();
                    //Se insertan datos en productividad
                    cmd = new MySqlCommand("INSERT INTO " + LineaDeSoporte + ".productividad (`id`, `registro`, `estado`, `subestado`, `consecutivointerno`, `codigo`, `agenteasignado`, `diarecibidolatcom`, `fechaultimamodificacion`, `documento_identidad`, `formacion`, `supervision`, `calidad`, `minfalla`) VALUES (NULL, '" + idconsulta + "', '" + cmbestado.Text.Trim() + "', '" + cmbsubestado.Text.Trim() + "', '" + PrefijoSoporte + idconsulta + "', '" + idusuariosoporte + "', '" + nombresoporte + "', '', now(), '" + Documentosoporte + "', '" + formacionsoporte + "', '" + supervisionsoporte + "', '" + calidadsoporte + "', NULL);", Conexion.ObtenerConexion());
                    cmd.ExecuteNonQuery();

                    // Se guardan cambios en el histial de modificaciones
                    //   cmd = new MySqlCommand("INSERT INTO " + LineaDeSoporte + ".historialModificaciones (`id`, `registro`, `accion`, `tipo`, `alteradoDe`, `alteradoA`, `accionPor`, `codigoAccionPor`, `fecha`) VALUES (NULL, '" + IDconsecutivointerno + "', 'Creó', '	estado	con Interfaz de Gestión', '', '" + cmbestado.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	nombre	con Interfaz de Gestión', '', '" + txtNombre.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	telefono	con Interfaz de Gestión', '', '" + txtTelefono.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	nit	con Interfaz de Gestión', '', '" + txtNit.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	correo	con Interfaz de Gestión', '', '" + txtCorreo.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	servicioSolicitud	con Interfaz de Gestión', '', '" + cmbservicio.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	subEstado	con Interfaz de Gestión', '', '" + cmbsubestado.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	fallaReportada	con Interfaz de Gestión', '', '" + txtFALLA.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	cuentaEnlace	con Interfaz de Gestión', '', '" + txtEnlace.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	redAcceso	con Interfaz de Gestión', '', '" + txtSWW.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	equipo	con Interfaz de Gestión', '', '" + txtCPEE.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	radicadoTicket	con Interfaz de Gestión', '', '" + txtTicket.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()), (NULL, '" + IDconsecutivointerno + "', 'Creó', '	direccion	con Interfaz de Gestión', '', '" + txtDireccion.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	ciudad	con Interfaz de Gestión', '', '" + txtCiudad.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	horarioAtencion	con Interfaz de Gestión', '', '" + txtHorario.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	horarioAtencionFDS	con Interfaz de Gestión', '', '" + txtHorariofds.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	reincidente	con Interfaz de Gestión', '', '" + cmbReincidente.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	observaciones	con Interfaz de Gestión', '', '" + richObservaciones.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	tkInterno	con Interfaz de Gestión', '', '" + txtTk.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	nombreContactoSede	con Interfaz de Gestión', '', '" + txtContactoSede.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	telefonoContactoSede	con Interfaz de Gestión', '', '" + txtTelefonoSede.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	ClienteBW	con Interfaz de Gestión', '', '" + txtBW.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	puertosSW	con Interfaz de Gestión', '', '" + txtSWPuerto.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	PDSR	con Interfaz de Gestión', '', '" + richPDSR.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	ValidacionSW	con Interfaz de Gestión', '', '" + richSW.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	ValidacionRuta	con Interfaz de Gestión', '', '" + richRUTA.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	ValidacionUM	con Interfaz de Gestión', '', '" + richUM.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	ValidacionCPE	con Interfaz de Gestión', '', '" + richCPE.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	SenalizacionSER	con Interfaz de Gestión', '', '" + richSEÑALIZACION.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	CierreSintoma	con Interfaz de Gestión', '', '" + txtCSintoma.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	CierreFInicio	con Interfaz de Gestión', '', '" + txtCFInicio.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	CierreFSolucion	con Interfaz de Gestión', '', '" + txtCFSolucion.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	CierreDown	con Interfaz de Gestión', '', '" + txtCDown.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	CierreFCausa	con Interfaz de Gestión', '', '" + txtCCausa.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	CierreSolDef	con Interfaz de Gestión', '', '" + cmbCSolucion.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	CierreSolFalaRazon	con Interfaz de Gestión', '', '" + txtCSFalla.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	CierraFallaAtribuible	con Interfaz de Gestión', '', '" + txtCFalla.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	PQRActiva	con Interfaz de Gestión', '', '" + cmbCPQR.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()),(NULL, '" + IDconsecutivointerno + "', 'Creó', '	TkRed	con Interfaz de Gestión', '', '" + txtCTK.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now()), (NULL, '" + IDconsecutivointerno + "', 'Creó', '	uccid con Interfaz de Gestión', '', '" + txtUCCID.Text + "', '" + nombresoporte + "', '" + idusuariosoporte + "', now())", Conexion.ObtenerConexion());
                    //cmd.ExecuteNonQuery();
                    MessageBox.Show("Se guardaron los datos correctamente " + PrefijoSoporte + idconsulta, " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);




                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar || " + ex.Message);
                }



            }




        }
        //metodo para actualizar datos en mysql    <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
        public void UpdateMysql()
        {
            try
            {
                string SolPrimerContacto = "", Escalado = "", Transferencia = "", Seguimiento = "", cierretxtCSintoma, cierretxtCFInicio, cierretxtCFSolucion, cierretxtCDown, cierretxtCCausa, cierrecmbCSolucion, cierretxtCSFalla, cierretxtCFalla, cierrecmbCPQR, cierretxtCTK, cierretxtMotivo;

                cierretxtCSintoma = txtCSintoma.Text.Trim();
                cierretxtCFInicio = txtCFInicio.Text.Trim();
                cierretxtCFSolucion = txtCFSolucion.Text.Trim();
                cierretxtCDown = txtCDown.Text.Trim();
                cierretxtCCausa = txtCCausa.Text.Trim();
                cierrecmbCSolucion = cmbCSolucion.Text.Trim();
                cierretxtCSFalla = txtCSFalla.Text.Trim();
                cierretxtCFalla = txtCFalla.Text.Trim();
                cierrecmbCPQR = cmbCPQR.Text.Trim();
                cierretxtCTK = txtCTK.Text.Trim();
                cierretxtMotivo = txtMotivo.Text.Trim();

                //SE cambian plantilal de cierre cuando se lecciona  ecare

                if (RadioECare.Checked == true)
                {
                    cierretxtCSintoma = txtesintoma.Text.Trim();
                    cierretxtCFInicio = txtefinicio.Text.Trim();
                    cierretxtCFSolucion = txtefsolucion.Text.Trim();
                    cierretxtCDown = txtedown.Text.Trim();
                    cierretxtCCausa = txtecfalla.Text;
                    cierrecmbCSolucion = txtesolucion.Text.Trim();
                    cierretxtCSFalla = txtesfalla.Text.Trim();
                    cierretxtCFalla = txtefallede.Text.Trim();
                    cierrecmbCPQR = txtepqr.Text.Trim();
                    cierretxtCTK = txtetk.Text.Trim();
                    cierretxtMotivo = txtMotivo.Text.Trim();
                }


                //Se selecicona la fecha de solucion segun linea de soporte, front o back 

                if (radioFront.Checked == true)
                {
                    fechasolucioncerrado = "fechasolucionenprimercontacto";

                }
                if (radioBacklinea.Checked == true)
                {
                    fechasolucioncerrado = "fechacerrado";
                }


                //SOLUCION PRIMER CONTACTO 

                if (cmbestado.Text == "SOLUCIÓN EN PRIMER CONTACTO" | cmbestado.Text == "CERRADO")
                {
                    SolPrimerContacto = "now()";
                    Escalado = "NULL";
                    Transferencia = "NULL";
                    Seguimiento = "NULL";

                    if (radioFront.Checked == true)
                    {
                        UpdateTimeTabla = "fechasolucionenprimercontacto";
                    }
                    if (radioBacklinea.Checked == true)
                    {
                        UpdateTimeTabla = "fechacerrado";
                    }



                }

                if (cmbestado.Text == "TRANSFERENCIA")
                {
                    SolPrimerContacto = "NULL";
                    Escalado = "NULL";
                    Transferencia = "now()";
                    Seguimiento = "NULL";
                    UpdateTimeTabla = "fechatransferencia";
                    TransferenciaPendiente = "fechatransferencia";

                }

                if (cmbestado.Text == "SEGUIMIENTO")
                {
                    SolPrimerContacto = "NULL";
                    Escalado = "NULL";
                    Transferencia = "NULL";
                    Seguimiento = "now()";
                    UpdateTimeTabla = "fechaseguimiento";
                    TransferenciaPendiente = "fechapendiente";


                }
                if (cmbestado.Text == "ESCALADO")
                {
                    SolPrimerContacto = "NULL";
                    Escalado = "now()";
                    Transferencia = "NULL";
                    Seguimiento = "NULL";

                    UpdateTimeTabla = "fechaescalado";

                    if (cmbestado.Text == "ESCALADO" & radioFront.Checked == true)
                    {

                        try
                        {


                            // Se guardan datos en la BD back registros <<<<<<<<<<<<<<<<
                            string QueryBDregistros = "INSERT INTO empresasNegociosBack.registros (`id`, `consecutivointerno`, `ultimamodificacionpor`, `fechaultimamodificacion`, `creadopor`, `fechacreacion`, `documento_identidad`, `ultimamodificacionmasivapor`, `fechaultimamodificacionmasiva`, `agenteasignado`, `añorecibidolatcom`, `diarecibidolatcom`, `estado`, `fecha1ergestion`, `mesrecibidolatcom`, `formacion`, `supervision`, `calidad`, `estado1ergestion`, `nombre`, `cargo`, `telefono`, `nit`, `correo`, `uccid`, `chatSpark`, `linea`, `servicioSolicitud`, `subEstado`, `fallaReportada`, `cuentaEnlace`, `redAcceso`, `equipo`, `radicadoTicket`, `plantilla`, `nombreEmpresa`, `direccion`, `ciudad`, `horarioAtencion`, `horarioAtencionFDS`, `clienteAutorizaEnvioCorreo`, `LLSOTAVISO`, `tituloAviso`, `reincidente`, `observaciones`, `equipoEnganchado`, `pqrPorEstaCausa`, `provisionCorrecta`, `subeConReinicio`, `cuentasVecinas`, `reparoActualizo`, `ssid`, `cuentaMatrizCaida`, `ip`, `pe`, `pass`, `mascara`, `dns2`, `dns1`, `numeroNuevo`, `numeroAntiguo`, `tipologia`, `marcacion`, `equipoRR`, `cuantosEquiposFallan`, `estructuraMarcacionRR`, `cedula`, `fechacerrado`, `fechaescalado`, `fechapendiente`, `fechaseguimiento`, `tkInterno`, `nombreContactoSede`, `telefonoContactoSede`, `ClienteBW`, `puertosSW`, `PDSR`, `ValidacionSW`, `ValidacionRuta`, `ValidacionUM`, `ValidacionCPE`, `SenalizacionSER`, `CierreSintoma`, `CierreFInicio`, `CierreFSolucion`, `CierreDown`, `CierreFCausa`, `CierreSolDef`, `CierreSolFalla`, `CierreSolFalaRazon`, `CierraFallaAtribuible`, `PQRActiva`, `TkRed`, `MotivoTransferencia`, `TrasferenciaRecibidoPor`, `PermisosIngerso`, `ValidacionCapa2`, `ConfiguracionCPE`, `SeEnviaCorreo`, `InfoAtencion`, `PermisosActuales`, `HabilitarPermisos`, `tipoDeGestionSelect`, `plantillaCierre`, `seRecibeCorreo`, `SolicitudEcare`, `UsuarioEcare`, `ContrasenaEcare`, `ClienteEcare`, `franjaVisita`,`skill`,`nombreSkill`,`estructuraLLS`,`codigoServicio`,areaResponsable) VALUES " + " (@id,@consecutivointerno,@ultimamodificacionpor,now(),@creadopor,now(),@documento_identidad,@ultimamodificacionmasivapor,@fechaultimamodificacionmasiva,@agenteasignado,@añorecibidolatcom,@diarecibidolatcom,@estado,now(),@mesrecibidolatcom,@formacion,@supervision,@calidad,@estado1ergestion,@nombre,@cargo,@telefono,@nit,@correo,@uccid,@chatSpark,@linea,@servicioSolicitud,@subEstado,@fallaReportada,@cuentaEnlace,@redAcceso,@equipo,@radicadoTicket,@plantilla,@nombreEmpresa,@direccion,@ciudad,@horarioAtencion,@horarioAtencionFDS,@clienteAutorizaEnvioCorreo,@LLSOTAVISO,@tituloAviso,@reincidente,@observaciones,@equipoEnganchado,@pqrPorEstaCausa,@provisionCorrecta,@subeConReinicio,@cuentasVecinas,@reparoActualizo,@ssid,@cuentaMatrizCaida,@ip,@pe,@pass,@mascara,@dns2,@dns1,@numeroNuevo,@numeroAntiguo,@tipologia,@marcacion,@equipoRR,@cuantosEquiposFallan,@estructuraMarcacionRR,@cedula," + SolPrimerContacto + ", " + Escalado + ", " + Transferencia + ", " + Seguimiento + ",@tkInterno,@nombreContactoSede,@telefonoContactoSede,@ClienteBW,@puertosSW,@PDSR,@ValidacionSW,@ValidacionRuta,@ValidacionUM,@ValidacionCPE,@SenalizacionSER,@CierreSintoma,@CierreFInicio,@CierreFSolucion,@CierreDown,@CierreFCausa,@CierreSolDef,@CierreSolFalla,@CierreSolFalaRazon,@CierraFallaAtribuible,@PQRActiva,@TkRed,@MotivoTransferencia,@TrasferenciaRecibidoPor,@PermisosIngerso,@ValidacionCapa2,@ConfiguracionCPE,@SeEnviaCorreo,@InfoAtencion,@PermisosActuales,@HabilitarPermisos,@tipoDeGestionSelect,'" + PlantillaCierre + "',@seRecibeCorreo,@SolicitudEcare,@UsuarioEcare,@ContrasenaEcare,'" + usuarioecare + "',@franjaVisita,@skill,@nombreSkill,@estructuraLLS,@codigoServicio,@areaResponsable); SELECT LAST_INSERT_ID() as lastid;";
                            cmd = new MySqlCommand(QueryBDregistros, Conexion.ObtenerConexion());

                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@id", null);
                            cmd.Parameters.AddWithValue("@consecutivointerno", "");
                            cmd.Parameters.AddWithValue("@ultimamodificacionpor", nombresoporte);
                            //cmd.Parameters.AddWithValue("@fechaultimamodificacion", DateTime.Now);
                            cmd.Parameters.AddWithValue("@creadopor", nombresoporte);
                            //cmd.Parameters.AddWithValue("@fechacreacion", "now()");
                            cmd.Parameters.AddWithValue("@documento_identidad", Documentosoporte);
                            cmd.Parameters.AddWithValue("@ultimamodificacionmasivapor", "");
                            cmd.Parameters.AddWithValue("@fechaultimamodificacionmasiva", null);
                            cmd.Parameters.AddWithValue("@agenteasignado", nombresoporte);
                            cmd.Parameters.AddWithValue("@añorecibidolatcom", "");
                            cmd.Parameters.AddWithValue("@diarecibidolatcom", "");
                            cmd.Parameters.AddWithValue("@estado", cmbestado.Text.Trim());
                            //cmd.Parameters.AddWithValue("@fecha1ergestion", "now()");
                            cmd.Parameters.AddWithValue("@mesrecibidolatcom", "");
                            cmd.Parameters.AddWithValue("@formacion", formacionsoporte);
                            cmd.Parameters.AddWithValue("@supervision", supervisionsoporte);
                            cmd.Parameters.AddWithValue("@calidad", calidadsoporte);
                            cmd.Parameters.AddWithValue("@estado1ergestion", cmbestado.Text.Trim());
                            cmd.Parameters.AddWithValue("@nombre", this.txtNombre.Text.Trim());
                            cmd.Parameters.AddWithValue("@cargo", "");
                            cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text.Trim());
                            cmd.Parameters.AddWithValue("@nit", txtNit.Text.Trim());
                            cmd.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());
                            cmd.Parameters.AddWithValue("@uccid", txtUCCID.Text.Trim());
                            cmd.Parameters.AddWithValue("@chatSpark", chSpark.Checked);
                            cmd.Parameters.AddWithValue("@linea", LineaGestion);
                            cmd.Parameters.AddWithValue("@servicioSolicitud", cmbservicio.Text.Trim());
                            cmd.Parameters.AddWithValue("@subEstado", cmbsubestado.Text.Trim());
                            cmd.Parameters.AddWithValue("@fallaReportada", txtFALLA.Text.Trim());
                            cmd.Parameters.AddWithValue("@cuentaEnlace", txtEnlace.Text.Trim());
                            cmd.Parameters.AddWithValue("@redAcceso", txtSWW.Text.Trim());
                            cmd.Parameters.AddWithValue("@equipo", txtCPEE.Text.Trim());
                            cmd.Parameters.AddWithValue("@radicadoTicket", txtTicket.Text.Trim());
                            cmd.Parameters.AddWithValue("@plantilla", "");
                            cmd.Parameters.AddWithValue("@nombreEmpresa", txtNombreEmpresa.Text.Trim());
                            cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text.Trim());
                            cmd.Parameters.AddWithValue("@ciudad", txtCiudad.Text.Trim());
                            cmd.Parameters.AddWithValue("@horarioAtencion", txtHorario.Text.Trim());
                            cmd.Parameters.AddWithValue("@horarioAtencionFDS", txtHorariofds.Text.Trim());
                            cmd.Parameters.AddWithValue("@clienteAutorizaEnvioCorreo", "");
                            cmd.Parameters.AddWithValue("@LLSOTAVISO", "");
                            cmd.Parameters.AddWithValue("@tituloAviso", "");
                            cmd.Parameters.AddWithValue("@reincidente", cmbReincidente.Text.Trim());
                            cmd.Parameters.AddWithValue("@observaciones", richObservaciones.Text.Trim());
                            cmd.Parameters.AddWithValue("@equipoEnganchado", "");
                            cmd.Parameters.AddWithValue("@pqrPorEstaCausa", "");
                            cmd.Parameters.AddWithValue("@provisionCorrecta", "");
                            cmd.Parameters.AddWithValue("@subeConReinicio", "");
                            cmd.Parameters.AddWithValue("@cuentasVecinas", "");
                            cmd.Parameters.AddWithValue("@reparoActualizo", "");
                            cmd.Parameters.AddWithValue("@ssid", "");
                            cmd.Parameters.AddWithValue("@cuentaMatrizCaida", "");
                            cmd.Parameters.AddWithValue("@ip", "");
                            cmd.Parameters.AddWithValue("@pe", "");
                            cmd.Parameters.AddWithValue("@pass", "");
                            cmd.Parameters.AddWithValue("@mascara", "");
                            cmd.Parameters.AddWithValue("@dns2", "");
                            cmd.Parameters.AddWithValue("@dns1", "");
                            cmd.Parameters.AddWithValue("@numeroNuevo", "");
                            cmd.Parameters.AddWithValue("@numeroAntiguo", "");
                            cmd.Parameters.AddWithValue("@tipologia", "");
                            cmd.Parameters.AddWithValue("@marcacion", "");
                            cmd.Parameters.AddWithValue("@equipoRR", "");
                            cmd.Parameters.AddWithValue("@cuantosEquiposFallan", "");
                            cmd.Parameters.AddWithValue("@estructuraMarcacionRR", "");
                            cmd.Parameters.AddWithValue("@cedula", "");
                            /*cmd.Parameters.AddWithValue("@fechasolucionenprimercontacto", SolPrimerContacto);
                            cmd.Parameters.AddWithValue("@fechaescalado", Escalado);
                            cmd.Parameters.AddWithValue("@fechatransferencia", Transferencia);
                            cmd.Parameters.AddWithValue("@fechaseguimiento", Seguimiento);*/
                            cmd.Parameters.AddWithValue("@tkInterno", txtTk.Text.Trim());
                            cmd.Parameters.AddWithValue("@nombreContactoSede", txtContactoSede.Text.Trim());
                            cmd.Parameters.AddWithValue("@telefonoContactoSede", txtTelefonoSede.Text.Trim());
                            cmd.Parameters.AddWithValue("@ClienteBW", txtBW.Text.Trim());
                            cmd.Parameters.AddWithValue("@puertosSW", txtSWPuerto.Text.Trim());
                            cmd.Parameters.AddWithValue("@PDSR", richPDSR.Text.Trim());
                            cmd.Parameters.AddWithValue("@ValidacionSW", richSW.Text.Trim());
                            cmd.Parameters.AddWithValue("@ValidacionRuta", richRUTA.Text.Trim());
                            cmd.Parameters.AddWithValue("@ValidacionUM", richUM.Text.Trim());
                            cmd.Parameters.AddWithValue("@ValidacionCPE", richCPE.Text.Trim());
                            cmd.Parameters.AddWithValue("@SenalizacionSER", richSEÑALIZACION.Text.Trim());
                            cmd.Parameters.AddWithValue("@CierreSintoma", cierretxtCSintoma);
                            cmd.Parameters.AddWithValue("@CierreFInicio", cierretxtCFInicio);
                            cmd.Parameters.AddWithValue("@CierreFSolucion", cierretxtCFSolucion);
                            cmd.Parameters.AddWithValue("@CierreDown", cierretxtCDown);
                            cmd.Parameters.AddWithValue("@CierreFCausa", cierretxtCCausa);
                            cmd.Parameters.AddWithValue("@CierreSolDef", cierrecmbCSolucion);
                            cmd.Parameters.AddWithValue("@CierreSolFalla", cierretxtCSFalla);
                            cmd.Parameters.AddWithValue("@CierreSolFalaRazon", "");
                            cmd.Parameters.AddWithValue("@CierraFallaAtribuible", cierretxtCFalla);
                            cmd.Parameters.AddWithValue("@PQRActiva", cierrecmbCPQR);
                            cmd.Parameters.AddWithValue("@TkRed", cierretxtCTK);
                            cmd.Parameters.AddWithValue("@MotivoTransferencia", cierretxtMotivo);
                            cmd.Parameters.AddWithValue("@TrasferenciaRecibidoPor", txtRecibidopor.Text.Trim());
                            cmd.Parameters.AddWithValue("@PermisosIngerso", txtIngresopermisos.Text.Trim());
                            cmd.Parameters.AddWithValue("@ValidacionCapa2", richCapa2.Text.Trim());
                            cmd.Parameters.AddWithValue("@ConfiguracionCPE", richConfiguracionRealizada.Text.Trim());
                            cmd.Parameters.AddWithValue("@SeEnviaCorreo", richSeEnviaCorreo.Text.Trim());
                            cmd.Parameters.AddWithValue("@InfoAtencion", richInformacionDeLaAtencion.Text.Trim());
                            cmd.Parameters.AddWithValue("@PermisosActuales", richValidarPermisosActuales.Text.Trim());
                            cmd.Parameters.AddWithValue("@HabilitarPermisos", richHabilitarPermisos.Text.Trim());
                            cmd.Parameters.AddWithValue("@tipoDeGestionSelect", EstadoRadiobutonBD);
                            //cmd.Parameters.AddWithValue("@plantillaCierre", PlantillaCierre);
                            cmd.Parameters.AddWithValue("@seRecibeCorreo", richSeRecibeCorreo.Text.Trim());
                            cmd.Parameters.AddWithValue("@SolicitudEcare", txtSolicitude.Text.Trim());
                            cmd.Parameters.AddWithValue("@UsuarioEcare", txteusuario.Text.Trim());
                            cmd.Parameters.AddWithValue("@ContrasenaEcare", txtecontraseña.Text.Trim());
                            cmd.Parameters.AddWithValue("@ClienteEcare", usuarioecare);
                            cmd.Parameters.AddWithValue("@franjaVisita", "");
                            cmd.Parameters.AddWithValue("@skill", "");
                            cmd.Parameters.AddWithValue("@nombreSkill", "");
                            cmd.Parameters.AddWithValue("@estructuraLLS", "");
                            cmd.Parameters.AddWithValue("@codigoServicio", txtEnlace.Text.Trim());
                            cmd.Parameters.AddWithValue("@areaResponsable", txtEnlace.Text.Trim());

                            //se obtiene ID para generar consecutivo interno (Se actualiza informacion en registro back)
                            MySqlDataAdapter sdaa = new MySqlDataAdapter(cmd);
                            DataTable dtr = new DataTable();
                            sdaa.Fill(dtr);
                            string IDconsecutivointernoback = dtr.Rows[0][0].ToString();
                            cmd = new MySqlCommand("UPDATE empresasNegociosBack.registros SET `consecutivointerno` = 'FIBB-" + IDconsecutivointernoback + "' WHERE `registros`.`id` = " + IDconsecutivointernoback + ";", Conexion.ObtenerConexion());
                            cmd.ExecuteNonQuery();





                        }
                        catch (Exception exx)
                        {
                            MessageBox.Show("Error al insertar" + exx.Message);
                        }
                    }

                }


                /////////////////////////////////////////////////////////7

                // Se actualiza tabla registros
                string query = "UPDATE " + LineaDeSoporte + ".registros SET ultimamodificacionpor = @nombresoporte, fechaultimamodificacion = now(), agenteasignado =@nombresoporte, formacion = @formacionsoporte, supervision = @supervisionsoporte, calidad = @calidadsoporte, estado = @cmbestado, nombre = @txtNombre, telefono = @txtTelefono, nit = @txtNit, correo = @txtCorreo, subEstado = @cmbsubestado, servicioSolicitud = @cmbservicio, fallaReportada = @txtFALLA, cuentaEnlace = @txtEnlace, redAcceso = @txtSWW, equipo = @txtCPEE, radicadoTicket = @txtTicket, nombreEmpresa = @txtNombreEmpresa, direccion = @txtDireccion, ciudad = @txtCiudad, horarioAtencion = @txtHorario, horarioAtencionFDS = @txtHorariofds, reincidente = @cmbReincidente, observaciones = @richObservaciones, tkInterno = @txtTk, nombreContactoSede = @txtContactoSede, telefonoContactoSede = @txtTelefonoSede, ClienteBW = @txtBW, puertosSW = @txtSWPuerto, PDSR = @richPDSR, ValidacionSW = @richSW, ValidacionRuta = @richRUTA, ValidacionUM = @richUM, ValidacionCPE = @richCPE, SenalizacionSER = @richSEÑALIZACION, CierreSintoma = @txtCSintoma, CierreFInicio = @txtCFInicio, CierreFSolucion = @txtCFSolucion, CierreDown = @txtCDown, CierreFCausa = @txtCCausa, CierreSolDef = @cmbCSolucion, CierreSolFalaRazon =@txtCSFalla, CierraFallaAtribuible = @txtCFalla, PQRActiva = @cmbCPQR, TkRed = @txtCTK, MotivoTransferencia = @txtMotivo, TrasferenciaRecibidoPor = @txtRecibidopor, PermisosIngerso = @txtIngresopermisos, ValidacionCapa2 = @richCapa2, ConfiguracionCPE = @richConfiguracionRealizada, SeEnviaCorreo = @richSeEnviaCorreo, InfoAtencion = @richInformacionDeLaAtencion, PermisosActuales = @richValidarPermisosActuales, HabilitarPermisos = @richHabilitarPermisos, uccid = @txtUCCID, seRecibeCorreo = @richSeRecibeCorreo, CierreSolFalla = @txtCSFalla, SolicitudEcare = @txtSolicitude, UsuarioEcare = @txteusuario, ContrasenaEcare = @txtecontraseña, CierreSintoma = @txtesintoma, CierreFInicio = @txtefinicio, CierreFSolucion = @txtefsolucion, CierreDown = @txtedown, CierreFCausa = @txtecfalla, CierreSolDef = @txtesolucion, CierreSolFalla = @txtesfalla, CierraFallaAtribuible = @txtefallede, PQRActiva = @txtepqr, TkRed = @txtetk, " + UpdateTimeTabla + " = now(), documento_identidad =" + Documentosoporte + " WHERE " + LineaDeSoporte + ".registros.id = '" + idconsulta + "';";
                cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

                cmd.Parameters.AddWithValue("@nombresoporte", nombresoporte);
                //cmd.Parameters.AddWithValue("now()", now());
                //cmd.Parameters.AddWithValue("@nombresoporte", nombresoporte);
                cmd.Parameters.AddWithValue("@formacionsoporte", formacionsoporte);
                cmd.Parameters.AddWithValue("@supervisionsoporte", supervisionsoporte);
                cmd.Parameters.AddWithValue("@calidadsoporte", calidadsoporte);
                cmd.Parameters.AddWithValue("@cmbestado", cmbestado.Text.Trim());
                cmd.Parameters.AddWithValue("@txtNombre", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@txtTelefono", txtTelefono.Text.Trim());
                cmd.Parameters.AddWithValue("@txtNit", txtNit.Text.Trim());
                cmd.Parameters.AddWithValue("@txtCorreo", txtCorreo.Text.Trim());
                cmd.Parameters.AddWithValue("@cmbsubestado", cmbsubestado.Text.Trim());
                cmd.Parameters.AddWithValue("@cmbservicio", cmbservicio.Text.Trim());
                cmd.Parameters.AddWithValue("@txtFALLA", txtFALLA.Text.Trim());
                cmd.Parameters.AddWithValue("@txtEnlace", txtEnlace.Text.Trim());
                cmd.Parameters.AddWithValue("@txtSWW", txtSWW.Text.Trim());
                cmd.Parameters.AddWithValue("@txtCPEE", txtCPEE.Text.Trim());
                cmd.Parameters.AddWithValue("@txtTicket", txtTicket.Text.Trim());
                cmd.Parameters.AddWithValue("@txtNombreEmpresa", txtNombreEmpresa.Text.Trim());
                cmd.Parameters.AddWithValue("@txtDireccion", txtDireccion.Text.Trim());
                cmd.Parameters.AddWithValue("@txtCiudad", txtCiudad.Text.Trim());
                cmd.Parameters.AddWithValue("@txtHorario", txtHorario.Text.Trim());
                cmd.Parameters.AddWithValue("@txtHorariofds", txtHorariofds.Text.Trim());
                cmd.Parameters.AddWithValue("@cmbReincidente", cmbReincidente.Text.Trim());
                cmd.Parameters.AddWithValue("@richObservaciones", richObservaciones.Text.Trim());
                cmd.Parameters.AddWithValue("@txtTk", txtTk.Text.Trim());
                cmd.Parameters.AddWithValue("@txtContactoSede", txtContactoSede.Text.Trim());
                cmd.Parameters.AddWithValue("@txtTelefonoSede", txtTelefonoSede.Text.Trim());
                cmd.Parameters.AddWithValue("@txtBW", txtBW.Text.Trim());
                cmd.Parameters.AddWithValue("@txtSWPuerto", txtSWPuerto.Text.Trim());
                cmd.Parameters.AddWithValue("@richPDSR", richPDSR.Text.Trim());
                cmd.Parameters.AddWithValue("@richSW", richSW.Text.Trim());
                cmd.Parameters.AddWithValue("@richRUTA", richRUTA.Text.Trim());
                cmd.Parameters.AddWithValue("@richUM", richUM.Text.Trim());
                cmd.Parameters.AddWithValue("@richCPE", richCPE.Text.Trim());
                cmd.Parameters.AddWithValue("@richSEÑALIZACION", richSEÑALIZACION.Text.Trim());
                cmd.Parameters.AddWithValue("@txtCSintoma", txtCSintoma.Text.Trim());
                cmd.Parameters.AddWithValue("@txtCFInicio", txtCFInicio.Text.Trim());
                cmd.Parameters.AddWithValue("@txtCFSolucion", txtCFSolucion.Text.Trim());
                cmd.Parameters.AddWithValue("@txtCDown", txtCDown.Text.Trim());
                cmd.Parameters.AddWithValue("@txtCCausa", txtCCausa.Text.Trim());
                cmd.Parameters.AddWithValue("@cmbCSolucion", cmbCSolucion.Text.Trim());
                cmd.Parameters.AddWithValue("@txtCSFalla", txtCSFalla.Text.Trim());
                cmd.Parameters.AddWithValue("@txtCFalla", txtCFalla.Text.Trim());
                cmd.Parameters.AddWithValue("@cmbCPQR", cmbCPQR.Text.Trim());
                cmd.Parameters.AddWithValue("@txtCTK", txtCTK.Text.Trim());
                cmd.Parameters.AddWithValue("@txtMotivo", txtMotivo.Text.Trim());
                cmd.Parameters.AddWithValue("@txtRecibidopor", txtRecibidopor.Text.Trim());
                cmd.Parameters.AddWithValue("@txtIngresopermisos", txtIngresopermisos.Text.Trim());
                cmd.Parameters.AddWithValue("@richCapa2", richCapa2.Text.Trim());
                cmd.Parameters.AddWithValue("@richConfiguracionRealizada", richConfiguracionRealizada.Text.Trim());
                cmd.Parameters.AddWithValue("@richSeEnviaCorreo", richSeEnviaCorreo.Text.Trim());
                cmd.Parameters.AddWithValue("@richInformacionDeLaAtencion", richInformacionDeLaAtencion.Text.Trim());
                cmd.Parameters.AddWithValue("@richValidarPermisosActuales", richValidarPermisosActuales.Text.Trim());
                cmd.Parameters.AddWithValue("@richHabilitarPermisos", richHabilitarPermisos.Text.Trim());
                cmd.Parameters.AddWithValue("@txtUCCID", txtUCCID.Text.Trim());
                cmd.Parameters.AddWithValue("@richSeRecibeCorreo", richSeRecibeCorreo.Text.Trim());
                // cmd.Parameters.AddWithValue("@txtCSFalla", txtCSFalla.Text.Trim());
                cmd.Parameters.AddWithValue("@txtSolicitude", txtSolicitude.Text.Trim());
                cmd.Parameters.AddWithValue("@txteusuario", txteusuario.Text.Trim());
                cmd.Parameters.AddWithValue("@txtecontraseña", txtecontraseña.Text.Trim());
                cmd.Parameters.AddWithValue("@txtesintoma", txtesintoma.Text.Trim());
                cmd.Parameters.AddWithValue("@txtefinicio", txtefinicio.Text.Trim());
                cmd.Parameters.AddWithValue("@txtefsolucion", txtefsolucion.Text.Trim());
                cmd.Parameters.AddWithValue("@txtedown", txtedown.Text.Trim());
                cmd.Parameters.AddWithValue("@txtecfalla", txtecfalla.Text.Trim());
                cmd.Parameters.AddWithValue("@txtesolucion", txtesolucion.Text.Trim());
                cmd.Parameters.AddWithValue("@txtesfalla", txtesfalla.Text.Trim());
                cmd.Parameters.AddWithValue("@txtefallede", txtefallede.Text.Trim());
                cmd.Parameters.AddWithValue("@txtepqr", txtepqr.Text.Trim());
                cmd.Parameters.AddWithValue("@txtetk", txtetk.Text.Trim());


                cmd.ExecuteNonQuery();
                //Se actualiza tabla productiviad
                //se obtiene ultimo registro para generar actualziar productividad
                cmd = new MySqlCommand("SELECT MAX(" + LineaDeSoporte + ".productividad.id) FROM " + LineaDeSoporte + ".productividad WHERE " + LineaDeSoporte + ".productividad.registro = " + idconsulta + "", Conexion.ObtenerConexion());
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                string idproductividad = dt.Rows[0][0].ToString();
                cmd = new MySqlCommand("UPDATE " + LineaDeSoporte + ".productividad SET estado = '" + cmbestado.Text.Trim() + "',subEstado = '" + cmbsubestado.Text.Trim() + "', codigo = '" + idusuariosoporte + "',fechaultimamodificacion = now(),formacion = '" + formacionsoporte + "',supervision = '" + supervisionsoporte + "',calidad = '" + calidadsoporte + "',documento_identidad= '" + Documentosoporte + "', agenteasignado = '" + nombresoporte + "' WHERE " + LineaDeSoporte + ".productividad.id = '" + idproductividad + "';", Conexion.ObtenerConexion());
                cmd.ExecuteNonQuery();


                MessageBox.Show("Se modificaron los datos correctamente", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar" + ex.Message);
            }


        }
        public bool ValidacionGuardar = true;

        public void ValidarBontonGuardar()
        {
            ValidacionGuardar = true;
            if (radioconsultacliente.Checked == true | radioConsulta.Checked == true | RadioECare.Checked == true | rTransferencia.Checked == true | radioFalla.Checked == true)
            {


                if (txtNombre.Text.Trim() == "")
                {
                    epvValidacionTXT.SetError(txtNombre, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }


                if (txtTelefono.Text.Trim() == "")
                {
                    epvValidacionTXT.SetError(txtTelefono, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }


                if (txtCorreo.Text.Trim() == "")
                {
                    epvValidacionTXT.SetError(txtCorreo, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }


                if (txtNit.Text.Trim() == "")
                {
                    epvValidacionTXT.SetError(txtNit, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }


                if (txtDireccion.Text.Trim() == "")
                {
                    epvValidacionTXT.SetError(txtDireccion, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }


                if (txtCiudad.Text.Trim() == "" | txtCiudad.SelectedIndex == -1)
                {
                    epvValidacionTXT.SetError(txtCiudad, "Debe seleccionar una cidudad de la lista");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }
                if (txtEnlace.Text.Trim() == "")
                {
                    epvValidacionTXT.SetError(txtEnlace, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }


                if (txtHorario.Text.Trim() == "")
                {
                    epvValidacionTXT.SetError(txtHorario, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }


                if (txtHorariofds.Text.Trim() == "")
                {
                    epvValidacionTXT.SetError(txtHorariofds, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }


                if (txtTicket.Text.Trim() == "")
                {
                    epvValidacionTXT.SetError(txtTicket, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }


                if (txtUCCID.Text.Trim() == "")
                {
                    epvValidacionTXT.SetError(txtUCCID, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }



                if (cmbestado.Text.Trim() == "")
                {
                    epvValidacionTXT.SetError(cmbestado, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }


                if (cmbsubestado.Text.Trim() == "")
                {
                    epvValidacionTXT.SetError(cmbsubestado, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }


                if (cmbservicio.Items.Count >= 1)
                {
                    if (cmbservicio.Text.Trim() == "")
                    {
                        epvValidacionTXT.SetError(cmbservicio, "Este campo no puede estar vacio");
                        txtNombre.Focus();
                        ValidacionGuardar = false;
                    }



                }
                if (txtFALLA.Items.Count >= 1)
                {
                    if (txtFALLA.Text.Trim() == "")
                    {
                        epvValidacionTXT.SetError(txtFALLA, "Este campo no puede estar vacio");
                        txtNombre.Focus();
                        ValidacionGuardar = false;
                    }


                }

            }

            if (radioconsultacliente.Checked == true | radioConsulta.Checked == true | RadioECare.Checked == true)
            {
                if (txtContactoSede.Text.Trim() == "")
                {
                    epvValidacionTXT.SetError(txtContactoSede, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }

                if (txtTelefonoSede.Text.Trim() == "")
                {
                    epvValidacionTXT.SetError(txtTelefonoSede, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }
            }

            if (radioconsultacliente.Checked == true | radioConsulta.Checked == true)
            {
                if (txtSWW.Text.Trim() == "")
                {
                    epvValidacionTXT.SetError(txtSWW, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }

                if (txtSWPuerto.Text.Trim() == "")
                {
                    epvValidacionTXT.SetError(txtSWPuerto, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }

                if (txtBW.Text.Trim() == "")
                {
                    epvValidacionTXT.SetError(txtBW, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }



                if (txtCPEE.Text.Trim() == "" | txtCPEE.SelectedIndex == -1)
                {
                    epvValidacionTXT.SetError(txtCPEE, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }
            }


            if (radioFalla.Checked == true)
            {
                if (txtSWW.Text.Trim() == "")
                {
                    epvValidacionTXT.SetError(txtSWW, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }

                if (txtSWPuerto.Text.Trim() == "")
                {
                    epvValidacionTXT.SetError(txtSWPuerto, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }
            }

            if (radioBacklinea.Checked == true)

            {
                if (txtTicket.Text.Trim() == "")
                {
                    epvValidacionTXT.SetError(txtTicket, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }

                if (cmbestado.Text.Trim() == "")
                {
                    epvValidacionTXT.SetError(cmbestado, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }
                if (cmbsubestado.Text.Trim() == "")
                {
                    epvValidacionTXT.SetError(cmbsubestado, "Este campo no puede estar vacio");
                    txtNombre.Focus();
                    ValidacionGuardar = false;
                }
                if (cmbservicio.Items.Count >= 1)
                {
                    if (cmbservicio.Text.Trim() == "")
                    {
                        epvValidacionTXT.SetError(cmbservicio, "Este campo no puede estar vacio");
                        txtNombre.Focus();
                        ValidacionGuardar = false;
                    }

                }
                if (txtFALLA.Items.Count >= 1)
                {
                    if (txtFALLA.Text.Trim() == "")
                    {
                        epvValidacionTXT.SetError(txtFALLA, "Este campo no puede estar vacio");
                        txtNombre.Focus();
                        ValidacionGuardar = false;
                    }

                }
            }



        }

        private void comboBox1_Click(object sender, EventArgs e)
        {



        }

        private void cmbsubestado_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_3(object sender, EventArgs e)
        {
            /* if (cmbestado.Text == "CERRADO" | cmbestado.Text == "SOLUCIÓN EN PRIMER CONTACTO")
             {
                 MessageBox.Show("El caso ya se encuentra cerrado", " Advertencia", MessageBoxButtons.OK);

             }*/

            if (MessageBox.Show("¿Desea guardar los cambios?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                epvValidacionTXT.Clear();
                this.ValidarBontonGuardar();

                if (ValidacionGuardar == true)

                {
                    this.DatosMysql();
                    this.borrar();
                }
                else
                {
                    TabValidaciones.SelectedIndex = 0;
                    btnGuardar.Visible = false;

                }
            }



        }

        private void cmbservicio_Click(object sender, EventArgs e)
        {

        }

        private void cmbestado_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbestado_TextChanged_1(object sender, EventArgs e)
        {


        }

        private void cmbsubestado_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbservicio_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button6_Click_3(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea modificar el registro?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                epvValidacionTXT.Clear();
                this.ValidarBontonGuardar();

                if (ValidacionGuardar == true)
                {
                    this.UpdateMysql();
                    this.borrar();
                }


            }


        }

        private void HistorialModificaiones_Click(object sender, EventArgs e)
        {

        }

        private void radioseñor_CheckedChanged(object sender, EventArgs e)
        {
            this.RetornoTipoDeGestion();

        }

        private void radioseñora_CheckedChanged(object sender, EventArgs e)
        {
            this.RetornoTipoDeGestion();

        }

        private void cmbsubestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbservicio.Items.Clear();


            MySqlCommand Barberos = new MySqlCommand("SELECT DISTINCT servicioSolicitud FROM " + LineaDeSoporte + ".dep_dependenciasBigData WHERE `linea` = '" + LineaGestion + "' AND `estado` = '" + cmbestado.Text + "' AND `subEstado` = '" + cmbsubestado.Text + "'", Conexion.ObtenerConexion());
            MySqlDataReader Datos = Barberos.ExecuteReader();


            int numRows = 0;

            while (Datos.Read())
            {



                cmbservicio.Refresh();
                string ValidacionItem = Datos[0].ToString();

                if (ValidacionItem != "")
                {
                    cmbservicio.Items.Add(Datos[0]);

                }





            }




            /////


            this.ValidacionTipificacion();


            //cmbservicio.Items.Clear();
            txtFALLA.Items.Clear();

            cmbservicio.Text = "";
            txtFALLA.Text = "";
            txtFALLA.Enabled = false;
        }

        private void cmbestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbsubestado.Items.Clear();

            try
            {



                MySqlCommand Barberos = new MySqlCommand("SELECT DISTINCT subEstado FROM " + LineaDeSoporte + ".dep_dependenciasBigData WHERE `linea` = '" + LineaGestion + "' AND `estado` = '" + cmbestado.Text + "'", Conexion.ObtenerConexion());
                MySqlDataReader Datos = Barberos.ExecuteReader();

                while (Datos.Read())
                {
                    cmbsubestado.Refresh();
                    string ValidacionItem = Datos[0].ToString();

                    if (ValidacionItem != "")
                    {
                        cmbsubestado.Items.Add(Datos[0]);

                    }


                }








                this.ValidacionTipificacion();

                // Se limpian combobox
                //cmbsubestado.Items.Clear();
                cmbservicio.Items.Clear();
                txtFALLA.Items.Clear();

                cmbsubestado.Text = "";
                cmbservicio.Text = "";
                txtFALLA.Text = "";
                cmbservicio.Enabled = false;
                txtFALLA.Enabled = false;


                /////////
            }
            catch (Exception exx)
            {
                MessageBox.Show("Lo datos ya estan eliminados");
            }


        }

        private void txtCPEE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCPEE_Click_1(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtNombre.Text = txtNombre.Text.Replace("'", "''");

            this.dgvHistorialMod.Columns["id"].Visible = false;










        }

        private void cmbservicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFALLA.Items.Clear();


            MySqlCommand Barberos = new MySqlCommand("SELECT DISTINCT fallaReportada FROM " + LineaDeSoporte + ".dep_dependenciasBigData WHERE `linea` = '" + LineaGestion + "' AND `estado` = '" + cmbestado.Text + "' AND `subEstado` = '" + cmbsubestado.Text + "' AND `servicioSolicitud` = '" + cmbservicio.Text + "'", Conexion.ObtenerConexion());
            MySqlDataReader Datos = Barberos.ExecuteReader();

            while (Datos.Read())
            {
                txtFALLA.Refresh();


                string ValidacionItem = Datos[0].ToString();

                if (ValidacionItem != "")
                {
                    txtFALLA.Items.Add(Datos[0]);

                }
            }

            //

            this.ValidacionTipificacion();
            //txtFALLA.Items.Clear();
            txtFALLA.Text = "";
        }

        private void txtFALLA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            epvValidacionTXT.Clear();
            txtTicket.Text = ValidacionGuardar.ToString();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Limpiar limpiar = new Limpiar();
            limpiar.Borrar(this, groupBox1, gFalla, groupBox4, groupBox5, TabValidaciones, groupBox6);
        }

        private void TabValidaciones_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_4(object sender, EventArgs e)
        {
            this.UpdateMysql();
        }

        private void button6_Click_4(object sender, EventArgs e)
        {
            string query = "INSERT INTO " + LineaDeSoporte + ".historialModificaciones (`id`, `registro`, `accion`, `tipo`, `alteradoDe`, `alteradoA`, `accionPor`, `codigoAccionPor`, `fecha`) VALUES ((NULL, 'prueba', 'Creó', ' estado con Interfaz de Gestión', '',@cmbestado , '" + nombresoporte + "', '" + idusuariosoporte + "', now())";


            if (txtNombre.Text != Buscar.nombre)
            {
                query += ",(datos,ficty,prueba)";
            }
            if (txtNit.Text != Buscar.nit)
            {
                query += ",(datos,ficty,prueba2)";
            }
            if (txtTicket.Text != Buscar.radicadoTicket)
            {
                query += ",(datos,ficty,prueba3)";
            }

            richPDSR.Text = query;

            // Se guardan datos en la BD back registros <<<<<<<<<<<<<<<<
            // cmd = new MySqlCommand(query, Conexion.ObtenerConexion());

            //cmd.CommandType = CommandType.Text;
            //cmd.Parameters.AddWithValue("@id", null);



        }

       

        private void button8_Click_2(object sender, EventArgs e)
        {

        }

        private void button8_Click_3(object sender, EventArgs e)
        {

            MySqlCommand Barberos = new MySqlCommand("SELECT valores  FROM empresasnegociosfront.camposfiltrables WHERE `campo` = 'ciudad'", Conexion.ObtenerConexion());
            MySqlDataReader Datos = Barberos.ExecuteReader();

            while (Datos.Read())
            {
                cmbsubestado.Refresh();
                string ValidacionItem = Datos[0].ToString();
                richSW.Text = ValidacionItem;
                if (ValidacionItem != "")
                {
                    string[] arreglo = ValidacionItem.Split("\n".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i <arreglo.Length; i++)
                    {
                        prueba.Items.Add(arreglo[i]);
                    }



                }


            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.DatosMysql();
        }

        private void TabValidaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dgvHistorialMod.Rows.Count > 0)
            {
                this.dgvHistorialMod.Columns["id"].Visible = false;
                this.dgvHistorialMod.Columns["comentario"].Visible = false;

                dgvHistorialMod.Columns[1].HeaderText = "Fecha de Creacion";
                dgvHistorialMod.Columns[2].HeaderText = "Agente";
            }

        }

        private void radioFront_CheckedChanged(object sender, EventArgs e)
        {
            LineaDeSoporte = "empresasNegociosFront";
            LineaGestion = "FO FRONT";
            // Se limpian combobox
            cmbsubestado.Items.Clear();
            cmbservicio.Items.Clear();
            txtFALLA.Items.Clear();
            cmbestado.Items.Clear();

            cmbsubestado.Text = "";
            cmbestado.Text = "";
            cmbservicio.Text = "";
            txtFALLA.Text = "";
            cmbservicio.Enabled = false;
            txtFALLA.Enabled = false;
            cmbsubestado.Enabled = false;
            cmbestado.Enabled = true;
            this.ValidacionTipificacion();


            MySqlCommand cmd = new MySqlCommand("SELECT prefijo FROM " + LineaDeSoporte + ".linea_prefijo WHERE `linea` = '" + LineaGestion + "'", Conexion.ObtenerConexion());
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {


                //dt.Rows[0][3].ToString() <-- Captura de datos, resultado 0 columna 3

                PrefijoSoporte = dt.Rows[0][0].ToString();

            }


            radioConsulta.Enabled = true;
            radioconsultacliente.Enabled = true;
            RadioECare.Enabled = true;
            rTransferencia.Enabled = true;
            radioFalla.Enabled = true;
            radioback.Enabled = false;
            RadioConfiguracionCPE.Enabled = false;
            RadioConfiguracionTelefonia.Enabled = false;


            radioConsulta.Checked = false;
            radioconsultacliente.Checked = false;
            RadioECare.Checked = false;
            rTransferencia.Checked = false;
            radioFalla.Checked = false;
            radioback.Checked = false;
            RadioConfiguracionCPE.Checked = false;
            RadioConfiguracionTelefonia.Checked = false;


            ///////// SE llena el combo box estado 

            cmbestado.Items.Clear();


            MySqlCommand Barberos = new MySqlCommand("SELECT DISTINCT estado FROM " + LineaDeSoporte + ".dep_dependenciasBigData WHERE `linea` = '" + LineaGestion + "'", Conexion.ObtenerConexion());
            MySqlDataReader Datos = Barberos.ExecuteReader();

            while (Datos.Read())
            {
                cmbestado.Refresh();
                cmbestado.Items.Add(Datos[0]);

            }



        }

        private void radioBacklinea_CheckedChanged(object sender, EventArgs e)
        {
            LineaDeSoporte = "empresasNegociosBack";
            LineaGestion = "FO BACK";
            // Se limpian combobox
            cmbsubestado.Items.Clear();
            cmbservicio.Items.Clear();
            txtFALLA.Items.Clear();
            cmbestado.Items.Clear();

            cmbsubestado.Text = "";
            cmbestado.Text = "";
            cmbservicio.Text = "";
            txtFALLA.Text = "";
            cmbservicio.Enabled = false;
            txtFALLA.Enabled = false;
            cmbsubestado.Enabled = false;
            cmbestado.Enabled = true;
            this.ValidacionTipificacion();


            MySqlCommand cmd = new MySqlCommand("SELECT prefijo FROM " + LineaDeSoporte + ".linea_prefijo WHERE `linea` = '" + LineaGestion + "'", Conexion.ObtenerConexion());
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {

                //dt.Rows[0][3].ToString() <-- Captura de datos, resultado 0 columna 3

                PrefijoSoporte = dt.Rows[0][0].ToString();

            }

            radioConsulta.Enabled = true;
            radioconsultacliente.Enabled = true;
            RadioECare.Enabled = false;
            rTransferencia.Enabled = false;
            radioFalla.Enabled = false;
            radioback.Enabled = true;
            RadioConfiguracionCPE.Enabled = true;
            RadioConfiguracionTelefonia.Enabled = true;

            radioConsulta.Checked = false;
            radioconsultacliente.Checked = false;
            RadioECare.Checked = false;
            rTransferencia.Checked = false;
            radioFalla.Checked = false;
            radioback.Checked = false;
            RadioConfiguracionCPE.Checked = false;
            RadioConfiguracionTelefonia.Checked = false;


            cmbestado.Items.Clear();


            MySqlCommand Barberos = new MySqlCommand("SELECT DISTINCT estado FROM " + LineaDeSoporte + ".dep_dependenciasBigData WHERE `linea` = '" + LineaGestion + "'", Conexion.ObtenerConexion());
            MySqlDataReader Datos = Barberos.ExecuteReader();

            while (Datos.Read())
            {
                cmbestado.Refresh();
                cmbestado.Items.Add(Datos[0]);

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.dgvHistorialMod.Columns["id"].Visible = false;
        }
        public string agenteasignadohistorial;
        private void dgvHistorialMod_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                idhistorial = dgvHistorialMod.Rows[e.RowIndex].Cells["id"].Value.ToString();
                comentariohistorial = dgvHistorialMod.Rows[e.RowIndex].Cells["comentario"].Value.ToString();
                agenteasignadohistorial = dgvHistorialMod.Rows[e.RowIndex].Cells["agenteasignado"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar" + ex.Message);
            }




        }

        private void button7_Click(object sender, EventArgs e)
        {

            HistorialMod historialMod = new HistorialMod();

            //
            try
            {



                if (dgvHistorialMod.SelectedRows.Count > 0)
                {
                    MySqlCommand VERCOMENTARIO = new MySqlCommand("SELECT comentario FROM " + LineaDeSoporte + ".historial_actividades WHERE `id`  = " + idhistorial + "", Conexion.ObtenerConexion());
                    MySqlDataReader Datos = VERCOMENTARIO.ExecuteReader();

                    while (Datos.Read())
                    {

                        comentariohistorial = Datos[0].ToString();

                        historialMod.richHistMod.Text = comentariohistorial;


                    }



                    //historialMod.richHistMod.Text = comentariohistorial;
                    historialMod.nombresoporte = nombresoporte;
                    historialMod.id = idhistorial;
                    historialMod.agenteasignado = agenteasignadohistorial;
                    historialMod.LineaDeSoporte = LineaDeSoporte;

                    historialMod.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Por favor seleccione el comentario que va a visualizar");
                }

            }
            catch
            {
                MessageBox.Show("Por favor seleccione el comentario que va a visualizar");
            }
        }


        private void btnModificar(object sender, EventArgs e)
        {

        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            this.RetornoTipoDeGestion();
            txtNombre.Text = EstadoRadiobutonBD;




        }


        private void txtFALLA_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_2(object sender, EventArgs e)
        {

            if (MessageBox.Show("Al abrir la ventana de busqueda todos los datos se van a eliminar ¿Desea continuar?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {





                Buscar Buscar = new Buscar();
                Buscar.ShowDialog();


                idconsulta = Buscar.id;



                //Se carga el historial de actividades

                if (idconsulta == "null")
                {
                    this.borrar();
                    // this.ValidarBontonGuardar();

                }
                if (idconsulta != "null")
                {
                    /////////////////////////////////////////////////////////

                    radioFront.Checked = Buscar.radioFront.Checked;
                    radioBacklinea.Checked = Buscar.radioBacklinea.Checked;
                    LineaDeSoporte = Buscar.LineaDeSoporte;




                    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                    //Se traen los datos para llenar radiobuton en tiipo de getion




                    if (Buscar.tipoDeGestionSelect == "Reporte Tecnico")
                    {
                        radioConsulta.Checked = true;
                    }
                    if (Buscar.tipoDeGestionSelect == "Consulta Cliente")
                    {
                        radioconsultacliente.Checked = true;
                    }
                    if (Buscar.tipoDeGestionSelect == "E-Care")
                    {
                        RadioECare.Checked = true;
                    }
                    if (Buscar.tipoDeGestionSelect == "Transferencia")
                    {
                        rTransferencia.Checked = true;
                    }
                    if (Buscar.tipoDeGestionSelect == "Falla Masiva")
                    {
                        radioFalla.Checked = true;
                    }
                    if (Buscar.tipoDeGestionSelect == "Backoffice")
                    {
                        radioback.Checked = true;
                    }
                    if (Buscar.tipoDeGestionSelect == "Configuracion CPE")
                    {
                        RadioConfiguracionCPE.Checked = true;
                    }
                    if (Buscar.tipoDeGestionSelect == "Configuracion Telefonia")
                    {
                        RadioConfiguracionTelefonia.Checked = true;
                    }
                    if (Buscar.plantillaCierre == "Si")
                    {
                        plantilla_si.Checked = true;
                    }
                    if (Buscar.plantillaCierre == "No")
                    {
                        plantilla_no.Checked = true;
                    }
                    if (Buscar.chatSpark == "True")
                    {
                        chSpark.Checked = true;
                    }
                    if (Buscar.ClienteEcare == "Señor")
                    {
                        radioseñor.Checked = true;
                    }
                    if (Buscar.ClienteEcare == "Señora")
                    {
                        radioseñora.Checked = true;
                    }


                    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

                    //asigan los datos extraidos de la consulta

                    //

                    //



                    //


                    // idconsulta = Buscar.id;
                    cmbestado.Text = Buscar.estado;
                    txtNombre.Text = Buscar.nombre;
                    txtTelefono.Text = Buscar.telefono;
                    txtNit.Text = Buscar.nit;
                    txtCorreo.Text = Buscar.correo;
                    cmbsubestado.Text = Buscar.subEstado;
                    cmbservicio.Text = Buscar.servicioSolicitud;
                    txtFALLA.Text = Buscar.fallaReportada;
                    txtEnlace.Text = Buscar.cuentaEnlace;
                    txtSWW.Text = Buscar.redAcceso;
                    txtCPEE.Text = Buscar.equipo;
                    txtTicket.Text = Buscar.radicadoTicket;
                    txtNombreEmpresa.Text = Buscar.nombreEmpresa;
                    txtDireccion.Text = Buscar.direccion;
                    txtCiudad.Text = Buscar.ciudad;
                    txtHorario.Text = Buscar.horarioAtencion;
                    txtHorariofds.Text = Buscar.horarioAtencionFDS;
                    cmbReincidente.Text = Buscar.reincidente;
                    richObservaciones.Text = Buscar.observaciones;
                    txtTk.Text = Buscar.tkInterno;
                    txtContactoSede.Text = Buscar.nombreContactoSede;
                    txtTelefonoSede.Text = Buscar.telefonoContactoSede;
                    txtBW.Text = Buscar.ClienteBW;
                    txtSWPuerto.Text = Buscar.puertosSW;
                    richPDSR.Text = Buscar.PDSR;
                    richSW.Text = Buscar.ValidacionSW;
                    richRUTA.Text = Buscar.ValidacionRuta;
                    richUM.Text = Buscar.ValidacionUM;
                    richCPE.Text = Buscar.ValidacionCPE;
                    richSEÑALIZACION.Text = Buscar.SenalizacionSER;
                    txtCSintoma.Text = Buscar.CierreSintoma;
                    txtCFInicio.Text = Buscar.CierreFInicio;
                    txtCFSolucion.Text = Buscar.CierreFSolucion;
                    txtCDown.Text = Buscar.CierreDown;
                    txtCCausa.Text = Buscar.CierreFCausa;
                    cmbCSolucion.Text = Buscar.CierreSolDef;
                    txtCSFalla.Text = Buscar.CierreSolFalaRazon;
                    txtCFalla.Text = Buscar.CierraFallaAtribuible;
                    cmbCPQR.Text = Buscar.PQRActiva;
                    txtCTK.Text = Buscar.TkRed;
                    txtMotivo.Text = Buscar.MotivoTransferencia;
                    txtRecibidopor.Text = Buscar.TrasferenciaRecibidoPor;
                    txtIngresopermisos.Text = Buscar.PermisosIngerso;
                    richCapa2.Text = Buscar.ValidacionCapa2;
                    richConfiguracionRealizada.Text = Buscar.ConfiguracionCPE;
                    richSeEnviaCorreo.Text = Buscar.SeEnviaCorreo;
                    richInformacionDeLaAtencion.Text = Buscar.InfoAtencion;
                    richValidarPermisosActuales.Text = Buscar.PermisosActuales;
                    richHabilitarPermisos.Text = Buscar.HabilitarPermisos;
                    txtUCCID.Text = Buscar.uccid;
                    richSeRecibeCorreo.Text = Buscar.seRecibeCorreo;
                    txtCSFalla.Text = Buscar.CierreSolFalla;
                    txtSolicitude.Text = Buscar.SolicitudEcare;
                    txteusuario.Text = Buscar.UsuarioEcare;
                    txtecontraseña.Text = Buscar.ContrasenaEcare;
                    agenteasignado = Buscar.agenteasignado;

                    //ecare

                    txtesintoma.Text = Buscar.CierreSintoma;
                    txtefinicio.Text = Buscar.CierreFInicio;
                    txtefsolucion.Text = Buscar.CierreFSolucion;
                    txtedown.Text = Buscar.CierreDown;
                    txtecfalla.Text = Buscar.CierreFCausa;
                    txtesolucion.Text = Buscar.CierreSolDef;
                    txtesfalla.Text = Buscar.CierreSolFalla;
                    txtefallede.Text = Buscar.CierraFallaAtribuible;
                    txtepqr.Text = Buscar.PQRActiva;
                    txtetk.Text = Buscar.TkRed;

                    //Radio tipo de linea

                    radioFront.Enabled = radioFront.Enabled;
                    radioBacklinea.Enabled = radioBacklinea.Enabled;




                    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<



                    DataTable Registros = new DataTable();
                    ad = new MySqlDataAdapter("SELECT id, fechacreacion, agenteasignado, comentario FROM " + LineaDeSoporte + ".historial_actividades WHERE `codigo`  = " + idconsulta + "", Conexion.ObtenerConexion()); ad.Fill(Registros);
                    dgvHistorialMod.DataSource = Registros;



                    if (Registros.Rows.Count >= 1)
                    {
                        string comentariocrm = Registros.Rows[0][3].ToString();

                        richComentario.Text = comentariocrm;
                        HistorialModificaiones.Parent = TabValidaciones;

                    }


                    if (cmbestado.Text == "SOLUCIÓN EN PRIMER CONTACTO" | cmbestado.Text == "CERRADO")
                    {
                        btnGuardar.Visible = false;

                        //
                        radioBacklinea.Enabled = false;
                        radioFront.Enabled = false;

                        cmbestado.Enabled = false;
                        cmbsubestado.Enabled = false;
                        cmbservicio.Enabled = false;
                        txtFALLA.Enabled = false;


                    }

                    else
                    {
                        btnGuardar.Visible = true;
                    }



                    if (agenteasignado == nombresoporte)
                    {
                        btnmod.Visible = true;

                        //
                        radioBacklinea.Enabled = true;
                        radioFront.Enabled = true;

                        cmbestado.Enabled = true;
                        cmbsubestado.Enabled = true;
                        cmbservicio.Enabled = true;
                        txtFALLA.Enabled = true;
                    }


                    if (Buscar.radioFront.Checked == true)
                    {
                        radioBacklinea.Enabled = false;
                    }
                    if (Buscar.radioBacklinea.Checked == true)
                    {
                        radioFront.Enabled = false;
                    }




                }

                Buscar.id = "null";




            }


        }


        private void Soporte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Datos Datos = new Datos();
                Datos.txtContacto.Text = txtNombre.Text + " / " + txtTelefono.Text;
                Datos.txtDir.Text = txtDireccion.Text;
                Datos.txtCiudad.Text = txtCiudad.Text;
                Datos.txtHorario.Text = txtHorario.Text;
                Datos.txtEnlace.Text = txtEnlace.Text;
                Datos.texthorarioFDS.Text = txtHorariofds.Text;
                Datos.richObservaciones.Text = richObservaciones.Text;
                Datos.ShowDialog();

            }

            if (e.KeyCode == Keys.F3)
            {
                Planta Planta = new Planta();
                Planta.txtDireccion.Text = txtDireccion.Text;
                Planta.txtCiudad.Text = txtCiudad.Text;
                Planta.txtSW.Text = txtSWW.Text;
                Planta.txtPuerto.Text = txtSWPuerto.Text;
                Planta.txtContactoDelCliente.Text = txtNombre.Text + " / " + txtTelefono.Text;
                Planta.ShowDialog();
            }

            if (e.KeyCode == Keys.F1)
            {
                DocumentadorFO12.VDNSoporte VDNSoporte = new VDNSoporte();
                VDNSoporte.ShowDialog();


            }
            if (e.KeyCode == Keys.F4)
            {
                if (MessageBox.Show("Todos los datos se van a eliminar ¿Desea continuar?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    this.borrar();

                }





            }
            if (e.KeyCode == Keys.F5)
            {

                // Validacion datos de contacto
                if (radioConsulta.Checked | RadioECare.Checked | radioFalla.Checked | rTransferencia.Checked)
                {

                    string error = "";

                    if (txtCorreo.Text == "" | txtHorario.Text == "" | txtHorariofds.Text == "")
                    {
                        error += "Datos de Contacto \n \n";
                    }


                    if (txtCorreo.Text == "")
                    {
                        error += "El campo Correo electronico no puede estar vacio \n";
                    }


                    if (txtHorario.Text == "")
                    {
                        error += "El campo de Horario atención (Lunes / Viernes) no puede estar vacio \n";
                    }

                    if (txtHorariofds.Text == "")
                    {
                        error += "El campo de Horario atención ( Fin de semana ) no puede estar vacio \n";
                    }

                    if (error != "")
                    {
                        MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                    else
                    {
                        this.Datosusuario();
                        this.CRM();
                    }




                    // Validacion casilla pestaña de cierre

                }
                if (radioConsulta.Checked | radioback.Checked == true)
                {



                    if (plantilla_si.Checked == false & plantilla_no.Checked == false)
                    {
                        MessageBox.Show("El campo \"Adjuntar plantilla de cierre\" no puede estar vacio", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                // validacion soporte Ecare
                if (RadioECare.Checked == true)
                {



                    if (radioseñor.Checked == false & radioseñora.Checked == false)
                    {
                        MessageBox.Show("Cierre \n \n El campo \"Cliente\" no puede estar vacio", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (txtSolicitude.SelectedIndex.Equals(-1))
                    {
                        MessageBox.Show("Cierre \n \n El campo \"Solicitud\" no puede estar vacio", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }


                //Condicional Seleccione Tipo de Gestion

                if (radioConsulta.Checked == false & RadioECare.Checked == false & rTransferencia.Checked == false & radioFalla.Checked == false & radioback.Checked == false & RadioConfiguracionCPE.Checked == false & RadioConfiguracionTelefonia.Checked == false)
                {


                    MessageBox.Show("Por favor seleccione el tipo de gestion", " Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                }

                //Validaciones



                if (radioback.Checked == true | RadioConfiguracionCPE.Checked == true | RadioConfiguracionTelefonia.Checked == true)
                {
                    this.Datosusuario();
                    this.CRM();
                }


            }


        }

        private void txtCiudad_Click(object sender, EventArgs e)
        {
            try
            {
                txtCiudad.Items.Clear();


                MySqlCommand Barberos = new MySqlCommand("SELECT valores FROM " + LineaDeSoporte + ".camposfiltrables WHERE `campo` = 'ciudad'", Conexion.ObtenerConexion());
                MySqlDataReader Datos = Barberos.ExecuteReader();

                while (Datos.Read())
                {
                    txtCiudad.Refresh();
                    txtCiudad.Items.Add(Datos[0]);
                }



            }
            catch
            {
                MessageBox.Show("Error al conectar con la base de datos");
            }
        }

        private void txtCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
