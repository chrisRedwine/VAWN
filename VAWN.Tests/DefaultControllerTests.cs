using System;
using NUnit.Framework;
using VAWN.Controllers;
using VAWN.Models;

namespace VAWN.Tests
{
    [TestFixture]
    public class DefaultControllerTests
    {
        // Arrange
        private DefaultController _controller;

        public DefaultControllerTests()
        {
            _controller = new DefaultController();
        }

        // Tests
        [Test]
        public void SampleTest()
        {
            Assert.Pass();
        }

        // GET api/default test
        [Test]
        public void GetHealthTest()
        {
            // Act
            string result = _controller.GetHealth();

            // Assert
            Assert.AreEqual("Default controller is up and running", result);
        }

        // GET api/default/user test
        [Test]
        public void GetUserTest()
        {
            // Act
            var result = _controller.GetUser();

            // Assert
            Assert.IsInstanceOf(typeof(DefaultModel), result);
            Assert.AreEqual(Environment.UserName, result.UserName);
            Assert.AreEqual(Environment.UserDomainName, result.UserDomainName);
            Assert.AreEqual(Environment.MachineName, result.MachineName);
            Assert.AreEqual(Environment.OSVersion.VersionString, result.OSVersionString);
        }

        //GET api/default/{name} test
        [Test]
        public void GetGreetingTest()
        {
            // Act
            string result = _controller.GetGreeting("Chris");

            // Assert
            Assert.AreEqual("Hello, Chris!", result);
        }
    }
}
