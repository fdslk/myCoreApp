using Moq;
using Prime.Services;
using Xunit;

namespace Prime.UnitTests.Services
{
    public class MockOperationTest
    {
        [Fact]
        public void Should_return_2_when_2_add_2()
        {
            var mock = new Mock<OpertionService>();
            mock.Setup(x => x.add(2, 2)).Returns(4);
            Assert.Equal(4, mock.Object.add(2, 2));
        }
    }
}