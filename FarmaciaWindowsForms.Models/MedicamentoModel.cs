using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaWindowsForms.Models
{
    public class MedicamentoModel
    {
        public int Id {  get; set; }
        public string Descripcion { get; set; }
        public TipoMedicamentoModel TipoMedicamento { get; set; }
        public int Cantidad { get; set; }
    }
}
