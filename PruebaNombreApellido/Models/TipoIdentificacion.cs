using System;
using System.Collections.Generic;

namespace PruebaNombreApellido.Models
{
    public partial class TipoIdentificacion
    {
        public TipoIdentificacion()
        {
            Clientes = new HashSet<Cliente>();
        }

        public int IdTipoIdentificacion { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
