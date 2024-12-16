using OOADCsharp;

namespace OOPADTest;


[TestFixture]
public abstract class Given_a_Car 
{
    protected Car SUT {get; set;}

    [SetUp]
    public void Setup()
    {
        SUT = new Car();
    }
}