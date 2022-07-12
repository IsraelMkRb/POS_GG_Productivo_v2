using System;
using System.Collections.Generic;
using System.Linq;


namespace Negocio
{
    static public class Empleados_Login
    {
        static public List<Datos.empleados_login_dtl> Get()
        {
            try
            {
                using (Datos.GemaEntities1 dbmodel = new Datos.GemaEntities1())
                {
                    return dbmodel.empleados_login_dtl.ToList(); //Devolveremos la lista de logins por empleado
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public string GetToken(int ID_empleado)
        {
            string token = DateTime.Now.Day.ToString() +
                DateTime.Now.Month.ToString() + 
                DateTime.Now.Second + 
                ID_empleado.ToString();
            Datos.GemaEntities1 proceso = new Datos.GemaEntities1();
            proceso.RegistraToken(token,DateTime.Now.AddMinutes(15));
            return token;
        }

        static public void RefreshStatusToken(string token)
        {
            Datos.GemaEntities1 proceso = new Datos.GemaEntities1();
            proceso.ActualizaEstadoToken(DateTime.Now.AddMinutes(15),token);
        }
    }
}

