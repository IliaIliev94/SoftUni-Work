using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    private Dummy target;
    private const int attackPoints = 10;
    private const int health = 20;
    private const int experience = 20;
    [SetUp]
    public void Initialized()
    {
        target = new Dummy(health, experience);
    }
    [Test]
    public void DummyLosesHealthIfAttacked()
    {
        target.TakeAttack(attackPoints);
        Assert.That(target.Health, Is.EqualTo(10), "Dummy doesn't lose health if attacked.");
    }
    [Test]
    public void DummyThrowsExceptionIfDead()
    {
        target.TakeAttack(health);

        Assert.That(() => target.TakeAttack(health), Throws
            .InvalidOperationException.With.Message
            .EqualTo("Dummy is dead."), "Dummy doesn't throw exception if dead.");
    }

    [Test]
    public void DeadDummyGivesXp()
    {
        target.TakeAttack(health);

        Assert.That(target.GiveExperience(), Is.EqualTo(experience), "Dead dummy doesn't give XP.");
    }

    [Test]
    public void AliveDummyDoesntGiveXp()
    {
        Assert.That(() => target.GiveExperience(), Throws
            .InvalidOperationException.With.Message
            .EqualTo("Target is not dead."), "Alive dummy gives xp.");
    }
}
