using System;
using Xunit;
using GenBalancedParenCombos;

namespace GenBalancedParensTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, new string[] { "()" })]
        [InlineData(2, new string[] { "()()", "(())"})]
        [InlineData(3, new string[] { "()()()", "(())()", "()(())", "((()))", "(()())"})]
        public void MatchesExamples(int n, string[] expected)
        {
            string[] gennedPerms = Program.GenBalancedParenCombos(n);
            foreach(string perm in gennedPerms)
            {
                Assert.True(Array.Exists(expected, expectedPerm => expectedPerm == perm));
            }
        }



        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(7)]
        public void DoesntGenDuplicates(int n)
        {
            string[] gennedPerms = Program.GenBalancedParenCombos(n);
            bool unique = true;
            foreach(string perm in gennedPerms)
            {
                if (Array.FindAll(gennedPerms, p => p == perm).Length != 1)
                {
                    unique = false;
                }
            }
            Assert.True(unique);
        }

        [Fact]
        public void BadArgumentThrows()
        {
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => Program.GenBalancedParenCombos(-1));
        }

    }
}
