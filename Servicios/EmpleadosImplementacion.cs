using edu.ExamenTerceraEvRepetido.Controladores;
using edu.ExamenTerceraEvRepetido.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.ExamenTerceraEvRepetido.Servicios
{
    internal class EmpleadosImplementacion : EmpleadosInterfaz
    {

        public void agregarVenta()
        {

            VentaDto venta = new VentaDto();    
            venta.IdVenta = crearId();
            Console.WriteLine("Introduzca el importe de la venta");
            venta.Euros = Convert.ToDouble(Console.ReadLine());
            DateTime fechaActual = DateTime.Now;
            string fechaFormateada = fechaActual.ToString("dd-MM-yyyy");
            DateTime fechaF = DateTime.Parse(fechaFormateada);
            venta.InstanteCompra = fechaF;

            Program.listaVentas.Add(venta);
            
            Console.WriteLine(fechaF.ToShortDateString());
            


        }

        public void calculoTVentasDiarias()
        {

            Console.WriteLine("Introduca la fecha de la venta en formato: dd-MM-yyyy");
            string fecha = Console.ReadLine();
            DateTime fechaDate = DateTime.Parse(fecha);
            string fechaFormateada = fechaDate.ToString("dd-MM-yyyy");
            DateTime fechaActualizada = DateTime.Parse(fechaFormateada);

            TimeSpan tiempoTranscurrido;
            Console.WriteLine(fechaActualizada.ToString());
            double aux = 0.00;
            List<VentaDto> listaAux = new List<VentaDto>();

            foreach(VentaDto venta in Program.listaVentas)
            {
                if(venta.InstanteCompra.ToShortDateString == fechaActualizada.ToShortDateString)
                {
                    aux = aux + venta.Euros;


                    listaAux.Add(venta);


                }

            }

            
           

                tiempoTranscurrido = listaAux[0].InstanteCompra - listaAux[-1].InstanteCompra;

            

            Console.WriteLine("Total de ventas: " +aux);
            string texto = "Tiempo transcurrido";
           Console.WriteLine(String.Concat(texto,tiempoTranscurrido.ToString()));







        }

        private long crearId()
        {
            long nuevoId;
            int tamanioLista = Program.listaProductos.Count;

            if(tamanioLista > 0)
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
