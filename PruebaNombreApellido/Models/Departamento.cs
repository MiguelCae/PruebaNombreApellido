using System;
using System.Collections.Generic;

namespace PruebaNombreApellido.Models
{
    public partial class Departamento
    {
        public Departamento()
        {
            Municipios = new HashSet<Municipio>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<Municipio> Municipios { get; set; }
    }
}
