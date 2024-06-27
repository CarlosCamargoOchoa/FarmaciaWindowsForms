using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaWindowsForms.Models
{
    public class PedidoEncabezadoModel
    {
        public int Id {  get; set; }   
        public List<SucursalModel> Sucursales { get; set; }
    }
}
