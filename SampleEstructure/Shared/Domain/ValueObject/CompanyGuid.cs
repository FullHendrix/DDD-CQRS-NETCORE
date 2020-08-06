using System;
using System.Collections.Generic;
using System.Text;
namespace SampleEstructure.Shared.Domain.ValueObject
{
    public class CompanyGuid
    {

        public Guid Value { get; set; }
        public CompanyGuid(Guid value)
        {

        }
        #region Guard
        private void IsValidCompanyGuid(Guid Value)
        {

        }
        #endregion
    }
}
