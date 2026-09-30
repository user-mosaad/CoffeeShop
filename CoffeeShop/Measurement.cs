class SensorReading(double value, string unit)
{
    public double Value { get; } = value;
    public string Unit { get; } = unit;

    public virtual string Display() => $"{Value}{Unit}";
}

class CalibratedReading(double value, string unit, double offset)
    : SensorReading(value, unit)
{
    public double Offset { get; } = offset;

    public override string Display() => $"{Value + Offset}{Unit} (offset {Offset:+0.0;-0.0})";
}
