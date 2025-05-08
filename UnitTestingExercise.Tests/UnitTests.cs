
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(4,6,7,17)]
        [InlineData(5, 7, 8, 20)]
        [InlineData(3, 3, 3, 9)]
        public void Add_Test(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var test = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9, 6, 3)]//Add test data <-------
        [InlineData(7, 5, 2)]
        [InlineData(8, 4, 4)]
        [InlineData(10,1,9)]
        
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var test = new Calculator();

            //Act
            var actual = test.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(3, 3, 9)]//Add test data <-------
        [InlineData(2, 8, 16)]
        [InlineData(5, 1, 5)]
        [InlineData(9, 5, 45)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test = new Calculator();

            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(actual, expected);

        }

        [Theory]
        [InlineData(4, 2, 2)]//Add test data <-------
        [InlineData(6, 2, 3)]
        [InlineData(20, 5, 4)]
        [InlineData(9, 3, 3)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var test = new Calculator();

            //Act
            var actual = test.Divide(num1, num2);

            //Assert
            Assert.Equal(actual, expected);

        }

    }
}
