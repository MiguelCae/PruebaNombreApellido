using System;
using System.Collections.Generic;

namespace PruebaNombreApellido.Models
{
    public partial class TipoCuenta
    {
        public TipoCuenta()
        {
            Cuenta = new HashSet<Cuenta>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<Cuenta> Cuenta { get; set; }
    }
}
