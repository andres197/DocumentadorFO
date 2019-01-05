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
    public partial class HistorialMod : Form
    {

        MySqlCommand cmd;
        MySqlDataAdapter ad;

        public HistorialMod()
        {
            InitializeComponent();
        }

        public string nombresoporte, id, agenteasignado, LineaDeSoporte;

        private void btnmod_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea modificar el registro?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {

                
                // Se actualiza tabla historial modificaciones
                cmd = new MySqlCommand("UPDATE " + LineaDeSoporte + ".historial_actividades SET comentario = '" + richHistMod.Text+"' WHERE " + LineaDeSoporte + ".historial_actividades.id = '" + id + "';", Conexion.ObtenerConexion());
                cmd.ExecuteNonQuery();

                    MessageBox.Show("Se modificaros los datos correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar" + ex.Message);
                }
            }
        }

        private void HistorialMod_Load(object sender, EventArgs e)
        {
            if (nombresoporte == agenteasignado)
            {
                richHistMod.ReadOnly = false;
                btnmod.Visible = true;
            }
            else
            {
                btnmod.Visible = false;
            }
        }

    
    }
}
