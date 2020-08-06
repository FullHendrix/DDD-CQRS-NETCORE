using System;
namespace SampleEstructure.Shared.Domain
{
    public abstract class DomainModel
    {
        public bool Active { get; set; }
        public DateTime? CreacionDate { get; set; }
        public string CreacionUser { get; set; }
        public DateTime? ModificationDate { get; set; }
        public string ModificationUser { get; set; }
    }
}
