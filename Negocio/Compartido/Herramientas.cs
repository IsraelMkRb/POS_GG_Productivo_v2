using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Compartido
{
     static public class Herramientas
    {
        public static string loadingFlagPath = Environment.CurrentDirectory + "\\loading";
        public static void StopLoadingDialog()
        {
            System.IO.File.Delete(loadingFlagPath);
        }
    }
}
