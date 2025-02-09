public class BaseClass
{
    public int BaseValue { get; protected set; }

    public BaseClass(int value)
    {
        BaseValue = value;
    }
}

public class DerivedClass : BaseClass
{
    public int DerivedValue { get; set; }

    public DerivedClass(int baseValue, int derivedValue) : base(baseValue)
    {
        // Access BaseValue here - it's safe because the base class constructor has run
        DerivedValue = baseValue + derivedValue; 
    }
} 