using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.ExamenTerceraEvRepetido.Utiles
{
    internal class Util
    {

        public static  string nombreArchivo() {
        
            DateTime fechaHoy = DateTime.Today;

            string nombreFichero = String.Concat(fechaHoy.ToString("ddMMyyyy"), ".txt");
            return nombreFichero;

        }

        public static string nombreArchivoErrores()
        {

            DateTime fechaHoy = DateTime.Today;

            string nombreFichero = String.Concat("logErrores-",fechaHoy.ToString("ddMMyyyy"), ".txt");
            return nombreFichero;

        }

        public static string nombreArchivoTrazaSelecc()
        {

            DateTime fechaHoy = DateTime.Today;

            string nombreFichero = String.Concat("logSeleccion-", fechaHoy.ToString("ddMMyyyy"), ".txt");
            return nombreFichero;

        }
    }
}
