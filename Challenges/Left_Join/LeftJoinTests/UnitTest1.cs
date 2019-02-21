using System;
using Xunit;
using Left_Join;
using HashTables;
using System.Collections.Generic;

namespace LeftJoinTests
{
    public class UnitTest1
    {
        [Fact]
        public void NoCommonKeys()
        {
            HashTable left = new HashTable();
            left.Add("light", "bright");
            HashTable right = new HashTable();
            right.Add("nope", "yup");
            List<object[]> expected = new List<object[]>();
            expected.Add(new object[] { "light", "bright", null });
            Assert.Equal(expected, Program.LeftJoin(left, right));

        }

        [Fact]
        public void AddsAllCommons()
        {
            HashTable left = new HashTable();
            left.Add("light", "bright");
            left.Add("nope", "nah");
            HashTable right = new HashTable();
            right.Add("nope", "yup");
            right.Add("light", "dark");
            List<object[]> expected = new List<object[]>();
            expected.Add(new object[] { "light", "bright", "dark" });
            expected.Add(new object[] { "nope", "nah", "yup" });
            Assert.Equal(expected, Program.LeftJoin(left, right));

        }

        [Fact]
        public void AddsOnlyCommons()
        {
            HashTable left = new HashTable();
            left.Add("light", "bright");
            left.Add("nope", "nah");
            left.Add("bad", "evil");
            HashTable right = new HashTable();
            right.Add("nope", "yup");
            right.Add("light", "dark");
            right.Add("good", "evil");
            List<object[]> expected = new List<object[]>();
            expected.Add(new object[] { "bad", "evil", null });
            expected.Add(new object[] { "light", "bright", "dark" });
            expected.Add(new object[] { "nope", "nah", "yup" });
            Assert.Equal(expected, Program.LeftJoin(left, right));
        }

        [Fact]
        public void NullTableThrows()
        {
            HashTable left = new HashTable();
            left.Add("light", "bright");
            left.Add("nope", "nah");
            left.Add("bad", "evil");
            Assert.ThrowsAny<ArgumentNullException>(() => Program.LeftJoin(left, null));
        }

        [Fact]
        public void EmptyLeft()
        {
            HashTable left = new HashTable();
            HashTable right = new HashTable();
            right.Add("nope", "yup");
            right.Add("light", "dark");
            Assert.Equal(new List<object[]>(), Program.LeftJoin(left, right));
        }

        [Fact]
        public void EmptyRight()
        {
            HashTable left = new HashTable();
            left.Add("light", "bright");
            HashTable right = new HashTable();
            List<object[]> expected = new List<object[]>();
            expected.Add(new object[] { "light", "bright", null });
            Assert.Equal(expected, Program.LeftJoin(left, right));
        }
    }
}
