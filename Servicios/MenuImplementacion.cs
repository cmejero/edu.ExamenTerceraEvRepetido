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
                            Console.WriteLine("Has seleccionado cerrar menu");
                            cerrarMenu = true;
                            break;

                        case 1:
                            Console.WriteLine("Has seleccionado calculo total de ventas diarias");
                            ei.agregarVenta();
                            break;

                        case 2:
                            Console.WriteLine("Has seleccionado agrear venta");
                            ei.calculoTVentasDiarias();
                            break;

                        default:
                            Console.WriteLine("La opcion indicada es incorrecta");
                            break;



                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Ha ocurrido un error, intentelo mas tarde");
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
                            Console.WriteLine("Has seleccionado cerrar menu");
                            cerrarMenu = true;
                            break;

                        case 1:
                            Console.WriteLine("Has seleccionado calculo total de ventas diarias");

                            break;

                        case 2:
                            Console.WriteLine("Has seleccionado agrear venta");

                            break;

                        default:
                            Console.WriteLine("La opcion indicada es incorrecta");
                            break;



                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Ha ocurrido un error, intentelo mas tarde");
                }


            } while (!cerrarMenu);

        }
    }
}
