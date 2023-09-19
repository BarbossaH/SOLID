using Moq;

namespace SOLID.Tests;

public class DeskFanTest
{
    [Fact]
    public void PowerLowerThanZero_OK()
    {
        var mock = new Mock<IPowerSupply>();
        mock.Setup(ps => ps.GetPower()).Returns(() => 0);
        var fan = new DeskFan(mock.Object);
        var expected = "Won't work";
        var actual = fan.Work();
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void PowerMoreThan200_OK()
    {
        var mock = new Mock<IPowerSupply>();
        mock.Setup(ps => ps.GetPower()).Returns(() => 220);
        var fan = new DeskFan(mock.Object);
        var expected = "Warning";
        var actual = fan.Work();
        Assert.Equal(expected, actual);
    }
    //class PowerSuppyLowerThanZero : IPowerSupply
    //{
    //    public int GetPower()
    //    {
    //        return 0;
    //    }
    //}

    //class PowerSuppyLowerThan200 : IPowerSupply
    //{
    //    public int GetPower()
    //    {
    //        return 220;
    //    }
    //}
}
