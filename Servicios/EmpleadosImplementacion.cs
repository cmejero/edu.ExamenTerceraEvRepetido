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
            

            Program.listaVentas.Add(venta);
            
            
            


        }

        public void calculoTVentasDiarias()
        {

            Console.WriteLine("Introduca la fecha de la venta en formato: dd-MM-yyyy");
            string fecha = Console.ReadLine();
            DateTime fechaDate = DateTime.Parse(fecha);
            string fechaFormateada = fechaDate.ToString("dd-MM-yyyy");
            DateTime fechaActualizada = DateTime.Parse(fechaFormateada);

            
            
            double aux = 0.00;
            List<VentaDto> listaAux = new List<VentaDto>();

            foreach(VentaDto venta in Program.listaVentas)
            {
                if(venta.InstanteCompra.ToShortDateString() == fechaActualizada.ToShortDateString())
                {

                    listaAux.Add(venta);
                    aux = aux + venta.Euros;


                    


                }

            }



            if (listaAux.Count > 1)
            {
                TimeSpan tiempoTranscurrido = listaAux[listaAux.Count - 1].InstanteCompra - listaAux[0].InstanteCompra;



                Console.WriteLine("Total de ventas: " + aux);
                string texto = "Tiempo transcurrido: ";
                Console.WriteLine(String.Concat(texto, tiempoTranscurrido));
            }






        }

        private long crearId()
        {
            long nuevoId;
            int tamanioLista = Program.listaVentas.Count;

            if(tamanioLista > 0)
            {
                nuevoId = Program.listaVentas[tamanioLista - 1].IdVenta + 1;
            }
            else
            {
                nuevoId = 1;
            }
            return nuevoId;

        }
    }
}
