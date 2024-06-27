using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaWindowsForms.Models
{
    public class PedidoDetalleModel
    {

        public int Id { get; set; }
        public PedidoEncabezadoModel Encabezado { get; set; }
        public List<MedicamentoModel> Medicamentos {  get; set; }
    }
}
