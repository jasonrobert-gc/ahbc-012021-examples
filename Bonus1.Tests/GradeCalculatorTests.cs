using System;
using Xunit;

namespace Bonus1.Tests
{
    public class GradeCalculatorTests
    {
        [Theory]
        [InlineData(100, LetterGrade.A)]
        [InlineData(95, LetterGrade.A)]
        [InlineData(88, LetterGrade.A)]
        [InlineData(87, LetterGrade.B)]
        [InlineData(86, LetterGrade.B)]
        [InlineData(80, LetterGrade.B)]
        [InlineData(79, LetterGrade.C)]
        [InlineData(73, LetterGrade.C)]
        [InlineData(67, LetterGrade.C)]
        [InlineData(66, LetterGrade.D)]
        [InlineData(65, LetterGrade.D)]
        [InlineData(60, LetterGrade.D)]
        [InlineData(59, LetterGrade.F)]
        [InlineData(31, LetterGrade.F)]
        [InlineData(0, LetterGrade.F)]
        public void CalculateReturnsApproprateGrade(int numberGrade, LetterGrade letterGrade)
        {
            // Arrange
            var sut = new GradeCalculator();

            // Act
            var result = sut.Calculate(numberGrade);

            // Assert
            Assert.Equal(letterGrade, result);
        }

        [Theory]
        [InlineData(1000)]
        [InlineData(-500)]
        [InlineData(101)]
        [InlineData(-1)]
        public void CalculateThrowsWithInvalidGrade(int numberGrade)
        {
            // Arrange
            var sut = new GradeCalculator();

            // Act / Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => sut.Calculate(numberGrade));
        }
    }
}
