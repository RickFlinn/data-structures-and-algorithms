using System;
using Xunit;
using StacksAndQueues.Classes;

namespace StacksAndQueueTests
{
    


    public class UnitTest1
    {
        [Fact]
        public void PushAddsToEmpty() 
        {
            Stack stack = new Stack();
            Node node = new Node(1);

            stack.Push(node);
            Assert.True(stack.Top != null);
        }

        [Fact]
        public void PushAddsToNotEmpty()
        {
            Stack stack = new Stack();
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            stack.Top = node1;
            stack.Push(node2);
            Assert.True(stack.Top == node2);
        }

        [Fact]
        public void PushAddsInOrder()
        {
            Stack stack = new Stack();
            stack.Push(new Node(1));
            stack.Push(new Node(2));
            stack.Push(new Node(3));
            Assert.True((int)stack.Top.Value == 3 && (int)stack.Top.Next.Value == 2 && (int)stack.Top.Next.Next.Value == 1);
        }

        [Fact]
        public void PeekTest()
        {
            Stack stack = new Stack();
            Node node = new Node(1);
            stack.Top = node;
            Assert.Equal(stack.Top, stack.Peek());
        }

        [Fact]
        public void PeekEmpty()
        {
            Stack stack = new Stack();
            Assert.Null(stack.Peek());
        }

        [Fact]
        public void PeekLooksAtTopNode()
        {
            Stack stack = new Stack();
            stack.Push(new Node(1));
            stack.Push(new Node(2));
            stack.Push(new Node(3));
            Assert.Equal(3, stack.Peek().Value);
        }

        [Fact]
        public void PopGivesLastNode()
        {
            Stack stack = new Stack();
            Node node1 = new Node(1);
            stack.Top = node1;
            Assert.Equal(node1, stack.Pop());
        }

        [Fact]
        public void PopGivesTopNode()
        {
            Stack stack = new Stack();
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            stack.Push(node1);
            stack.Push(node2);
            Assert.Equal(node2, stack.Pop());
        }

        [Fact]
        public void PopEmpty()
        {
            Stack stack = new Stack();
            Assert.Null(stack.Pop());
        }

        [Fact]
        public void EnqEmpty()
        {
            Queue q = new Queue();
            Node node1 = new Node(1);
            q.Enqueue(node1);
            Assert.Equal(node1, q.Front);
        }

        [Fact]
        public void EnqFull()
        {
            Queue q = new Queue();
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            q.Front = node1;
            q.End = node1;
            q.Enqueue(node2);
            Assert.True(q.Front == node1 && q.End == node2);
        }

        [Fact]
        public void EnqOrder()
        {
            Queue q = new Queue();
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            q.Enqueue(node1);
            q.Enqueue(node2);
            q.Enqueue(node3);
            Assert.True(q.Front == node1 && q.End == node3);
        }

        [Fact]
        public void DeqEmpty()
        {
            Queue q = new Queue();
            Assert.Null(q.Dequeue());
        }

        [Fact]
        public void DeqGetsFront()
        {
            Queue q = new Queue();
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            q.Front = node1;
            q.Front.Next = node2;
            q.Front.Next.Next = node3;
            q.End = node3;

            Assert.Equal(node1, q.Dequeue());
        }

        [Fact]
        public void DeqGetsCorrectNode()
        {
            Queue q = new Queue();
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            q.Front = node1;
            q.Front.Next = node2;
            q.Front.Next.Next = node3;
            q.End = node3;
            q.Dequeue();
            Assert.Equal(node2, q.Dequeue());
        }

        [Fact]
        public void PeekGetsFront()
        {
            Queue q = new Queue();
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            q.Front = node1;
            q.Front.Next = node2;
            q.Front.Next.Next = node3;
            q.End = node3;

            Assert.Equal(q.Front, q.Peek());
        }

        [Fact]
        public void PeekNullQ()
        {
            Queue q = new Queue();
            Assert.Null(q.Peek());
        }

        [Fact]
        public void PeekGetsCorrectNode()
        {
            Queue q = new Queue();
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            q.Front = node1;
            q.Front.Next = node2;
            q.Front.Next.Next = node3;
            q.End = node3;

            Assert.Equal(node1, q.Peek());
        }
    }
}
