using System;
using System.Collections.Generic;
using System.Text;
namespace SampleEstructure.Profile.Domain
{
    public class ProfileModelDomain
    {
        //Propiedades en español, por consistencia con BD 
        public Guid ProfileGuid { get; set; }
        public string ProfileName { get; set; }
        public bool IsPacient { get; set; }
        public Guid CompanyGuid { get; set; }
        public bool Active { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid CreationUserGuid { get; set; }
        public DateTime? ModificationDate { get; set; }
        public Guid ModificationUserGuid { get; set; }
    }
}