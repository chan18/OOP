
/// <summary>
/// Inherit features from other classes
/// Create hierarchy
///     • Is-A relation
/// Improve reuse of code between parent and child class
/// Child class can extend functionality and attributes
/// </summary>
/// The parent car class also knowns base class
public class Car
{
    private int maxSpeed;

    public int MaxSpeed { get => maxSpeed; set => maxSpeed = value; }

    public void Drive()
    {
    }
}

/// <summary>
/// 
/// </summary>
/// derived class also knwon as child class
public class SportsCar : Car
{
    private bool isRoofOpen;
}