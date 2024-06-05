using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.ExamenTerceraEvRepetido.Dtos
{
    internal class ProductoDto
    {
        long idProducto;
        string nombreProducto = "aaaaa";
        int cantidadProducto = 0;
        double precio = 0;
        DateTime fechaEntrega = new DateTime(31, 1, 1999,0,0,0);

        public ProductoDto(long idProducto, string nombreProducto, int cantidadProducto, double precio, DateTime fechaEntrega)
        {
            this.idProducto = idProducto;
            this.nombreProducto = nombreProducto;
            this.cantidadProducto = cantidadProducto;
            this.precio = precio;
            this.fechaEntrega = fechaEntrega;
        }

        public long IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int CantidadProducto { get => cantidadProducto; set => cantidadProducto = value; }
        public double Precio { get => precio; set => precio = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }

        public ProductoDto()
        {

        }
    }
}
