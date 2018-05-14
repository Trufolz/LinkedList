using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class MyLinkedList
    {
        internal Node Head;
        internal Node Tail;

        public void AddLast(object content)
        {
            Node newNode = new Node(content);
            if (this.Head != null)
            {
                newNode.PrevNode = this.Head;
                this.Head.NextNode = newNode;
                this.Head = newNode;
            }
            else
            {
                this.Head = newNode;
                this.Tail = newNode;
            }
            this.Head = newNode;
        }

        public void RemoveLast()
        {
            this.Head = this.Head.PrevNode;
            this.Head.NextNode = null;
        }

        public void AddFirst(object content)
        {
            Node newNode = new Node(content);
            if (this.Tail != null)
            {
                this.Tail.PrevNode = newNode;
                newNode.NextNode = this.Tail;
            }
            else
            {
                this.Head = newNode;
            }
            this.Tail = newNode;
        }

        public void RemoveFirst()
        {
            if (this.Tail != null)
            {
                this.Tail.NextNode.PrevNode = null;
                this.Tail = this.Tail.NextNode;
            }
        }

        public void AddAfter(Node node, object content)
        {
            Node newNode = new Node(content);
            Node currentNode = this.Tail;

            while (currentNode != null)
            {
                if (currentNode.Equals(node))
                {
                    newNode.PrevNode = node;
                    newNode.NextNode = node.NextNode;
                    newNode.NextNode.PrevNode = newNode;
                    node.NextNode = newNode;
                    break;
                }
                currentNode = currentNode.NextNode;
            }
        }

        public void AddBefore(Node node, object content)
        {
            Node newNode = new Node(content);
            Node currentNode = this.Tail;

            while (currentNode != null)
            {
                if (currentNode.Equals(node))
                {
                    newNode.PrevNode = node.PrevNode;
                    newNode.PrevNode.NextNode = newNode;
                    newNode.NextNode = node;
                    node.PrevNode = newNode;
                    break;
                }
                currentNode = currentNode.NextNode;
            }
        }
    }
}
