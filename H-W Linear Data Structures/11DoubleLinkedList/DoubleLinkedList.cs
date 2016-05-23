using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11DoubleLinkedList
{
    class DoubleLinkedList<T>
    {
        public Node<T> First { get; set; }
        public Node<T> Last { get; set; }
        public int Count { get; set; }

        public DoubleLinkedList()
        {
            this.First = null;
            this.Last = null;
            this.Count = 0;
        }

        public object this[int index]
        {
            get
            {
                if (index > Count || index < 0)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                Node<T> currentNode = this.First;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }

                return currentNode.Value;
            }
        }

        public void Add(T element)
        {
            if (this.First == null)
            {
                this.Last = new Node<T>(element);
                this.First = this.Last;
            }
            else
            {
                Node<T> newNode = new Node<T>(this.Last, element);
                this.Last = newNode;
            }
            this.Count++;

        }

        public void Remove(T element)
        {
            Node<T> currentNode = this.First;
            int currentIndex = 0;

            while (currentNode != null)
            {
                if ((currentNode.Value != null && currentNode.Value.Equals(element) ||
                    (currentNode.Value == null && element == null)))
                {
                    break;
                }
                currentNode = currentNode.Next;
                currentIndex++;
            }

            if (currentNode != null)
            {
                this.Count--;
                if (this.Count == 0)
                {
                    this.First = null;
                }
                else if (currentNode.Prev == null)
                {
                    this.First = currentNode.Next;
                }
                else
                {
                    currentNode.Prev.Next = currentNode.Next;
                }
            }
            else
            {
                throw new ArgumentException("The element does not exist in the LinkedList!");
            }
        }
        public void Insert(T element, uint index)
        {
            if (index > this.Count)
            {
                throw new IndexOutOfRangeException("The index entered is out of range");
            }
            else if (element == null)
            {
                throw new ArgumentNullException("Cannot insert null!");
            }
            else
            {
                Node<T> currentNode = this.First;
                Node<T> nodeToInsert = new Node<T>(element);

                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Prev.Next = nodeToInsert;
                currentNode.Prev = nodeToInsert;
                nodeToInsert.Prev = currentNode.Prev;
                nodeToInsert.Next = currentNode;
                this.Count++;
            }
        }
    }
    class Node<T>
    {
        public Node<T> Next { get; internal set; }
        public Node<T> Prev { get; internal set; }
        public T Value { get; set; }

        public Node(Node<T> prev, T element)
        {
            this.Value = element;
            this.Prev = prev;
            prev.Next = this;
        }
        public Node(T element)
        {
            this.Value = element;
            this.Next = this;
            this.Prev = this;
        }
    }
}
