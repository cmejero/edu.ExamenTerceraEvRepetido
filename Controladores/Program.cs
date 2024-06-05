using edu.ExamenTerceraEvRepetido.Dtos;
using edu.ExamenTerceraEvRepetido.Servicios;

namespace edu.ExamenTerceraEvRepetido.Controladores
{
    internal class Program
    {
        public static List<ProductoDto> listaProductos = new List<ProductoDto>();
        public static List<VentaDto> listaVentas = new List<VentaDto>();

        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();

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
                            cerrarMenu = true;
                            break;

                        case 1:
                            Console.WriteLine("Has seleccionado menu empleados");
                            mi.accesoMenuEmpleados();

                            break;

                        case 2:
                            Console.WriteLine("Has seleccionado menu gerencia");
                            mi.accesoMenuGerencia();
                            break;

                        default:
                            Console.WriteLine("La opcion indicada es incorrecta");
                            break;



                    }
                }catch (Exception ex) { }


            } while (!cerrarMenu);


        }
    }
}
