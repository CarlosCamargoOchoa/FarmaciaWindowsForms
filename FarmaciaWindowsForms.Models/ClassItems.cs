using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaWindowsForms.Models
{
    public  class ClassItems
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public bool Selectable { get; set; }

        public ClassItems(string name, int value, bool selectable = true)
        {
            Name = name;
            Value = value;
            Selectable = selectable;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
