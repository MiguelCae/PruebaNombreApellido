using System;
using System.Collections.Generic;

namespace PruebaNombreApellido.Models
{
    public partial class LogCuentum
    {
        public Guid Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public Guid IdCuenta { get; set; }
        public int IdTransaccion { get; set; }

        public virtual Cuenta IdCuentaNavigation { get; set; } = null!;
        public virtual Transaccion IdTransaccionNavigation { get; set; } = null!;
    }
}
