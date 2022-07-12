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
    public partial class Index : Form
    {
        private string token;
        public Index(string token)
        {
            InitializeComponent();
            this.token = token;
            Negocio.Empleados_Login.RefreshStatusToken(token);
        }

        #region Metodos y variables de comportamiento
        //Variable para determinar si el usuario lo cerro por boton o por teclado forzado
        public bool Cerradoporbotonera = false;
        private void Index_Shown(object sender, EventArgs e)
        {
            cambiartamaño_button_Click(sender, e);
        }
        private void Index_Load(object sender, EventArgs e)
        {
            Negocio.Compartido.Herramientas.StopLoadingDialog();
        }
        /// <summary>
        /// Valida los formularios abiertos en el contenedor central y devuelve el valor de la busqueda
        /// </summary>
        /// <param name="name">Nombre del formulario</param>
        /// <returns></returns>
        private bool HayUnoAbierto(string name)
        {   //Recorremos los formularios que hay dentro del contenedor central para validar si existe
            foreach (Form form in Contendedor_central.Controls)
            {
                if (form.Name.Contains(name))
                {
                    form.Show();
                    return true;
                }
                else
                {
                    form.Hide();
                }
            }
            //si no encontramos nada regresaremos que es falso
            return false;
        }
        /// <summary>
        /// Ajusta el formulario a la configuracion correcta para agregarlo al contenedor principal
        /// </summary>
        /// <param name="formularioaAbrir">la instancia del formulario</param>
        private void AperturaForm(Form formularioaAbrir)
        {
            formularioaAbrir.TopLevel = false;
            formularioaAbrir.FormBorderStyle = FormBorderStyle.None;
            Contendedor_central.Controls.Add(formularioaAbrir);
            formularioaAbrir.WindowState = FormWindowState.Maximized;
            formularioaAbrir.Show();

        }
        /// <summary>
        /// Realiza la configuracion y adaptacion del formulario dado al con contenedor 
        /// central
        /// </summary>
        /// <param name="nombreForm">Valor de la propiedad 'Name' del formulario</param>
        /// <param name="Formulario">instancia del formulario a abrir</param>
        private void Open(string nombreForm,Form Formulario)
        {
            Cursor = Cursors.WaitCursor;
            //Validamos si no existe un formulario
            if (!HayUnoAbierto(nombreForm))
            {
                //Creamos un hilo para mostrar el loading
                System.Threading.Thread loadingForm = new System.Threading.Thread(() =>
                {
                    Application.Run(new Compartido.Loading());
                });
                //iniciamos el hilo mostrando el loading
                loadingForm.Start();
                System.Threading.Thread.Sleep(1000);
                Negocio.Compartido.Herramientas.StopLoadingDialog();
                AperturaForm(Formulario);
            }
            Cursor = Cursors.Default;
        }

        /// <summary>
        /// Validaremos si el usuario cerro con los botones configurados o con teclado, o cierre forzado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Index_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Cerradoporbotonera)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Metodos de la Botonera

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open("Articulos", new Catalogos.ArticulosForm());
        }
        private void modificadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Open("Modificadores", new Catalogos.ModificadoresForm());
        }
        private void CerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Cerradoporbotonera = true;
            this.Close();
        }
        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cerradoporbotonera = true;
            Application.Exit();
        }
        private void InformeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }    
}
