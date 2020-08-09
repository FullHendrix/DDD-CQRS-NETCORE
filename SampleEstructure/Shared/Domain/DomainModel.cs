using SampleEstructure.Shared.Domain.ValueObject;
using System;
namespace SampleEstructure.Shared.Domain
{
    public abstract class DomainModel
    {
        public bool Active { get; set; }
        public DateTime? CreacionDate { get; set; }
        public StringValueObject CreacionUser { get; set; }
        public DateTime? ModificationDate { get; set; }
        public string ModificationUser { get; set; }
    }
}
