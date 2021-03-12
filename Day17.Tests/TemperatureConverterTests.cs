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

        [Fact]
        public void ConvertsToFahrenheit_100()
        {
            // Arrange
            var converter = new TemperatureConverter();

            // Act
            var result = converter.Convert(100, "F");

            // Assert
            Assert.Equal(212, result);
        }

        [Fact]
        public void ConvertsToFahrenheit_40()
        {
            // Arrange
            var converter = new TemperatureConverter();

            // Act
            var result = converter.Convert(-40, "F");

            // Assert
            Assert.Equal(-40, result);
        }
    }
}
