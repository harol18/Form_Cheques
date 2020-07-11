using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Net.Mail;
using System.Net.Mime;
//using Outlook = Microsoft.Office.Interop.Outlook;



namespace Usuarios_planta.Formularios
{
    public partial class FormGiros : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;Uid=root;password=;database=dblibranza;port=3306;persistsecurityinfo=True;");
        Comandos cmds = new Comandos();
        private string To;
        private string Subject;
        private string Body;
        private string From;
        private string CC;
        private string Pass;
        private MailMessage mail;
              
        


        public FormGiros()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(TxtRadicado.Text, Txtcedula.Text);//agregar informacion de los textbox en el datagridview
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            BtnSalir.BackColor = Color.FromArgb(251, 187, 33);
            this.Close();
        }
        DateTime hoy = DateTime.Today;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(TxtRadicado.Text, Txtcod_oficina.Text, hoy.ToShortDateString(), Txtnom_oficina.Text,Txtciudad.Text,Txtcedula.Text, Txtnombre.Text, TxtNit1.Text, TxtNom_entidad1.Text, TxtValor1.Text, Txtobligacion1.Text, Txtscoring.Text,Txtnom_gestor.Text,Txtcoordinador.Text, Txtcuenta.Text, Txtref.Text);//agregar informacion de los textbox en el datagridview
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(TxtRadicado.Text, Txtcod_oficina.Text, hoy.ToShortDateString(), Txtnom_oficina.Text, Txtciudad.Text, Txtcedula.Text, Txtnombre.Text, TxtNit2.Text, TxtNom_entidad2.Text, TxtValor2.Text, Txtobligacion2.Text, Txtscoring.Text, Txtnom_gestor.Text, Txtcoordinador.Text, Txtcuenta.Text, Txtref.Text);//agregar informacion de los textbox en el datagridview
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(TxtRadicado.Text, Txtcod_oficina.Text, hoy.ToShortDateString(), Txtnom_oficina.Text, Txtciudad.Text, Txtcedula.Text, Txtnombre.Text, TxtNit3.Text, TxtNom_entidad3.Text, TxtValor3.Text, Txtobligacion3.Text, Txtscoring.Text, Txtnom_gestor.Text, Txtcoordinador.Text, Txtcuenta.Text, Txtref.Text);//agregar informacion de los textbox en el datagridview
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(TxtRadicado.Text, Txtcod_oficina.Text, hoy.ToShortDateString(), Txtnom_oficina.Text, Txtciudad.Text, Txtcedula.Text, Txtnombre.Text, TxtNit4.Text, TxtNom_entidad4.Text, TxtValor4.Text, Txtobligacion4.Text, Txtscoring.Text, Txtnom_gestor.Text, Txtcoordinador.Text, Txtcuenta.Text, Txtref.Text);//agregar informacion de los textbox en el datagridview
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(TxtRadicado.Text, Txtcod_oficina.Text, hoy.ToShortDateString(), Txtnom_oficina.Text, Txtciudad.Text, Txtcedula.Text, Txtnombre.Text, TxtNit5.Text, TxtNom_entidad5.Text, TxtValor5.Text, Txtobligacion5.Text, Txtscoring.Text, Txtnom_gestor.Text, Txtcoordinador.Text, Txtcuenta.Text, Txtref.Text);//agregar informacion de los textbox en el datagridview
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(TxtRadicado.Text, Txtcod_oficina.Text, hoy.ToShortDateString(), Txtnom_oficina.Text, Txtciudad.Text, Txtcedula.Text, Txtnombre.Text, TxtNit6.Text, TxtNom_entidad6.Text, TxtValor6.Text, Txtobligacion6.Text, Txtscoring.Text, Txtnom_gestor.Text, Txtcoordinador.Text, Txtcuenta.Text, Txtref.Text);//agregar informacion de los textbox en el datagridview
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(TxtRadicado.Text, Txtcod_oficina.Text, hoy.ToShortDateString(), Txtnom_oficina.Text, Txtciudad.Text, Txtcedula.Text, Txtnombre.Text, TxtNit7.Text, TxtNom_entidad7.Text, TxtValor7.Text, Txtobligacion7.Text, Txtscoring.Text, Txtnom_gestor.Text, Txtcoordinador.Text, Txtcuenta.Text, Txtref.Text);//agregar informacion de los textbox en el datagridview
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(TxtRadicado.Text, Txtcod_oficina.Text, hoy.ToShortDateString(), Txtnom_oficina.Text, Txtciudad.Text, Txtcedula.Text, Txtnombre.Text, TxtNit8.Text, TxtNom_entidad8.Text, TxtValor8.Text, Txtobligacion8.Text, Txtscoring.Text, Txtnom_gestor.Text, Txtcoordinador.Text, Txtcuenta.Text, Txtref.Text);//agregar informacion de los textbox en el datagridview
        }
        private void TxtCod_oficina_TextChanged(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM tf_oficinas WHERE codigo_oficina = @codigo ", con);
            comando.Parameters.AddWithValue("@codigo", Txtcod_oficina.Text);
            con.Open();
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                Txtnom_oficina.Text = registro["sucursal"].ToString();
                Txtciudad.Text = registro["ciudad"].ToString();
                Txtto.Text = registro["correo_gerente"].ToString() + ", " + registro["correo_subgerente"].ToString() + ", " + Txtcorreo_coordinador.Text + ", " + Txtcorreo_apoyo.Text;

            }
            con.Close();
        }

        private void TxtCoordinador_TextChanged(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM tf_coordinador WHERE nombre_coordinador = @coordinador ", con);
            comando.Parameters.AddWithValue("@coordinador", Txtcoordinador.Text);
            con.Open();
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                Txtcorreo_coordinador.Text = registro["correo_coordinador"].ToString();
                Txtcorreo_apoyo.Text = registro["correo_apoyo"].ToString();
            }
            con.Close();
        }

        public static string getHtml(DataGridView grid)
        {
            try
            {
                string messageBody = "<font>Señores: </font><br><br><br>Oficina<br><br><br>Buen Día,<br><br>Por motivo del desembolso de la compra de cartera del cliente en referencia, se generó para su oficina el(los) Giro(s) de Cheque(s) de acuerdo con la información adjunta,para su respectiva impresión, custodia y contacto a cliente para su entrega. <br><br>" +
                    "La operatoria que se debe realizar:<br>Operatoria 2 / Operatoria activos / Prestamos / Formalización / Imprimir Cheques - Desembolso Crédito<br><br><br>";
                if (grid.RowCount == 0) return messageBody;
                string htmlTableStart = "<table style=\"border-collapse:collapse; text-align:center;\" >";
                string htmlTableEnd = "</table>";
                string htmlHeaderRowStart = "<tr style=\"background-color:#004254; color:#FFFFFF;\">";
                string htmlHeaderRowEnd = "</tr>";
                string htmlTrStart = "<tr style=\"color:#000000;\">";
                string htmlTrEnd = "</tr>";
                string htmlTdStart = "<td style=\" border-color:#000000; border-style:solid; border-width:thin; padding: 5px;\">";
                string htmlTdEnd = "</td>";
                string htmlTdparrafo = "<font><br><br><br>Por favor proceder con el giro de cheque de forma inmediata, dado que en caso contrario la partida quedará pendiente en la cuenta 259595201 de su centro de costos y la cual estará siendo monitoreada por CONTROL CONTABLE.<br><br>" +
                    "<br>Así mismo, una vez realizada la impresión del cheque se solicita realizar el endoso de cada una de las obligaciones correspondientes según la información suministrada; igualmente de requerirse esta información se podrá validar en Bonita.<br><br>" +
                    "Si presenta algún inconveniente en la impresión del(los) Cheque(s) por favor comunicarse con su respectivo TAR o devolver el correo con copia a TODOS los buzones adjuntando PANTALLAS paso a paso de como se está ingresando toda la información.<br><br><br>" +
                    "BBVA - INDRA.<br>Centro de formalización.<br>Calle 75a # 27a - 28.<br>cheques.libranza@bbva.com.co</font>";
                messageBody += htmlTableStart;
                messageBody += htmlHeaderRowStart;
                messageBody += htmlTdStart + "Radicado" + htmlTdEnd;
                messageBody += htmlTdStart + "Codigo" + htmlTdEnd;
                messageBody += htmlTdStart + "Fecha" + htmlTdEnd;
                messageBody += htmlTdStart + "Oficina" + htmlTdEnd;
                messageBody += htmlTdStart + "Ciudad" + htmlTdEnd;
                messageBody += htmlTdStart + "Cedula" + htmlTdEnd;
                messageBody += htmlTdStart + "Nombre" + htmlTdEnd;
                messageBody += htmlTdStart + "Nit" + htmlTdEnd;
                messageBody += htmlTdStart + "Entidad" + htmlTdEnd;
                messageBody += htmlTdStart + "Valor" + htmlTdEnd;
                messageBody += htmlTdStart + "Obligacion" + htmlTdEnd;
                messageBody += htmlTdStart + "Scoring" + htmlTdEnd;
                messageBody += htmlTdStart + "Gestor" + htmlTdEnd;
                messageBody += htmlTdStart + "Coordinador" + htmlTdEnd;
                messageBody += htmlTdStart + "Cuenta" + htmlTdEnd;
                messageBody += htmlTdStart + "Ref" + htmlTdEnd;
                messageBody += htmlHeaderRowEnd;
                
                //Loop all the rows from grid vew and added to html td  
                for (int i = 0; i <= grid.RowCount - 1; i++)
                {
                    messageBody = messageBody + htmlTrStart;
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[0].Value; //Radicado
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[1].Value; //Codigo
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[2].Value; //Fecha  
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[3].Value; //Oficina
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[4].Value; //Ciudad 
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[5].Value; //Cedula 
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[6].Value; //Nombre 
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[7].Value; //Nit
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[8].Value; //Entidad
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[9].Value; //Valor
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[10].Value; //Obligacion 
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[11].Value; //Scoring 
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[12].Value; //Gestor
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[12].Value; //Coordinador 
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[14].Value; //Cuenta
                    messageBody = messageBody + htmlTdStart + grid.Rows[i].Cells[15].Value; //Ref
                    messageBody = messageBody + htmlTrEnd;
                    

                }
                messageBody = messageBody + htmlTableEnd;
                messageBody = messageBody + htmlTdparrafo;
                return messageBody; // devuelve la tabla HTML como cadena de esta función  
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            cmds.buscar_giros(TxtRadicado, Txtcedula, Txtnombre, Txtcuenta, Txtcorreo_envio, Txtscoring, Txtnom_gestor,
            Txtcoordinador, Txtcod_oficina, Txtnom_oficina, Txtciudad, Txtobligacion1, TxtNom_entidad1, TxtNit1, TxtValor1,
            Txtobligacion2, TxtNom_entidad2, TxtNit2, TxtValor2, Txtobligacion3, TxtNom_entidad3, TxtNit3, TxtValor3,
            Txtobligacion4, TxtNom_entidad4, TxtNit4, TxtValor4, Txtobligacion5, TxtNom_entidad5, TxtNit5, TxtValor5,
            Txtobligacion6, TxtNom_entidad6, TxtNit6, TxtValor6, Txtobligacion7, TxtNom_entidad7, TxtNit7, TxtValor7,
            Txtobligacion8, TxtNom_entidad8, TxtNit8, TxtValor8);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar limpiar = new limpiar(); //llamo la clase para limpiar todos los textbox que se encuentran en el groupbox1
            limpiar.BorrarCampos(groupBox1);
            limpiar.BorrarCampos(groupBox2);
            limpiar.BorrarCampos(groupBox4);
            dataGridView1.Rows.Clear();
        }

        private void Txtnombre_TextChanged(object sender, EventArgs e)
        {
            TxtAsunto.Text = "GIRO CHEQUE CPK " + Txtnombre.Text + " CC " + Txtcedula.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string htmlString = getHtml(dataGridView1);
            Enviarcorreo(htmlString);
            cmds.Insertar_giro(TxtRadicado, Txtcedula, Txtnombre, Txtnom_oficina);
            MessageBox.Show("Ok correo enviado");
        }


        public void Enviarcorreo(string htmlString)
        {
            try
            {

                To = Txtto.Text;
                Subject = TxtAsunto.Text;
                Body = Txtnombre.Text;
                From = Txtcorreo_envio.Text;
                CC = Txtcorreo_copia.Text;
                Pass = Txtcontraseña_correo.Text;

                MailMessage message = new MailMessage(CC,To);
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(this.From);
                message.To.Add(new MailAddress(this.To));
                message.CC.Add(this.CC);
                message.Subject = Subject;
                message.IsBodyHtml = true;
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.live.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(From, Pass);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception) { }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            string htmlString = getHtml(dataGridView1);
            Enviarcorreo(htmlString);
            MessageBox.Show("Ok correo enviado");
            cmds.Insertar_giro(TxtRadicado, Txtcedula, Txtnombre, Txtnom_oficina);
            
        }
    }
}
