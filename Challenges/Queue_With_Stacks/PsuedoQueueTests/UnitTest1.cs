using System;
using Xunit;
using Queue_With_Stacks.Classes;
using StacksAndQueues.Classes;


namespace PseudoQueueTests
{
    public class UnitTest1
    {
        [Fact]
        public void PeeksFirstIn() 
        {
            PseudoQueue pQ = new PseudoQueue();
            Stack stack = new Stack();

            stack.Push(new Node(1));
            stack.Push(new Node(2));
            pQ.In = stack;

            Assert.Equal(1, pQ.Peek().Value);
        }

        [Fact]
        public void PeekNull()
        {
            PseudoQueue pQ = new PseudoQueue();
            Queue trueQ = new Queue();
            Assert.Equal(trueQ.Peek(), pQ.Peek());
        }

        [Fact]
        public void PeeksLikeQueue()
        {
            PseudoQueue pQ = new PseudoQueue();
            Queue trueQ = new Queue();
            Stack stack = new Stack();

            stack.Push(new Node(1));
            stack.Push(new Node(2));
            pQ.In = stack;

            trueQ.Enqueue(new Node(1));
            trueQ.Enqueue(new Node(2));

            Assert.Equal(trueQ.Peek().Value, pQ.Peek().Value);
        }

        [Fact]
        public void EnQsNull()
        {
            PseudoQueue pQ = new PseudoQueue();
            Queue trueQ = new Queue();
            trueQ.Enqueue(new Node(1));
            pQ.Enqueue(new Node(1));
            Assert.Equal(trueQ.Peek().Value, pQ.Peek().Value);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 4, 8, 7, 1 })]
        public void EnQsFIFO(int[] testVals)
        {
            PseudoQueue pQ = new PseudoQueue();
            Queue trueQ = new Queue();
            foreach(int val in testVals)
            {
                pQ.Enqueue(new Node(val));
                trueQ.Enqueue(new Node(val));
            }
            Assert.Equal(trueQ.Peek().Value, pQ.Peek().Value);
        }

        [Fact]
        public void DequeuesFIFO()
        {
            PseudoQueue pQ = new PseudoQueue();
            Stack stack = new Stack();

            stack.Push(new Node(1));
            stack.Push(new Node(2));
            pQ.In = stack;

            Assert.Equal(1, pQ.Dequeue().Value);
        }

        [Fact]
        public void DequeuesLILO()
        {
            PseudoQueue pQ = new PseudoQueue();
            Stack stack = new Stack();

            stack.Push(new Node(1));
            stack.Push(new Node(2));
            stack.Push(new Node(3));
            pQ.In = stack;
            pQ.Dequeue();
            pQ.Dequeue();
            
            Assert.Equal(3, pQ.Dequeue().Value);
        }
  
        [Fact]
        public void DequeueNull()
        {
            PseudoQueue pQ = new PseudoQueue();
            Assert.Null(pQ.Dequeue());
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 9, 8, 7, 6 })]
        [InlineData(new int[] { 55 })]
        public void EnqsInCorrectOrder(int[] testVals)
        {
            PseudoQueue pQ = new PseudoQueue();
            foreach (int val in testVals)
            {
                pQ.Enqueue(new Node(val));
            }
            int[] pQVals = new int[testVals.Length];
            int i = 0;
            while (pQ.Peek() != null)
            {
                pQVals[i] = pQ.Dequeue().Value;
                i++;
            }
            Assert.Equal(testVals, pQVals);
        }
    }
}
