using System;
using Xunit;
using LinkedListChallenge.Classes;
using LinkedList_Merge;

namespace MergeTest
{
    public class UnitTest1
    {
        
        public int GetListLength (LinkedList list)
        {
            list.Current = list.Head;
            int counter = 0;
            while (list.Current != null)
            {
                counter++;
                list.Current = list.Current.Next;
            }
            list.Current = list.Head;
            return counter;
        }

        [Theory]
        [InlineData(0, 2)]
        [InlineData(3, 0)]
        [InlineData(4, 5)]
        [InlineData(5, 4)]
        [InlineData(100, 50)]
        public void CorrectMergedLength (int length1, int length2)
        {

            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();


            for (int i = 0; i < length1; i++)
            {
                list1.Append(i * 2);
            }

            for (int i = 0; i < length2; i++) {
                list2.Append(i * 2 + 1);
            }

            
            int lengthOfMergedList = GetListLength(Program.Merge(list1, list2));
            Assert.Equal(length1 + length2, lengthOfMergedList);
        }



        
    }
}
