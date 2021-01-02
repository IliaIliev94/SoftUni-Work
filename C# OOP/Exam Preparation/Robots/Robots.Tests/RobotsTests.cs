namespace Robots.Tests
{
    using NUnit.Framework;
    using System;

    public class RobotsTests
    {
        private RobotManager robotManager;
        private Robot robot;

        [SetUp]
        public void Initialize()
        {
            this.robotManager = new RobotManager(2);
            robot = new Robot("Pesho", 50);
        }

        [Test]
        public void CapacityThrowsExceptionIfNegative()
        {
            Assert.That(() => this.robotManager = new RobotManager(-1), Throws
                .ArgumentException.With.Message
                .EqualTo("Invalid capacity!"));
        }

        [Test]
        public void CapacityInitializesWithPositiveValue()
        {
            Assert.That(this.robotManager.Capacity, Is.EqualTo(2));
        }

        [Test]
        public void ThrowsExceptionIfTryToAddExistingRobot()
        {
            this.robotManager.Add(robot);
            Assert.That(() => this.robotManager.Add(new Robot("Pesho", 20)), Throws
                .InvalidOperationException.With.Message
                .EqualTo("There is already a robot with name Pesho!"));
        }

        [Test]
        public void CannotAddBeyondCapacity()
        {
            this.robotManager.Add(robot);
            this.robotManager.Add(new Robot("Gosho", 50));
            Assert.That(() => this.robotManager.Add(new Robot("Misho", 50)), Throws
                .InvalidOperationException.With.Message.EqualTo("Not enough capacity!"));
        }

        [Test]
        public void AddsCorrectNumberOfRobots()
        {
            this.robotManager.Add(robot);
            this.robotManager.Add(new Robot("Gosho", 50));
            Assert.That(this.robotManager.Count, Is.EqualTo(2));
        }

        [Test]
        public void CannotRemoveNonExistingRobot()
        {
            this.robotManager.Add(robot);
            Assert.That(() => this.robotManager.Remove("Gosho"), Throws
                .InvalidOperationException.With.Message
                .EqualTo("Robot with the name Gosho doesn't exist!"));
        }

        [Test]
        public void RemoveRobot()
        {
            this.robotManager.Add(robot);
            this.robotManager.Remove("Pesho");
            Assert.That(this.robotManager.Count, Is.EqualTo(0));
        }

        [Test]
        public void CannotWorkNonExistingRobot()
        {
            this.robotManager.Add(robot);
            Assert.That(() => this.robotManager.Work("Gosho", "Work", 10), Throws
                .InvalidOperationException.With.Message
                .EqualTo("Robot with the name Gosho doesn't exist!"));
        }

        [Test]
        public void CannotMakeRobotWorkMoreThanBatteryAllows()
        {
            this.robotManager.Add(robot);
            Assert.That(() => this.robotManager.Work("Pesho", "Work", 60), Throws
                .InvalidOperationException.With.Message.EqualTo("Pesho doesn't have enough battery!"));
        }
        [Test]
        public void BatteryDropsAfterWork()
        {
            this.robotManager.Add(robot);
            this.robotManager.Work("Pesho", "Work", 40);
            Assert.That(robot.Battery, Is.EqualTo(10));
        }

        [Test]
        public void CannotChargeInexistingRobot()
        {
            this.robotManager.Add(robot);
            Assert.That(() => this.robotManager.Charge("Gosho"), Throws
                .InvalidOperationException.With.Message
                .EqualTo("Robot with the name Gosho doesn't exist!"));
        }

        [Test]
        public void ChargesExistingRobot()
        {
            this.robotManager.Add(robot);
            this.robotManager.Work("Pesho", "Work", 20);
            this.robotManager.Charge("Pesho");
            Assert.That(robot.Battery, Is.EqualTo(50));
        }
    }
}
