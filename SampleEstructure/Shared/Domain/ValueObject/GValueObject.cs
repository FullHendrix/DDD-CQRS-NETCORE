namespace SampleEstructure.Shared.Domain.ValueObject
{
    public class GValueObject 
    {
        public string Guid { get; private set; }
        public GValueObject(string Value)
        {
            Guid = Value;
        }
    }
}
