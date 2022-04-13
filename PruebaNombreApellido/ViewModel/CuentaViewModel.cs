using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace PruebaNombreApellido.ViewModel
{
    public class CuentaViewModel
    {
        
        public Guid Id { get; set; }
        [Required]
        public int NumeroCuenta { get; set; }
        public int Saldo { get; set; }
        public int TipoCuenta { get; set; }
        public SelectList? ListTipoCuenta { get; set; }
        public int Transaccion { get; set; }
        public SelectList? ListTransaccion { get; set; }
        public Guid ClienteId { get; set; }
        public SelectList? ListCliente { get; set; }
    }
}
