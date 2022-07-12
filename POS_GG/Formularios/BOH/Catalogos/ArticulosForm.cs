using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Catalogos;
using System.Linq;
using Negocio.Compartido;

namespace POS_GG.Formularios.BOH.Catalogos
{
    public partial class ArticulosForm : Form
    {
        private ComboBox[] ModificadoresCB = new ComboBox[4];

        public ArticulosForm()
        {
            InitializeComponent();
            //Creamos un array con los textbox de modificadores para su rapido acceso
            ComboBox[] ModificadoresCB = { Modificador1, Modificador2, Modificador3, Modificador4, Modificador5 };
            this.ModificadoresCB = ModificadoresCB;
        }

        #region Eventos
        private void Articulos_Load(object sender, EventArgs e)
        {
            //Obtenemos la lista de articulos
            List<Datos.general_Articulos> articulosList = Negocio.Catalogos.Articulos.Articulos.Get();
            //Obtenemos la lista de Modificadores
            List<Datos.general_Modificadores> modificadoresList = Negocio.Catalogos.Modificadores.Modificadores.Get();
            //Cargamos los combobox de los modificadores con los modificadores
            for (int i = 0; i < ModificadoresCB.Length; i++)
            {
                bool primerEspacio = true;
                for (int c = 0; c < modificadoresList.Count; c++)
                {
                    if (primerEspacio)
                    {
                        ModificadoresCB[i].Items.Add("<Vacio>");
                        ModificadoresCB[i].SelectedIndex = 0;
                        primerEspacio = false;
                        c--;
                    }
                    else
                    {
                        ModificadoresCB[i].Items.Add($"{ modificadoresList[c].ID } { modificadoresList[c].Nombre }");
                    }

                }
            }
            //Llenamos el Indice con la lista de articulos
            for (int i = 0; i < articulosList.Count; i++)
            {
                Indice.Rows.Add(articulosList[i].ID, articulosList[i].Nombre);
                //Llenamos el formulario con los datos del primer articulo
                if (i == 0)
                {
                    Fill(articulosList[i]);
                }
            }
            Herramientas.StopLoadingDialog();
        }
       
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Indice_CurrentCellChanged(object sender, EventArgs e)
        {
            IEnumerable<Datos.general_Articulos> articulo = from item in Negocio.Catalogos.Articulos.Articulos.Get()
                                                     where item.ID == (int)Indice.CurrentRow.Cells[0].Value select item;
            foreach (var item in articulo)
            {
                Fill(item);
            }
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Llena los campos del formulario con la informacion del articulo
        /// </summary>
        /// <param name="articulo">Instancia del articulo</param>
        private void Fill(Datos.general_Articulos articulo)
        {
            ID.Text = articulo.ID.ToString();
            nombre.Text = articulo.Nombre;
            display.Text = articulo.Display;
            precio.Text = articulo.Precio.ToString();
            PrecioModificable.Checked = articulo.Precio_Modificable;
            //Pedimos a la capa de Datos los modificadores del articulo
            List<Datos.ModificadoresdelArticulo_Result> modificadoresDelArticulo =
                Negocio.Catalogos.Modificadores.Modificadores.GetModsOf(articulo.ID);
            //Reseteamos todos los combobox en <vacio>
            for (int c = 0; c < ModificadoresCB.Length; c++)
            {
                ModificadoresCB[c].SelectedIndex = 0;
            }
            //Revisamos si el articulo contiene modificadores
            if (modificadoresDelArticulo.Count > 0)
            {
                //Recorremos la cantidad de modificadores registrados en la misma cantidad de combobox de Modificadores
                for (int c = 0; c < modificadoresDelArticulo.Count; c++)
                {
                    ModificadoresCB[c].SelectedIndex = (int)modificadoresDelArticulo[c].ID_Mod;
                }
            }
            else
            {
                //De lo contrario dejamos todos en <vacio>
                for (int c = 0; c < modificadoresDelArticulo.Count; c++)
                {
                    ModificadoresCB[c].SelectedIndex = 0;
                }
            }
        }
        #endregion

    }
}
