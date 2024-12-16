
namespace OOADCsharp;

public class Car
{
    public string Make {get; set;}
    public string Model {get; set;}
    public float SteeringPositoin {get; set;}
    public float ThrottlePosition {get; set;}
    public float BreakPosition {get; set;}

    public bool Start()
    {
        return true;
    }

    public bool Stop()
    {
        return false;
    }
}