using System;
using System.Collections.Generic;
using System.Text;

namespace SampleEstructure.Companies.Domain
{
    public class Company
    {
        public Guid GuidCompany { get; set; }
        public string CompanyNanme { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public Guid LegalRepresentativeGuid { get; set; }
        public string PagoActivo { get; set; }
        public string WebPersonalizada { get; set; }
        public string Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
    }
}
