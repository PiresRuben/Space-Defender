using NUnit.Framework;
using SpaceDefender.Core;

[TestFixture]
public class EnemyTests
{
    private Enemy _enemy;

    [SetUp]
    public void SetUp()
    {
        _enemy = new Enemy(50, 100, EnemyType.Basic);
    }

    // T07
    [Test]
    public void TakeDamage_WhenKilled_SetsIsAliveToFalse()
    {
        _enemy.TakeDamage(50);

        Assert.IsFalse(_enemy.IsAlive);
    }

    // T08
    [Test]
    public void GetReward_WhenAlreadyDead_ReturnsZero()
    {
        _enemy.TakeDamage(100);

        Assert.AreEqual(0, _enemy.GetReward());
    }
}