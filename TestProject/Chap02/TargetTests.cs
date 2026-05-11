using TargetProject.Chap02;

namespace TestProject.Chap02;

[TestClass]
public class GreetingServiceTests
{
    [TestMethod("テストケース1:朝の時間帯(7～11時)ではGood Morningを返す")]
    public void Greet_ShouldReturnGoodMorning_WhenHourIsMorning()
    {
        var greet = new GreetingService();
        var result = greet.Greet(8);
        Assert.AreEqual("Good Morning", result);
    }
    [TestMethod("テストケース2:昼の時間帯(12~17時)ではHelloを返す")]
    public void Greet_ShouldReturnHello_WhenHourIsLunch()
    {
        var greet = new GreetingService();
        var result = greet.Greet(12);
        Assert.AreEqual("Hello", result);
    }
    [TestMethod("テストケース3:夕方の時間帯(18~20時)ではGood Eveningを返す")]
    public void Greet_ShouldReturnGoodEvening_WhenHourIsEvening()
    {
        var greet = new GreetingService();
        var result = greet.Greet(18);
        Assert.AreEqual("Good Evening", result);
    }
    [TestMethod("テストケース4:夜の時間帯(0~6,21~23時)ではGood Nightを返す")]
    public void Greet_ShouldReturnGoodNight_WhenHourIsNight()
    {
        var greet = new GreetingService();
        var result = greet.Greet(23);
        Assert.AreEqual("Good Night", result);
    }
}
