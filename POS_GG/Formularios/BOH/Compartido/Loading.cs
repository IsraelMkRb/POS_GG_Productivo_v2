using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_GG.Formularios.BOH.Compartido
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            System.IO.FileStream file = System.IO.File.Create(Negocio.Compartido.Herramientas.loadingFlagPath);
            file.Close();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(Negocio.Compartido.Herramientas.loadingFlagPath))
            {
                this.Close();
            }
        }
    }
}
