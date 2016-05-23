using System;
using System.Collections.Generic;

class Sequence
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());

        if (N < 0 || M < 0 || M < N)
        {
            Console.WriteLine("Invalid input data");
            return;
        }

        Queue<Node> operations = new Queue<Node>();
        operations.Enqueue(new Node(null, N));
        HashSet<int> found = new HashSet<int>();

        while (operations.Count > 0)
        {
            Node node = operations.Dequeue();
            int current = node.Value;
            if (current < M)
            {
                if (found.Contains(current + 2) == false)
                {
                    operations.Enqueue(new Node(node, current + 2));
                    found.Add(current + 2);
                }
                if (found.Contains(current + 1) == false)
                {
                    operations.Enqueue(new Node(node, current + 1));
                    found.Add(current + 1);
                }
                if (found.Contains(current * 2) == false)
                {
                    operations.Enqueue(new Node(node, current * 2));
                    found.Add(current * 2);
                }
            }
            else if (current == M)
            {
                node.Print();
                Console.WriteLine();
            }
            Console.WriteLine(string.Join("->",found));
        }
    }
}

class Node
{
    private Node prev;
    private int value;

    public int Value
    {
        get { return this.value; }
        private set { this.value = value; }
    }

    public Node(Node prev, int value)
    {
        this.prev = prev;
        this.Value = value;
    }

    public void Print()
    {
        if (prev != null)
        {
            prev.Print();
        }
        Console.Write("{0,4}", Value);
    }
}
