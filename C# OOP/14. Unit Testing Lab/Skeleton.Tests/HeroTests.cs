using NUnit.Framework;
using Skeleton.Contracts;
using Skeleton.TestClasses;
using Moq;

[TestFixture]
public class HeroTests
{

    Hero hero;
    ITarget target;
    [SetUp]
    public void Initialize()
    {
        Mock<IWeapon> mockedWeapon = new Mock<IWeapon>();
        Mock <ITarget>mockedTarget = new Mock<ITarget>();
        mockedWeapon.Setup(p => p.AttackPoints).Returns(0);
        mockedTarget.Setup(p => p.IsDead()).Returns(true);
        mockedTarget.Setup(p => p.GiveExperience()).Returns(20);
        IWeapon weapon = mockedWeapon.Object;
        hero = new Hero("Ilia", weapon);
        target = mockedTarget.Object;
    }
    [Test]
    public void HeroGainsXPWhenTargetDies()
    {
        hero.Attack(target);
        Assert.That(hero.Experience, 
            Is.EqualTo(20), 
            "Hero does not get experience when target dies.");
    }
}