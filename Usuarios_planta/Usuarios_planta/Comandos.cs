using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace Usuarios_planta
{
    class Comandos
    {
        MySqlConnection con = new MySqlConnection("server=localhost;Uid=root;password=;database=dblibranza;port=3306;persistsecurityinfo=True;");
        //MySqlConnection con = new MySqlConnection("server=;Uid=;password=;database=dblibranza;port=3306;persistsecurityinfo=True;");
        


        public void buscar_giros(TextBox TxtRadicado, TextBox Txtcedula, TextBox Txtnombre, TextBox Txtcuenta, TextBox Txtfecha_giro, TextBox Txtscoring, TextBox Txtnom_gestor, 
            TextBox Txtcoordinador, TextBox Txtcod_oficina, TextBox Txtnom_oficina, TextBox Txtciudad, TextBox Txtobligacion1, TextBox TxtNom_entidad1, TextBox TxtNit1, TextBox TxtValor1, 
            TextBox Txtobligacion2, TextBox TxtNom_entidad2, TextBox TxtNit2, TextBox TxtValor2, TextBox Txtobligacion3, TextBox TxtNom_entidad3, TextBox TxtNit3, TextBox TxtValor3, 
            TextBox Txtobligacion4, TextBox TxtNom_entidad4, TextBox TxtNit4, TextBox TxtValor4, TextBox Txtobligacion5, TextBox TxtNom_entidad5, TextBox TxtNit5, TextBox TxtValor5, 
            TextBox Txtobligacion6, TextBox TxtNom_entidad6, TextBox TxtNit6, TextBox TxtValor6, TextBox Txtobligacion7, TextBox TxtNom_entidad7, TextBox TxtNit7, TextBox TxtValor7, 
            TextBox Txtobligacion8, TextBox TxtNom_entidad8, TextBox TxtNit8, TextBox TxtValor8)
        {
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("buscar_giros", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_radicado", TxtRadicado.Text);
                MySqlDataReader registro;
                registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    Txtcedula.Text = registro["cedula"].ToString();
                    Txtnombre.Text = registro["nombre"].ToString();
                    Txtcuenta.Text = registro["cuenta"].ToString();
                    Txtscoring.Text = registro["scoring"].ToString();
                    Txtnom_gestor.Text = registro["nombre_gestor"].ToString();
                    Txtcoordinador.Text = registro["nombre_coordinador"].ToString();                    
                    Txtcod_oficina.Text = registro["codigo_oficina"].ToString();
                    Txtnom_oficina.Text = registro["sucursal"].ToString();
                    Txtciudad.Text = registro["ciudad"].ToString();                    
                    Txtobligacion1.Text = registro["numero_obligacion1"].ToString();
                    TxtNom_entidad1.Text = registro["nombre_entidad1"].ToString();
                    TxtNit1.Text = registro["nit_entidad1"].ToString();
                    TxtValor1.Text = registro["valor_cartera1"].ToString();
                    Txtobligacion2.Text = registro["numero_obligacion2"].ToString();
                    TxtNom_entidad2.Text = registro["nombre_entidad2"].ToString();
                    TxtNit2.Text = registro["nit_entidad2"].ToString();
                    TxtValor2.Text = registro["valor_cartera2"].ToString();
                    Txtobligacion3.Text = registro["numero_obligacion3"].ToString();
                    TxtNom_entidad3.Text = registro["nombre_entidad3"].ToString();
                    TxtNit3.Text = registro["nit_entidad3"].ToString();
                    TxtValor3.Text = registro["valor_cartera3"].ToString();
                    Txtobligacion4.Text = registro["numero_obligacion4"].ToString();
                    TxtNom_entidad4.Text = registro["nombre_entidad4"].ToString();
                    TxtNit4.Text = registro["nit_entidad4"].ToString();
                    TxtValor4.Text = registro["valor_cartera4"].ToString();
                    Txtobligacion5.Text = registro["numero_obligacion5"].ToString();
                    TxtNom_entidad5.Text = registro["nombre_entidad5"].ToString();
                    TxtNit5.Text = registro["nit_entidad5"].ToString();
                    TxtValor5.Text = registro["valor_cartera5"].ToString();
                    Txtobligacion6.Text = registro["numero_obligacion6"].ToString();
                    TxtNom_entidad6.Text = registro["nombre_entidad6"].ToString();
                    TxtNit6.Text = registro["nit_entidad6"].ToString();
                    TxtValor6.Text = registro["valor_cartera6"].ToString();
                    Txtobligacion7.Text = registro["numero_obligacion7"].ToString();
                    TxtNom_entidad7.Text = registro["nombre_entidad7"].ToString();
                    TxtNit7.Text = registro["nit_entidad7"].ToString();
                    TxtValor7.Text = registro["valor_cartera7"].ToString();
                    Txtobligacion8.Text = registro["numero_obligacion8"].ToString();
                    TxtNom_entidad8.Text = registro["nombre_entidad8"].ToString();
                    TxtNit8.Text = registro["nit_entidad8"].ToString();
                    TxtValor8.Text = registro["valor_cartera8"].ToString();

                }
                con.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Caso no existe", ex.ToString());
                con.Close();
                MessageBox.Show("Conexion cerrada");
            }

        }

        public void Insertar_giro(TextBox TxtRadicado, TextBox Txtcedula, TextBox Txtnombre, TextBox Txtnom_oficina)
        {


            try
            {
                con.Open();
                //transaction = con.BeginTransaction();
                MySqlCommand cmd = new MySqlCommand("insertar_giro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_radicado", TxtRadicado.Text);
                cmd.Parameters.AddWithValue("@_cedula", Txtcedula.Text);
                cmd.Parameters.AddWithValue("@_nombre", Txtnombre.Text);
                cmd.Parameters.AddWithValue("@_sucursal", Txtnom_oficina.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Información Registrada");
                //transaction.Commit();
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Error al insertar los datos", ex.ToString());
                /*transaction.Rollback();*/ // en caso de salir error no realiza ningun cambio a la base de datos
                con.Close();
                MessageBox.Show("Conexion cerrada");
            }
        }

        public void control_horarios(TextBox Txtidentificacion, TextBox TxtNombre, TextBox TxtArea, ComboBox cmbactividad,TextBox Txtobservaciones)
        {

            con.Open();
            MySqlCommand cmd = new MySqlCommand("control_horarios", con);
            MySqlTransaction myTrans; // Iniciar una transacción local 
            myTrans = con.BeginTransaction(); // Debe asignar tanto el objeto de transacción como la conexión // al objeto de Comando para una transacción local pendiente 
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@_Identificacion", Txtidentificacion.Text);
                cmd.Parameters.AddWithValue("@_Nombre", TxtNombre.Text);
                cmd.Parameters.AddWithValue("@_Area", TxtArea.Text);
                cmd.Parameters.AddWithValue("@_Actividad", cmbactividad.Text);
                cmd.Parameters.AddWithValue("@_Observaciones", Txtobservaciones.Text);
                cmd.ExecuteNonQuery();
                myTrans.Commit();
                MessageBox.Show("Información Registrada");
                con.Close();
            }
            catch (Exception e)
            {
                try
                {
                    myTrans.Rollback();
                    Console.WriteLine("Error", e.ToString());
                }
                catch (MySqlException ex)
                {
                    if (myTrans.Connection != null)
                    {
                        Console.WriteLine("Se encontró una excepción de tipo" + ex.GetType() +
                                                      " al intentar revertir la transacción..");
                        Console.Write(ex.ToString());
                        Console.Write(e.ToString());
                    }
                }
                Console.WriteLine("Se encontró una excepción de tipo " + e.GetType() +
                                              " al insertar los datos.");
                Console.WriteLine("Ninguno de los registros se escribió en la base de datos.");


            }
            finally
            {
                con.Close();
            }
        }
    }
}
