using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeria_Arte.Models
{
    internal class Exposicion
    {
        public int ID_Exposicion { get; set; }
        public int ID_Obra { get; set; }
        public DateTime Fecha { get; set; }
    }
}
