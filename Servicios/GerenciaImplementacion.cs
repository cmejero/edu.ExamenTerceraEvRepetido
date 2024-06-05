using edu.ExamenTerceraEvRepetido.Controladores;
using edu.ExamenTerceraEvRepetido.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.ExamenTerceraEvRepetido.Servicios
{
    internal class GerenciaImplementacion : GerenciaInterfaz
    {

        public void  mostrarVentasDia()
        {

            Console.WriteLine("Introduzca la fecha del dia que quieras mostrar en formato: dd-MM-yyyy.");
            string fecha = Console.ReadLine();

            DateTime fechaM = DateTime.Parse(fecha);
            string formatear = fechaM.ToString("dd-MM-yyyy");
            DateTime fechaDia = DateTime.Parse(formatear);

            foreach(VentaDto venta in Program.listaVentas)
            {
                if(venta.InstanteCompra.ToShortDateString() == fechaDia.ToShortDateString())
                {

                    StreamWriter st = new StreamWriter(Program.rutaFinal , true);

                    st.WriteLine("……….");
                    st.WriteLine(String.Concat("Venta número: ", venta.IdVenta));
                    st.WriteLine(String.Concat("Euros: ", venta.Euros, " euros"));
                    st.WriteLine(String.Concat("Intante de compra: ", venta.InstanteCompra.ToString()));
                    
                    st.Close();
                    


                }



            }

        }


        public void pedidoParaProveedores()
        {

            string respuesta;

            do
            {



                long id = crearId();
                Console.WriteLine("Introduzca el nombre del producto");
                string nombre = Console.ReadLine();

                Console.WriteLine("Introduza la cantidad de producto");
                int cantidad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduzca la fecha deseada para entrega en formato: dd-MM-yyyy");
                string fechaString = Console.ReadLine();

                DateTime fecha = DateTime.Parse(fechaString);

                ProductoDto producto = new ProductoDto(id, nombre ,cantidad, fecha);

                Program.listaProductos.Add(producto);

                Console.WriteLine("¿quieres agregar otro producto?: s/n");
                respuesta = Console.ReadLine();

            } while (respuesta.Equals("s"));
            
            foreach(ProductoDto producto2 in Program.listaProductos) {

                Console.WriteLine(String.Concat("Producto: ", producto2.NombreProducto));
                Console.WriteLine(String.Concat("Cantidad: ", producto2.CantidadProducto.ToString()));
                Console.WriteLine(String.Concat("Fecha entrega: ", producto2.FechaEntrega.ToString()));
            
            
            }

        }


        private long crearId()
        {
            long nuevoId;
            int tamanioLista = Program.listaProductos.Count;

            if (tamanioLista > 0)
            {
                nuevoId = Program.listaProductos[tamanioLista - 1].IdProducto + 1;
            }
            else
            {
                nuevoId = 1;
            }
            return nuevoId;

        }


    }
}
