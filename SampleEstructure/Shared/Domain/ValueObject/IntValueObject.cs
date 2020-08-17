namespace SampleEstructure.Shared.Domain.ValueObject
{
    public class IntValueObject
    {
        public int Value { get; private set; }
        public IntValueObject(int value)
        {
            Value = value;
        }
    }
}