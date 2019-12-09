using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartidoLiberalWeb.Models
{
    public class Categoria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Categoria()
        {
            this.Persona = new HashSet<Persona>();
        }

        public int idCategoria { get; set; }
        public string nombre { get; set; }
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Persona> Persona { get; set; }
    }
}
