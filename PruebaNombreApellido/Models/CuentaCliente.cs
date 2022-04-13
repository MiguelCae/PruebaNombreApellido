using System;
using System.Collections.Generic;

namespace PruebaNombreApellido.Models
{
    public partial class CuentaCliente
    {
        public Guid Id { get; set; }
        public Guid IdCliente { get; set; }
        public Guid IdCuenta { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; } = null!;
        public virtual Cuenta IdCuentaNavigation { get; set; } = null!;
    }
}
