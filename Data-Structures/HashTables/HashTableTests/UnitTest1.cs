using System;
using Xunit;
using HashTables;
using System.Collections.Generic;

namespace HashTableTests
{
    public class UnitTest1
    {
        [Fact]
        public void ValueExists()
        {
            HashTable table = new HashTable();
            table.Add("Amanda", "IsGreat");
            bool contains = false;
            foreach(List<KeyValuePair<string, object>> bucket in table.BackingArray)
            {
                if (bucket != null)
                {
                    foreach(KeyValuePair<string, object> kvp in bucket)
                    {
                        if ((string)kvp.Value == "IsGreat")
                            contains = true;
                    }
                }
            }
            Assert.True(contains);
        }

        [Fact]
        public void KeyGetsValue()
        {
            HashTable table = new HashTable();
            table.Add("Amanda", "IsGreat");
            Assert.Equal("IsGreat", table.Get("Amanda"));
        }

        [Fact]
        public void Sadness()
        {
            HashTable table = new HashTable();
            table.Add("Amanda", "IsGreat");
            Assert.Null(table.Get("Vinicio"));
        }

        [Fact]
        public void HandlesCollision()
        {
            HashTable table = new HashTable();
            table.Add("cba", "backwards");
            table.Add("abc", "forwards");
            Assert.Equal(table.Hash("abc"), table.Hash("cba"));
        }

        [Fact]
        public void CanGetCollided()
        {
            HashTable table = new HashTable();
            table.Add("cba", "backwards");
            table.Add("abc", "forwards");
            Assert.Equal("backwards", table.Get("cba"));
        }

        [Theory]
        [InlineData("ayy lmao")]
        [InlineData("asldkfjalsdkjfasdhfqwieoruyowieuyraosdhfaskljdhfaslkdjfhalskdhfdsafhvbbvxb")]
        [InlineData("Utilize the Single-responsibility principle: any methods you write should be clean, reusable, abstract component parts to the whole challenge. You will be given feedback and marked down if you attempt to define a large, complex algorithm in one function definition.")]
        public void HashesInRange(string key)
        {
            HashTable table = new HashTable();
            int index = table.Hash(key);
            Assert.True(index >= 0 && index < 1024);
            

        }
    }
}
