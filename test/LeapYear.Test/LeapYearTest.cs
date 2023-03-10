namespace LeapYear.Test;

public class LeapYearTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldReturnTrueWithTheYear400()
    {
        bool result = Program.IsLeapYear(400);
        Assert.IsTrue(result);
    }
}