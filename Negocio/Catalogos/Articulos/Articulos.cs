using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio.Catalogos.Articulos
{
    public static class Articulos
    {
        /// <summary>
        /// devuelve la lista de articulos registrados
        /// </summary>
        /// <returns></returns>
        public static List<general_Articulos> Get()
        {
            using(GemaEntities1 db = new GemaEntities1())
            {
                return db.general_Articulos.ToList();
            }
        }
               
    }
}
