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
using System.Data.SqlClient;

namespace Usuarios_planta.Formularios
{
    public partial class Informes : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;Uid=root;password=;database=dblibranza;port=3306;persistsecurityinfo=True;");
        //MySqlConnection con = new MySqlConnection("server=;Uid=;password=;database=dblibranza;port=3306;persistsecurityinfo=True;");
        Comandos cmds = new Comandos();

        public Informes()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            cmds.control_horarios(Txtidentificacion, TxtNombre, TxtArea, cmbactividad, Txtobservaciones);
            Txtidentificacion.Clear();
            TxtNombre.Clear();
            TxtArea.Clear();
            cmbactividad.Text = "";
            Txtobservaciones.Clear();
        }

        private void Txtidentificacion_TextChanged(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM tf_usuarios WHERE Identificacion = @Identificacion ", con);
            comando.Parameters.AddWithValue("@Identificacion", Txtidentificacion.Text);
            con.Open();
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                TxtNombre.Text = registro["Nombre"].ToString();
                TxtArea.Text = registro["Area"].ToString();
            }
            con.Close();
        }
    }
}
