using System;
using Xunit;

namespace Day17.Tests
{
    public class TemperatureConverterTests
    {
        [Fact]
        public void ConvertsToCelsius_32()
        {
            // Arrange
            var converter = new TemperatureConverter();

            // Act
            var result = converter.Convert(32, "C");

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void ConvertsToCelsius_68()
        {
            // Arrange
            var converter = new TemperatureConverter();

            // Act
            var result = converter.Convert(68, "C");

            // Assert
            Assert.Equal(20, result);
        }

        [Theory]
        [InlineData(-40, -40)]
        [InlineData(100, 212)]
        public void ConvertsToFahrenheit(int source, int expected)
        {
            // Arrange
            var converter = new TemperatureConverter();

            // Act
            var result = converter.Convert(source, "F");

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
