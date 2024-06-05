using edu.ExamenTerceraEvRepetido.Controladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.ExamenTerceraEvRepetido.Servicios
{
    internal class FicherosImplementacion : FicherosInterfaz
    {

        public void ficheroErrores(string mensaje)
        {
            StreamWriter st = null;
            try
            {
                st = new StreamWriter(Program.rutaFicheroErrores, true);

                st.WriteLine(mensaje);



            }
            catch (IOException io)
            {

                Console.WriteLine("Se ha poducido un error, intentelo más tarde");

            }
            finally
            {
                if (st != null)
                {
                    st.Close();
                }
            }
        }

        public void ficheroTrazaSeleccion(string mensaje)
        {
            StreamWriter st = null;
            try
            {
                st = new StreamWriter(Program.rutaFicheroSeleccion,true);

                st.WriteLine(mensaje);



            }
            catch (IOException io)
            {

                Console.WriteLine("Se ha poducido un error, intentelo más tarde");
                ficheroErrores(String.Concat("Se ha producido un error en ficheroTrazaSeleccion ", io.Message, ";"));
            }
            finally
            {
                if (st != null)
                {
                    st.Close();
                }
            }
        }

        


        

    }
}
