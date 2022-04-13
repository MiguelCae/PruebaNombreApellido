using System;
using System.Collections.Generic;

namespace PruebaNombreApellido.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            CuentaClientes = new HashSet<CuentaCliente>();
        }

        public Guid Id { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? RazonSocial { get; set; }
        public string NumeroIdentificacion { get; set; } = null!;
        public string? Celular { get; set; }
        public string? Telefono { get; set; }
        public int IdTipoIdentificacion { get; set; }
        public int IdMunicipio { get; set; }

        public virtual Municipio IdMunicipioNavigation { get; set; } = null!;
        public virtual TipoIdentificacion IdTipoIdentificacionNavigation { get; set; } = null!;
        public virtual ICollection<CuentaCliente> CuentaClientes { get; set; }
    }
}
