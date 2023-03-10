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
    [TestCase(5)]
    [TestCase(6)]
    public void ShouldReturnFalseForNonLeapYear(int year)
    {
        bool result = Program.IsLeapYear(year);
        Assert.That(result, Is.False);
    }
    
    [TestCase(0)]
    [TestCase(4)]
    [TestCase(8)]
    public void ShouldReturnTrueForMultiplesOfFour(int year)
    {
        bool result = Program.IsLeapYear(year);
        Assert.That(result, Is.True);
    }

    [TestCase(100)]
    [TestCase(200)]
    [TestCase(300)]
    [TestCase(500)]
    [TestCase(600)]
    public void ShouldReturnFalseForMultiplesOfOneHundred(int year)
    {
        bool result = Program.IsLeapYear(year);
        Assert.That(result, Is.False);
    }

    [TestCase(400)]
    [TestCase(800)]
    [TestCase(1200)]
    public void ShouldReturnTrueForMultiplesOfFourHundred(int year)
    {
        bool result = Program.IsLeapYear(year);
        Assert.That(result, Is.True);
    }

    [Test]
    public void ShouldReturnTrueForThePandemicYear()
    {
        bool result = Program.IsLeapYear(2020);
        Assert.That(result, Is.True);
    }
}