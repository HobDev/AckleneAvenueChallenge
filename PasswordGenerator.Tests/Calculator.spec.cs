using System;
using Xunit;

namespace PasswordGenerator.Tests
{
    public class CalculatorTest
    {
// Given the user input is empty when calculating the sum then it should return zero.        
        [Fact]
        public void itShouldReturnZeroWhenInputIsEmpty()
        {
            var calc =  new Calculator();
            var res = calc.Add();
            Assert.Equal(res, 0);
        }
// Given the user input is one number when calculating the sum then it should return the same number. (example "3" should equal 3)            
        [Fact]
        public void whenUserInputIsOneNumberItShouldReturnSameNumber()
        {
            var calc =  new Calculator();
            var res = calc.Add("3");
            Assert.Equal(res, 3);
        }

        // Given the user input is two numbers when calculating the sum then it should return the sum of those numbers. (example "1,2" should equal 3)
        [Fact]
        public void whenUserInputIsTwoNumbersItShouldReturnSumOfThoseNumbers()
        {
            var calc =  new Calculator();
            var res = calc.Add("1,2");
            Assert.Equal(res, 3);
        }
// Given the user input is an unknown amount of numbers when calculating the sum then it should return the sum of all the numbers. (example "1,2,3" should equal 6)        
        [Fact]
        public void whenInputIsUnknowAmountOfNumbersReturnTheSumOfAllNumbers()
        {
            var calc =  new Calculator();
            var res = calc.Add("1,2,3");
            Assert.Equal(res, 6);
        }



// Given the user input is multiple numbers with a custom single-character delimiter when calculating the sum then it should return the sum of all the numbers. (example “//;\n1;2” should return 3)        


    }
}

// Given the user input is multiple numbers with new line and comma delimiters when calculating the sum then it should return the sum of all the numbers. (example "1\n2,3" should equal 6)

// Given the user input contains one negative number when calculating the sum then it should throw an exception "negatives not allowed: x" (where x is the negative number).
// Given the user input contains multiple negative numbers mixed with positive numbers when calculating the sum then it should throw an exception "negatives not allowed: x, y, z" (where x, y, z are only the negative numbers).
// Given the user input contains numbers larger than 1000 when calculating the sum it should only sum the numbers less than 1001. (example 2 + 1001 = 2)
// Given the user input is multiple numbers with a custom multi-character delimiter when calculating the sum then it should return the sum of all the numbers. (example: “//[]\n12***3” should return 6)
// Given the user input is multiple numbers with multiple custom delimiters when calculating the sum then it should return the sum of all the numbers. (example “//[][%]\n12%3” should return 6)
