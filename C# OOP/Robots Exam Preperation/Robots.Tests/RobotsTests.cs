using NUnit.Framework;

namespace Robots.Tests
{
    using System;

    public class RobotsTests
    {
        private Robot myRobot;
        RobotManager myRobotManager;
        [SetUp]
        public void Initialize()
        {
            myRobot = new Robot("Pesho", 50);
            myRobotManager = new RobotManager(3);
        }

        [Test]
        public void ThrowsErrorIfInitializedWithNegativeCapacity()
        {
            Assert.That(() => myRobotManager = new RobotManager(-3), Throws
                .ArgumentException.With.Message.EqualTo("Invalid capacity!"));
        }

        [Test]
        public void InitializesCapacity()
        {
            Assert.That(myRobotManager.Capacity, Is.EqualTo(3));
        }

        [Test]
        public void InitializesRobotsList()
        {
            Assert.That(myRobotManager.Count, Is.EqualTo(0));
        }

        [Test]
        public void AddsNewRobots()
        {
            myRobotManager.Add(myRobot);
            Assert.That(myRobotManager.Count, Is.EqualTo(1));
        }

        [Test]
        public void ThrowsExceptionIfRobotIsAddedMoreThanOnce()
        {
            myRobotManager.Add(myRobot);
            Assert.That(() => myRobotManager.Add(myRobot), Throws
                .InvalidOperationException.With.Message.EqualTo("There is already a robot with name Pesho!"));
        }

        [Test]
        public void ThrowsExceptionIfCapacityIsReached()
        {
            myRobotManager.Add(myRobot);
            myRobotManager.Add(new Robot("Test", 30));
            myRobotManager.Add(new Robot("Test 2", 40));
            Assert.That(() => myRobotManager.Add(new Robot("Test 3", 30)), Throws
                .InvalidOperationException.With.Message.EqualTo("Not enough capacity!"));
        }
        [Test]
        public void RemovesRobotSuccessfuly()
        {
            myRobotManager.Add(myRobot);
            myRobotManager.Remove(myRobot.Name);
            Assert.That(() => myRobotManager.Count, Is.EqualTo(0));
        }

        [Test]
        public void ThrowsErrorIfNonExistingRobotIsRemoved()
        {
            Assert.That(() => myRobotManager.Remove("Ivan"), Throws
                .InvalidOperationException.With.Message.EqualTo("Robot with the name Ivan doesn't exist!"));
        }
        
        [Test]
        public void WorkFunctionWorksCorrectly()
        {
            myRobotManager.Add(myRobot);
            myRobotManager.Work("Pesho", "Clean", 10);
            Assert.That(myRobot.Battery, Is.EqualTo(40));
        }
        
        [Test]
        public void NonExistingRobotCantWork()
        {
            
            Assert.That(() => myRobotManager.Work("Pesho", "Clean", 10), Throws
                .InvalidOperationException.With.Message.EqualTo("Robot with the name Pesho doesn't exist!"));
        }

        [Test]
        public void RobotCantWorkIfHeDoesntHaveEnoughBattery()
        {
            myRobotManager.Add(myRobot);
            
            Assert.That(() => myRobotManager.Work("Pesho", "Clean", 70), Throws
                .InvalidOperationException.With.Message.EqualTo("Pesho doesn't have enough battery!"));
        }
        
        [Test]
        public void ChargeFunctionWorks()
        {
            myRobotManager.Add(myRobot);
            myRobotManager.Work("Pesho", "Clean", 10);
            myRobotManager.Charge("Pesho");
            Assert.That(myRobot.Battery, Is.EqualTo(myRobot.MaximumBattery));
        }
        
        [Test]
        public void ThrowsErrorIfNonExistingRobotIsCharged()
        {
            Assert.That(() => myRobotManager.Charge("Pesho"), Throws
                .InvalidOperationException.With.Message.EqualTo("Robot with the name Pesho doesn't exist!"));
        }
    }
}
