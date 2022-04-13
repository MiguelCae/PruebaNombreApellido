using System;
using System.Collections.Generic;

namespace PruebaNombreApellido.Models
{
    public partial class Cuenta
    {
        public Cuenta()
        {
            CuentaClientes = new HashSet<CuentaCliente>();
            LogCuenta = new HashSet<LogCuentum>();
        }

        public Guid Id { get; set; }
        public int? Saldo { get; set; }
        public int IdTipoCuenta { get; set; }
        public int IdTransaccion { get; set; }

        public virtual TipoCuenta IdTipoCuentaNavigation { get; set; } = null!;
        public virtual Transaccion IdTransaccionNavigation { get; set; } = null!;
        public virtual ICollection<CuentaCliente> CuentaClientes { get; set; }
        public virtual ICollection<LogCuentum> LogCuenta { get; set; }
    }
}
