using OOADCsharp;

namespace Test.CarTest;


[TestFixture]
public abstract class CarTestBase 
{
    protected Car SUT {get; set;}

    [SetUp]
    public void Setup()
    {
        SUT = new Car();
    }
}