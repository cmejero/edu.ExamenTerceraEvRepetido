using edu.ExamenTerceraEvRepetido.Dtos;
using edu.ExamenTerceraEvRepetido.Servicios;
using edu.ExamenTerceraEvRepetido.Utiles;
using System.Xml.Serialization;


 
namespace edu.ExamenTerceraEvRepetido.Controladores
{
    internal class Program
    {
        public static List<ProductoDto> listaProductos = new List<ProductoDto>();
        public static List<VentaDto> listaVentas = new List<VentaDto>();
        public static string rutaFichero = "C:\\Users\\Carlos\\Desktop\\FICHEROS\\examen3evPR";

        public static string rutaFinal = String.Concat(rutaFichero, Util.nombreArchivo());
        public static string rutaFicheroErrores = String.Concat(rutaFichero, Util.nombreArchivoErrores());
        public static string rutaFicheroSeleccion = String.Concat(rutaFichero, Util.nombreArchivoTrazaSelecc());


        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            FicherosInterfaz fi = new FicherosImplementacion();    

            int opcionUsuario;
            bool cerrarMenu = false;

           

            do
            {
                try
                {
                    opcionUsuario = mi.MenuYSeleccionPrincipal();


                    switch (opcionUsuario)
                    {

                        case 0:
                            Console.WriteLine("Has seleccionado cerrar menu");
                            fi.ficheroTrazaSeleccion("Ha seleccionado cerrar menu");
                            cerrarMenu = true;
                            break;

                        case 1:
                            Console.WriteLine("Has seleccionado menu empleados");
                            fi.ficheroTrazaSeleccion("ha seleccionado menu empleados");
                            mi.accesoMenuEmpleados();

                            break;

                        case 2:
                            Console.WriteLine("Has seleccionado menu gerencia");
                            fi.ficheroTrazaSeleccion("ha seleccionado menu gerencia");
                            mi.accesoMenuGerencia();
                            break;

                        default:
                            Console.WriteLine("La opcion indicada es incorrecta");
                            fi.ficheroTrazaSeleccion("ha seleccionado opcion incorrecta");
                            break;



                    }
                }catch (Exception ex) {
                
                    fi.ficheroErrores(String.Concat("Se ha producido un error: " , ex.Message , ";"));
                    Console.WriteLine("Se ha producido un error, intentelo más tarde");

                }


            } while (!cerrarMenu);


        }
    }
}
