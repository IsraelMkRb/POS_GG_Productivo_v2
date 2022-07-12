using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_GG.Formularios.BOH
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Cerrar_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Ingresar_button_Click(object sender, EventArgs e)
        {
            //Creamos un hilo para mostrar el loading
            System.Threading.Thread loadingForm = new System.Threading.Thread(() => {
                Application.Run(new Compartido.Loading());
            });
            //iniciamos el hilo mostrando el loading
            loadingForm.Start();
            //Obtenemos el listado de empleados con login desde la bd al cargar login, para no hacer larga la espera al presionar enter
            List<Datos.empleados_login_dtl> listEmpelados = Negocio.Empleados_Login.Get();
            Mensajedecarga.Text = "Cargando";
            Cursor = Cursors.WaitCursor;
            //Variable de control de existencia de credencial
            bool existeUsuario = false;
            //Variable para registrar el ID del empleado
            int EmpID = 0;
            //Recorremos el listado de datos 
            foreach (var empleado in listEmpelados)
            {   //validamos que exista la configuracion y devolveremos true si encontramos una
                if(empleado.passwordlogin == password_textbox.Text && empleado.userlogin == user_textbox.Text)
                {
                    existeUsuario = true;
                    EmpID = empleado.ID;
                }
            }
            if (existeUsuario)
            {
                //Si existe una configuracion de login igual al ingresado
                //creamos token de usuario
                string token = Negocio.Empleados_Login.GetToken(EmpID);
                //Creamos la instancia para abrir el formulario principal y le pasamos el token generado
                //Le pasamos el formulario de login por si cierran sesion, este regrese.
                Index ingresoindex = new Index(token);
                //mostramos index y escondemos login.
                ingresoindex.Show();
                this.Hide();
                Cursor = Cursors.Default;
                return;
            }
            else
            {
                Negocio.Compartido.Herramientas.StopLoadingDialog();
                //Enviamos mensaje de error de login y reseteamos espacio de texto
                MessageBox.Show("Usuario o contraseña equivocado, favor de verificar", "Usuario no encontrado");
                user_textbox.Text = "";
                password_textbox.Text = "";
                Mensajedecarga.Text = "";
                user_textbox.Focus();
                Cursor = Cursors.Default;
                return;
            }
        }

        private void user_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                //Si presionan Enter mientras este en el textbox de usuario mandamos llamar la funcion de validar ingreso
                Ingresar_button_Click(sender,new EventArgs());
            }
        }
        
        private void password_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                //Si presionan Enter mientras este en el textbox de contraseña mandamos llamar la funcion de validar ingreso
                Ingresar_button_Click(sender, new EventArgs());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.LinearGradientBrush linGrBrush = new System.Drawing.Drawing2D.LinearGradientBrush(panel1.ClientRectangle,Color.White,Color.Gray,90); // Opaque blue
            e.Graphics.FillRectangle(linGrBrush,panel1.ClientRectangle);

        }
    }
}
