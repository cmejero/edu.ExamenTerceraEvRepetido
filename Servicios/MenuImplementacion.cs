using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.ExamenTerceraEvRepetido.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        EmpleadosInterfaz ei = new EmpleadosImplementacion();
        GerenciaInterfaz gi = new GerenciaImplementacion();
        FicherosInterfaz fi = new FicherosImplementacion();

        public int MenuYSeleccionPrincipal()
        {
            int opcionUsuario;

            Console.WriteLine("############################");
            Console.WriteLine("0. Cerrar aplicacion");
            Console.WriteLine("1. Menu empleados");
            Console.WriteLine("2. Menu gerencia");
            Console.WriteLine("############################");

            opcionUsuario = Convert.ToInt32(Console.ReadLine());

            return opcionUsuario;
        }


        private int MenuYSeleccionEmpleados()
        {

            int opcionUsuario;

            Console.WriteLine("############################");
            Console.WriteLine("0. volver");
            Console.WriteLine("1. Agregar venta");
            Console.WriteLine("2. calculo total de ventas diarias");            
            Console.WriteLine("############################");

            opcionUsuario = Convert.ToInt32(Console.ReadLine());

            return opcionUsuario;

        }

        public void accesoMenuEmpleados()
        {


            int opcionUsuario;
            bool cerrarMenu = false;

            do
            {
                try
                {
                    opcionUsuario = MenuYSeleccionEmpleados();


                    switch (opcionUsuario)
                    {

                        case 0:
                            Console.WriteLine("Has seleccionado volver");
                            fi.ficheroTrazaSeleccion("ha seleccionado volver");
                            cerrarMenu = true;
                            break;

                        case 1:
                            Console.WriteLine("Has seleccionado calculo total de ventas diarias");
                            
                            ei.agregarVenta();
                            fi.ficheroTrazaSeleccion("ha seleccionado calculo total de ventas diarias");
                            break;

                        case 2:
                            Console.WriteLine("Has seleccionado agregar venta");
                            fi.ficheroTrazaSeleccion("ha seleccionado agregar ventas");
                            ei.calculoTVentasDiarias();
                            break;

                        default:
                            Console.WriteLine("La opcion indicada es incorrecta");
                            fi.ficheroTrazaSeleccion("ha seleccionado opcion incorrecta");
                            break;



                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Ha ocurrido un error, intentelo mas tarde");
                    fi.ficheroErrores(String.Concat("Se ha producido un error: ", ex.Message));
                }


            } while (!cerrarMenu);



        }

        private int MenuYSeleccionGerencia()
        {

            int opcionUsuario;

            Console.WriteLine("############################");
            Console.WriteLine("0. volver");
            Console.WriteLine("1. Escribir en ficheros todas las ventas del dia");
            Console.WriteLine("2. Crear nuevo pedido de proveedores");
            Console.WriteLine("############################");

            opcionUsuario = Convert.ToInt32(Console.ReadLine());

            return opcionUsuario;

        }


        public void accesoMenuGerencia()
        {


            int opcionUsuario;
            bool cerrarMenu = false;

            do
            {
                try
                {
                    opcionUsuario = MenuYSeleccionGerencia();


                    switch (opcionUsuario)
                    {

                        case 0:
                            Console.WriteLine("Has seleccionado volver");
                            fi.ficheroTrazaSeleccion("ha seleccionado volver");
                            cerrarMenu = true;
                            break;

                        case 1:
                            Console.WriteLine("Has seleccionado mostrar en ficheros ventas del dia ");
                            fi.ficheroTrazaSeleccion("ha seleccionado mostrar en ficheros ventas del dia");
                            gi.mostrarVentasDia();
                            break;

                        case 2:
                            Console.WriteLine("Has seleccionado nuevo pedido para proveedores");
                            fi.ficheroTrazaSeleccion("ha seleccionado nuevo pedido para proveedores");
                            gi.pedidoParaProveedores();
                            break;

                        default:
                            Console.WriteLine("La opcion indicada es incorrecta");
                            fi.ficheroTrazaSeleccion("ha seleccionado una opcion incorrecta");
                            break;



                    }
                }
                catch (Exception ex)
                {


                    fi.ficheroErrores(String.Concat("Se ha producido un error: ", ex.Message, ";"));
                    Console.WriteLine("Se ha producido un error, intentelo más tarde");
                }


            } while (!cerrarMenu);

        }
    }
}
