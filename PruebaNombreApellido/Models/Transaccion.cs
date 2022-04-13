using System;
using System.Collections.Generic;

namespace PruebaNombreApellido.Models
{
    public partial class Transaccion
    {
        public Transaccion()
        {
            Cuenta = new HashSet<Cuenta>();
            LogCuenta = new HashSet<LogCuentum>();
        }

        public int Id { get; set; }
        public string? Nombre { get; set; }

        public virtual ICollection<Cuenta> Cuenta { get; set; }
        public virtual ICollection<LogCuentum> LogCuenta { get; set; }
    }
}
