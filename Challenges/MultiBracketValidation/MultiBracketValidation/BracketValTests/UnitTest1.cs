using System;
using Xunit;
using MultiBracketValidation;

namespace BracketValTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("{}")]
        [InlineData("{}(){}")]
        [InlineData("()[[Extra Characters]]")]
        [InlineData("(){}[[]]")]
        [InlineData("{}{Code}[Fellows](())")]
        public void GoodPairsReturnTrue(string input)
        {
            Assert.True(Program.MultiBracketValidation(input));
        }

        [Theory]
        [InlineData("[({}])")]
        [InlineData("{(})")]
        [InlineData("[[(])]")]
        public void InvalidBracketOrder(string input)
        {
            Assert.False(Program.MultiBracketValidation(input));
        }

        [Theory]
        [InlineData("[[]")]
        [InlineData("(())(")]
        [InlineData(")(")]
        [InlineData("({{{}}}")]
        [InlineData("({[]})}")]
        public void UnpairedBracket(string input)
        {
            Assert.False(Program.MultiBracketValidation(input));
        }
    }
}
