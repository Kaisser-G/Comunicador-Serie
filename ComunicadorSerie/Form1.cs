using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace ComunicadorSerie
{
    public partial class Form1 : Form
    {
        private SerialPort PuertoSerie;
        delegate string DelegadoSerie();
        int com = 1;
        Boolean conectado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PuertoSerie = new SerialPort();

            PuertoSerie.PortName = "COM" + com;
            PuertoSerie.BaudRate = 9600;
            PuertoSerie.StopBits = StopBits.One;
            PuertoSerie.DataBits = 8;
            PuertoSerie.Parity = Parity.None;
            PuertoSerie.ReceivedBytesThreshold = 1;

            PuertoSerie.DataReceived += new SerialDataReceivedEventHandler(PuertoSerie_RecibirDatos);

            //copiado de internet
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.richTextBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.textBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.lblEstado.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.btnConexion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.lblCOM1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.lblCOM2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.lblCOM3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.lblCOM4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.lblCOM5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region COM
        private void lblCOM1_Click(object sender, EventArgs e)
        {
            //lblCOM1.BorderStyle = BorderStyle.Fixed3D;
            lblCOM1.BackColor = Color.RoyalBlue;
            lblCOM2.BackColor = Color.Transparent;
            lblCOM3.BackColor = Color.Transparent;
            lblCOM4.BackColor = Color.Transparent;
            lblCOM5.BackColor = Color.Transparent;

            com = 1;
        }

        private void lblCOM2_Click(object sender, EventArgs e)
        {
            lblCOM1.BackColor = Color.Transparent;
            lblCOM2.BackColor = Color.RoyalBlue;
            lblCOM3.BackColor = Color.Transparent;
            lblCOM4.BackColor = Color.Transparent;
            lblCOM5.BackColor = Color.Transparent;

            com = 2;
        }

        private void lblCOM3_Click(object sender, EventArgs e)
        {
            lblCOM1.BackColor = Color.Transparent;
            lblCOM2.BackColor = Color.Transparent;
            lblCOM3.BackColor = Color.RoyalBlue;
            lblCOM4.BackColor = Color.Transparent;
            lblCOM5.BackColor = Color.Transparent;

            com = 3;
        }

        private void lblCOM4_Click(object sender, EventArgs e)
        {
            lblCOM1.BackColor = Color.Transparent;
            lblCOM2.BackColor = Color.Transparent;
            lblCOM3.BackColor = Color.Transparent;
            lblCOM4.BackColor = Color.RoyalBlue;
            lblCOM5.BackColor = Color.Transparent;

            com = 4;
        }

        private void lblCOM5_Click(object sender, EventArgs e)
        {
            lblCOM1.BackColor = Color.Transparent;
            lblCOM2.BackColor = Color.Transparent;
            lblCOM3.BackColor = Color.Transparent;
            lblCOM4.BackColor = Color.Transparent;
            lblCOM5.BackColor = Color.RoyalBlue;

            com = 5;
        }
        #endregion

        private void btnConexion_Click(object sender, EventArgs e)
        {

            if (!conectado)
            {
                try
                {
                    PuertoSerie.PortName = "COM" + com;
                    PuertoSerie.Open();

                    lblEstado.Text = "Conectado";
                    lblEstado.BackColor = Color.Green;

                    conectado = true;
                }
                catch(Exception ex)
                { MessageBox.Show(ex.Message.ToString(), "Error"); }

                
            }
            else
            {
                PuertoSerie.Close();

                lblEstado.Text = "Desconectado";
                lblEstado.BackColor = Color.Firebrick;

                conectado = false;
            }
                
        }

        private void PuertoSerie_RecibirDatos(object sender, SerialDataReceivedEventArgs e)
        {
            string dato = "";
            dato = leerDatos();

            richTextBox1.Text = dato + "\n";
        }

        private string leerDatos()
        {
            string dato = "";

            if(this.InvokeRequired)
            {
                DelegadoSerie Del = new DelegadoSerie(leerDatos);
                this.Invoke(Del);
            }
            else
            {
                dato = PuertoSerie.ReadExisting().ToString();
            }
            return dato;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                PuertoSerie.Write(textBox1.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        #region CopiadoDeInternet
        const int WM_SYSCOMMAND = 0x112;
        const int MOUSE_MOVE = 0xF012;

        // Declaraciones del API 
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        // 
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        // 
        // función privada usada para mover el formulario actual 

        private void moverForm()
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, MOUSE_MOVE, 0);
        }


        private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            moverForm();
        }
        #endregion

    }
}
