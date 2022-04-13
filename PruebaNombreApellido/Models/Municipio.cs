using System;
using System.Collections.Generic;

namespace PruebaNombreApellido.Models
{
    public partial class Municipio
    {
        public Municipio()
        {
            Clientes = new HashSet<Cliente>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdDepartamento { get; set; }

        public virtual Departamento IdDepartamentoNavigation { get; set; } = null!;
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
