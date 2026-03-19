using NUnit.Framework;
using SpaceDefender.Core;

[TestFixture]
public class PlayerTests
{
    private Player _player;

    [SetUp]
    public void SetUp()
    {
        _player = new Player();
    }

    // T01
    [Test]
    public void TakeDamage_WithFatalDamage_SetsHealthToZero()
    {
        _player.TakeDamage(150);

        Assert.AreEqual(0, _player.Health);
    }

    // T02
    [Test]
    public void TakeDamage_WithNegativeAmount_DoesNotChangeHealth()
    {
        _player.TakeDamage(-10);

        Assert.AreEqual(100, _player.Health);
    }

    // T03
    [Test]
    public void Heal_WhenHealthBelow100_IncreasesHealth()
    {
        _player.TakeDamage(30);

        _player.Heal(20);

        Assert.AreEqual(90, _player.Health);
    }

    // T04
    [Test]
    public void Heal_WhenAlreadyFullHealth_DoesNotExceed100()
    {
        _player.TakeDamage(10);

        _player.Heal(50);

        Assert.AreEqual(100, _player.Health);
    }

    // T05
    [Test]
    public void IsAlive_WhenHealthIsZero_ReturnsFalse()
    {
        _player.TakeDamage(100);

        Assert.IsFalse(_player.IsAlive);
    }

    // T06
    [Test]
    public void LoseLife_WhenLastLife_IsAliveReturnsFalse()
    {
        _player.LoseLife();
        _player.LoseLife();
        _player.LoseLife();

        Assert.IsFalse(_player.IsAlive);
    }
}