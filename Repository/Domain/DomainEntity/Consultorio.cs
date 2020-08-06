using System;
namespace Repository.Domain.DomainEntity
{
    public class Consultorio
    {
        public int IdConsultorio { get; set; }
        public int IdDistrito { get; set; }
        public string Consultorio1 { get; set; }
        public string Direccion { get; set; }
        public string Responsable { get; set; }
        public int IdEmpresa { get; set; }
        public string Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
    }
}