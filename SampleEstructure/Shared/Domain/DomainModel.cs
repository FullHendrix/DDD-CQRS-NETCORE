using SampleEstructure.Shared.Domain.ValueObject;
using System;
namespace SampleEstructure.Shared.Domain
{
    public abstract class DomainModel
    {
        public bool Active { get; set; }
        public DateTime? CreationDate { get; set; }
        public Email CreationUser { get; set; }
        public DateTime? ModificationDate { get; set; }
        public Email ModificationUser { get; set; }
    }
}