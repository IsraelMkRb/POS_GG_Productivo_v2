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
                IEnumerable<general_Articulos> iarticulos = from articulo in db.general_Articulos.ToList() 
                                                            orderby articulo.ID ascending select articulo;
                return iarticulos.ToList();
            }
        }
        /// <summary>
        /// Devuelve un ID basandose en el ultimo ID registrado en articulos y sumando 1 espacio
        /// </summary>
        /// <returns>ID Nuevo</returns>
        public static general_Articulos New()
        {
            using(GemaEntities1 db = new GemaEntities1())
            {
                IEnumerable<general_Articulos> UltimoRegistro = (from articulo in db.general_Articulos
                                                                 orderby articulo.ID descending select articulo).Take(1);
                general_Articulos articuloNew = new general_Articulos();
                foreach (var item in UltimoRegistro)
                {
                   articuloNew.ID  = item.ID + 1;
                    articuloNew.Nombre = "";
                    articuloNew.Display = "";
                    articuloNew.Precio = 0;
                    articuloNew.Precio_Modificable = false;
                    articuloNew.Tiene_Modificadores = false;
                }
                return articuloNew;
            }
        }
        /// <summary>
        /// Guardamos el articulo
        /// </summary>
        /// <param name="articulo">articulo a guardar</param>
        /// <returns>el resultado de guardar cambios</returns>
        public static bool Save(general_Articulos articulo)
        {
            using(GemaEntities1 db = new GemaEntities1())
            {
                //Corremos el proceso almacenado de guardar item
                db.guardaritem(articulo.ID, articulo.Nombre, articulo.Display, 
                    articulo.Precio, articulo.Impuestos, articulo.Categoria, 
                    articulo.Precio_Modificable, articulo.Tiene_Modificadores);
                //Creamos una consulta linq para validar que ya este el articulo
                IEnumerable<general_Articulos> articuloList = from item in db.general_Articulos.ToList()
                                                              where item.ID == articulo.ID
                                                              select item;
                //regresamos si encontro el articulo
                return articuloList.ToList().Count > 0;
            }
        }
        /// <summary>
        /// Valida si el ID del articulo a consultar existe
        /// </summary>
        /// <param name="ID">ID del articulo a consultar</param>
        /// <returns></returns>
        public static bool Exists(int ID)
        {
            using(GemaEntities1 db = new GemaEntities1())
            {
                IEnumerable<general_Articulos> articulosQueCoincide = from item in db.general_Articulos.ToList()
                                                                      where item.ID == ID
                                                                      select item;
                return articulosQueCoincide.ToList().Count != 0;
            }
        }
        /// <summary>
        /// Elimina el articulo que coincida con el ID
        /// </summary>
        /// <param name="ID_Item">ID del articulo a borrar</param>
        public static void Delete(int ID_Item)
        {
            using(GemaEntities1 db = new GemaEntities1())
            {
                IEnumerable<general_Articulos> iarticulos = from articulo in db.general_Articulos.ToList()
                                                            where articulo.ID == ID_Item
                                                            select articulo;
                foreach (var item in iarticulos)
                {
                    db.Borraitem(ID_Item);
                }
            }
        }
    }
}
