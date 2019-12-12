using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartidoLiberalWeb.Models
{
    public partial class Persona
    {
        public int idPersona { get; set; }
        public Nullable<int> idCategoria { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Edad { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
