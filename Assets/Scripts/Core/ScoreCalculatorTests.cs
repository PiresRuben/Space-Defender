using NUnit.Framework;
using SpaceDefender.Core;

[TestFixture]
public class ScoreCalculatorTests
{
    private ScoreCalculator _calc;

    [SetUp]
    public void SetUp()
    {
        _calc = new ScoreCalculator();
    }

    // T09
    [Test]
    public void Calculate_WithZeroKills_ReturnsZero()
    {
        int result = _calc.Calculate(0, 60);

        Assert.AreEqual(0, result);
    }

    // T10
    [Test]
    public void ApplyCombo_With3Kills_IncreasesMultiplier()
    {
        _calc.ApplyCombo(3);

        Assert.Greater(_calc.Multiplier, 1.0f);
    }

    // T11
    [Test]
    public void ResetMultiplier_AfterCombo_SetsMultiplierToOne()
    {
        _calc.ApplyCombo(5);

        _calc.ResetMultiplier();

        Assert.AreEqual(1.0f, _calc.Multiplier);
    }

    // T12
    [Test]
    public void Calculate_AfterComboAndReset_UsesBaseMultiplier()
    {
        _calc.ApplyCombo(4);
        _calc.ResetMultiplier();

        int result = _calc.Calculate(5, 60);

        Assert.AreEqual(50, result);
    }
}