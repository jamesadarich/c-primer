using System;
using Xunit;

using Example;

namespace Example.Tests
{
    public class SampleUnitTests
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, 2 + 2);
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, 2 + 2);
        }
    }
}
