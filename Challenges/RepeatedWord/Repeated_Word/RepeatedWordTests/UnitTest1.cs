using System;
using Xunit;
using Repeated_Word;

namespace RepeatedWordTests
{
    public class UnitTest1
    {
        [Fact]
        public void FindsRepeated()
        {
            string str = "The quick brown fox jumped over the lazy dog";
            Assert.Equal("the", Program.RepeatedWord(str));
        }

        [Fact]
        public void NoRepeatsNull()
        {
            string str = "None of these words are repeated";
            Assert.Null(Program.RepeatedWord(str));
        }

        [Fact]
        public void FindsFirstRepeated()
        {
            string str = "yup nope yup nope";
            Assert.Equal("yup", Program.RepeatedWord(str));
        }

        [Fact]
        public void FindsRepeatedIfLast()
        {
            string str = "The quick brown dog jumped over another dog";
            Assert.Equal("dog", Program.RepeatedWord(str));
        }
    }
}
