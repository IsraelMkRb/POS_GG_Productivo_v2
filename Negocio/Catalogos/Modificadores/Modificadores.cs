using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio.Catalogos.Modificadores
{
    public static class Modificadores
    {
        /// <summary>
        /// devuelve la lista de modficadores registrados
        /// </summary>
        /// <returns></returns>
        public static List<general_Modificadores> Get()
        {
            using (GemaEntities1 db = new GemaEntities1())
            {
                return db.general_Modificadores.ToList();
            }
        }

        /// <summary>
        /// Busca los modificadores del articulo especificado
        /// </summary>
        /// <returns>Lista de los modificadores</returns>
        /// <param name="iD_Item">ID del articulo</param>
        public static List<ModificadoresdelArticulo_Result> GetModsOf(int iD_Item)
        {
            using (GemaEntities1 db = new GemaEntities1())
            {
                return db.ModificadoresdelArticulo(iD_Item).ToList();
            }
        }
    }
}
