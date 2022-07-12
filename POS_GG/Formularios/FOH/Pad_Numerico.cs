using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_GG
{
    public partial class POS_SYS : Form
    {
        public POS_SYS()
        {
            InitializeComponent();
        }
        #region Numeros
        private void num_1_Click(object sender, EventArgs e)
        {
            dato_ingresado_textbox.Text += "0";
            clave += "1";
        }

        private void num_2_Click(object sender, EventArgs e)
        {
            dato_ingresado_textbox.Text += "0";
            clave += "2";
        }

        private void num_3_Click(object sender, EventArgs e)
        {
            dato_ingresado_textbox.Text += "0";
            clave += "3";
        }

        private void num_4_Click(object sender, EventArgs e)
        {
            dato_ingresado_textbox.Text += "0";
            clave += "4";
        }

        private void num_5_Click(object sender, EventArgs e)
        {
            dato_ingresado_textbox.Text += "0";
            clave += "5";
        }

        private void num_6_Click(object sender, EventArgs e)
        {
            dato_ingresado_textbox.Text += "0";
            clave += "6";
        }

        private void num_7_Click(object sender, EventArgs e)
        {
            dato_ingresado_textbox.Text += "0";
            clave += "7";
        }

        private void num_8_Click(object sender, EventArgs e)
        {
            dato_ingresado_textbox.Text += "0";
            clave += "8";
        }

        private void num_9_Click(object sender, EventArgs e)
        {
            dato_ingresado_textbox.Text += "0";
            clave += "9";
        }

        private void num_0_Click(object sender, EventArgs e)
        {
            dato_ingresado_textbox.Text += "0";
            clave += "0";
        }

        #endregion

        public string clave { get; set; }

        private void borrar_button_Click(object sender, EventArgs e)
        {
            dato_ingresado_textbox.Text = "";
        }

        private void aceptar_button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
