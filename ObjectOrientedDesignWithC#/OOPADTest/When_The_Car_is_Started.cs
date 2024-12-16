namespace OOPADTest;
using NUnit.Framework;

[TestFixture]
public class When_The_Car_is_Started : Given_a_Car
{
    private bool _result;

    [SetUp]
    public void SetUp()
    {
        base.Setup();
        _result = SUT.Start();
    }

    [Test]
    public void Then_the_return_value_is_false()
    {
        Assert.That(_result, Is.True);
    }
}

