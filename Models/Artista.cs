using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeria_Arte.Models
{
    internal class Artista
    {
            public int ID_Artista { get; set; }
            public string Nombre { get; set; }
        public override string ToString()
        {
            return Nombre;
        }

    }
}
