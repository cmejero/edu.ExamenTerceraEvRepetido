using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace edu.ExamenTerceraEvRepetido.Dtos
{
    internal class VentaDto
    {

        long idVenta;
        double euros = 0.00;
        DateTime instanteCompra = DateTime.Now;

        public long IdVenta { get => idVenta; set => idVenta = value; }
        public double Euros { get => euros; set => euros = value; }
        public DateTime InstanteCompra { get => instanteCompra; set => instanteCompra = value; }

        public VentaDto() {
        }

       
    }
}
