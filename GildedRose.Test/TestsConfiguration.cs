using System;
using NUnit.Framework;

namespace GildedRose.Test
{
    [SetUpFixture]
    public class TestsConfiguration
    {
        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            Environment.CurrentDirectory = TestContext.CurrentContext.TestDirectory;
        }
    }
}