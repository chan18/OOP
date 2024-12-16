
/// <summary>
/// 1. Allow methods to execute differently
/// 2. virtual and override keywords in C#
/// 3. On objects of different types, we can invoke the same methods
/// </summary>
public class Car
{
    // applying method overriding.
    public virtual void Drive()
    { }
}

/// <summary>
/// 
/// </summary>
public class ElectricCar : Car
{
    public override void Drive()
    {
        base.Drive(); // base keyword used to call the base class function/method.
    }
}
