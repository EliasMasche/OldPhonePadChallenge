using OldPhonePadChallenge;

namespace OldPhonePadChallengeUnitTest;

[TestClass]
public sealed class UnitTests
{
    [TestMethod]
    public void ExpectedResultE()
    {
        Assert.AreEqual("E", PhonePad.OldPhonePad("33#"));
    }
    [TestMethod]
    public void ExpectedResultHello()
    {
        Assert.AreEqual("HELLO", PhonePad.OldPhonePad("4433555 555666#"));
    }
    [TestMethod]
    public void ExpectedResultB()
    {
        Assert.AreEqual("B", PhonePad.OldPhonePad("227*#"));
    }
    [TestMethod]
    public void ExpectedResultEmptyInput()
    {
        Assert.AreEqual("", PhonePad.OldPhonePad("#"));
    }
    [TestMethod]
    public void ExpectedResultInvalidInput()
    {
        Assert.AreEqual("Invalid input", PhonePad.OldPhonePad(""));
    }
    [TestMethod]
    public void ExpectedResultHelloMom()
    {
        Assert.AreEqual("HELLO MOM", PhonePad.OldPhonePad("4433555 555666 0 6 666 6#"));
    }
}
