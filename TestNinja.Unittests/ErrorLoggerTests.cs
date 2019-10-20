using System;
using _3_5_TestingVoidMethods.Fundamentals;
using NUnit.Framework;

namespace TestNinja.Unittests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();

            logger.Log("a");

            Assert.That(logger.LastError, Is.EqualTo("a"));
        }
    }
}
