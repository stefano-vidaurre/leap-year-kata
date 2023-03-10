namespace LeapYear.Test;

public class LeapYearTest
{
    [SetUp]
    public void Setup()
    {
    }
    
    [TestCase(1)]
    [TestCase(2)]
    [TestCase(3)]
    public void ShouldReturnFalseForNonLeapYear(int year)
    {
        bool result = Program.IsLeapYear(year);
        Assert.That(result, Is.False);
    }
    
    [Test]
    public void ShouldReturnTrueForYear0()
    {
        bool result = Program.IsLeapYear(0);
        Assert.That(result, Is.True);
    }

    [Test]
    public void ShouldReturnTrueForYear4()
    {
        bool result = Program.IsLeapYear(4);
        Assert.That(result, Is.True);
    }

    [Test]
    public void ShouldReturnTrueForYear400()
    {
        bool result = Program.IsLeapYear(400);
        Assert.That(result, Is.True);
    }
}