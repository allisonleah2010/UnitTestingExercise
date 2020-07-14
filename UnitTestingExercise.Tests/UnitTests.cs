using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(4, 5, 6, 15)]
        [InlineData(300,300,200,800)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var calculator = new UnitTestMethods();

            //Act
            var actual = calculator.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(50, 20, 30)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var calculator = new UnitTestMethods();

            //Act
            var actual = calculator.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 10, 100)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new UnitTestMethods();

            //Act
            var actual = calculator.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(100, 2, 50)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new UnitTestMethods();

            //Act
            var actual = calculator.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        //[Fact]
        //public void YourMethodName()
        //{
        //    //Arrange

        //    //Act

        //    //Assert

        //}

        //[Fact]
        //public void YourMethodName2()
        //{
        //    //Arrange

        //    //Act

        //    //Assert
        }
    }
}
