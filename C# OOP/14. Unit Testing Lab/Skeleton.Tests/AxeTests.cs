using NUnit.Framework;


[TestFixture]
public class AxeTests
{
    private Axe axe;
    private Dummy target;
    private int durability;
    private int attack;
    [SetUp]
    public void Initialize()
    {
        durability = 10;
        attack = 10;
        this.axe = new Axe(durability, attack);
        target = new Dummy(200, 200);

    }
    [Test]
    public void DurabilityDoesDecrease()
    {
        axe.Attack(target);
        Assert.That(axe.DurabilityPoints, Is.EqualTo(9), "Axe does not lose durability.");
    }
    [Test]
    public void AttacksWithBrokenWeapon()
    {
        for(int i = 0; i < durability; i++)
        {
            axe.Attack(target);
        }
        Assert.That(() => axe.Attack(target), Throws
            .InvalidOperationException.With.Message
            .EqualTo("Axe is broken."), "Can attack with broken weapon.");
    }
}