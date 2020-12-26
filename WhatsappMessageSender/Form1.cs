using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsappMessageSender
{
    public partial class Index : Form
    {
        //variables
        public string ID = "z5AZR6PqYkqrtRuu82VdjE1heHdlbGx0cm9jaGEwNzA5X2F0X2dtYWlsX2RvdF9jb20=";
        public string phoneToSend;
        public string _Message;

        public Index()
        {
            //evento autonomo (creado automaticamente por el Visual Studio)
            InitializeComponent();
        }
        



        //---------------------------botones y eventos (de los botones)---------------------------//
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Esta saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        /*Boton Limpiar*/ private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        /*Boton Enviar*/ private void sendButton_Click(object sender, EventArgs e)
        {
            enviarMensajes();
        }

        //permision de solo numeros (que solo se puedan teclear numeros en los textbox)
        private void phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                panelErr.Visible = true;
                MessageBox.Show("Solo se pueden digitar números", "Caracter sin pies!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                panelErr.Visible = false;
            }
        }
        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                panelErr.Visible = true;
                e.Handled = true;
                MessageBox.Show("Solo se pueden digitar números", "Caracter sin pies", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                panelErr.Visible = false;
            }
        }

        /*mostrar telefono*/private void showPass_Click(object sender, EventArgs e)
        {
            showPass.Visible = false;
            hidePass.Visible = true;
            phoneNumber.UseSystemPasswordChar = false;
        }
        /*esconder telefono*/private void hidePass_Click(object sender, EventArgs e)
        {
            hidePass.Visible = false;
            showPass.Visible = true;
            phoneNumber.UseSystemPasswordChar = true;
        }


        

        //----------------------------------Sistema de eventos-----------------------------------//

        //Void Start()
        public void InicializarTodo()
        {
            Index indexform = new Index();

            //---------------------Textos---------------------//
            titleText.Text = indexform.Text;
            cuantityText.Text = "1";

            //---------------------Tamaños--------------------//
            indexform.Size = new Size(344, 494);

            //-----------------Localizaciones-----------------//
            hidePass.Location = new Point(197, 38);
            showPass.Location = new Point(197, 38);

            //-------------------Visibilidad------------------//
            hidePass.Visible = false;
            showPass.Visible = true;
        }

        //evento al cargar el formulario
        private void Index_Load(object sender, EventArgs e)
        {
            InicializarTodo();
        }

        //evento para "Limpiar"
        public void Limpiar()
        {
            //obten todos los componentes textbox y limpialos
            foreach (Control ctrl in Controls)
            {
                if (ctrl.Tag == "control")
                {
                    ctrl.Text = "";
                }
                cuantityText.Text = "1";
            }
        }

        //evento para "Enviar mensajes"
        public void enviarMensajes()
        {
            //seteando variables
            phoneToSend = phoneToSendTextBox.Text;
            _Message = messageTextBox.Text;

            try
            {
                //string url = "https://niceapi.net//API";

                //ya se mando la vaina
                Limpiar();
                MessageBox.Show("Mensaje enviado correctamente!", "Send message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception err)
            {
                DialogResult = MessageBox.Show("Ha ocurrido un error, codigo del error: " + err, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (DialogResult == DialogResult.Retry)
                {
                    enviarMensajes();
                }
            }
        }

        //evento al presionar enter
        private void messageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (enterSend.Checked == true))
            {
                enviarMensajes();
            }
        }
    }
}

