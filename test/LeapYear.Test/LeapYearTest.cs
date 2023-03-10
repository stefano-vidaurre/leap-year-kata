namespace LeapYear.Test;

public class LeapYearTest
{
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    public void ShouldReturnFalseForYear1()
    {
        bool result = Program.IsLeapYear(1);
        Assert.That(result, Is.False);
    }

    [Test]
    public void ShouldReturnTrueForYear400()
    {
        bool result = Program.IsLeapYear(400);
        Assert.That(result, Is.True);
    }
}