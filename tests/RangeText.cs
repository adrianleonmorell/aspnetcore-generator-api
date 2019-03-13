using System;
using System.Linq;
using api.Controllers;
using Xunit;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var range = new Range { Count = 3 };
            var generated = range.Of(() => string.Empty);

            Assert.Equal(3, generated.Count());
        }
    }
}
