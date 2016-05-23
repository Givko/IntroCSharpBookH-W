using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12DymanicStack
{
    class DymanicStack<T>
    {
        public Node<T> First { get; set; }
        public Node<T> Last { get; set; }
        public int Count { get; set; }

        public DymanicStack()
        {
            this.First = null;
            this.Last = null;
        }

        public void Push(T element)
        {
            if (this.First == null)
            {
                this.First = new Node<T>(element);
                this.Last = this.First;
            }
            else
            {
                Node<T> nodeToPush = new Node<T>(element, this.Last);
                this.Last = nodeToPush;
            }
            this.Count++;
        }
        public T Pop()
        {
            if (this.Count==0)
            {
                throw new InvalidOperationException("The DynamicStack is empty there is nothing to Pop.");
            }
            else
            {
                Node<T> nodeToPop = this.Last;
                this.Last = nodeToPop.Prev;
                nodeToPop.Prev = null;
                return nodeToPop.Value;
            }
        }
        public T Peek()
        {
            if (this.Count==0)
            {
                throw new InvalidOperationException("The DynamicStack is empty there is nothing to Peek.");
            }
            return this.Last.Value;
        }
        public void Clear()
        {
            this.Last = null;
            this.First = null;
            this.Count = 0;
        }
    }

    class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Prev { get; set; }

        public Node(T element, Node<T> prevNode)
        {
            this.Prev = prevNode;
            this.Value = element;
        }
        public Node(T element)
        {
            this.Value = element;
        }
    }
}
